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
    public partial class Form_ListaPalestrante : Form
    {
        DBO dbo;
        DataTable dt = new DataTable();
        SQLiteDataAdapter da;
        BindingSource bss = new BindingSource();
        Estados estados;

        public Dashboard dashboard;

        public Form_ListaPalestrante()
        {
            dashboard = new Dashboard();
            dbo = new DBO();
            estados = new Estados();
            InitializeComponent();
        }

        /**************************************************************************************************
         * MÉTODOS ESPECÍFICOS
         * */
        public void DataBidingsNavigtor(BindingSource bs)
        {
            tbID.DataBindings.Add(new Binding("Text", bs, "ID"));
            tbCodPalestrante.DataBindings.Add(new Binding("Text", bs, "Codigo"));
            tbNomePalestrante.DataBindings.Add(new Binding("Text", bs, "Nome"));
            tbEmail.DataBindings.Add(new Binding("Text", bs, "E-mail"));
            tbCidadePalestrante.DataBindings.Add(new Binding("Text", bs, "Cidade"));
            cEstado.DataBindings.Add(new Binding("Text", bs, "Estado"));
            mtbTelefoneFixo.DataBindings.Add(new Binding("Text", bs, "Telefone"));
            mtbTelefoneCelular.DataBindings.Add(new Binding("Text", bs, "Celular"));
        }

        public void DataBidingsNavigatorClear()
        {
            tbID.DataBindings.Clear();
            tbCodPalestrante.DataBindings.Clear();
            tbNomePalestrante.DataBindings.Clear();
            tbEmail.DataBindings.Clear();
            tbCidadePalestrante.DataBindings.Clear();
            cEstado.DataBindings.Clear();
            mtbTelefoneFixo.DataBindings.Clear();
            mtbTelefoneCelular.DataBindings.Clear();
        }

        public Boolean EmptyFields()
        {
            bool r = true;
            if (
                tbNomePalestrante.Text == "" ||
                tbEmail.Text == "" ||
                tbCidadePalestrante.Text == "" ||
                cEstado.Text == ""
             )
            {
                MessageBox.Show("Preencha todos os campos!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                r = false;
            }
            return r;
        }

        private void Form_ListaPalestrante_Load(object sender, EventArgs e)
        {
            dbo.OpenConnection();
            string query = "SELECT " +
                            "palestrante.idpalestrante AS 'ID'," +
                            "palestrante.codPalestrante AS 'Codigo'," +
                            "palestrante.nomePalestrante AS 'Nome'," +
                            "infopalestrante.telefoneFixo As 'Telefone'," +
                            "infopalestrante.celular As 'Celular'," +
                            "infopalestrante.email AS 'E-mail', " +
                            "infopalestrante.cidade AS 'Cidade', " +
                            "estados.nomeEstado AS 'Estado' " +
                            "FROM palestrante " +
                            "INNER JOIN infopalestrante ON infopalestrante.palestrante_idpalestrante = palestrante.idpalestrante " +
                            "INNER JOIN estados ON estados.idEstados = infopalestrante.estados_idestados ;";

            da = new SQLiteDataAdapter(query, dbo.GetStringConn());
            da.Fill(dt);

            bss.DataSource = dt;

            nvPalestrante.BindingSource = bss;
            dGringPalestrante.DataSource = bss;

            this.DataBidingsNavigtor(bss);
            dbo.CloseConnection();

            List<Estados> LE = new List<Estados>(dbo.SelectFromAllEstados("estados"));
            LE.ForEach(delegate (Estados state)
            {
                cEstado.Items.Insert(state.CodEstado-1, state.NomeEstado);
            });
        }    

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("Nome like '%{0}%'", tbSearch.Text);
                BindingSource source = new BindingSource();
                source.DataSource = dv.ToTable();
                nvPalestrante.BindingSource = source;
                dGringPalestrante.DataSource = source;

                this.DataBidingsNavigatorClear();
                this.DataBidingsNavigtor(source);
            }
        }
                

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(255,255,192);

            if (tbSearch.Text != "")
                tbSearch.BackColor = myRgbColor;
            else
                tbSearch.BackColor = System.Drawing.Color.White;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (EmptyFields())
            {
                Interface_has_Palestrante_InfoPalestrante_Titulos_Estados pite = new Interface_has_Palestrante_InfoPalestrante_Titulos_Estados();

                pite.Palestrante.IdPalestrante = Convert.ToInt32(tbID.Text);
                pite.Palestrante.NomePalestrante = tbNomePalestrante.Text;
                pite.InfoPalestrante.Email = tbEmail.Text;
                pite.InfoPalestrante.Cidade = tbCidadePalestrante.Text;
                pite.InfoPalestrante.Estados_idEstados = cEstado.FindString(cEstado.Text) + 1;
                pite.InfoPalestrante.TelefoneFixo = mtbTelefoneFixo.Text;
                pite.InfoPalestrante.Celular = mtbTelefoneCelular.Text;
                               
                if ( dbo.UpdatePalestrante(pite) && dbo.UpdateInfoPalestrante(pite))
                {
                    MessageBox.Show("Dados atualizados com sucesso!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dGringPalestrante.Refresh();
                }
                else                    
                    MessageBox.Show("Ocorreu um erro na operação! Entre em contato com o suporte", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void navigatorRefresh_Click(object sender, EventArgs e)
        {
            dGringPalestrante.Refresh();
        }

        private void btTitulos_Click(object sender, EventArgs e)
        {
            Form_ListaTitulosPalestrante form_listatitulospalestrante = new Form_ListaTitulosPalestrante();
            form_listatitulospalestrante.idPalestrante = tbID.Text;
            form_listatitulospalestrante.MdiParent = dashboard;
            form_listatitulospalestrante.Show();
        }
    }
}
