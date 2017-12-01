using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uemgevent
{
    public partial class Dashboard : Form
    {
        public int idUsuario = 0;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void menuLateral_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarPalestrantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CadPalestrantes form_cadpalesrantes = new Form_CadPalestrantes();
            form_cadpalesrantes.MdiParent = this;
            form_cadpalesrantes.Show();
        }

        private void listarPalestranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListaPalestrante form_listapalestrante = new Form_ListaPalestrante();
            form_listapalestrante.MdiParent = this;
            form_listapalestrante.dashboard = this;
            form_listapalestrante.Show();
        }

        private void listarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListaUsuarios form_listausuarios = new Form_ListaUsuarios();
            form_listausuarios.dashboard = this;
            form_listausuarios.MdiParent = this;
            form_listausuarios.Show();

        }

        private void cadastrarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Cadastro form_cadastrousuario = new Form_Cadastro();
            form_cadastrousuario.MdiParent = this;
            form_cadastrousuario.Show();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Close();
        }

        private void criarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CadastroEventos form_cadastrareventos = new Form_CadastroEventos();
            form_cadastrareventos.MdiParent = this;
            form_cadastrareventos.idUsuario = this.idUsuario;
            form_cadastrareventos.Show();
        }

        private void pesquisarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListaEventos form_listaeventos = new Form_ListaEventos();
            form_listaeventos.MdiParent = this;
            form_listaeventos.idUsuario = this.idUsuario;
            form_listaeventos.Show();
        }
    }
}
