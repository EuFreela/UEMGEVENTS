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
    public partial class Form_CadPalestrantes : Form
    {
        DBO dbo;
        Estados estados;
        public Form_CadPalestrantes()
        {
            dbo = new DBO();
            estados = new Estados();
            InitializeComponent();
        }
        
        public Boolean EmptyFields()
        {
            bool r = true;
            if(
                tbCodPalestrante.Text == "" ||
                tbNomePalestrante.Text == "" ||
                ctbTitulo.Text == "" ||
                tbInstituicaoTitulo.Text == "" ||
                mtbTelefoneFixo.Text == "" ||
                mTelefoneCelular.Text == "" ||
                tbEmail.Text == "" ||
                tbCidade.Text == "" ||
                cEstado.Text == ""
             )
            {
                MessageBox.Show("Preencha todos os campos!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                r = false;
            }
            return r;
        }


        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if( EmptyFields())
            {

                List<Palestrante> LP = new List<Palestrante>();
                List<Titulos> LT = new List<Titulos>();
                List<InfoPalestrante> LIP = new List<InfoPalestrante>();

                Palestrante palestrante = new Palestrante();
                palestrante.CodPalestrante = Convert.ToInt32(tbCodPalestrante.Text.Trim());
                palestrante.NomePalestrante = tbNomePalestrante.Text;                
                LP.Add(palestrante);

                if (dbo.InsertPalestrante(LP)) {
                    Titulos titulos = new Titulos();                    
                    titulos.NomeInstituicaoTitulo = tbInstituicaoTitulo.Text;
                    titulos.dataTitulo = dDataPosse.Value.Date;
                    titulos.Titulacao_idTitulacao =  ctbTitulo.FindString(ctbTitulo.Text);
                    titulos.Palestrante_idPalestrante =  dbo.LastField("palestrante", "idpalestrante");
                    LT.Add(titulos);
                }

                if (dbo.InserTitulos(LT))
                {
                    InfoPalestrante infopalestrante = new InfoPalestrante();
                    infopalestrante.TelefoneFixo = mtbTelefoneFixo.Text;
                    infopalestrante.Celular = mTelefoneCelular.Text;
                    infopalestrante.Email = tbEmail.Text;
                    infopalestrante.Cidade = tbCidade.Text;
                    infopalestrante.Palestrante_idPalestrante = dbo.LastField("palestrante", "idpalestrante");
                    infopalestrante.Estados_idEstados = cEstado.FindString(cEstado.Text)+1;
                    LIP.Add(infopalestrante);                    
                }

                if (dbo.InsertInfoPalestrante(LIP))
                {
                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro! Entre em contato com o administrador.", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void Form_CadPalestrantes_Load(object sender, EventArgs e)
        {
            List<Estados> LE = new List<Estados>(dbo.SelectFromAllEstados("estados"));
            LE.ForEach(delegate (Estados state) 
            {
                cEstado.Items.Insert(state.CodEstado-1,state.NomeEstado);
            });

            List<Titulacao> LT = new List<Titulacao>(dbo.SelectFromAllTitulacao("titulacao"));
            LT.ForEach(delegate (Titulacao titulacao)
            {
                ctbTitulo.Items.Insert(titulacao.CodTitulacao-1, titulacao.NomeTitulacao);
            });
        }
    }
}
