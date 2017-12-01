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
    public partial class Form_CadastroEventos : Form
    {
        DBO dbo;
        public int idUsuario;
        public Form_CadastroEventos()
        {
            dbo = new DBO();
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Eventos eventos = new Eventos();
            eventos.TituloEvento = tbNome.Text;
            eventos.DataEvento = Convert.ToDateTime(dDataEvento.Text);
            eventos.HInicio = (mHInicio.Text);
            eventos.HFim = (mHFim.Text);
            eventos.Usuarios_IdUsuarios = this.idUsuario;
            eventos.Palestrante_idPalestrante = Convert.ToInt32(dbo.SelectOneIDPalestrante("idPalestrante",cPalestrantes.Text));
            if (dbo.InsertEventos(eventos))
            {
                MessageBox.Show("Evento criado com sucesso!", "Sucesso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Ocorreu um erro na operação! Entre em contato com o suporte", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form_CadastroEventos_Load(object sender, EventArgs e)
        {
            List<Palestrante> LP = new List<Palestrante>(dbo.SelectFromAllPalestrante());
            int i = 0;
            LP.ForEach(delegate (Palestrante pale) 
            {
                cPalestrantes.Items.Insert(i,pale.NomePalestrante);
                i++;
            });
        }
    }
}
