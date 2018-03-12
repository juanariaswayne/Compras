namespace StaCatalina.Forms
{
    partial class Frm_stkTipoMov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_stkTipoMov));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNegativo = new System.Windows.Forms.RadioButton();
            this.radioButtonPositivo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDescrip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMovimientoStock = new System.Windows.Forms.DataGridView();
            this.tIPOMOVIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIGNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceMovimientoStock = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripEvents.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovimientoStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMovimientoStock)).BeginInit();
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
            this.toolStripEvents.Location = new System.Drawing.Point(0, 319);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(649, 50);
            this.toolStripEvents.TabIndex = 9;
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
            this.groupBox1.Controls.Add(this.radioButtonNegativo);
            this.groupBox1.Controls.Add(this.radioButtonPositivo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxDescrip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 319);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // radioButtonNegativo
            // 
            this.radioButtonNegativo.AutoSize = true;
            this.radioButtonNegativo.Location = new System.Drawing.Point(173, 196);
            this.radioButtonNegativo.Name = "radioButtonNegativo";
            this.radioButtonNegativo.Size = new System.Drawing.Size(68, 17);
            this.radioButtonNegativo.TabIndex = 4;
            this.radioButtonNegativo.TabStop = true;
            this.radioButtonNegativo.Text = "Negativo";
            this.radioButtonNegativo.UseVisualStyleBackColor = true;
            // 
            // radioButtonPositivo
            // 
            this.radioButtonPositivo.AutoSize = true;
            this.radioButtonPositivo.Location = new System.Drawing.Point(42, 196);
            this.radioButtonPositivo.Name = "radioButtonPositivo";
            this.radioButtonPositivo.Size = new System.Drawing.Size(62, 17);
            this.radioButtonPositivo.TabIndex = 3;
            this.radioButtonPositivo.TabStop = true;
            this.radioButtonPositivo.Text = "Positivo";
            this.radioButtonPositivo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Signo";
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
            this.groupBox2.Controls.Add(this.dataGridViewMovimientoStock);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(295, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 319);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipos de Movimiento Stock";
            // 
            // dataGridViewMovimientoStock
            // 
            this.dataGridViewMovimientoStock.AllowUserToAddRows = false;
            this.dataGridViewMovimientoStock.AllowUserToDeleteRows = false;
            this.dataGridViewMovimientoStock.AutoGenerateColumns = false;
            this.dataGridViewMovimientoStock.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMovimientoStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMovimientoStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovimientoStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIPOMOVIDDataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn,
            this.sIGNODataGridViewTextBoxColumn});
            this.dataGridViewMovimientoStock.DataSource = this.bindingSourceMovimientoStock;
            this.dataGridViewMovimientoStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMovimientoStock.EnableHeadersVisualStyles = false;
            this.dataGridViewMovimientoStock.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewMovimientoStock.MultiSelect = false;
            this.dataGridViewMovimientoStock.Name = "dataGridViewMovimientoStock";
            this.dataGridViewMovimientoStock.ReadOnly = true;
            this.dataGridViewMovimientoStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewMovimientoStock.Size = new System.Drawing.Size(348, 300);
            this.dataGridViewMovimientoStock.TabIndex = 0;
            this.dataGridViewMovimientoStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovimientoStock_CellClick);
            // 
            // tIPOMOVIDDataGridViewTextBoxColumn
            // 
            this.tIPOMOVIDDataGridViewTextBoxColumn.DataPropertyName = "TIPOMOV_ID";
            this.tIPOMOVIDDataGridViewTextBoxColumn.HeaderText = "TIPOMOV_ID";
            this.tIPOMOVIDDataGridViewTextBoxColumn.Name = "tIPOMOVIDDataGridViewTextBoxColumn";
            this.tIPOMOVIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tIPOMOVIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            this.dESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sIGNODataGridViewTextBoxColumn
            // 
            this.sIGNODataGridViewTextBoxColumn.DataPropertyName = "SIGNO";
            this.sIGNODataGridViewTextBoxColumn.HeaderText = "Signo";
            this.sIGNODataGridViewTextBoxColumn.Name = "sIGNODataGridViewTextBoxColumn";
            this.sIGNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceMovimientoStock
            // 
            this.bindingSourceMovimientoStock.DataSource = typeof(Entities.Tables.STKTIPOMOV);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(154, 47);
            this.toolStripLabel1.Text = "                                                 ";
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
            // Frm_stkTipoMov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(649, 369);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripEvents);
            this.Name = "Frm_stkTipoMov";
            this.Text = "A.B.M. Tipo de Movimiento Stock";
            this.Load += new System.EventHandler(this.Frm_stkTipoMov_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovimientoStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMovimientoStock)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewMovimientoStock;
        private System.Windows.Forms.BindingSource bindingSourceMovimientoStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonNegativo;
        private System.Windows.Forms.RadioButton radioButtonPositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOMOVIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIGNODataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
    }
}
