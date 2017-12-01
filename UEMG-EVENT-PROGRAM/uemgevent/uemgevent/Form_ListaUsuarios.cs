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
    public partial class Form_ListaUsuarios : Form
    {
        private DBO dbo;
        private DataTable dt = new DataTable();
        private SQLiteDataAdapter da;
        private BindingSource bss = new BindingSource();
      
        public Dashboard dashboard;

        public Form_ListaUsuarios()
        {
            dashboard = new Dashboard();
            dbo = new DBO();
            InitializeComponent();
        }


        /**************************************************************************************************
        * MÉTODOS ESPECÍFICOS
        * */
        public void DataBidingsNavigtor(BindingSource bs)
        {
            tbID.DataBindings.Add(new Binding("Text", bs, "ID"));
            tbNomeUsuario.DataBindings.Add(new Binding("Text", bs, "Nome"));
            tbEmail.DataBindings.Add(new Binding("Text", bs, "E-mail"));
            tbUsuario.DataBindings.Add(new Binding("Text", bs, "Usuario"));           
            cAtivo.DataBindings.Add(new Binding("Text", bs, "Status"));
            cPerfil.DataBindings.Add(new Binding("Text", bs, "Perfil"));
        }

        public void DataBidingsNavigatorClear()
        {
            tbID.DataBindings.Clear();
            tbUsuario.DataBindings.Clear();
            tbNomeUsuario.DataBindings.Clear();
            tbEmail.DataBindings.Clear();
            cAtivo.DataBindings.Clear();
            cPerfil.DataBindings.Clear();
        }

        public Boolean EmptyFields()
        {
            bool r = true;
            if (
                tbNomeUsuario.Text == "" ||
                tbEmail.Text == "" ||
                tbUsuario.Text == "" ||
                cAtivo.Text == "" ||
                cPerfil.Text == ""
             )
            {
                MessageBox.Show("Preencha todos os campos!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                r = false;
            }
            return r;
        }



        private void btUpdate_Click(object sender, EventArgs e)
        {            
            if (EmptyFields())
            {
                Usuarios usuarios = new Usuarios();
                usuarios.IdUsuarios = Convert.ToInt32(tbID.Text);
                usuarios.Ativo = Convert.ToInt16(cAtivo.FindString(cAtivo.Text));
                usuarios.Nome = tbNomeUsuario.Text;
                usuarios.Email = tbEmail.Text;
                usuarios.Username = tbUsuario.Text.Trim();
                usuarios.perfilCodPerfil = cPerfil.FindString(cPerfil.Text) + 1;
               

                if (dbo.UpdateUsuario(usuarios))
                {
                    MessageBox.Show("Dados atualizados com sucesso!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dGridListaUsuarios.Refresh();
                }
                else
                    MessageBox.Show("Ocorreu um erro na operação! Entre em contato com o suporte", "Erro!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form_ListaUsuarios_Load(object sender, EventArgs e)
        {
            dbo.OpenConnection();
            string query = "SELECT " +
                            "usuarios.idusuarios AS 'ID'," +
                            "usuarios.ativo AS 'Status'," +
                            "usuarios.nomeUsuario AS 'Nome'," +
                            "usuarios.email AS 'E-mail'," +
                            "usuarios.username AS 'Usuario'," +
                            "perfil.nomePerfil AS 'Perfil' " +
                            "from usuarios " +
                            "INNER JOIN perfil ON perfil.idperfil=usuarios.perfil_codperfil;";


            da = new SQLiteDataAdapter(query, dbo.GetStringConn());
            da.Fill(dt);

            bss.DataSource = dt;

            nvListaUsuarios.BindingSource = bss;
            dGridListaUsuarios.DataSource = bss;

            this.DataBidingsNavigtor(bss);
            dbo.CloseConnection();

          

        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btResetarSenhaUsuario_Click(object sender, EventArgs e)
        {
            ResetarSenha resetarSenha = new ResetarSenha();
            resetarSenha.MdiParent = dashboard;
            resetarSenha.idUsuarios = tbID.Text;
            resetarSenha.Show();
        }
    }
}
