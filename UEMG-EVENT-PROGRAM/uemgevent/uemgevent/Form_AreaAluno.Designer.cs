namespace uemgevent
{
    partial class Form_AreaAluno
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AreaAluno));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meuPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriçõesRealizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.nvEventos = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.navigatorRefresh = new System.Windows.Forms.ToolStripButton();
            this.dGrindEventos = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mDataEvento = new System.Windows.Forms.DateTimePicker();
            this.mHFinal = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mHInicial = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cPalestrante = new System.Windows.Forms.ComboBox();
            this.btInscricao = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvEventos)).BeginInit();
            this.nvEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrindEventos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.meuPerfilToolStripMenuItem,
            this.inscriçõesRealizadasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sairToolStripMenuItem.Text = "Fechar Aplicação";
            // 
            // meuPerfilToolStripMenuItem
            // 
            this.meuPerfilToolStripMenuItem.Name = "meuPerfilToolStripMenuItem";
            this.meuPerfilToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.meuPerfilToolStripMenuItem.Text = "Meu Perfil";
            this.meuPerfilToolStripMenuItem.Click += new System.EventHandler(this.meuPerfilToolStripMenuItem_Click);
            // 
            // inscriçõesRealizadasToolStripMenuItem
            // 
            this.inscriçõesRealizadasToolStripMenuItem.Name = "inscriçõesRealizadasToolStripMenuItem";
            this.inscriçõesRealizadasToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.inscriçõesRealizadasToolStripMenuItem.Text = "Inscrições Realizadas";
            this.inscriçõesRealizadasToolStripMenuItem.Click += new System.EventHandler(this.inscriçõesRealizadasToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.nvEventos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 58);
            this.panel1.TabIndex = 2;
            // 
            // tbSearch
            // 
            this.tbSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearch.Location = new System.Drawing.Point(0, 25);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(791, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // nvEventos
            // 
            this.nvEventos.AddNewItem = null;
            this.nvEventos.CountItem = this.bindingNavigatorCountItem;
            this.nvEventos.DeleteItem = null;
            this.nvEventos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.navigatorRefresh});
            this.nvEventos.Location = new System.Drawing.Point(0, 0);
            this.nvEventos.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nvEventos.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nvEventos.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nvEventos.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nvEventos.Name = "nvEventos";
            this.nvEventos.PositionItem = this.bindingNavigatorPositionItem;
            this.nvEventos.Size = new System.Drawing.Size(791, 25);
            this.nvEventos.TabIndex = 0;
            this.nvEventos.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // navigatorRefresh
            // 
            this.navigatorRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navigatorRefresh.Image = global::uemgevent.Properties.Resources.refresh_button;
            this.navigatorRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navigatorRefresh.Name = "navigatorRefresh";
            this.navigatorRefresh.Size = new System.Drawing.Size(23, 22);
            this.navigatorRefresh.Text = "toolStripButton1";
            // 
            // dGrindEventos
            // 
            this.dGrindEventos.AllowUserToAddRows = false;
            this.dGrindEventos.AllowUserToDeleteRows = false;
            this.dGrindEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrindEventos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dGrindEventos.Location = new System.Drawing.Point(0, 82);
            this.dGrindEventos.Name = "dGrindEventos";
            this.dGrindEventos.ReadOnly = true;
            this.dGrindEventos.Size = new System.Drawing.Size(791, 274);
            this.dGrindEventos.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mDataEvento);
            this.panel3.Controls.Add(this.mHFinal);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.mHInicial);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cPalestrante);
            this.panel3.Controls.Add(this.btInscricao);
            this.panel3.Controls.Add(this.tbID);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbTitulo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 356);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 192);
            this.panel3.TabIndex = 4;
            // 
            // mDataEvento
            // 
            this.mDataEvento.Location = new System.Drawing.Point(531, 18);
            this.mDataEvento.Name = "mDataEvento";
            this.mDataEvento.Size = new System.Drawing.Size(222, 20);
            this.mDataEvento.TabIndex = 23;
            // 
            // mHFinal
            // 
            this.mHFinal.Enabled = false;
            this.mHFinal.Location = new System.Drawing.Point(530, 83);
            this.mHFinal.Mask = "00:00";
            this.mHFinal.Name = "mHFinal";
            this.mHFinal.Size = new System.Drawing.Size(223, 20);
            this.mHFinal.TabIndex = 22;
            this.mHFinal.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(492, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Final:";
            // 
            // mHInicial
            // 
            this.mHInicial.Enabled = false;
            this.mHInicial.Location = new System.Drawing.Point(530, 51);
            this.mHInicial.Mask = "00:00";
            this.mHInicial.Name = "mHInicial";
            this.mHInicial.Size = new System.Drawing.Size(223, 20);
            this.mHInicial.TabIndex = 3;
            this.mHInicial.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(487, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Início;";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Data:";
            // 
            // cPalestrante
            // 
            this.cPalestrante.Enabled = false;
            this.cPalestrante.FormattingEnabled = true;
            this.cPalestrante.Location = new System.Drawing.Point(128, 82);
            this.cPalestrante.Name = "cPalestrante";
            this.cPalestrante.Size = new System.Drawing.Size(295, 21);
            this.cPalestrante.TabIndex = 6;
            // 
            // btInscricao
            // 
            this.btInscricao.BackColor = System.Drawing.Color.DodgerBlue;
            this.btInscricao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInscricao.ForeColor = System.Drawing.Color.White;
            this.btInscricao.Location = new System.Drawing.Point(530, 124);
            this.btInscricao.Name = "btInscricao";
            this.btInscricao.Size = new System.Drawing.Size(223, 45);
            this.btInscricao.TabIndex = 9;
            this.btInscricao.Text = "Increver-me";
            this.btInscricao.UseVisualStyleBackColor = false;
            this.btInscricao.Click += new System.EventHandler(this.btInscricao_Click);
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(128, 17);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(136, 20);
            this.tbID.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Palestrante:";
            // 
            // tbTitulo
            // 
            this.tbTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbTitulo.Enabled = false;
            this.tbTitulo.Location = new System.Drawing.Point(128, 51);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(295, 20);
            this.tbTitulo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo:";
            // 
            // Form_AreaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 548);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dGrindEventos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Form_AreaAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area do Aluno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_AreaAluno_FormClosing);
            this.Load += new System.EventHandler(this.Form_AreaAluno_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvEventos)).EndInit();
            this.nvEventos.ResumeLayout(false);
            this.nvEventos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrindEventos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.BindingNavigator nvEventos;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton navigatorRefresh;
        private System.Windows.Forms.DataGridView dGrindEventos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker mDataEvento;
        private System.Windows.Forms.MaskedTextBox mHFinal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mHInicial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cPalestrante;
        private System.Windows.Forms.Button btInscricao;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem meuPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriçõesRealizadasToolStripMenuItem;
    }
}