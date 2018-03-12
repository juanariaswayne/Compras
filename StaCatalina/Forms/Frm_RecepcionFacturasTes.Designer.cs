namespace StaCatalina.Forms
{
    partial class Frm_RecepcionFacturasTes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RecepcionFacturasTes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewFacturas = new System.Windows.Forms.DataGridView();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.dateTimefechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimefechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTraeFacturas = new System.Windows.Forms.Button();
            this.checkBoxSeleccion = new System.Windows.Forms.CheckBox();
            this.recibido = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FContable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturas)).BeginInit();
            this.toolStripEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewFacturas);
            this.groupBox1.Location = new System.Drawing.Point(0, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1121, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facturas enviadas";
            // 
            // dataGridViewFacturas
            // 
            this.dataGridViewFacturas.AllowUserToAddRows = false;
            this.dataGridViewFacturas.AllowUserToDeleteRows = false;
            this.dataGridViewFacturas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recibido,
            this.comprobante,
            this.PVenta,
            this.tipo,
            this.codigo,
            this.razonSocial,
            this.importe,
            this.FContable});
            this.dataGridViewFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFacturas.EnableHeadersVisualStyles = false;
            this.dataGridViewFacturas.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewFacturas.Name = "dataGridViewFacturas";
            this.dataGridViewFacturas.Size = new System.Drawing.Size(1115, 391);
            this.dataGridViewFacturas.TabIndex = 0;
            this.dataGridViewFacturas.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewFacturas_CurrentCellDirtyStateChanged);
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 456);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(1121, 50);
            this.toolStripEvents.TabIndex = 11;
            this.toolStripEvents.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(94, 47);
            this.toolStripButtonSave.Text = "Grabar";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // dateTimefechaDesde
            // 
            this.dateTimefechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimefechaDesde.Location = new System.Drawing.Point(140, 13);
            this.dateTimefechaDesde.Name = "dateTimefechaDesde";
            this.dateTimefechaDesde.Size = new System.Drawing.Size(99, 20);
            this.dateTimefechaDesde.TabIndex = 12;
            // 
            // dateTimefechaHasta
            // 
            this.dateTimefechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimefechaHasta.Location = new System.Drawing.Point(338, 13);
            this.dateTimefechaHasta.Name = "dateTimefechaHasta";
            this.dateTimefechaHasta.Size = new System.Drawing.Size(99, 20);
            this.dateTimefechaHasta.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha Hasta";
            // 
            // buttonTraeFacturas
            // 
            this.buttonTraeFacturas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonTraeFacturas.Location = new System.Drawing.Point(464, 12);
            this.buttonTraeFacturas.Name = "buttonTraeFacturas";
            this.buttonTraeFacturas.Size = new System.Drawing.Size(103, 23);
            this.buttonTraeFacturas.TabIndex = 16;
            this.buttonTraeFacturas.Text = "Traer Facturas";
            this.buttonTraeFacturas.UseVisualStyleBackColor = false;
            this.buttonTraeFacturas.Click += new System.EventHandler(this.buttonTraeFacturas_Click);
            // 
            // checkBoxSeleccion
            // 
            this.checkBoxSeleccion.AutoSize = true;
            this.checkBoxSeleccion.Location = new System.Drawing.Point(596, 16);
            this.checkBoxSeleccion.Name = "checkBoxSeleccion";
            this.checkBoxSeleccion.Size = new System.Drawing.Size(115, 17);
            this.checkBoxSeleccion.TabIndex = 17;
            this.checkBoxSeleccion.Text = "Seleccionar Todas";
            this.checkBoxSeleccion.UseVisualStyleBackColor = true;
            this.checkBoxSeleccion.CheckedChanged += new System.EventHandler(this.checkBoxSeleccion_CheckedChanged);
            // 
            // recibido
            // 
            this.recibido.HeaderText = "Recibido";
            this.recibido.Name = "recibido";
            this.recibido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.recibido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // comprobante
            // 
            this.comprobante.FillWeight = 10.62812F;
            this.comprobante.HeaderText = "Comprobante";
            this.comprobante.Name = "comprobante";
            this.comprobante.ReadOnly = true;
            // 
            // PVenta
            // 
            this.PVenta.FillWeight = 10.62812F;
            this.PVenta.HeaderText = "P. Venta";
            this.PVenta.Name = "PVenta";
            this.PVenta.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.FillWeight = 5.314062F;
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 80;
            // 
            // codigo
            // 
            this.codigo.FillWeight = 183.6539F;
            this.codigo.HeaderText = "Proveed.";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // razonSocial
            // 
            this.razonSocial.FillWeight = 26.57031F;
            this.razonSocial.HeaderText = "Razon Social";
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            this.razonSocial.Width = 350;
            // 
            // importe
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.importe.DefaultCellStyle = dataGridViewCellStyle2;
            this.importe.FillWeight = 10.62812F;
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            // 
            // FContable
            // 
            this.FContable.HeaderText = "F. Contabilidad";
            this.FContable.Name = "FContable";
            this.FContable.Width = 110;
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClose.Image")));
            this.toolStripButtonClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Size = new System.Drawing.Size(83, 47);
            this.toolStripButtonClose.Text = "Cerrar";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // Frm_RecepcionFacturasTes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 506);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxSeleccion);
            this.Controls.Add(this.buttonTraeFacturas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimefechaHasta);
            this.Controls.Add(this.dateTimefechaDesde);
            this.Controls.Add(this.toolStripEvents);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_RecepcionFacturasTes";
            this.Text = "Recepción de Facturas Tesoreria";
            this.Load += new System.EventHandler(this.Frm_RecepcionFacturasTes_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturas)).EndInit();
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewFacturas;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.DateTimePicker dateTimefechaDesde;
        private System.Windows.Forms.DateTimePicker dateTimefechaHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTraeFacturas;
        private System.Windows.Forms.CheckBox checkBoxSeleccion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn recibido;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn FContable;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
    }
}