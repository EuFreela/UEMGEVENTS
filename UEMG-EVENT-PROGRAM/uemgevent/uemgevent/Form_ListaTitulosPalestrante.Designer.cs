namespace uemgevent
{
    partial class Form_ListaTitulosPalestrante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ListaTitulosPalestrante));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nvTitulosPalestrante = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dGridTitulosPalestrante = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cTitulo = new System.Windows.Forms.ComboBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.datePosse = new System.Windows.Forms.DateTimePicker();
            this.tbInstituicao = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorRefreshtem = new System.Windows.Forms.ToolStripButton();
            this.navigatorTitulosPalestranteExcluirItem = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvTitulosPalestrante)).BeginInit();
            this.nvTitulosPalestrante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridTitulosPalestrante)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nvTitulosPalestrante);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 54);
            this.panel1.TabIndex = 0;
            // 
            // nvTitulosPalestrante
            // 
            this.nvTitulosPalestrante.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nvTitulosPalestrante.CountItem = this.bindingNavigatorCountItem;
            this.nvTitulosPalestrante.DeleteItem = null;
            this.nvTitulosPalestrante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorRefreshtem,
            this.navigatorTitulosPalestranteExcluirItem});
            this.nvTitulosPalestrante.Location = new System.Drawing.Point(0, 0);
            this.nvTitulosPalestrante.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nvTitulosPalestrante.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nvTitulosPalestrante.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nvTitulosPalestrante.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nvTitulosPalestrante.Name = "nvTitulosPalestrante";
            this.nvTitulosPalestrante.PositionItem = this.bindingNavigatorPositionItem;
            this.nvTitulosPalestrante.Size = new System.Drawing.Size(690, 25);
            this.nvTitulosPalestrante.TabIndex = 0;
            this.nvTitulosPalestrante.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dGridTitulosPalestrante
            // 
            this.dGridTitulosPalestrante.AllowUserToDeleteRows = false;
            this.dGridTitulosPalestrante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridTitulosPalestrante.Dock = System.Windows.Forms.DockStyle.Top;
            this.dGridTitulosPalestrante.Location = new System.Drawing.Point(0, 54);
            this.dGridTitulosPalestrante.Name = "dGridTitulosPalestrante";
            this.dGridTitulosPalestrante.ReadOnly = true;
            this.dGridTitulosPalestrante.Size = new System.Drawing.Size(690, 202);
            this.dGridTitulosPalestrante.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cTitulo);
            this.panel2.Controls.Add(this.btUpdate);
            this.panel2.Controls.Add(this.btCancelar);
            this.panel2.Controls.Add(this.datePosse);
            this.panel2.Controls.Add(this.tbInstituicao);
            this.panel2.Controls.Add(this.tbID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 154);
            this.panel2.TabIndex = 2;
            // 
            // cTitulo
            // 
            this.cTitulo.FormattingEnabled = true;
            this.cTitulo.Location = new System.Drawing.Point(416, 11);
            this.cTitulo.Name = "cTitulo";
            this.cTitulo.Size = new System.Drawing.Size(228, 21);
            this.cTitulo.TabIndex = 1;
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.ForeColor = System.Drawing.Color.White;
            this.btUpdate.Location = new System.Drawing.Point(523, 87);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(121, 45);
            this.btUpdate.TabIndex = 4;
            this.btUpdate.Text = "Salvar";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(396, 87);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(121, 45);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // datePosse
            // 
            this.datePosse.Location = new System.Drawing.Point(416, 42);
            this.datePosse.Name = "datePosse";
            this.datePosse.Size = new System.Drawing.Size(226, 20);
            this.datePosse.TabIndex = 2;
            // 
            // tbInstituicao
            // 
            this.tbInstituicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbInstituicao.Location = new System.Drawing.Point(90, 41);
            this.tbInstituicao.Name = "tbInstituicao";
            this.tbInstituicao.Size = new System.Drawing.Size(205, 20);
            this.tbInstituicao.TabIndex = 0;
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(90, 12);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(98, 20);
            this.tbID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Título:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Posse:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Instituição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // bindingNavigatorRefreshtem
            // 
            this.bindingNavigatorRefreshtem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorRefreshtem.Image = global::uemgevent.Properties.Resources.refresh_button;
            this.bindingNavigatorRefreshtem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorRefreshtem.Name = "bindingNavigatorRefreshtem";
            this.bindingNavigatorRefreshtem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorRefreshtem.Text = "toolStripButton1";
            this.bindingNavigatorRefreshtem.Click += new System.EventHandler(this.bindingNavigatorRefreshtem_Click);
            // 
            // navigatorTitulosPalestranteExcluirItem
            // 
            this.navigatorTitulosPalestranteExcluirItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navigatorTitulosPalestranteExcluirItem.Image = global::uemgevent.Properties.Resources.delete;
            this.navigatorTitulosPalestranteExcluirItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navigatorTitulosPalestranteExcluirItem.Name = "navigatorTitulosPalestranteExcluirItem";
            this.navigatorTitulosPalestranteExcluirItem.Size = new System.Drawing.Size(23, 22);
            this.navigatorTitulosPalestranteExcluirItem.Text = "toolStripButton1";
            this.navigatorTitulosPalestranteExcluirItem.Click += new System.EventHandler(this.navigatorTitulosPalestranteExcluirItem_Click);
            // 
            // Form_ListaTitulosPalestrante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 416);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dGridTitulosPalestrante);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ListaTitulosPalestrante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titulos do Palestrante";
            this.Load += new System.EventHandler(this.Form_ListaTitulosPalestrante_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvTitulosPalestrante)).EndInit();
            this.nvTitulosPalestrante.ResumeLayout(false);
            this.nvTitulosPalestrante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridTitulosPalestrante)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGridTitulosPalestrante;
        private System.Windows.Forms.BindingNavigator nvTitulosPalestrante;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePosse;
        private System.Windows.Forms.TextBox tbInstituicao;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ComboBox cTitulo;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshtem;
        private System.Windows.Forms.ToolStripButton navigatorTitulosPalestranteExcluirItem;
    }
}