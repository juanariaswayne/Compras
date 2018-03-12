namespace StaCatalina.Forms
{
    partial class Frm_IngresoStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_IngresoStock));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDetalleIngStock = new System.Windows.Forms.DataGridView();
            this.Buscador = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LlevaVto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxInicial = new System.Windows.Forms.CheckBox();
            this.comboBoxSector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDeposito = new System.Windows.Forms.ComboBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleIngStock)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1332, 940);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewDetalleIngStock);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1332, 863);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // dataGridViewDetalleIngStock
            // 
            this.dataGridViewDetalleIngStock.AllowUserToResizeColumns = false;
            this.dataGridViewDetalleIngStock.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDetalleIngStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDetalleIngStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalleIngStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Buscador,
            this.CodProd,
            this.DescripProd,
            this.UniMed,
            this.Cantidad,
            this.LlevaVto});
            this.dataGridViewDetalleIngStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDetalleIngStock.EnableHeadersVisualStyles = false;
            this.dataGridViewDetalleIngStock.Location = new System.Drawing.Point(4, 106);
            this.dataGridViewDetalleIngStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDetalleIngStock.Name = "dataGridViewDetalleIngStock";
            this.dataGridViewDetalleIngStock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewDetalleIngStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDetalleIngStock.Size = new System.Drawing.Size(1324, 752);
            this.dataGridViewDetalleIngStock.TabIndex = 12;
            this.dataGridViewDetalleIngStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetalleIngStock_CellContentClick);
            this.dataGridViewDetalleIngStock.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetalleIngStock_CellEndEdit);
            this.dataGridViewDetalleIngStock.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewDetalleIngStock_CurrentCellDirtyStateChanged);
            this.dataGridViewDetalleIngStock.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewDetalleIngStock_EditingControlShowing);
            this.dataGridViewDetalleIngStock.SelectionChanged += new System.EventHandler(this.dataGridViewDetalleIngStock_SelectionChanged);
            this.dataGridViewDetalleIngStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewDetalleIngStock_KeyDown);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DescripProd.DefaultCellStyle = dataGridViewCellStyle3;
            this.DescripProd.HeaderText = "Descripción";
            this.DescripProd.Name = "DescripProd";
            this.DescripProd.ReadOnly = true;
            this.DescripProd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DescripProd.Width = 420;
            // 
            // UniMed
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.UniMed.DefaultCellStyle = dataGridViewCellStyle4;
            this.UniMed.HeaderText = "UniMed";
            this.UniMed.Name = "UniMed";
            this.UniMed.ReadOnly = true;
            this.UniMed.Width = 55;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
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
            this.groupBox2.Controls.Add(this.checkBoxInicial);
            this.groupBox2.Controls.Add(this.comboBoxSector);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxDeposito);
            this.groupBox2.Controls.Add(this.buttonNew);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimeFecha);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(4, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1324, 82);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // checkBoxInicial
            // 
            this.checkBoxInicial.AutoSize = true;
            this.checkBoxInicial.Location = new System.Drawing.Point(1049, 37);
            this.checkBoxInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxInicial.Name = "checkBoxInicial";
            this.checkBoxInicial.Size = new System.Drawing.Size(120, 24);
            this.checkBoxInicial.TabIndex = 7;
            this.checkBoxInicial.Text = "Stock Inicial";
            this.checkBoxInicial.UseVisualStyleBackColor = true;
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
            this.label2.Location = new System.Drawing.Point(486, 43);
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
            this.comboBoxDeposito.Location = new System.Drawing.Point(625, 39);
            this.comboBoxDeposito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDeposito.Name = "comboBoxDeposito";
            this.comboBoxDeposito.Size = new System.Drawing.Size(402, 28);
            this.comboBoxDeposito.TabIndex = 3;
            this.comboBoxDeposito.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeposito_SelectedIndexChanged);
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonNew.Location = new System.Drawing.Point(1173, 32);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(141, 35);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "Nuevo Ingreso";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha Ingreso";
            // 
            // dateTimeFecha
            // 
            this.dateTimeFecha.Enabled = false;
            this.dateTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFecha.Location = new System.Drawing.Point(309, 40);
            this.dateTimeFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.Size = new System.Drawing.Size(157, 26);
            this.dateTimeFecha.TabIndex = 0;
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
            this.toolStripEvents.Size = new System.Drawing.Size(1332, 77);
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
            // Frm_IngresoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1332, 940);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Frm_IngresoStock";
            this.Text = "Ingreso de Artículos sin Orden de Compra";
            this.Load += new System.EventHandler(this.Frm_IngresoStock_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleIngStock)).EndInit();
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
        public System.Windows.Forms.DataGridView dataGridViewDetalleIngStock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeFecha;
        private System.Windows.Forms.ComboBox comboBoxSector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDeposito;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.CheckBox checkBoxInicial;
        private System.Windows.Forms.DataGridViewButtonColumn Buscador;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn LlevaVto;
    }
}
