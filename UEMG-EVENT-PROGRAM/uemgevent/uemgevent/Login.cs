using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using uemgevent.classes;

namespace uemgevent
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if( login.ValidarUsuario(tbUsername.Text, mtbPasswd.Text) )
            {
                //MessageBox.Show("Senha Correta!", "Mensagem do Sistema",MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if( login.Perfil == 1)
                {
                    //Admin
                    Dashboard dashboard = new Dashboard();
                    dashboard.idUsuario = login.idUsuario;
                    dashboard.Show();
                    this.Visible = false;
                }
                if (login.Perfil == 2)
                {
                    //Aluno
                    Form_AreaAluno form_areaaluno = new Form_AreaAluno();
                    form_areaaluno.idUsuario = login.idUsuario;
                    form_areaaluno.Show();
                    this.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            }       

        }

        private void llbCadastroUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Cadastro form_cadastro = new Form_Cadastro();
            form_cadastro.Show();
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnEntrar_Click(sender, e);
            }
        }

        private void mtbPasswd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnEntrar_Click(sender, e);
            }
        }

        private void pcHelp_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
