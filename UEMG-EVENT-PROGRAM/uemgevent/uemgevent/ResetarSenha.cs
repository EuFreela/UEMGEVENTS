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
    public partial class ResetarSenha : Form
    {
        public string idUsuarios = "";
        private DBO dbo;
        public ResetarSenha()
        {
            dbo = new DBO();
            InitializeComponent();
        }

        private void mtbConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            string str = "As senhas não conferem!";
            lbConfirmarSenha.Font = new Font("Arial", 10);
            if (mtbPasswd.Text != mtbConfirmarSenha.Text)
                lbConfirmarSenha.Text = str;
            else
                lbConfirmarSenha.Text = "";
        }

        private void btResetarSenhaU_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente resetar a senha do perfil atual?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dbo.ResetPasswd(Convert.ToInt32(this.idUsuarios), mtbPasswd.Text))
                {
                    MessageBox.Show("Dados atualizados com sucesso!", "Sucesso!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                    MessageBox.Show("Dados atualizados com sucesso!", "Sucesso!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void ResetarSenha_Load(object sender, EventArgs e)
        {
        }
    }
}
