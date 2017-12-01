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


namespace uemgevent
{
    public partial class Form_Cadastro : Form
    {
        DBO dbo;
        public Form_Cadastro()
        {
            dbo = new DBO();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( 
                    tbNome.Text == "" || 
                    tbEmail.Text == "" || 
                    tbUsuario.Text == "" ||
                    mtbPasswd.Text == "" ||
                    mtbConfirmarSenha.Text == ""
              )
            {
                MessageBox.Show("Preencha todos os campos!", "Erro!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if ( mtbPasswd.Text != mtbConfirmarSenha.Text )
                    MessageBox.Show("Os campos senha não conferem!", "Erro!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                else
                {
                    Usuarios usuario = new Usuarios();
                    usuario.Ativo = 1;
                    usuario.Nome = tbNome.Text;
                    usuario.Email = tbEmail.Text;
                    usuario.Username = tbUsuario.Text;
                    usuario.Passwd = mtbPasswd.Text;
                    usuario.perfilCodPerfil = 2;
                    List<Usuarios> LU = new List<Usuarios>();
                    LU.Add(usuario);
                    if (this.dbo.InsertUsuario(LU))
                    {
                        MessageBox.Show("Sucesso! Use suas credenciais para acesso ao sistema", "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }else
                        MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "Erro!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            tbEmail.Text = tbEmail.Text.Trim();
            tbEmail.Select(tbEmail.Text.Length,0);
            if ( this.dbo.ExistOneField("usuarios", "email",tbEmail.Text) )
            {
                MessageBox.Show("Este email já existe cadastrado no sistema!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEmail.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            tbUsuario.Text = tbUsuario.Text.Trim();
            tbUsuario.Select(tbUsuario.Text.Length,0);
            if ( this.dbo.ExistOneField("usuarios", "username",tbUsuario.Text) )
            {
                MessageBox.Show("Este usuário já existe cadastrado no sistema!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUsuario.Text = "";
            }

        }

        private void mtbConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            string str = "As senhas não conferem!";
            lbConfirmarSenha.Font = new Font("Arial",7);
            if (mtbPasswd.Text != mtbConfirmarSenha.Text)
                lbConfirmarSenha.Text = str;
            else
                lbConfirmarSenha.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente sair do formulário", "Sistema",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void Form_Cadastro_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = false;         
        }
    }
}
