namespace uemgevent
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palestranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPalestranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarPalestrantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.eventoToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(762, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.toolStripMenuItem2});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(90, 6);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.palestranteToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // palestranteToolStripMenuItem
            // 
            this.palestranteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarPalestranteToolStripMenuItem,
            this.cadastrarPalestrantesToolStripMenuItem});
            this.palestranteToolStripMenuItem.Name = "palestranteToolStripMenuItem";
            this.palestranteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.palestranteToolStripMenuItem.Text = "Palestrante";
            // 
            // listarPalestranteToolStripMenuItem
            // 
            this.listarPalestranteToolStripMenuItem.Name = "listarPalestranteToolStripMenuItem";
            this.listarPalestranteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.listarPalestranteToolStripMenuItem.Text = "Listar Palestrante";
            this.listarPalestranteToolStripMenuItem.Click += new System.EventHandler(this.listarPalestranteToolStripMenuItem_Click);
            // 
            // cadastrarPalestrantesToolStripMenuItem
            // 
            this.cadastrarPalestrantesToolStripMenuItem.Name = "cadastrarPalestrantesToolStripMenuItem";
            this.cadastrarPalestrantesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.cadastrarPalestrantesToolStripMenuItem.Text = "Cadastrar Palestrantes";
            this.cadastrarPalestrantesToolStripMenuItem.Click += new System.EventHandler(this.cadastrarPalestrantesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarUsuarioToolStripMenuItem,
            this.cadastrarUsuáriosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // listarUsuarioToolStripMenuItem
            // 
            this.listarUsuarioToolStripMenuItem.Name = "listarUsuarioToolStripMenuItem";
            this.listarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.listarUsuarioToolStripMenuItem.Text = "Listar Usuario";
            this.listarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.listarUsuarioToolStripMenuItem_Click);
            // 
            // cadastrarUsuáriosToolStripMenuItem
            // 
            this.cadastrarUsuáriosToolStripMenuItem.Name = "cadastrarUsuáriosToolStripMenuItem";
            this.cadastrarUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cadastrarUsuáriosToolStripMenuItem.Text = "Cadastrar Usuários";
            this.cadastrarUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuáriosToolStripMenuItem_Click);
            // 
            // eventoToolStripMenuItem
            // 
            this.eventoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarEventoToolStripMenuItem,
            this.pesquisarEventoToolStripMenuItem});
            this.eventoToolStripMenuItem.Name = "eventoToolStripMenuItem";
            this.eventoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.eventoToolStripMenuItem.Text = "Evento";
            // 
            // criarEventoToolStripMenuItem
            // 
            this.criarEventoToolStripMenuItem.Name = "criarEventoToolStripMenuItem";
            this.criarEventoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.criarEventoToolStripMenuItem.Text = "Criar Evento";
            this.criarEventoToolStripMenuItem.Click += new System.EventHandler(this.criarEventoToolStripMenuItem_Click);
            // 
            // pesquisarEventoToolStripMenuItem
            // 
            this.pesquisarEventoToolStripMenuItem.Name = "pesquisarEventoToolStripMenuItem";
            this.pesquisarEventoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pesquisarEventoToolStripMenuItem.Text = "Listar Evento";
            this.pesquisarEventoToolStripMenuItem.Click += new System.EventHandler(this.pesquisarEventoToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(762, 404);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palestranteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPalestranteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarPalestrantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuáriosToolStripMenuItem;
    }
}