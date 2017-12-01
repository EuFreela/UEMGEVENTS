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
    public partial class Form_ListaTitulosPalestrante : Form
    {
        DBO dbo;
        DataTable dt = new DataTable();
        SQLiteDataAdapter da;
        BindingSource bss = new BindingSource();
        
        public string idPalestrante = "";
        private int saveUpdate = 0;

        public Form_ListaTitulosPalestrante()
        {
            dbo = new DBO();
            InitializeComponent();
        }

        public void DataBidingsNavigtor(BindingSource bs)
        {
            tbID.DataBindings.Add(new Binding("Text", bs, "ID"));
            tbInstituicao .DataBindings.Add(new Binding("Text", bs, "Instituicao"));
            cTitulo.DataBindings.Add(new Binding("Text", bs, "Titulo"));
            datePosse.DataBindings.Add(new Binding("Text", bs, "Posse"));
        }

        public void DataBidingsNavigatorClear()
        {
            tbID.DataBindings.Clear();
            tbInstituicao.DataBindings.Clear();
            cTitulo.DataBindings.Clear();
            datePosse.DataBindings.Clear();
        }

             

        private void Form_ListaTitulosPalestrante_Load(object sender, EventArgs e)
        {
            if (this.idPalestrante != "")
            {
                dbo.OpenConnection();
                string query = "SELECT " +
                                "titulos.idtitulos AS 'ID'," +
                                "titulos.nomeInstituicaoTitulo AS 'Instituicao'," +
                                "titulos.dataTitulo AS 'Posse'," +
                                "titulacao.nomeTitulacao As 'Titulo'" +
                                "FROM titulos " +
                                "INNER JOIN titulacao ON titulacao.idtitulacao = titulos.titulacao_idtitulacao " +
                                "WHERE titulos.palestrante_idpalestrante = "+this.idPalestrante+";";

                da = new SQLiteDataAdapter(query, dbo.GetStringConn());
                da.Fill(dt);

                bss.DataSource = dt;
                nvTitulosPalestrante.BindingSource = bss;
                dGridTitulosPalestrante.DataSource = bss;

                this.DataBidingsNavigtor(bss);
                dbo.CloseConnection();
            }

            List<Titulacao> LT = new List<Titulacao>(dbo.SelectFromAllTitulacao("titulacao"));
            LT.ForEach(delegate (Titulacao titulacao)
            {
                cTitulo.Items.Insert(titulacao.CodTitulacao - 1, titulacao.NomeTitulacao);
            });

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {           

            if (this.saveUpdate == 0)
            {
                Titulos titulos = new Titulos();
                titulos.NomeInstituicaoTitulo = tbInstituicao.Text;
                titulos.Titulacao_idTitulacao = cTitulo.FindString(cTitulo.Text) + 1;
                titulos.dataTitulo = Convert.ToDateTime(datePosse.Text);
                titulos.Palestrante_idPalestrante = Convert.ToInt32(this.idPalestrante);

                if (dbo.UpdateTitulos(titulos))
                {
                    MessageBox.Show("Atualização realizada com sucesso!", "Sucesso!",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dGridTitulosPalestrante.Refresh();
                }
                else
                    MessageBox.Show("Ocorreu um erro! Entre em contato com o suporte.", "Erro!",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Titulos> LT = new List<Titulos>();
                Titulos titulos = new Titulos();
                titulos.NomeInstituicaoTitulo = tbInstituicao.Text;
                titulos.Titulacao_idTitulacao = cTitulo.FindString(cTitulo.Text) + 1;
                titulos.dataTitulo = Convert.ToDateTime(datePosse.Text);
                titulos.Palestrante_idPalestrante = Convert.ToInt32(this.idPalestrante);
                LT.Add(titulos);
               
                if (dbo.InserTitulos(LT))
                {
                    MessageBox.Show("Titulo adicionado com sucesso!", "Sucesso!",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dGridTitulosPalestrante.Refresh();
                }
                else
                    MessageBox.Show("Ocorreu um erro! Entre em contato com o suporte.", "Erro!",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.saveUpdate = 0;
            }
        }

        private void bindingNavigatorRefreshtem_Click(object sender, EventArgs e)
        {
            dGridTitulosPalestrante.Refresh();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.saveUpdate = 1;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
        }

        private void navigatorTitulosPalestranteExcluirItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este dado?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (this.dbo.DeleteTitulos(Convert.ToInt32(this.idPalestrante), (cTitulo.FindString(cTitulo.Text) + 1)))
                {
                    MessageBox.Show("Dado excluído com sucesso!", "Sucesso!",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                else
                    MessageBox.Show("Ocorreu um erro! Entre em contato com o suporte.", "Erro!",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                dGridTitulosPalestrante.Refresh();
            }
        }
    }
}
