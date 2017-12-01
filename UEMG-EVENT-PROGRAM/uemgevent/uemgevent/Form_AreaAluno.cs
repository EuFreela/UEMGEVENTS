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
    public partial class Form_AreaAluno : Form
    {
        DBO dbo;
        DataTable dt = new DataTable();
        SQLiteDataAdapter da;
        BindingSource bss = new BindingSource();

        public int idUsuario;

        public Form_AreaAluno()
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

        private void Form_AreaAluno_Load(object sender, EventArgs e)
        {
            dbo.OpenConnection();
            string query = "SELECT " +
                            "evento.idEvento AS 'ID'," +
                            "evento.tituloEvento AS 'Titulo'," +
                            "evento.dataEvento AS 'Data'," +
                            "palestrante.nomePalestrante AS 'Palestrante'," +
                            "evento.horarioInicial As 'Inicio'," +
                            "evento.horarioFinal As 'Fim' " +
                            "FROM evento " +
                            "INNER JOIN palestrante ON palestrante.idpalestrante=evento.palestrante_idPalestrante ;";

            da = new SQLiteDataAdapter(query, dbo.GetStringConn());
            da.Fill(dt);

            bss.DataSource = dt;

            nvEventos.BindingSource = bss;
            dGrindEventos.DataSource = bss;

            this.DataBidingsNavigtor(bss);
            dbo.CloseConnection();
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

        private void Form_AreaAluno_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Close();
        }

        private void meuPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_PerfilAluno form_areaaluno = new Form_PerfilAluno();
            form_areaaluno.idUsuario = this.idUsuario;
            //form_areaaluno.MdiParent = this;
            form_areaaluno.Show();
        }

        private void btInscricao_Click(object sender, EventArgs e)
        {
            if (dbo.Exists("select * from infouser where usuarios_idusuarios=" + this.idUsuario, "idInfoUser"))
            {
                if(!dbo.Exists("select * from inscricao where usuarios_idusuarios="+this.idUsuario+" and evento_idevento=" + tbID.Text,"idinscricao")){

                    string msg = "Você esta se inscrevendo para o evento " + dbo.SelectOneOneEventos("tituloEvento", Convert.ToInt32(tbID.Text)) + ". Deseja realemente se inscrever?";

                    if (MessageBox.Show(msg, "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Inscricao inscricao = new Inscricao();
                        Hash hw = new Hash();
                        inscricao.Matricula = hw.GerarMatricula(15); 
                        inscricao.Usuarios_IdUsuarios = this.idUsuario;
                        inscricao.Evento_IdEvento = Convert.ToInt32(tbID.Text);
                        if (dbo.InsertInscricao(inscricao))
                            MessageBox.Show("Sua inscrição foi realizada com sucesso!", "Sucesso!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Erro durante a operação. Entre em contato com o administrador!", "Erro!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }else
                    MessageBox.Show("Você já se inscreveu para este Evento!", "Atenção!",
                               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("A matrícula é vinculada aos seus dados informados no Perfil. Clique em Perfil e preencha o formulário", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void inscriçõesRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_InscricoesRealizadas fir = new Form_InscricoesRealizadas();
            fir.idUsuario = this.idUsuario;
            fir.Show();
        }
    }
}
