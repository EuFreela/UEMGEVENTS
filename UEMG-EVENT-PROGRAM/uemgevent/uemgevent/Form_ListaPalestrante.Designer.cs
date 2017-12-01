namespace uemgevent
{
    partial class Form_ListaPalestrante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ListaPalestrante));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.nvPalestrante = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mtbTelefoneCelular = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefoneFixo = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cEstado = new System.Windows.Forms.ComboBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btTitulos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCidadePalestrante = new System.Windows.Forms.TextBox();
            this.tbNomePalestrante = new System.Windows.Forms.TextBox();
            this.tbCodPalestrante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGringPalestrante = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvPalestrante)).BeginInit();
            this.nvPalestrante.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGringPalestrante)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.nvPalestrante);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 58);
            this.panel1.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearch.Location = new System.Drawing.Point(0, 25);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(949, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // nvPalestrante
            // 
            this.nvPalestrante.AddNewItem = null;
            this.nvPalestrante.CountItem = this.bindingNavigatorCountItem;
            this.nvPalestrante.DeleteItem = null;
            this.nvPalestrante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.nvPalestrante.Location = new System.Drawing.Point(0, 0);
            this.nvPalestrante.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nvPalestrante.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nvPalestrante.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nvPalestrante.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nvPalestrante.Name = "nvPalestrante";
            this.nvPalestrante.PositionItem = this.bindingNavigatorPositionItem;
            this.nvPalestrante.Size = new System.Drawing.Size(949, 25);
            this.nvPalestrante.TabIndex = 0;
            this.nvPalestrante.Text = "bindingNavigator1";
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
            this.navigatorRefresh.Click += new System.EventHandler(this.navigatorRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dGringPalestrante);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 475);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mtbTelefoneCelular);
            this.panel3.Controls.Add(this.mtbTelefoneFixo);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cEstado);
            this.panel3.Controls.Add(this.btUpdate);
            this.panel3.Controls.Add(this.btCancelar);
            this.panel3.Controls.Add(this.btTitulos);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tbEmail);
            this.panel3.Controls.Add(this.tbID);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbCidadePalestrante);
            this.panel3.Controls.Add(this.tbNomePalestrante);
            this.panel3.Controls.Add(this.tbCodPalestrante);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(949, 201);
            this.panel3.TabIndex = 1;
            // 
            // mtbTelefoneCelular
            // 
            this.mtbTelefoneCelular.Location = new System.Drawing.Point(128, 144);
            this.mtbTelefoneCelular.Mask = "(99) 0000-0000";
            this.mtbTelefoneCelular.Name = "mtbTelefoneCelular";
            this.mtbTelefoneCelular.Size = new System.Drawing.Size(136, 20);
            this.mtbTelefoneCelular.TabIndex = 3;
            // 
            // mtbTelefoneFixo
            // 
            this.mtbTelefoneFixo.Location = new System.Drawing.Point(128, 115);
            this.mtbTelefoneFixo.Mask = "(99) 000-0000";
            this.mtbTelefoneFixo.Name = "mtbTelefoneFixo";
            this.mtbTelefoneFixo.Size = new System.Drawing.Size(136, 20);
            this.mtbTelefoneFixo.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Celular:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "T.Fixo:";
            // 
            // cEstado
            // 
            this.cEstado.FormattingEnabled = true;
            this.cEstado.Location = new System.Drawing.Point(545, 82);
            this.cEstado.Name = "cEstado";
            this.cEstado.Size = new System.Drawing.Size(182, 21);
            this.cEstado.TabIndex = 6;
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
            // btTitulos
            // 
            this.btTitulos.BackColor = System.Drawing.Color.SeaGreen;
            this.btTitulos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTitulos.ForeColor = System.Drawing.Color.White;
            this.btTitulos.Location = new System.Drawing.Point(545, 131);
            this.btTitulos.Name = "btTitulos";
            this.btTitulos.Size = new System.Drawing.Size(121, 45);
            this.btTitulos.TabIndex = 7;
            this.btTitulos.Text = "Titulos";
            this.btTitulos.UseVisualStyleBackColor = false;
            this.btTitulos.Click += new System.EventHandler(this.btTitulos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "email:";
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
            this.label3.Location = new System.Drawing.Point(491, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estado:";
            // 
            // tbCidadePalestrante
            // 
            this.tbCidadePalestrante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCidadePalestrante.Location = new System.Drawing.Point(545, 51);
            this.tbCidadePalestrante.Name = "tbCidadePalestrante";
            this.tbCidadePalestrante.Size = new System.Drawing.Size(376, 20);
            this.tbCidadePalestrante.TabIndex = 5;
            // 
            // tbNomePalestrante
            // 
            this.tbNomePalestrante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNomePalestrante.Location = new System.Drawing.Point(128, 83);
            this.tbNomePalestrante.Name = "tbNomePalestrante";
            this.tbNomePalestrante.Size = new System.Drawing.Size(295, 20);
            this.tbNomePalestrante.TabIndex = 1;
            // 
            // tbCodPalestrante
            // 
            this.tbCodPalestrante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbCodPalestrante.Enabled = false;
            this.tbCodPalestrante.Location = new System.Drawing.Point(128, 51);
            this.tbCodPalestrante.Name = "tbCodPalestrante";
            this.tbCodPalestrante.Size = new System.Drawing.Size(136, 20);
            this.tbCodPalestrante.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "cidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Palestrante:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Palestrante:";
            // 
            // dGringPalestrante
            // 
            this.dGringPalestrante.AllowUserToAddRows = false;
            this.dGringPalestrante.AllowUserToDeleteRows = false;
            this.dGringPalestrante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGringPalestrante.Dock = System.Windows.Forms.DockStyle.Top;
            this.dGringPalestrante.Location = new System.Drawing.Point(0, 0);
            this.dGringPalestrante.Name = "dGringPalestrante";
            this.dGringPalestrante.ReadOnly = true;
            this.dGringPalestrante.Size = new System.Drawing.Size(949, 274);
            this.dGringPalestrante.TabIndex = 0;
            // 
            // Form_ListaPalestrante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ListaPalestrante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ListaPalestrante";
            this.Load += new System.EventHandler(this.Form_ListaPalestrante_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvPalestrante)).EndInit();
            this.nvPalestrante.ResumeLayout(false);
            this.nvPalestrante.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGringPalestrante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingNavigator nvPalestrante;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dGringPalestrante;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbCidadePalestrante;
        private System.Windows.Forms.TextBox tbNomePalestrante;
        private System.Windows.Forms.TextBox tbCodPalestrante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btTitulos;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.ComboBox cEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripButton navigatorRefresh;
        private System.Windows.Forms.MaskedTextBox mtbTelefoneCelular;
        private System.Windows.Forms.MaskedTextBox mtbTelefoneFixo;
    }
}