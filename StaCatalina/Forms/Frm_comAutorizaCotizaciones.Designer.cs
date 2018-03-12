namespace StaCatalina.Forms
{
    partial class Frm_comAutorizaCotizaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_comAutorizaCotizaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridRequerimientosCotizados = new System.Windows.Forms.DataGridView();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAutoriza = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCotizaciones = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSubRubro = new System.Windows.Forms.ComboBox();
            this.Autorizar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nrocotizacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articuloidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artdescgenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unimedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.embalajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonsocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechacotizacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRequerimientosCotizados)).BeginInit();
            this.toolStripEvents.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCotizaciones)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridRequerimientosCotizados);
            this.groupBox1.Location = new System.Drawing.Point(0, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1215, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Requerimientos Cotizados";
            // 
            // dataGridRequerimientosCotizados
            // 
            this.dataGridRequerimientosCotizados.AllowUserToAddRows = false;
            this.dataGridRequerimientosCotizados.AllowUserToDeleteRows = false;
            this.dataGridRequerimientosCotizados.AllowUserToOrderColumns = true;
            this.dataGridRequerimientosCotizados.AllowUserToResizeColumns = false;
            this.dataGridRequerimientosCotizados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRequerimientosCotizados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRequerimientosCotizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRequerimientosCotizados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Articulo,
            this.Descripcion});
            this.dataGridRequerimientosCotizados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridRequerimientosCotizados.EnableHeadersVisualStyles = false;
            this.dataGridRequerimientosCotizados.Location = new System.Drawing.Point(3, 16);
            this.dataGridRequerimientosCotizados.MultiSelect = false;
            this.dataGridRequerimientosCotizados.Name = "dataGridRequerimientosCotizados";
            this.dataGridRequerimientosCotizados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridRequerimientosCotizados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRequerimientosCotizados.Size = new System.Drawing.Size(1209, 204);
            this.dataGridRequerimientosCotizados.TabIndex = 1;
            this.dataGridRequerimientosCotizados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRequerimientosCotizados_CellClick);
            // 
            // Articulo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Articulo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Articulo.HeaderText = "Artículo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            // 
            // Descripcion
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 1000;
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAutoriza,
            this.toolStripButtonClose});
            this.toolStripEvents.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripEvents.Location = new System.Drawing.Point(0, 515);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(1218, 50);
            this.toolStripEvents.TabIndex = 13;
            this.toolStripEvents.Text = "toolStrip1";
            // 
            // toolStripButtonAutoriza
            // 
            this.toolStripButtonAutoriza.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAutoriza.Image")));
            this.toolStripButtonAutoriza.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAutoriza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAutoriza.Name = "toolStripButtonAutoriza";
            this.toolStripButtonAutoriza.Size = new System.Drawing.Size(166, 47);
            this.toolStripButtonAutoriza.Text = "Autorizar Cotización";
            this.toolStripButtonAutoriza.Click += new System.EventHandler(this.toolStripButtonAutoriza_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewCotizaciones);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1218, 208);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cotizaciones";
            // 
            // dataGridViewCotizaciones
            // 
            this.dataGridViewCotizaciones.AllowUserToAddRows = false;
            this.dataGridViewCotizaciones.AllowUserToDeleteRows = false;
            this.dataGridViewCotizaciones.AllowUserToOrderColumns = true;
            this.dataGridViewCotizaciones.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCotizaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCotizaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Autorizar,
            this.nrocotizacionDataGridViewTextBoxColumn,
            this.codempDataGridViewTextBoxColumn,
            this.articuloidDataGridViewTextBoxColumn,
            this.artdescgenDataGridViewTextBoxColumn,
            this.unimedDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.embalajeDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.proveedidDataGridViewTextBoxColumn,
            this.razonsocialDataGridViewTextBoxColumn,
            this.fechacotizacionDataGridViewTextBoxColumn,
            this.obsDataGridViewTextBoxColumn});
            this.dataGridViewCotizaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCotizaciones.EnableHeadersVisualStyles = false;
            this.dataGridViewCotizaciones.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewCotizaciones.Name = "dataGridViewCotizaciones";
            this.dataGridViewCotizaciones.Size = new System.Drawing.Size(1212, 189);
            this.dataGridViewCotizaciones.TabIndex = 1;
            this.dataGridViewCotizaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCotizaciones_CellContentClick);
            this.dataGridViewCotizaciones.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewCotizaciones_CurrentCellDirtyStateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cotizaciones para la Empresa:";
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Items.AddRange(new object[] {
            "EGESAC S.A.",
            "RSC S.A."});
            this.comboBoxEmpresa.Location = new System.Drawing.Point(458, 12);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(166, 21);
            this.comboBoxEmpresa.TabIndex = 8;
            this.comboBoxEmpresa.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmpresa_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.comboBoxSubRubro);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboBoxEmpresa);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1218, 72);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Sub Rubro:";
            // 
            // comboBoxSubRubro
            // 
            this.comboBoxSubRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSubRubro.FormattingEnabled = true;
            this.comboBoxSubRubro.Location = new System.Drawing.Point(87, 39);
            this.comboBoxSubRubro.Name = "comboBoxSubRubro";
            this.comboBoxSubRubro.Size = new System.Drawing.Size(418, 21);
            this.comboBoxSubRubro.TabIndex = 21;
            this.comboBoxSubRubro.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubRubro_SelectedIndexChanged);
            // 
            // Autorizar
            // 
            this.Autorizar.HeaderText = "Autorizar";
            this.Autorizar.Name = "Autorizar";
            this.Autorizar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Autorizar.Width = 60;
            // 
            // nrocotizacionDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.nrocotizacionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.nrocotizacionDataGridViewTextBoxColumn.HeaderText = "Nro. Cotizacion";
            this.nrocotizacionDataGridViewTextBoxColumn.Name = "nrocotizacionDataGridViewTextBoxColumn";
            this.nrocotizacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrocotizacionDataGridViewTextBoxColumn.Width = 110;
            // 
            // codempDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codempDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.codempDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.codempDataGridViewTextBoxColumn.Name = "codempDataGridViewTextBoxColumn";
            this.codempDataGridViewTextBoxColumn.ReadOnly = true;
            this.codempDataGridViewTextBoxColumn.Width = 80;
            // 
            // articuloidDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.articuloidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.articuloidDataGridViewTextBoxColumn.HeaderText = "Artículo";
            this.articuloidDataGridViewTextBoxColumn.Name = "articuloidDataGridViewTextBoxColumn";
            this.articuloidDataGridViewTextBoxColumn.ReadOnly = true;
            this.articuloidDataGridViewTextBoxColumn.Visible = false;
            this.articuloidDataGridViewTextBoxColumn.Width = 90;
            // 
            // artdescgenDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.artdescgenDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.artdescgenDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.artdescgenDataGridViewTextBoxColumn.Name = "artdescgenDataGridViewTextBoxColumn";
            this.artdescgenDataGridViewTextBoxColumn.ReadOnly = true;
            this.artdescgenDataGridViewTextBoxColumn.Visible = false;
            this.artdescgenDataGridViewTextBoxColumn.Width = 150;
            // 
            // unimedDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.unimedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.unimedDataGridViewTextBoxColumn.HeaderText = "Uni. Med";
            this.unimedDataGridViewTextBoxColumn.Name = "unimedDataGridViewTextBoxColumn";
            this.unimedDataGridViewTextBoxColumn.ReadOnly = true;
            this.unimedDataGridViewTextBoxColumn.Width = 80;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.NullValue = null;
            this.cantidadDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 80;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.NullValue = null;
            this.precioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 80;
            // 
            // embalajeDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.embalajeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.embalajeDataGridViewTextBoxColumn.HeaderText = "Embalaje";
            this.embalajeDataGridViewTextBoxColumn.Name = "embalajeDataGridViewTextBoxColumn";
            this.embalajeDataGridViewTextBoxColumn.ReadOnly = true;
            this.embalajeDataGridViewTextBoxColumn.Width = 120;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.marcaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaDataGridViewTextBoxColumn.Width = 120;
            // 
            // proveedidDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.proveedidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.proveedidDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedidDataGridViewTextBoxColumn.Name = "proveedidDataGridViewTextBoxColumn";
            this.proveedidDataGridViewTextBoxColumn.ReadOnly = true;
            this.proveedidDataGridViewTextBoxColumn.Width = 90;
            // 
            // razonsocialDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.razonsocialDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.razonsocialDataGridViewTextBoxColumn.HeaderText = "Razón Social";
            this.razonsocialDataGridViewTextBoxColumn.Name = "razonsocialDataGridViewTextBoxColumn";
            this.razonsocialDataGridViewTextBoxColumn.ReadOnly = true;
            this.razonsocialDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechacotizacionDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fechacotizacionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.fechacotizacionDataGridViewTextBoxColumn.HeaderText = "F. Cotización";
            this.fechacotizacionDataGridViewTextBoxColumn.Name = "fechacotizacionDataGridViewTextBoxColumn";
            this.fechacotizacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obsDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.obsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.obsDataGridViewTextBoxColumn.HeaderText = "Obs";
            this.obsDataGridViewTextBoxColumn.Name = "obsDataGridViewTextBoxColumn";
            this.obsDataGridViewTextBoxColumn.ReadOnly = true;
            this.obsDataGridViewTextBoxColumn.Width = 120;
            // 
            // Frm_comAutorizaCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1218, 565);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStripEvents);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_comAutorizaCotizaciones";
            this.Text = "Autorizar Cotizaciones";
            this.Load += new System.EventHandler(this.Frm_comAutorizaCotizaciones_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRequerimientosCotizados)).EndInit();
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCotizaciones)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridRequerimientosCotizados;
        private System.Windows.Forms.DataGridView dataGridViewCotizaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn requerimientoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSubRubro;
        private System.Windows.Forms.ToolStripButton toolStripButtonAutoriza;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Autorizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrocotizacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articuloidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artdescgenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unimedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn embalajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonsocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechacotizacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obsDataGridViewTextBoxColumn;
    }
}
