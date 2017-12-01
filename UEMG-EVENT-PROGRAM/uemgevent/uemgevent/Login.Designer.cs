namespace uemgevent
{
    partial class formLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtbPasswd = new System.Windows.Forms.MaskedTextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.llbCadastroUsuario = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picInstagram = new System.Windows.Forms.PictureBox();
            this.pcFacebook = new System.Windows.Forms.PictureBox();
            this.pcHelp = new System.Windows.Forms.PictureBox();
            this.pcLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInstagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.mtbPasswd);
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbUsername);
            this.panel1.Controls.Add(this.llbCadastroUsuario);
            this.panel1.Location = new System.Drawing.Point(203, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 215);
            this.panel1.TabIndex = 0;
            // 
            // mtbPasswd
            // 
            this.mtbPasswd.Location = new System.Drawing.Point(36, 88);
            this.mtbPasswd.Name = "mtbPasswd";
            this.mtbPasswd.PasswordChar = '*';
            this.mtbPasswd.Size = new System.Drawing.Size(282, 20);
            this.mtbPasswd.TabIndex = 2;
            this.mtbPasswd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbPasswd_KeyPress);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEntrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(177, 129);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(141, 43);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario do sistema:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(36, 44);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(282, 20);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsername_KeyPress);
            // 
            // llbCadastroUsuario
            // 
            this.llbCadastroUsuario.AutoSize = true;
            this.llbCadastroUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbCadastroUsuario.Location = new System.Drawing.Point(33, 157);
            this.llbCadastroUsuario.Name = "llbCadastroUsuario";
            this.llbCadastroUsuario.Size = new System.Drawing.Size(117, 12);
            this.llbCadastroUsuario.TabIndex = 4;
            this.llbCadastroUsuario.TabStop = true;
            this.llbCadastroUsuario.Text = "Não sou cadastrado";
            this.llbCadastroUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCadastroUsuario_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 20);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pcLogo);
            this.panel3.Location = new System.Drawing.Point(16, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 359);
            this.panel3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ganhe Conhecimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "UEMG-EVENTS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Passos-MG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(76, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Beta v0.0.15";
            // 
            // picHome
            // 
            this.picHome.Image = global::uemgevent.Properties.Resources.home;
            this.picHome.Location = new System.Drawing.Point(405, 337);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(38, 23);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 11;
            this.picHome.TabStop = false;
            // 
            // picInstagram
            // 
            this.picInstagram.Image = global::uemgevent.Properties.Resources.instagram_logo;
            this.picInstagram.Location = new System.Drawing.Point(442, 337);
            this.picInstagram.Name = "picInstagram";
            this.picInstagram.Size = new System.Drawing.Size(36, 23);
            this.picInstagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInstagram.TabIndex = 10;
            this.picInstagram.TabStop = false;
            // 
            // pcFacebook
            // 
            this.pcFacebook.Image = global::uemgevent.Properties.Resources.facebook_logo;
            this.pcFacebook.Location = new System.Drawing.Point(479, 337);
            this.pcFacebook.Name = "pcFacebook";
            this.pcFacebook.Size = new System.Drawing.Size(36, 23);
            this.pcFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcFacebook.TabIndex = 9;
            this.pcFacebook.TabStop = false;
            // 
            // pcHelp
            // 
            this.pcHelp.Image = global::uemgevent.Properties.Resources.question_mark;
            this.pcHelp.Location = new System.Drawing.Point(515, 337);
            this.pcHelp.Name = "pcHelp";
            this.pcHelp.Size = new System.Drawing.Size(36, 23);
            this.pcHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcHelp.TabIndex = 8;
            this.pcHelp.TabStop = false;
            this.pcHelp.Click += new System.EventHandler(this.pcHelp_Click);
            // 
            // pcLogo
            // 
            this.pcLogo.Image = global::uemgevent.Properties.Resources.logo_500px;
            this.pcLogo.Location = new System.Drawing.Point(18, 62);
            this.pcLogo.Name = "pcLogo";
            this.pcLogo.Size = new System.Drawing.Size(134, 132);
            this.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcLogo.TabIndex = 3;
            this.pcLogo.TabStop = false;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(574, 376);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.picInstagram);
            this.Controls.Add(this.pcFacebook);
            this.Controls.Add(this.pcHelp);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cadastro para Eventos - Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInstagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.LinkLabel llbCadastroUsuario;
        private System.Windows.Forms.MaskedTextBox mtbPasswd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pcLogo;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox picInstagram;
        private System.Windows.Forms.PictureBox pcFacebook;
        private System.Windows.Forms.PictureBox pcHelp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

