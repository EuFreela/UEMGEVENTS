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
    public partial class Form_PerfilAluno : Form
    {
        private DBO dbo;
        private bool status = false;

        public int idUsuario;


        public Form_PerfilAluno()
        {
            dbo = new DBO();
            InitializeComponent();
        }

        private Boolean EmptyFields()
        {
            bool r = true;
            if (
                mCPF.Text == "" ||
                cCurso.Text == "" ||
                cPeriodo.Text == "" 
            )
            {
                MessageBox.Show("Preencha todos os campos!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                r = false;
            }
            return r;
        }

        private InfoUser setFields()
        {
            InfoUser infouser = new InfoUser();
            infouser.CPF = mCPF.Text;
            infouser.Usuario_IdUsuario = this.idUsuario;
            infouser.Periodo_IdPeriodo = dbo.SelectOneIDPeriodo("idperiodo", cPeriodo.Text);
            infouser.Curso_IdCurso = dbo.SelectOneIDCurso("idCurso", cCurso.Text);
            return infouser;
        }
        
        private void btCadastreMe_Click(object sender, EventArgs e)
        {
            if (EmptyFields())
            {                

                if (!this.status)
                {                    
                    if (dbo.InsertInfoUser(this.setFields()))
                        MessageBox.Show("Dados inseridos com sucesso!", "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    else
                        MessageBox.Show("Ocorreu um erro na operação! Entre em contato com o suporte", "Erro!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (dbo.UpdateInfoUser(this.setFields()))
                        MessageBox.Show("Dados atualizados com sucesso!", "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Ocorreu um erro na operação! Entre em contato com o suporte", "Erro!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            }
        }

        private void Form_PerfilAluno_Load(object sender, EventArgs e)
        {
            List<Curso> LU = new List<Curso>(dbo.SelectFromAllCurso());
            int i = 0;
            LU.ForEach(delegate (Curso curso)
            {
                cCurso.Items.Insert(i, curso.NomeCurso);
                i++;
            });

            List<Periodo> LP = new List<Periodo>(dbo.SelectFromAllPeriodo());
            i = 0;
            LP.ForEach(delegate (Periodo periodo)
            {
                cPeriodo.Items.Insert(i, periodo.NomePeriodo);
                i++;
            });

            InfoUser infouser = dbo.SelectFromOneInfoUser(this.idUsuario);
            mCPF.Text = infouser.CPF;
            cCurso.Text = dbo.SelectOneNameCurso("nomeCurso",infouser.Curso_IdCurso);
            cPeriodo.Text = dbo.SelectOneNamePeriodo("nomeperiodo",infouser.Periodo_IdPeriodo);

            if (dbo.Exists("select * from infouser where usuarios_idusuarios=" + this.idUsuario, "idInfoUser"))
                this.status = true;           

        }

        private void btResetarSenha_Click(object sender, EventArgs e)
        {            
            ResetarSenha resetarsenha = new ResetarSenha();
            resetarsenha.idUsuarios = Convert.ToString(this.idUsuario);
            resetarsenha.Show();
        }
    }
}
