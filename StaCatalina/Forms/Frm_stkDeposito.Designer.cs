namespace StaCatalina.Forms
{
    partial class Frm_stkDeposito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_stkDeposito));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxStockNegativo = new System.Windows.Forms.CheckBox();
            this.textBoxDescrip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDepositos = new System.Windows.Forms.DataGridView();
            this.cODEMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPOSITOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKNEGATIVODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource_stkDeposito = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripEvents.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepositos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_stkDeposito)).BeginInit();
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
            this.toolStripEvents.Size = new System.Drawing.Size(648, 50);
            this.toolStripEvents.TabIndex = 10;
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
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(136, 47);
            this.toolStripButtonNew.Text = "Nuevo Ingreso";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxStockNegativo);
            this.groupBox1.Controls.Add(this.textBoxDescrip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 334);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // checkBoxStockNegativo
            // 
            this.checkBoxStockNegativo.AutoSize = true;
            this.checkBoxStockNegativo.Location = new System.Drawing.Point(87, 190);
            this.checkBoxStockNegativo.Name = "checkBoxStockNegativo";
            this.checkBoxStockNegativo.Size = new System.Drawing.Size(100, 17);
            this.checkBoxStockNegativo.TabIndex = 4;
            this.checkBoxStockNegativo.Text = "Stock Negativo";
            this.checkBoxStockNegativo.UseVisualStyleBackColor = true;
            // 
            // textBoxDescrip
            // 
            this.textBoxDescrip.Location = new System.Drawing.Point(12, 128);
            this.textBoxDescrip.Name = "textBoxDescrip";
            this.textBoxDescrip.Size = new System.Drawing.Size(254, 20);
            this.textBoxDescrip.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewDepositos);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(294, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 334);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Depositos";
            // 
            // dataGridViewDepositos
            // 
            this.dataGridViewDepositos.AllowUserToAddRows = false;
            this.dataGridViewDepositos.AllowUserToDeleteRows = false;
            this.dataGridViewDepositos.AutoGenerateColumns = false;
            this.dataGridViewDepositos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDepositos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepositos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODEMPDataGridViewTextBoxColumn,
            this.dEPOSITOIDDataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn,
            this.sTOCKNEGATIVODataGridViewTextBoxColumn});
            this.dataGridViewDepositos.DataSource = this.bindingSource_stkDeposito;
            this.dataGridViewDepositos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDepositos.EnableHeadersVisualStyles = false;
            this.dataGridViewDepositos.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDepositos.MultiSelect = false;
            this.dataGridViewDepositos.Name = "dataGridViewDepositos";
            this.dataGridViewDepositos.ReadOnly = true;
            this.dataGridViewDepositos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewDepositos.Size = new System.Drawing.Size(348, 315);
            this.dataGridViewDepositos.TabIndex = 0;
            this.dataGridViewDepositos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovimientoStock_CellClick);
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
            this.dEPOSITOIDDataGridViewTextBoxColumn.HeaderText = "DEPOSITO_ID";
            this.dEPOSITOIDDataGridViewTextBoxColumn.Name = "dEPOSITOIDDataGridViewTextBoxColumn";
            this.dEPOSITOIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dEPOSITOIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            this.dESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCRIPCIONDataGridViewTextBoxColumn.Width = 150;
            // 
            // sTOCKNEGATIVODataGridViewTextBoxColumn
            // 
            this.sTOCKNEGATIVODataGridViewTextBoxColumn.DataPropertyName = "STOCKNEGATIVO";
            this.sTOCKNEGATIVODataGridViewTextBoxColumn.HeaderText = "Stock Negativo";
            this.sTOCKNEGATIVODataGridViewTextBoxColumn.Name = "sTOCKNEGATIVODataGridViewTextBoxColumn";
            this.sTOCKNEGATIVODataGridViewTextBoxColumn.ReadOnly = true;
            this.sTOCKNEGATIVODataGridViewTextBoxColumn.Width = 150;
            // 
            // bindingSource_stkDeposito
            // 
            this.bindingSource_stkDeposito.DataSource = typeof(Entities.Tables.STKDEPOSITO);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(142, 47);
            this.toolStripLabel1.Text = "                                             ";
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
            // Frm_stkDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(648, 384);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripEvents);
            this.Name = "Frm_stkDeposito";
            this.Text = "A.B.M Depositos";
            this.Load += new System.EventHandler(this.stkInventario_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepositos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_stkDeposito)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewDepositos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODEMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPOSITOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKNEGATIVODataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource_stkDeposito;
        private System.Windows.Forms.CheckBox checkBoxStockNegativo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
    }
}
