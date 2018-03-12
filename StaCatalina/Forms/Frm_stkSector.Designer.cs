namespace StaCatalina.Forms
{
    partial class Frm_stkSector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_stkSector));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxN_Deposito = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDescrip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewStkSubTIpoMov = new System.Windows.Forms.DataGridView();
            this.bindingSourceStkSector = new System.Windows.Forms.BindingSource(this.components);
            this.cODEMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPOSITOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECTORIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripEvents.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStkSubTIpoMov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStkSector)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripLabel1,
            this.toolStripButtonNew,
            this.toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 334);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(826, 50);
            this.toolStripEvents.TabIndex = 10;
            this.toolStripEvents.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(70, 47);
            this.toolStripButtonSave.Text = "Grabar";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(181, 47);
            this.toolStripLabel1.Text = "                                                          ";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(136, 47);
            this.toolStripButtonNew.Text = "Nuevo Ingreso";
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxN_Deposito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxDescrip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 334);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // comboBoxN_Deposito
            // 
            this.comboBoxN_Deposito.FormattingEnabled = true;
            this.comboBoxN_Deposito.Location = new System.Drawing.Point(77, 50);
            this.comboBoxN_Deposito.Name = "comboBoxN_Deposito";
            this.comboBoxN_Deposito.Size = new System.Drawing.Size(191, 21);
            this.comboBoxN_Deposito.TabIndex = 3;
            this.comboBoxN_Deposito.SelectedIndexChanged += new System.EventHandler(this.comboBoxN_Deposito_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Depósito";
            // 
            // textBoxDescrip
            // 
            this.textBoxDescrip.Location = new System.Drawing.Point(25, 159);
            this.textBoxDescrip.Name = "textBoxDescrip";
            this.textBoxDescrip.Size = new System.Drawing.Size(274, 20);
            this.textBoxDescrip.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción Sector";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewStkSubTIpoMov);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(323, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 334);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sectores";
            // 
            // dataGridViewStkSubTIpoMov
            // 
            this.dataGridViewStkSubTIpoMov.AllowUserToAddRows = false;
            this.dataGridViewStkSubTIpoMov.AllowUserToDeleteRows = false;
            this.dataGridViewStkSubTIpoMov.AutoGenerateColumns = false;
            this.dataGridViewStkSubTIpoMov.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStkSubTIpoMov.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStkSubTIpoMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStkSubTIpoMov.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODEMPDataGridViewTextBoxColumn,
            this.dEPOSITOIDDataGridViewTextBoxColumn,
            this.sECTORIDDataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn});
            this.dataGridViewStkSubTIpoMov.DataSource = this.bindingSourceStkSector;
            this.dataGridViewStkSubTIpoMov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStkSubTIpoMov.EnableHeadersVisualStyles = false;
            this.dataGridViewStkSubTIpoMov.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewStkSubTIpoMov.MultiSelect = false;
            this.dataGridViewStkSubTIpoMov.Name = "dataGridViewStkSubTIpoMov";
            this.dataGridViewStkSubTIpoMov.ReadOnly = true;
            this.dataGridViewStkSubTIpoMov.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewStkSubTIpoMov.Size = new System.Drawing.Size(497, 315);
            this.dataGridViewStkSubTIpoMov.TabIndex = 0;
            this.dataGridViewStkSubTIpoMov.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStkSubTIpoMov_CellClick);
            // 
            // bindingSourceStkSector
            // 
            this.bindingSourceStkSector.DataSource = typeof(Entities.Tables.STKSECTOR);
            // 
            // cODEMPDataGridViewTextBoxColumn
            // 
            this.cODEMPDataGridViewTextBoxColumn.DataPropertyName = "CODEMP";
            this.cODEMPDataGridViewTextBoxColumn.HeaderText = "CODEMP";
            this.cODEMPDataGridViewTextBoxColumn.Name = "cODEMPDataGridViewTextBoxColumn";
            this.cODEMPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODEMPDataGridViewTextBoxColumn.Visible = false;
            // 
            // dEPOSITOIDDataGridViewTextBoxColumn
            // 
            this.dEPOSITOIDDataGridViewTextBoxColumn.DataPropertyName = "DEPOSITO_ID";
            this.dEPOSITOIDDataGridViewTextBoxColumn.HeaderText = "Nº Deposito";
            this.dEPOSITOIDDataGridViewTextBoxColumn.Name = "dEPOSITOIDDataGridViewTextBoxColumn";
            this.dEPOSITOIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dEPOSITOIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sECTORIDDataGridViewTextBoxColumn
            // 
            this.sECTORIDDataGridViewTextBoxColumn.DataPropertyName = "SECTOR_ID";
            this.sECTORIDDataGridViewTextBoxColumn.HeaderText = "SECTOR_ID";
            this.sECTORIDDataGridViewTextBoxColumn.Name = "sECTORIDDataGridViewTextBoxColumn";
            this.sECTORIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sECTORIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            this.dESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCRIPCIONDataGridViewTextBoxColumn.Width = 430;
            // 
            // Frm_stkSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(826, 384);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripEvents);
            this.Name = "Frm_stkSector";
            this.Text = "Sectores por Depósitos";
            this.Load += new System.EventHandler(this.stkSector_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStkSubTIpoMov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStkSector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDescrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewStkSubTIpoMov;
        private System.Windows.Forms.BindingSource bindingSourceStkSector;
        private System.Windows.Forms.ComboBox comboBoxN_Deposito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODEMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPOSITOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECTORIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
    }
}
