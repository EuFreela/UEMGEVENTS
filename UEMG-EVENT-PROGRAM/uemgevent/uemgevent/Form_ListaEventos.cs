using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uemgevent.classes;
using System.Data.SQLite;

namespace uemgevent
{
    public partial class Form_ListaEventos : Form
    {
        DBO dbo;
        DataTable dt = new DataTable();
        SQLiteDataAdapter da;
        BindingSource bss = new BindingSource();

        public int idUsuario;

        public Form_ListaEventos()
        {
            dbo = new DBO();
            InitializeComponent();
        }

        /**************************************************************************************************
         * MÉTODOS ESPECÍFICOS
         * */
        public void DataBidingsNavigtor(BindingSource bs)
        {
            tbID.DataBindings.Add(new Binding("Text", bs, "ID"));
            tbTitulo.DataBindings.Add(new Binding("Text", bs, "Titulo"));
            cPalestrante.DataBindings.Add(new Binding("Text", bs, "Palestrante"));
            mDataEvento.DataBindings.Add(new Binding("Text", bs, "Data"));
            mHInicial.DataBindings.Add(new Binding("Text", bs, "Inicio"));
            mHFinal.DataBindings.Add(new Binding("Text", bs, "Fim"));
        }

        public void DataBidingsNavigatorClear()
        {
            tbID.DataBindings.Clear();
            tbTitulo.DataBindings.Clear();
            cPalestrante.DataBindings.Clear();
            mDataEvento.DataBindings.Clear();
            mHInicial.DataBindings.Clear();
            mHFinal.DataBindings.Clear();
        }

        public Boolean EmptyFields()
        {
            bool r = true;
            if (
                tbTitulo.Text == "" ||
                mDataEvento.Text == "" ||
                mHInicial.Text == "" ||
                mHFinal.Text == "" ||
                cPalestrante.Text == ""
             )
            {
                MessageBox.Show("Preencha todos os campos!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                r = false;
            }
            return r;
        }



        private void Form_ListaEventos_Load(object sender, EventArgs e)
        {
            dbo.OpenConnection();
            string query = "SELECT " +
                            "evento.idEvento AS 'ID'," +
                            "evento.tituloEvento AS 'Titulo'," +
                            "evento.dataEvento AS 'Data'," +
                            "palestrante.nomePalestrante AS 'Palestrante',"+
                            "evento.horarioInicial As 'Inicio'," +
                            "evento.horarioFinal As 'Fim' "+
                            "FROM evento "+
                            "INNER JOIN palestrante ON palestrante.idpalestrante=evento.palestrante_idPalestrante ;"; 

            da = new SQLiteDataAdapter(query, dbo.GetStringConn());
            da.Fill(dt);

            bss.DataSource = dt;

            nvEventos.BindingSource = bss;
            dGrindEventos.DataSource = bss;

            this.DataBidingsNavigtor(bss);
            dbo.CloseConnection();

            List<Palestrante> LP = new List<Palestrante>(dbo.SelectFromAllPalestrante());
            int i = 0;
            LP.ForEach(delegate (Palestrante pale)
            {
                cPalestrante.Items.Insert(i, pale.NomePalestrante);
                i++;
            });
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (EmptyFields())
            {
                Eventos eventos = new Eventos();
                eventos.IdEvento = Convert.ToInt32(tbID.Text);
                eventos.TituloEvento = tbTitulo.Text;
                eventos.Palestrante_idPalestrante = Convert.ToInt32(dbo.SelectOneIDPalestrante("idPalestrante",cPalestrante.Text));
                eventos.DataEvento = Convert.ToDateTime(mDataEvento.Text);
                eventos.HInicio = (mHInicial.Text);
                eventos.HFim = (mHFinal.Text);
                eventos.Usuarios_IdUsuarios = this.idUsuario;

                if (dbo.UpdateEventos(eventos))
                {
                    MessageBox.Show("Dados atualizados com sucesso!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dGrindEventos.Refresh();
                }
                else
                    MessageBox.Show("Ocorreu um erro na operação! Entre em contato com o suporte", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("Titulo like '%{0}%'", tbSearch.Text);
                BindingSource source = new BindingSource();
                source.DataSource = dv.ToTable();
                nvEventos.BindingSource = source;
                dGrindEventos.DataSource = source;

                this.DataBidingsNavigatorClear();
                this.DataBidingsNavigtor(source);
            }
        }
    }
}
