namespace StaCatalina.Stock
{
    partial class Frm_AjusteStock
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AjusteStock));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDetalleAjusteStock = new System.Windows.Forms.DataGridView();
            this.Buscador = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LlevaVto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxSector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDeposito = new System.Windows.Forms.ComboBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBoxTipoMov = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMotivo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleAjusteStock)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStripEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.toolStripEvents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1376, 940);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewDetalleAjusteStock);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1376, 863);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // dataGridViewDetalleAjusteStock
            // 
            this.dataGridViewDetalleAjusteStock.AllowUserToResizeColumns = false;
            this.dataGridViewDetalleAjusteStock.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDetalleAjusteStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDetalleAjusteStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalleAjusteStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Buscador,
            this.CodProd,
            this.DescripProd,
            this.UniMed,
            this.Cantidad,
            this.LlevaVto});
            this.dataGridViewDetalleAjusteStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDetalleAjusteStock.EnableHeadersVisualStyles = false;
            this.dataGridViewDetalleAjusteStock.Location = new System.Drawing.Point(4, 143);
            this.dataGridViewDetalleAjusteStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDetalleAjusteStock.Name = "dataGridViewDetalleAjusteStock";
            this.dataGridViewDetalleAjusteStock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewDetalleAjusteStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDetalleAjusteStock.Size = new System.Drawing.Size(1368, 715);
            this.dataGridViewDetalleAjusteStock.TabIndex = 12;
            this.dataGridViewDetalleAjusteStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetalleIngStock_CellContentClick);
            this.dataGridViewDetalleAjusteStock.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetalleIngStock_CellEndEdit);
            this.dataGridViewDetalleAjusteStock.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewDetalleIngStock_CurrentCellDirtyStateChanged);
            this.dataGridViewDetalleAjusteStock.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewDetalleIngStock_EditingControlShowing);
            this.dataGridViewDetalleAjusteStock.SelectionChanged += new System.EventHandler(this.dataGridViewDetalleIngStock_SelectionChanged);
            this.dataGridViewDetalleAjusteStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewDetalleIngStock_KeyDown);
            // 
            // Buscador
            // 
            this.Buscador.HeaderText = "";
            this.Buscador.Name = "Buscador";
            this.Buscador.Width = 50;
            // 
            // CodProd
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CodProd.DefaultCellStyle = dataGridViewCellStyle2;
            this.CodProd.HeaderText = "Código";
            this.CodProd.Name = "CodProd";
            // 
            // DescripProd
            // 
            this.DescripProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DescripProd.DefaultCellStyle = dataGridViewCellStyle3;
            this.DescripProd.HeaderText = "Descripción";
            this.DescripProd.Name = "DescripProd";
            this.DescripProd.ReadOnly = true;
            this.DescripProd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // UniMed
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.UniMed.DefaultCellStyle = dataGridViewCellStyle4;
            this.UniMed.HeaderText = "UniMed";
            this.UniMed.Name = "UniMed";
            this.UniMed.ReadOnly = true;
            this.UniMed.Width = 70;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 120;
            // 
            // LlevaVto
            // 
            this.LlevaVto.HeaderText = "Lleva Vencimiento";
            this.LlevaVto.Name = "LlevaVto";
            this.LlevaVto.ReadOnly = true;
            this.LlevaVto.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxMotivo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxTipoMov);
            this.groupBox2.Controls.Add(this.comboBoxSector);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxDeposito);
            this.groupBox2.Controls.Add(this.buttonNew);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(4, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1368, 119);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // comboBoxSector
            // 
            this.comboBoxSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSector.FormattingEnabled = true;
            this.comboBoxSector.Location = new System.Drawing.Point(921, 5);
            this.comboBoxSector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSector.Name = "comboBoxSector";
            this.comboBoxSector.Size = new System.Drawing.Size(25, 28);
            this.comboBoxSector.TabIndex = 5;
            this.comboBoxSector.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Depósito Destino:";
            // 
            // comboBoxDeposito
            // 
            this.comboBoxDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDeposito.FormattingEnabled = true;
            this.comboBoxDeposito.Location = new System.Drawing.Point(479, 34);
            this.comboBoxDeposito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDeposito.Name = "comboBoxDeposito";
            this.comboBoxDeposito.Size = new System.Drawing.Size(402, 28);
            this.comboBoxDeposito.TabIndex = 3;
            this.comboBoxDeposito.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeposito_SelectedIndexChanged);
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonNew.Location = new System.Drawing.Point(1100, 38);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(185, 35);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "Nuevo Movimiento";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo Mov.";
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonClose});
            this.toolStripEvents.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripEvents.Location = new System.Drawing.Point(0, 863);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripEvents.Size = new System.Drawing.Size(1376, 77);
            this.toolStripEvents.TabIndex = 10;
            this.toolStripEvents.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(122, 74);
            this.toolStripButtonSave.Text = "Grabar";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClose.Image")));
            this.toolStripButtonClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Size = new System.Drawing.Size(103, 74);
            this.toolStripButtonClose.Text = "Cerrar";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // comboBoxTipoMov
            // 
            this.comboBoxTipoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoMov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTipoMov.FormattingEnabled = true;
            this.comboBoxTipoMov.Items.AddRange(new object[] {
            "ENTRADA",
            "SALIDA"});
            this.comboBoxTipoMov.Location = new System.Drawing.Point(119, 34);
            this.comboBoxTipoMov.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTipoMov.Name = "comboBoxTipoMov";
            this.comboBoxTipoMov.Size = new System.Drawing.Size(187, 28);
            this.comboBoxTipoMov.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Motivo Ajuste:";
            // 
            // comboBoxMotivo
            // 
            this.comboBoxMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMotivo.FormattingEnabled = true;
            this.comboBoxMotivo.Location = new System.Drawing.Point(119, 76);
            this.comboBoxMotivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxMotivo.Name = "comboBoxMotivo";
            this.comboBoxMotivo.Size = new System.Drawing.Size(402, 28);
            this.comboBoxMotivo.TabIndex = 10;
            // 
            // Frm_AjusteStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1376, 940);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Frm_AjusteStock";
            this.Text = "Ajuste de Stock";
            this.Load += new System.EventHandler(this.Frm_AjusteStock_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleAjusteStock)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataGridViewDetalleAjusteStock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDeposito;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.DataGridViewButtonColumn Buscador;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn LlevaVto;
        private System.Windows.Forms.ComboBox comboBoxMotivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTipoMov;
    }
}
