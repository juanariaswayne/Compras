namespace StaCatalina.Forms
{
    partial class Frm_AutorizaOCSinStock
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AutorizaOCSinStock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.labelImporteOC = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewOCCabSinStock = new System.Windows.Forms.DataGridView();
            this.codEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroOrdenCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoOc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxNoAutoriza = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoriza = new System.Windows.Forms.CheckBox();
            this.dataGridViewOCItemSinStock = new System.Windows.Forms.DataGridView();
            this.codEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripEvents.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOCCabSinStock)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOCItemSinStock)).BeginInit();
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
            this.toolStripEvents.Location = new System.Drawing.Point(0, 539);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(1105, 50);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(468, 555);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Importe Total O.C.:";
            // 
            // labelImporteOC
            // 
            this.labelImporteOC.AutoSize = true;
            this.labelImporteOC.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImporteOC.Location = new System.Drawing.Point(601, 555);
            this.labelImporteOC.Name = "labelImporteOC";
            this.labelImporteOC.Size = new System.Drawing.Size(0, 20);
            this.labelImporteOC.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewOCCabSinStock);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1105, 236);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenes de Compra disponibles";
            // 
            // dataGridViewOCCabSinStock
            // 
            this.dataGridViewOCCabSinStock.AllowUserToAddRows = false;
            this.dataGridViewOCCabSinStock.AllowUserToDeleteRows = false;
            this.dataGridViewOCCabSinStock.AllowUserToResizeColumns = false;
            this.dataGridViewOCCabSinStock.AllowUserToResizeRows = false;
            this.dataGridViewOCCabSinStock.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOCCabSinStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewOCCabSinStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOCCabSinStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEmp,
            this.Empresa,
            this.NroOrdenCompra,
            this.Fecha,
            this.Proveedor,
            this.Observaciones,
            this.Email,
            this.TipoOc});
            this.dataGridViewOCCabSinStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOCCabSinStock.EnableHeadersVisualStyles = false;
            this.dataGridViewOCCabSinStock.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOCCabSinStock.MultiSelect = false;
            this.dataGridViewOCCabSinStock.Name = "dataGridViewOCCabSinStock";
            this.dataGridViewOCCabSinStock.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOCCabSinStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewOCCabSinStock.RowHeadersVisible = false;
            this.dataGridViewOCCabSinStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOCCabSinStock.Size = new System.Drawing.Size(1099, 217);
            this.dataGridViewOCCabSinStock.TabIndex = 1;
            this.dataGridViewOCCabSinStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOCCabSinStock_CellClick);
            // 
            // codEmp
            // 
            this.codEmp.HeaderText = "codEmp";
            this.codEmp.Name = "codEmp";
            this.codEmp.ReadOnly = true;
            this.codEmp.Visible = false;
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            // 
            // NroOrdenCompra
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.NroOrdenCompra.DefaultCellStyle = dataGridViewCellStyle13;
            this.NroOrdenCompra.HeaderText = "Orden Compra";
            this.NroOrdenCompra.Name = "NroOrdenCompra";
            this.NroOrdenCompra.ReadOnly = true;
            this.NroOrdenCompra.Width = 120;
            // 
            // Fecha
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle14;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Proveedor
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Proveedor.DefaultCellStyle = dataGridViewCellStyle15;
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            this.Proveedor.Width = 320;
            // 
            // Observaciones
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Observaciones.DefaultCellStyle = dataGridViewCellStyle16;
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Width = 280;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
            // 
            // TipoOc
            // 
            this.TipoOc.HeaderText = "TipoOc";
            this.TipoOc.Name = "TipoOc";
            this.TipoOc.ReadOnly = true;
            this.TipoOc.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxNoAutoriza);
            this.groupBox2.Controls.Add(this.checkBoxAutoriza);
            this.groupBox2.Controls.Add(this.dataGridViewOCItemSinStock);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1105, 299);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "                                                                            Detal" +
    "le Orden de Compra";
            // 
            // checkBoxNoAutoriza
            // 
            this.checkBoxNoAutoriza.AutoSize = true;
            this.checkBoxNoAutoriza.ForeColor = System.Drawing.Color.Red;
            this.checkBoxNoAutoriza.Location = new System.Drawing.Point(140, -1);
            this.checkBoxNoAutoriza.Name = "checkBoxNoAutoriza";
            this.checkBoxNoAutoriza.Size = new System.Drawing.Size(84, 17);
            this.checkBoxNoAutoriza.TabIndex = 14;
            this.checkBoxNoAutoriza.Text = "No Autorizar";
            this.checkBoxNoAutoriza.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoriza
            // 
            this.checkBoxAutoriza.AutoSize = true;
            this.checkBoxAutoriza.Location = new System.Drawing.Point(67, -1);
            this.checkBoxAutoriza.Name = "checkBoxAutoriza";
            this.checkBoxAutoriza.Size = new System.Drawing.Size(67, 17);
            this.checkBoxAutoriza.TabIndex = 13;
            this.checkBoxAutoriza.Text = "Autorizar";
            this.checkBoxAutoriza.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOCItemSinStock
            // 
            this.dataGridViewOCItemSinStock.AllowUserToAddRows = false;
            this.dataGridViewOCItemSinStock.AllowUserToDeleteRows = false;
            this.dataGridViewOCItemSinStock.AllowUserToResizeColumns = false;
            this.dataGridViewOCItemSinStock.AllowUserToResizeRows = false;
            this.dataGridViewOCItemSinStock.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewOCItemSinStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewOCItemSinStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEmpresa,
            this.NroOrden,
            this.Articulo,
            this.Marca,
            this.Cantidad,
            this.Precio});
            this.dataGridViewOCItemSinStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOCItemSinStock.EnableHeadersVisualStyles = false;
            this.dataGridViewOCItemSinStock.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOCItemSinStock.MultiSelect = false;
            this.dataGridViewOCItemSinStock.Name = "dataGridViewOCItemSinStock";
            this.dataGridViewOCItemSinStock.ReadOnly = true;
            this.dataGridViewOCItemSinStock.RowHeadersVisible = false;
            this.dataGridViewOCItemSinStock.RowTemplate.Height = 40;
            this.dataGridViewOCItemSinStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewOCItemSinStock.Size = new System.Drawing.Size(1099, 280);
            this.dataGridViewOCItemSinStock.TabIndex = 2;
            this.dataGridViewOCItemSinStock.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridViewOCItemSinStock_Scroll);
            this.dataGridViewOCItemSinStock.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridViewOCItemSinStock_Paint);
            // 
            // codEmpresa
            // 
            this.codEmpresa.HeaderText = "codEmpresa";
            this.codEmpresa.Name = "codEmpresa";
            this.codEmpresa.ReadOnly = true;
            this.codEmpresa.Visible = false;
            // 
            // NroOrden
            // 
            this.NroOrden.HeaderText = "NroOrden";
            this.NroOrden.Name = "NroOrden";
            this.NroOrden.ReadOnly = true;
            this.NroOrden.Visible = false;
            // 
            // Articulo
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Articulo.DefaultCellStyle = dataGridViewCellStyle19;
            this.Articulo.HeaderText = "Item";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            this.Articulo.Visible = false;
            this.Articulo.Width = 60;
            // 
            // Marca
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Marca.DefaultCellStyle = dataGridViewCellStyle20;
            this.Marca.HeaderText = "Detalle";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 900;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle21;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle22;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Frm_AutorizaOCSinStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1105, 589);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelImporteOC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStripEvents);
            this.Name = "Frm_AutorizaOCSinStock";
            this.Text = "Auotrizar Orden de Compra Sin Stock";
            this.Load += new System.EventHandler(this.Frm_AutorizaOCSinStock_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOCCabSinStock)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOCItemSinStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelImporteOC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewOCCabSinStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroOrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoOc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxAutoriza;
        private System.Windows.Forms.DataGridView dataGridViewOCItemSinStock;
        private System.Windows.Forms.CheckBox checkBoxNoAutoriza;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}
