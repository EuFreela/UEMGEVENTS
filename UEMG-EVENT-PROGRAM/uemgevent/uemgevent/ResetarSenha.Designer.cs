namespace uemgevent
{
    partial class ResetarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetarSenha));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btResetarSenhaU = new System.Windows.Forms.Button();
            this.lbConfirmarSenha = new System.Windows.Forms.Label();
            this.mtbConfirmarSenha = new System.Windows.Forms.MaskedTextBox();
            this.mtbPasswd = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btResetarSenhaU);
            this.panel1.Controls.Add(this.lbConfirmarSenha);
            this.panel1.Controls.Add(this.mtbConfirmarSenha);
            this.panel1.Controls.Add(this.mtbPasswd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 314);
            this.panel1.TabIndex = 0;
            // 
            // btResetarSenhaU
            // 
            this.btResetarSenhaU.Location = new System.Drawing.Point(270, 153);
            this.btResetarSenhaU.Name = "btResetarSenhaU";
            this.btResetarSenhaU.Size = new System.Drawing.Size(141, 43);
            this.btResetarSenhaU.TabIndex = 8;
            this.btResetarSenhaU.Text = "Resetar";
            this.btResetarSenhaU.UseVisualStyleBackColor = true;
            this.btResetarSenhaU.Click += new System.EventHandler(this.btResetarSenhaU_Click);
            // 
            // lbConfirmarSenha
            // 
            this.lbConfirmarSenha.AutoSize = true;
            this.lbConfirmarSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmarSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbConfirmarSenha.Location = new System.Drawing.Point(124, 123);
            this.lbConfirmarSenha.Name = "lbConfirmarSenha";
            this.lbConfirmarSenha.Size = new System.Drawing.Size(11, 15);
            this.lbConfirmarSenha.TabIndex = 7;
            this.lbConfirmarSenha.Text = ".";
            // 
            // mtbConfirmarSenha
            // 
            this.mtbConfirmarSenha.Location = new System.Drawing.Point(127, 88);
            this.mtbConfirmarSenha.Name = "mtbConfirmarSenha";
            this.mtbConfirmarSenha.PasswordChar = '*';
            this.mtbConfirmarSenha.Size = new System.Drawing.Size(284, 20);
            this.mtbConfirmarSenha.TabIndex = 6;
            this.mtbConfirmarSenha.TextChanged += new System.EventHandler(this.mtbConfirmarSenha_TextChanged);
            // 
            // mtbPasswd
            // 
            this.mtbPasswd.Location = new System.Drawing.Point(127, 56);
            this.mtbPasswd.Name = "mtbPasswd";
            this.mtbPasswd.PasswordChar = '*';
            this.mtbPasswd.Size = new System.Drawing.Size(284, 20);
            this.mtbPasswd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirme a senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha:";
            // 
            // ResetarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(478, 338);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ResetarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resetar Senha";
            this.Load += new System.EventHandler(this.ResetarSenha_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbConfirmarSenha;
        private System.Windows.Forms.MaskedTextBox mtbPasswd;
        private System.Windows.Forms.Label lbConfirmarSenha;
        private System.Windows.Forms.Button btResetarSenhaU;
    }
}