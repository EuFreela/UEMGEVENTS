namespace uemgevent
{
    partial class Form_CadastroEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CadastroEventos));
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picInstagram = new System.Windows.Forms.PictureBox();
            this.pcFacebook = new System.Windows.Forms.PictureBox();
            this.pcHelp = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dDataEvento = new System.Windows.Forms.DateTimePicker();
            this.mHInicio = new System.Windows.Forms.MaskedTextBox();
            this.mHFim = new System.Windows.Forms.MaskedTextBox();
            this.cPalestrantes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pcLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInstagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHelp)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picHome
            // 
            this.picHome.Image = global::uemgevent.Properties.Resources.home;
            this.picHome.Location = new System.Drawing.Point(562, 371);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(38, 23);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 14;
            this.picHome.TabStop = false;
            // 
            // picInstagram
            // 
            this.picInstagram.Image = global::uemgevent.Properties.Resources.instagram_logo;
            this.picInstagram.Location = new System.Drawing.Point(599, 371);
            this.picInstagram.Name = "picInstagram";
            this.picInstagram.Size = new System.Drawing.Size(36, 23);
            this.picInstagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInstagram.TabIndex = 13;
            this.picInstagram.TabStop = false;
            // 
            // pcFacebook
            // 
            this.pcFacebook.Image = global::uemgevent.Properties.Resources.facebook_logo;
            this.pcFacebook.Location = new System.Drawing.Point(636, 371);
            this.pcFacebook.Name = "pcFacebook";
            this.pcFacebook.Size = new System.Drawing.Size(36, 23);
            this.pcFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcFacebook.TabIndex = 12;
            this.pcFacebook.TabStop = false;
            // 
            // pcHelp
            // 
            this.pcHelp.Image = global::uemgevent.Properties.Resources.question_mark;
            this.pcHelp.Location = new System.Drawing.Point(672, 371);
            this.pcHelp.Name = "pcHelp";
            this.pcHelp.Size = new System.Drawing.Size(36, 23);
            this.pcHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcHelp.TabIndex = 11;
            this.pcHelp.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.dDataEvento);
            this.panel3.Controls.Add(this.mHInicio);
            this.panel3.Controls.Add(this.mHFim);
            this.panel3.Controls.Add(this.cPalestrantes);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btCancelar);
            this.panel3.Controls.Add(this.btCadastrar);
            this.panel3.Controls.Add(this.tbNome);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(201, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 334);
            this.panel3.TabIndex = 10;
            // 
            // dDataEvento
            // 
            this.dDataEvento.Location = new System.Drawing.Point(93, 85);
            this.dDataEvento.Name = "dDataEvento";
            this.dDataEvento.Size = new System.Drawing.Size(235, 20);
            this.dDataEvento.TabIndex = 13;
            // 
            // mHInicio
            // 
            this.mHInicio.Location = new System.Drawing.Point(93, 116);
            this.mHInicio.Mask = "00:00";
            this.mHInicio.Name = "mHInicio";
            this.mHInicio.Size = new System.Drawing.Size(87, 20);
            this.mHInicio.TabIndex = 12;
            this.mHInicio.ValidatingType = typeof(System.DateTime);
            // 
            // mHFim
            // 
            this.mHFim.Location = new System.Drawing.Point(93, 145);
            this.mHFim.Mask = "00:00";
            this.mHFim.Name = "mHFim";
            this.mHFim.Size = new System.Drawing.Size(87, 20);
            this.mHFim.TabIndex = 11;
            this.mHFim.ValidatingType = typeof(System.DateTime);
            // 
            // cPalestrantes
            // 
            this.cPalestrantes.FormattingEnabled = true;
            this.cPalestrantes.Location = new System.Drawing.Point(93, 178);
            this.cPalestrantes.Name = "cPalestrantes";
            this.cPalestrantes.Size = new System.Drawing.Size(378, 21);
            this.cPalestrantes.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "Palestrante:";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(183, 259);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(141, 43);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.ForeColor = System.Drawing.Color.White;
            this.btCadastrar.Location = new System.Drawing.Point(330, 259);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(141, 43);
            this.btCadastrar.TabIndex = 6;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // tbNome
            // 
            this.tbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNome.Location = new System.Drawing.Point(93, 51);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(378, 20);
            this.tbNome.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "H.Fim:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "H.Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Evento:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pcLogo);
            this.panel2.Location = new System.Drawing.Point(16, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 359);
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
            // Form_CadastroEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(725, 408);
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
            this.Name = "Form_CadastroEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Eventos";
            this.Load += new System.EventHandler(this.Form_CadastroEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInstagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHelp)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox picInstagram;
        private System.Windows.Forms.PictureBox pcFacebook;
        private System.Windows.Forms.PictureBox pcHelp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cPalestrantes;
        private System.Windows.Forms.MaskedTextBox mHFim;
        private System.Windows.Forms.DateTimePicker dDataEvento;
        private System.Windows.Forms.MaskedTextBox mHInicio;
    }
}