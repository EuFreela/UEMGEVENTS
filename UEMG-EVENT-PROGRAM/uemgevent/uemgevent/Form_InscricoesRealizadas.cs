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
    public partial class Form_InscricoesRealizadas : Form
    {
        DBO dbo;
        DataTable dt = new DataTable();
        SQLiteDataAdapter da;
        BindingSource bss = new BindingSource();

        public int idUsuario;

        public Form_InscricoesRealizadas()
        {
            dbo = new DBO();
            InitializeComponent();
        }



        private void Form_InscricoesRealizadas_Load(object sender, EventArgs e)
        {
            dbo.OpenConnection();
            string query = "SELECT " +
                            "evento.tituloEvento AS 'Evento'," +
                            "evento.dataEvento AS 'Data'," +
                            "evento.horarioInicial AS 'Inicio'," +
                            "palestrante.nomePalestrante AS 'Palestrante' " +
                            "FROM inscricao " +
                            "INNER JOIN palestrante ON palestrante.idpalestrante=evento.palestrante_idPalestrante "+
                            "INNER JOIN evento ON inscricao.evento_idevento=evento.idEvento "+
                            "where inscricao.usuarios_idUsuarios="+this.idUsuario+";";

            da = new SQLiteDataAdapter(query, dbo.GetStringConn());
            da.Fill(dt);

            bss.DataSource = dt;

            nvEventos.BindingSource = bss;
            dGrindInscricoesRealizadas.DataSource = bss;
            
            dbo.CloseConnection();
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("Evento like '%{0}%'", tbSearch.Text);
                BindingSource source = new BindingSource();
                source.DataSource = dv.ToTable();
                nvEventos.BindingSource = source;
                dGrindInscricoesRealizadas.DataSource = source;

            }
        }
    }
}
