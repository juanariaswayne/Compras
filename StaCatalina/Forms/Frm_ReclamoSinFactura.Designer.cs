namespace StaCatalina.Forms
{
    partial class Frm_ReclamoSinFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ReclamoSinFactura));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewHistorial = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCOEMPCODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCOCODPRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCOPRORAZSOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCONRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCOFEMISIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCOIMPMONLOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHARECLAMODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNBEJERMANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceHistorial = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.dateTimeFechaFactrua = new System.Windows.Forms.DateTimePicker();
            this.textBoxImporte = new System.Windows.Forms.TextBox();
            this.textBoxNro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRazonSocial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripEvents.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHistorial)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 365);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(872, 50);
            this.toolStripEvents.TabIndex = 8;
            this.toolStripEvents.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(101, 47);
            this.toolStripButtonSave.Text = "Guardar";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 365);
            this.panel1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewHistorial);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial Reclamo";
            // 
            // dataGridViewHistorial
            // 
            this.dataGridViewHistorial.AllowUserToAddRows = false;
            this.dataGridViewHistorial.AllowUserToDeleteRows = false;
            this.dataGridViewHistorial.AutoGenerateColumns = false;
            this.dataGridViewHistorial.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.cCOEMPCODIGODataGridViewTextBoxColumn,
            this.cCOCODPRODataGridViewTextBoxColumn,
            this.cCOPRORAZSOCDataGridViewTextBoxColumn,
            this.cCONRODataGridViewTextBoxColumn,
            this.cCOFEMISIONDataGridViewTextBoxColumn,
            this.cCOIMPMONLOCDataGridViewTextBoxColumn,
            this.fECHARECLAMODataGridViewTextBoxColumn,
            this.uSUARIODataGridViewTextBoxColumn,
            this.eNBEJERMANDataGridViewTextBoxColumn,
            this.oBSDataGridViewTextBoxColumn});
            this.dataGridViewHistorial.DataSource = this.bindingSourceHistorial;
            this.dataGridViewHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHistorial.EnableHeadersVisualStyles = false;
            this.dataGridViewHistorial.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewHistorial.Name = "dataGridViewHistorial";
            this.dataGridViewHistorial.Size = new System.Drawing.Size(866, 154);
            this.dataGridViewHistorial.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cCOEMPCODIGODataGridViewTextBoxColumn
            // 
            this.cCOEMPCODIGODataGridViewTextBoxColumn.DataPropertyName = "CCOEMP_CODIGO";
            this.cCOEMPCODIGODataGridViewTextBoxColumn.HeaderText = "CCOEMP_CODIGO";
            this.cCOEMPCODIGODataGridViewTextBoxColumn.Name = "cCOEMPCODIGODataGridViewTextBoxColumn";
            this.cCOEMPCODIGODataGridViewTextBoxColumn.Visible = false;
            // 
            // cCOCODPRODataGridViewTextBoxColumn
            // 
            this.cCOCODPRODataGridViewTextBoxColumn.DataPropertyName = "CCO_CODPRO";
            this.cCOCODPRODataGridViewTextBoxColumn.HeaderText = "CCO_CODPRO";
            this.cCOCODPRODataGridViewTextBoxColumn.Name = "cCOCODPRODataGridViewTextBoxColumn";
            this.cCOCODPRODataGridViewTextBoxColumn.Visible = false;
            // 
            // cCOPRORAZSOCDataGridViewTextBoxColumn
            // 
            this.cCOPRORAZSOCDataGridViewTextBoxColumn.DataPropertyName = "CCOPRO_RAZSOC";
            this.cCOPRORAZSOCDataGridViewTextBoxColumn.HeaderText = "CCOPRO_RAZSOC";
            this.cCOPRORAZSOCDataGridViewTextBoxColumn.Name = "cCOPRORAZSOCDataGridViewTextBoxColumn";
            this.cCOPRORAZSOCDataGridViewTextBoxColumn.Visible = false;
            // 
            // cCONRODataGridViewTextBoxColumn
            // 
            this.cCONRODataGridViewTextBoxColumn.DataPropertyName = "CCO_NRO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cCONRODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.cCONRODataGridViewTextBoxColumn.HeaderText = "Nro. Facctura";
            this.cCONRODataGridViewTextBoxColumn.Name = "cCONRODataGridViewTextBoxColumn";
            this.cCONRODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cCOFEMISIONDataGridViewTextBoxColumn
            // 
            this.cCOFEMISIONDataGridViewTextBoxColumn.DataPropertyName = "CCO_FEMISION";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.cCOFEMISIONDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.cCOFEMISIONDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.cCOFEMISIONDataGridViewTextBoxColumn.Name = "cCOFEMISIONDataGridViewTextBoxColumn";
            this.cCOFEMISIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cCOIMPMONLOCDataGridViewTextBoxColumn
            // 
            this.cCOIMPMONLOCDataGridViewTextBoxColumn.DataPropertyName = "CCO_IMPMONLOC";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.cCOIMPMONLOCDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.cCOIMPMONLOCDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.cCOIMPMONLOCDataGridViewTextBoxColumn.Name = "cCOIMPMONLOCDataGridViewTextBoxColumn";
            this.cCOIMPMONLOCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHARECLAMODataGridViewTextBoxColumn
            // 
            this.fECHARECLAMODataGridViewTextBoxColumn.DataPropertyName = "FECHARECLAMO";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.fECHARECLAMODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.fECHARECLAMODataGridViewTextBoxColumn.HeaderText = "F. Reclamo";
            this.fECHARECLAMODataGridViewTextBoxColumn.Name = "fECHARECLAMODataGridViewTextBoxColumn";
            this.fECHARECLAMODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uSUARIODataGridViewTextBoxColumn
            // 
            this.uSUARIODataGridViewTextBoxColumn.DataPropertyName = "USUARIO";
            this.uSUARIODataGridViewTextBoxColumn.HeaderText = "USUARIO";
            this.uSUARIODataGridViewTextBoxColumn.Name = "uSUARIODataGridViewTextBoxColumn";
            this.uSUARIODataGridViewTextBoxColumn.Visible = false;
            // 
            // eNBEJERMANDataGridViewTextBoxColumn
            // 
            this.eNBEJERMANDataGridViewTextBoxColumn.DataPropertyName = "ENBEJERMAN";
            this.eNBEJERMANDataGridViewTextBoxColumn.HeaderText = "ENBEJERMAN";
            this.eNBEJERMANDataGridViewTextBoxColumn.Name = "eNBEJERMANDataGridViewTextBoxColumn";
            this.eNBEJERMANDataGridViewTextBoxColumn.Visible = false;
            // 
            // oBSDataGridViewTextBoxColumn
            // 
            this.oBSDataGridViewTextBoxColumn.DataPropertyName = "OBS";
            this.oBSDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.oBSDataGridViewTextBoxColumn.Name = "oBSDataGridViewTextBoxColumn";
            this.oBSDataGridViewTextBoxColumn.ReadOnly = true;
            this.oBSDataGridViewTextBoxColumn.Width = 400;
            // 
            // bindingSourceHistorial
            // 
            this.bindingSourceHistorial.DataSource = typeof(Entities.Tables.RECLAMOFACTURASINCARGAR);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxObs);
            this.groupBox1.Controls.Add(this.dateTimeFechaFactrua);
            this.groupBox1.Controls.Add(this.textBoxImporte);
            this.groupBox1.Controls.Add(this.textBoxNro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelRazonSocial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Reclamo";
            // 
            // textBoxObs
            // 
            this.textBoxObs.Location = new System.Drawing.Point(137, 124);
            this.textBoxObs.Multiline = true;
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.Size = new System.Drawing.Size(723, 62);
            this.textBoxObs.TabIndex = 9;
            // 
            // dateTimeFechaFactrua
            // 
            this.dateTimeFechaFactrua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaFactrua.Location = new System.Drawing.Point(137, 98);
            this.dateTimeFechaFactrua.Name = "dateTimeFechaFactrua";
            this.dateTimeFechaFactrua.Size = new System.Drawing.Size(100, 20);
            this.dateTimeFechaFactrua.TabIndex = 8;
            this.dateTimeFechaFactrua.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimeFechaFactrua_KeyDown);
            // 
            // textBoxImporte
            // 
            this.textBoxImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxImporte.Location = new System.Drawing.Point(137, 70);
            this.textBoxImporte.Name = "textBoxImporte";
            this.textBoxImporte.Size = new System.Drawing.Size(100, 20);
            this.textBoxImporte.TabIndex = 7;
            this.textBoxImporte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxImporte_KeyDown);
            this.textBoxImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxImporte_KeyPress);
            // 
            // textBoxNro
            // 
            this.textBoxNro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNro.Location = new System.Drawing.Point(137, 42);
            this.textBoxNro.Name = "textBoxNro";
            this.textBoxNro.Size = new System.Drawing.Size(100, 20);
            this.textBoxNro.TabIndex = 6;
            this.textBoxNro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNro_KeyDown);
            this.textBoxNro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNro_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Obs:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha Factura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Importe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nro. Factura:";
            // 
            // labelRazonSocial
            // 
            this.labelRazonSocial.AutoSize = true;
            this.labelRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRazonSocial.Location = new System.Drawing.Point(137, 22);
            this.labelRazonSocial.Name = "labelRazonSocial";
            this.labelRazonSocial.Size = new System.Drawing.Size(0, 13);
            this.labelRazonSocial.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.toolStripButtonClose.ToolTipText = "Cerrar";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // Frm_ReclamoSinFactura
            // 
            this.ClientSize = new System.Drawing.Size(872, 415);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripEvents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ReclamoSinFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reclamos de Facturas que no están cargadas ";
            this.Load += new System.EventHandler(this.Frm_ReclamoSinFactura_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHistorial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxObs;
        private System.Windows.Forms.DateTimePicker dateTimeFechaFactrua;
        private System.Windows.Forms.TextBox textBoxImporte;
        private System.Windows.Forms.TextBox textBoxNro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRazonSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridViewHistorial;
        private System.Windows.Forms.BindingSource bindingSourceHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCOEMPCODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCOCODPRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCOPRORAZSOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCONRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCOFEMISIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCOIMPMONLOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHARECLAMODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNBEJERMANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
    }
}
