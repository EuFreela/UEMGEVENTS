namespace uemgevent
{
    partial class Form_ListaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ListaUsuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSearchListaUsuarios = new System.Windows.Forms.TextBox();
            this.nvListaUsuarios = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dGridListaUsuarios = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btResetarSenhaUsuario = new System.Windows.Forms.Button();
            this.cPerfil = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cAtivo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbNomeUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvListaUsuarios)).BeginInit();
            this.nvListaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridListaUsuarios)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbSearchListaUsuarios);
            this.panel1.Controls.Add(this.nvListaUsuarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 58);
            this.panel1.TabIndex = 1;
            // 
            // tbSearchListaUsuarios
            // 
            this.tbSearchListaUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearchListaUsuarios.Location = new System.Drawing.Point(0, 25);
            this.tbSearchListaUsuarios.Name = "tbSearchListaUsuarios";
            this.tbSearchListaUsuarios.Size = new System.Drawing.Size(957, 20);
            this.tbSearchListaUsuarios.TabIndex = 0;
            // 
            // nvListaUsuarios
            // 
            this.nvListaUsuarios.AddNewItem = null;
            this.nvListaUsuarios.CountItem = this.bindingNavigatorCountItem;
            this.nvListaUsuarios.DeleteItem = null;
            this.nvListaUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.nvListaUsuarios.Location = new System.Drawing.Point(0, 0);
            this.nvListaUsuarios.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nvListaUsuarios.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nvListaUsuarios.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nvListaUsuarios.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nvListaUsuarios.Name = "nvListaUsuarios";
            this.nvListaUsuarios.PositionItem = this.bindingNavigatorPositionItem;
            this.nvListaUsuarios.Size = new System.Drawing.Size(957, 25);
            this.nvListaUsuarios.TabIndex = 0;
            this.nvListaUsuarios.Text = "bindingNavigator1";
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
            // dGridListaUsuarios
            // 
            this.dGridListaUsuarios.AllowUserToAddRows = false;
            this.dGridListaUsuarios.AllowUserToDeleteRows = false;
            this.dGridListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridListaUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.dGridListaUsuarios.Location = new System.Drawing.Point(0, 58);
            this.dGridListaUsuarios.Name = "dGridListaUsuarios";
            this.dGridListaUsuarios.ReadOnly = true;
            this.dGridListaUsuarios.Size = new System.Drawing.Size(957, 274);
            this.dGridListaUsuarios.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btResetarSenhaUsuario);
            this.panel3.Controls.Add(this.cPerfil);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cAtivo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btUpdate);
            this.panel3.Controls.Add(this.btCancelar);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tbEmail);
            this.panel3.Controls.Add(this.tbID);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tbUsuario);
            this.panel3.Controls.Add(this.tbNomeUsuario);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 332);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(957, 206);
            this.panel3.TabIndex = 3;
            // 
            // btResetarSenhaUsuario
            // 
            this.btResetarSenhaUsuario.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btResetarSenhaUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResetarSenhaUsuario.ForeColor = System.Drawing.Color.White;
            this.btResetarSenhaUsuario.Location = new System.Drawing.Point(673, 83);
            this.btResetarSenhaUsuario.Name = "btResetarSenhaUsuario";
            this.btResetarSenhaUsuario.Size = new System.Drawing.Size(248, 45);
            this.btResetarSenhaUsuario.TabIndex = 26;
            this.btResetarSenhaUsuario.Text = "Resetar Senha";
            this.btResetarSenhaUsuario.UseVisualStyleBackColor = false;
            this.btResetarSenhaUsuario.Click += new System.EventHandler(this.btResetarSenhaUsuario_Click);
            // 
            // cPerfil
            // 
            this.cPerfil.FormattingEnabled = true;
            this.cPerfil.Items.AddRange(new object[] {
            "Administrador",
            "Aluno"});
            this.cPerfil.Location = new System.Drawing.Point(128, 114);
            this.cPerfil.Name = "cPerfil";
            this.cPerfil.Size = new System.Drawing.Size(176, 21);
            this.cPerfil.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Perfil:";
            // 
            // cAtivo
            // 
            this.cAtivo.FormattingEnabled = true;
            this.cAtivo.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cAtivo.Location = new System.Drawing.Point(128, 50);
            this.cAtivo.Name = "cAtivo";
            this.cAtivo.Size = new System.Drawing.Size(176, 21);
            this.cAtivo.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ativo:";
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.ForeColor = System.Drawing.Color.White;
            this.btUpdate.Location = new System.Drawing.Point(800, 131);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(121, 45);
            this.btUpdate.TabIndex = 9;
            this.btUpdate.Text = "Salvar";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(673, 131);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(121, 45);
            this.btCancelar.TabIndex = 8;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "E-mail:";
            // 
            // tbEmail
            // 
            this.tbEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbEmail.Location = new System.Drawing.Point(545, 21);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(376, 20);
            this.tbEmail.TabIndex = 4;
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(128, 17);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(176, 20);
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
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(545, 51);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(376, 20);
            this.tbUsuario.TabIndex = 5;
            this.tbUsuario.TextChanged += new System.EventHandler(this.tbUsuario_TextChanged);
            // 
            // tbNomeUsuario
            // 
            this.tbNomeUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNomeUsuario.Location = new System.Drawing.Point(128, 83);
            this.tbNomeUsuario.Name = "tbNomeUsuario";
            this.tbNomeUsuario.Size = new System.Drawing.Size(295, 20);
            this.tbNomeUsuario.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Usuário:";
            // 
            // Form_ListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 538);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dGridListaUsuarios);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ListaUsuarios";
            this.Text = "Lista de Usuários";
            this.Load += new System.EventHandler(this.Form_ListaUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvListaUsuarios)).EndInit();
            this.nvListaUsuarios.ResumeLayout(false);
            this.nvListaUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridListaUsuarios)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbSearchListaUsuarios;
        private System.Windows.Forms.BindingNavigator nvListaUsuarios;
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
        private System.Windows.Forms.DataGridView dGridListaUsuarios;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbNomeUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cAtivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cPerfil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btResetarSenhaUsuario;
    }
}