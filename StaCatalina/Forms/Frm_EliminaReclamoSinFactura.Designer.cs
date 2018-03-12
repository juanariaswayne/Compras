namespace StaCatalina.Forms
{
    partial class Frm_EliminaReclamoSinFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EliminaReclamoSinFactura));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewEliminaReclamos = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.bindingSourceReclamo = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEliminaReclamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceReclamo)).BeginInit();
            this.toolStripEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewEliminaReclamos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 422);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewEliminaReclamos
            // 
            this.dataGridViewEliminaReclamos.AllowUserToAddRows = false;
            this.dataGridViewEliminaReclamos.AllowUserToDeleteRows = false;
            this.dataGridViewEliminaReclamos.AllowUserToOrderColumns = true;
            this.dataGridViewEliminaReclamos.AutoGenerateColumns = false;
            this.dataGridViewEliminaReclamos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEliminaReclamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEliminaReclamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEliminaReclamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.Eliminar,
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
            this.dataGridViewEliminaReclamos.DataSource = this.bindingSourceReclamo;
            this.dataGridViewEliminaReclamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEliminaReclamos.EnableHeadersVisualStyles = false;
            this.dataGridViewEliminaReclamos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEliminaReclamos.Name = "dataGridViewEliminaReclamos";
            this.dataGridViewEliminaReclamos.Size = new System.Drawing.Size(1060, 422);
            this.dataGridViewEliminaReclamos.TabIndex = 0;
            this.dataGridViewEliminaReclamos.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewEliminaReclamos_CurrentCellDirtyStateChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 60;
            // 
            // cCOEMPCODIGODataGridViewTextBoxColumn
            // 
            this.cCOEMPCODIGODataGridViewTextBoxColumn.DataPropertyName = "CCOEMP_CODIGO";
            this.cCOEMPCODIGODataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.cCOEMPCODIGODataGridViewTextBoxColumn.Name = "cCOEMPCODIGODataGridViewTextBoxColumn";
            this.cCOEMPCODIGODataGridViewTextBoxColumn.Width = 70;
            // 
            // cCOCODPRODataGridViewTextBoxColumn
            // 
            this.cCOCODPRODataGridViewTextBoxColumn.DataPropertyName = "CCO_CODPRO";
            this.cCOCODPRODataGridViewTextBoxColumn.HeaderText = "Proveed";
            this.cCOCODPRODataGridViewTextBoxColumn.Name = "cCOCODPRODataGridViewTextBoxColumn";
            this.cCOCODPRODataGridViewTextBoxColumn.Width = 70;
            // 
            // cCOPRORAZSOCDataGridViewTextBoxColumn
            // 
            this.cCOPRORAZSOCDataGridViewTextBoxColumn.DataPropertyName = "CCOPRO_RAZSOC";
            this.cCOPRORAZSOCDataGridViewTextBoxColumn.HeaderText = "Razon Social";
            this.cCOPRORAZSOCDataGridViewTextBoxColumn.Name = "cCOPRORAZSOCDataGridViewTextBoxColumn";
            this.cCOPRORAZSOCDataGridViewTextBoxColumn.Width = 250;
            // 
            // cCONRODataGridViewTextBoxColumn
            // 
            this.cCONRODataGridViewTextBoxColumn.DataPropertyName = "CCO_NRO";
            this.cCONRODataGridViewTextBoxColumn.HeaderText = "Nro. Fact";
            this.cCONRODataGridViewTextBoxColumn.Name = "cCONRODataGridViewTextBoxColumn";
            this.cCONRODataGridViewTextBoxColumn.Width = 80;
            // 
            // cCOFEMISIONDataGridViewTextBoxColumn
            // 
            this.cCOFEMISIONDataGridViewTextBoxColumn.DataPropertyName = "CCO_FEMISION";
            this.cCOFEMISIONDataGridViewTextBoxColumn.HeaderText = "CCO_FEMISION";
            this.cCOFEMISIONDataGridViewTextBoxColumn.Name = "cCOFEMISIONDataGridViewTextBoxColumn";
            this.cCOFEMISIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // cCOIMPMONLOCDataGridViewTextBoxColumn
            // 
            this.cCOIMPMONLOCDataGridViewTextBoxColumn.DataPropertyName = "CCO_IMPMONLOC";
            this.cCOIMPMONLOCDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.cCOIMPMONLOCDataGridViewTextBoxColumn.Name = "cCOIMPMONLOCDataGridViewTextBoxColumn";
            this.cCOIMPMONLOCDataGridViewTextBoxColumn.Width = 80;
            // 
            // fECHARECLAMODataGridViewTextBoxColumn
            // 
            this.fECHARECLAMODataGridViewTextBoxColumn.DataPropertyName = "FECHARECLAMO";
            this.fECHARECLAMODataGridViewTextBoxColumn.HeaderText = "F.Reclamo";
            this.fECHARECLAMODataGridViewTextBoxColumn.Name = "fECHARECLAMODataGridViewTextBoxColumn";
            this.fECHARECLAMODataGridViewTextBoxColumn.Width = 80;
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
            this.oBSDataGridViewTextBoxColumn.Width = 300;
            // 
            // bindingSourceReclamo
            // 
            this.bindingSourceReclamo.DataSource = typeof(Entities.Tables.RECLAMOFACTURASINCARGAR);
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonClose});
            this.toolStripEvents.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripEvents.Location = new System.Drawing.Point(0, 423);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(1060, 50);
            this.toolStripEvents.TabIndex = 11;
            this.toolStripEvents.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(103, 47);
            this.toolStripButtonSave.Text = "Eliminar";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
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
            // Frm_EliminaReclamoSinFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1060, 473);
            this.ControlBox = false;
            this.Controls.Add(this.toolStripEvents);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_EliminaReclamoSinFactura";
            this.Text = "Elimina Raclamos de Facturas Sin Cargar";
            this.Load += new System.EventHandler(this.Frm_EliminaReclamoSinFactura_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEliminaReclamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceReclamo)).EndInit();
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewEliminaReclamos;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
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
        private System.Windows.Forms.BindingSource bindingSourceReclamo;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
    }
}
