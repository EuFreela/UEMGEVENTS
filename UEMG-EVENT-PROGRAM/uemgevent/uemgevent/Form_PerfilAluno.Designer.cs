namespace uemgevent
{
    partial class Form_PerfilAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PerfilAluno));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pcLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cCurso = new System.Windows.Forms.ComboBox();
            this.cPeriodo = new System.Windows.Forms.ComboBox();
            this.mCPF = new System.Windows.Forms.MaskedTextBox();
            this.btResetarSenha = new System.Windows.Forms.Button();
            this.btCadastreMe = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picInstagram = new System.Windows.Forms.PictureBox();
            this.pcFacebook = new System.Windows.Forms.PictureBox();
            this.pcHelp = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInstagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pcLogo);
            this.panel2.Location = new System.Drawing.Point(16, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 343);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "UEMG-EVENTS";
            // 
            // pcLogo
            // 
            this.pcLogo.Image = global::uemgevent.Properties.Resources.logo_500px;
            this.pcLogo.Location = new System.Drawing.Point(18, 62);
            this.pcLogo.Name = "pcLogo";
            this.pcLogo.Size = new System.Drawing.Size(134, 132);
            this.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcLogo.TabIndex = 0;
            this.pcLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 20);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.cCurso);
            this.panel3.Controls.Add(this.cPeriodo);
            this.panel3.Controls.Add(this.mCPF);
            this.panel3.Controls.Add(this.btResetarSenha);
            this.panel3.Controls.Add(this.btCadastreMe);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(201, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 318);
            this.panel3.TabIndex = 10;
            // 
            // cCurso
            // 
            this.cCurso.FormattingEnabled = true;
            this.cCurso.Location = new System.Drawing.Point(86, 75);
            this.cCurso.Name = "cCurso";
            this.cCurso.Size = new System.Drawing.Size(389, 21);
            this.cCurso.TabIndex = 1;
            // 
            // cPeriodo
            // 
            this.cPeriodo.FormattingEnabled = true;
            this.cPeriodo.Location = new System.Drawing.Point(86, 112);
            this.cPeriodo.Name = "cPeriodo";
            this.cPeriodo.Size = new System.Drawing.Size(389, 21);
            this.cPeriodo.TabIndex = 2;
            // 
            // mCPF
            // 
            this.mCPF.Location = new System.Drawing.Point(86, 42);
            this.mCPF.Mask = "999.999.999-99";
            this.mCPF.Name = "mCPF";
            this.mCPF.Size = new System.Drawing.Size(242, 20);
            this.mCPF.TabIndex = 0;
            // 
            // btResetarSenha
            // 
            this.btResetarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btResetarSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResetarSenha.ForeColor = System.Drawing.Color.White;
            this.btResetarSenha.Location = new System.Drawing.Point(187, 239);
            this.btResetarSenha.Name = "btResetarSenha";
            this.btResetarSenha.Size = new System.Drawing.Size(141, 43);
            this.btResetarSenha.TabIndex = 3;
            this.btResetarSenha.Text = "Resetar Senha";
            this.btResetarSenha.UseVisualStyleBackColor = false;
            this.btResetarSenha.Click += new System.EventHandler(this.btResetarSenha_Click);
            // 
            // btCadastreMe
            // 
            this.btCadastreMe.BackColor = System.Drawing.Color.DodgerBlue;
            this.btCadastreMe.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastreMe.ForeColor = System.Drawing.Color.White;
            this.btCadastreMe.Location = new System.Drawing.Point(334, 239);
            this.btCadastreMe.Name = "btCadastreMe";
            this.btCadastreMe.Size = new System.Drawing.Size(141, 43);
            this.btCadastreMe.TabIndex = 4;
            this.btCadastreMe.Text = "Salvar";
            this.btCadastreMe.UseVisualStyleBackColor = false;
            this.btCadastreMe.Click += new System.EventHandler(this.btCadastreMe_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Período:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Curso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "CPF:";
            // 
            // picHome
            // 
            this.picHome.Image = global::uemgevent.Properties.Resources.home;
            this.picHome.Location = new System.Drawing.Point(562, 362);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(38, 23);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 14;
            this.picHome.TabStop = false;
            // 
            // picInstagram
            // 
            this.picInstagram.Image = global::uemgevent.Properties.Resources.instagram_logo;
            this.picInstagram.Location = new System.Drawing.Point(599, 362);
            this.picInstagram.Name = "picInstagram";
            this.picInstagram.Size = new System.Drawing.Size(36, 23);
            this.picInstagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInstagram.TabIndex = 13;
            this.picInstagram.TabStop = false;
            // 
            // pcFacebook
            // 
            this.pcFacebook.Image = global::uemgevent.Properties.Resources.facebook_logo;
            this.pcFacebook.Location = new System.Drawing.Point(636, 362);
            this.pcFacebook.Name = "pcFacebook";
            this.pcFacebook.Size = new System.Drawing.Size(36, 23);
            this.pcFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcFacebook.TabIndex = 12;
            this.pcFacebook.TabStop = false;
            // 
            // pcHelp
            // 
            this.pcHelp.Image = global::uemgevent.Properties.Resources.question_mark;
            this.pcHelp.Location = new System.Drawing.Point(672, 362);
            this.pcHelp.Name = "pcHelp";
            this.pcHelp.Size = new System.Drawing.Size(36, 23);
            this.pcHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcHelp.TabIndex = 11;
            this.pcHelp.TabStop = false;
            // 
            // Form_PerfilAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(725, 407);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.picInstagram);
            this.Controls.Add(this.pcFacebook);
            this.Controls.Add(this.pcHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_PerfilAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil do Aluno";
            this.Load += new System.EventHandler(this.Form_PerfilAluno_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInstagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btResetarSenha;
        private System.Windows.Forms.Button btCadastreMe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox picInstagram;
        private System.Windows.Forms.PictureBox pcFacebook;
        private System.Windows.Forms.PictureBox pcHelp;
        private System.Windows.Forms.MaskedTextBox mCPF;
        private System.Windows.Forms.ComboBox cCurso;
        private System.Windows.Forms.ComboBox cPeriodo;
    }
}