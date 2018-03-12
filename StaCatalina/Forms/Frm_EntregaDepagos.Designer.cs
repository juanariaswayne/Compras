namespace StaCatalina.Forms
{
    partial class Frm_EntregaDepagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EntregaDepagos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewRetiro = new System.Windows.Forms.DataGridView();
            this.ccoempcodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccosuccodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccocodproDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccoprorazsocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cconroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccofemisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccoimpmonlocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retirado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSourcePagos = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStripEvents.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRetiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePagos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStripEvents);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 516);
            this.panel1.TabIndex = 10;
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripLabel1,
            this.toolStripButtonPrint,
            this.toolStripButtonClose});
            this.toolStripEvents.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripEvents.Location = new System.Drawing.Point(0, 466);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(906, 50);
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
            this.toolStripButtonSave.Size = new System.Drawing.Size(97, 47);
            this.toolStripButtonSave.Text = "Grabar";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButtonPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrint.Image")));
            this.toolStripButtonPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(108, 47);
            this.toolStripButtonPrint.Text = "Imprimir";
            this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewRetiro);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 463);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagos disponibles";
            // 
            // dataGridViewRetiro
            // 
            this.dataGridViewRetiro.AllowUserToAddRows = false;
            this.dataGridViewRetiro.AllowUserToDeleteRows = false;
            this.dataGridViewRetiro.AutoGenerateColumns = false;
            this.dataGridViewRetiro.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRetiro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRetiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRetiro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccoempcodigoDataGridViewTextBoxColumn,
            this.ccosuccodDataGridViewTextBoxColumn,
            this.ccoidDataGridViewTextBoxColumn,
            this.ccocodproDataGridViewTextBoxColumn,
            this.ccoprorazsocDataGridViewTextBoxColumn,
            this.cconroDataGridViewTextBoxColumn,
            this.ccofemisionDataGridViewTextBoxColumn,
            this.ccoimpmonlocDataGridViewTextBoxColumn,
            this.Retirado});
            this.dataGridViewRetiro.DataSource = this.bindingSourcePagos;
            this.dataGridViewRetiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRetiro.EnableHeadersVisualStyles = false;
            this.dataGridViewRetiro.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewRetiro.Name = "dataGridViewRetiro";
            this.dataGridViewRetiro.RowHeadersVisible = false;
            this.dataGridViewRetiro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewRetiro.Size = new System.Drawing.Size(900, 444);
            this.dataGridViewRetiro.TabIndex = 0;
            this.dataGridViewRetiro.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            // 
            // ccoempcodigoDataGridViewTextBoxColumn
            // 
            this.ccoempcodigoDataGridViewTextBoxColumn.DataPropertyName = "ccoemp_codigo";
            this.ccoempcodigoDataGridViewTextBoxColumn.HeaderText = "ccoemp_codigo";
            this.ccoempcodigoDataGridViewTextBoxColumn.Name = "ccoempcodigoDataGridViewTextBoxColumn";
            this.ccoempcodigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // ccosuccodDataGridViewTextBoxColumn
            // 
            this.ccosuccodDataGridViewTextBoxColumn.DataPropertyName = "ccosuc_cod";
            this.ccosuccodDataGridViewTextBoxColumn.HeaderText = "ccosuc_cod";
            this.ccosuccodDataGridViewTextBoxColumn.Name = "ccosuccodDataGridViewTextBoxColumn";
            this.ccosuccodDataGridViewTextBoxColumn.Visible = false;
            // 
            // ccoidDataGridViewTextBoxColumn
            // 
            this.ccoidDataGridViewTextBoxColumn.DataPropertyName = "cco_id";
            this.ccoidDataGridViewTextBoxColumn.HeaderText = "cco_id";
            this.ccoidDataGridViewTextBoxColumn.Name = "ccoidDataGridViewTextBoxColumn";
            this.ccoidDataGridViewTextBoxColumn.Visible = false;
            // 
            // ccocodproDataGridViewTextBoxColumn
            // 
            this.ccocodproDataGridViewTextBoxColumn.DataPropertyName = "cco_codpro";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ccocodproDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.ccocodproDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.ccocodproDataGridViewTextBoxColumn.Name = "ccocodproDataGridViewTextBoxColumn";
            // 
            // ccoprorazsocDataGridViewTextBoxColumn
            // 
            this.ccoprorazsocDataGridViewTextBoxColumn.DataPropertyName = "ccopro_razsoc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ccoprorazsocDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.ccoprorazsocDataGridViewTextBoxColumn.HeaderText = "Razón Social";
            this.ccoprorazsocDataGridViewTextBoxColumn.Name = "ccoprorazsocDataGridViewTextBoxColumn";
            this.ccoprorazsocDataGridViewTextBoxColumn.Width = 300;
            // 
            // cconroDataGridViewTextBoxColumn
            // 
            this.cconroDataGridViewTextBoxColumn.DataPropertyName = "cco_nro";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cconroDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.cconroDataGridViewTextBoxColumn.HeaderText = "Orden Pago";
            this.cconroDataGridViewTextBoxColumn.Name = "cconroDataGridViewTextBoxColumn";
            // 
            // ccofemisionDataGridViewTextBoxColumn
            // 
            this.ccofemisionDataGridViewTextBoxColumn.DataPropertyName = "cco_femision";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ccofemisionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.ccofemisionDataGridViewTextBoxColumn.HeaderText = "Fecha O. Pago";
            this.ccofemisionDataGridViewTextBoxColumn.Name = "ccofemisionDataGridViewTextBoxColumn";
            this.ccofemisionDataGridViewTextBoxColumn.Width = 105;
            // 
            // ccoimpmonlocDataGridViewTextBoxColumn
            // 
            this.ccoimpmonlocDataGridViewTextBoxColumn.DataPropertyName = "cco_impmonloc";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ccoimpmonlocDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.ccoimpmonlocDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.ccoimpmonlocDataGridViewTextBoxColumn.Name = "ccoimpmonlocDataGridViewTextBoxColumn";
            // 
            // Retirado
            // 
            this.Retirado.HeaderText = "Retirado";
            this.Retirado.Name = "Retirado";
            this.Retirado.Width = 70;
            // 
            // bindingSourcePagos
            // 
            this.bindingSourcePagos.DataSource = typeof(Entities.Procedures.PAGOSARETIRARPROVEEDORES);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(109, 47);
            this.toolStripLabel1.Text = "                                  ";
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
            // Frm_EntregaDepagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(906, 516);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_EntregaDepagos";
            this.Text = "Entrega de Pagos a Proveedores";
            this.Load += new System.EventHandler(this.FrmEntregaDepagos_Load);
            this.panel1.ResumeLayout(false);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRetiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewRetiro;
        private System.Windows.Forms.BindingSource bindingSourcePagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccoempcodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccosuccodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccocodproDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccoprorazsocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cconroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccofemisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccoimpmonlocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Retirado;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
    }
}
