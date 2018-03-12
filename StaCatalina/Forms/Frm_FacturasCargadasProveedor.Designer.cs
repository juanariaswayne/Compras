namespace StaCatalina.Forms
{
    partial class Frm_FacturasCargadasProveedor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FacturasCargadasProveedor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewFacturas = new System.Windows.Forms.DataGridView();
            this.VerDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ccoempcodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccosuccodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cconrocuotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccocodpvtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccoletraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccotcocodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cconroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccoimpmonlocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccosaldomonlocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccofemisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccofcontabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccofvtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccocodproDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceFacturas = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxProveed = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.labelMes1 = new System.Windows.Forms.Label();
            this.labelMes2 = new System.Windows.Forms.Label();
            this.labelMes3 = new System.Windows.Forms.Label();
            this.labelImporte1 = new System.Windows.Forms.Label();
            this.labelImporte2 = new System.Windows.Forms.Label();
            this.labelImporte3 = new System.Windows.Forms.Label();
            this.toolStripEvents.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFacturas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonClose});
            this.toolStripEvents.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripEvents.Location = new System.Drawing.Point(0, 462);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(1070, 50);
            this.toolStripEvents.TabIndex = 9;
            this.toolStripEvents.Text = "toolStrip1";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewFacturas);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 462);
            this.panel1.TabIndex = 10;
            // 
            // dataGridViewFacturas
            // 
            this.dataGridViewFacturas.AllowUserToAddRows = false;
            this.dataGridViewFacturas.AllowUserToDeleteRows = false;
            this.dataGridViewFacturas.AutoGenerateColumns = false;
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
            this.VerDetalle,
            this.ccoempcodigoDataGridViewTextBoxColumn,
            this.ccosuccodDataGridViewTextBoxColumn,
            this.ccoidDataGridViewTextBoxColumn,
            this.cconrocuotaDataGridViewTextBoxColumn,
            this.ccocodpvtDataGridViewTextBoxColumn,
            this.ccoletraDataGridViewTextBoxColumn,
            this.ccotcocodDataGridViewTextBoxColumn,
            this.cconroDataGridViewTextBoxColumn,
            this.ccoimpmonlocDataGridViewTextBoxColumn,
            this.ccosaldomonlocDataGridViewTextBoxColumn,
            this.ccofemisionDataGridViewTextBoxColumn,
            this.ccofcontabDataGridViewTextBoxColumn,
            this.ccofvtoDataGridViewTextBoxColumn,
            this.ccocodproDataGridViewTextBoxColumn});
            this.dataGridViewFacturas.DataSource = this.bindingSourceFacturas;
            this.dataGridViewFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFacturas.EnableHeadersVisualStyles = false;
            this.dataGridViewFacturas.Location = new System.Drawing.Point(0, 80);
            this.dataGridViewFacturas.Name = "dataGridViewFacturas";
            this.dataGridViewFacturas.Size = new System.Drawing.Size(1070, 382);
            this.dataGridViewFacturas.TabIndex = 1;
            this.dataGridViewFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFacturas_CellContentClick);
            // 
            // VerDetalle
            // 
            this.VerDetalle.HeaderText = "Ver Detalle";
            this.VerDetalle.Name = "VerDetalle";
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
            // cconrocuotaDataGridViewTextBoxColumn
            // 
            this.cconrocuotaDataGridViewTextBoxColumn.DataPropertyName = "cco_nrocuota";
            this.cconrocuotaDataGridViewTextBoxColumn.HeaderText = "cco_nrocuota";
            this.cconrocuotaDataGridViewTextBoxColumn.Name = "cconrocuotaDataGridViewTextBoxColumn";
            this.cconrocuotaDataGridViewTextBoxColumn.Visible = false;
            // 
            // ccocodpvtDataGridViewTextBoxColumn
            // 
            this.ccocodpvtDataGridViewTextBoxColumn.DataPropertyName = "cco_codpvt";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ccocodpvtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.ccocodpvtDataGridViewTextBoxColumn.HeaderText = "Sucursal";
            this.ccocodpvtDataGridViewTextBoxColumn.Name = "ccocodpvtDataGridViewTextBoxColumn";
            this.ccocodpvtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ccoletraDataGridViewTextBoxColumn
            // 
            this.ccoletraDataGridViewTextBoxColumn.DataPropertyName = "cco_letra";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ccoletraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.ccoletraDataGridViewTextBoxColumn.HeaderText = "Letra";
            this.ccoletraDataGridViewTextBoxColumn.Name = "ccoletraDataGridViewTextBoxColumn";
            this.ccoletraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ccotcocodDataGridViewTextBoxColumn
            // 
            this.ccotcocodDataGridViewTextBoxColumn.DataPropertyName = "ccotco_cod";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ccotcocodDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.ccotcocodDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.ccotcocodDataGridViewTextBoxColumn.Name = "ccotcocodDataGridViewTextBoxColumn";
            this.ccotcocodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cconroDataGridViewTextBoxColumn
            // 
            this.cconroDataGridViewTextBoxColumn.DataPropertyName = "cco_nro";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cconroDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.cconroDataGridViewTextBoxColumn.HeaderText = "Número";
            this.cconroDataGridViewTextBoxColumn.Name = "cconroDataGridViewTextBoxColumn";
            this.cconroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ccoimpmonlocDataGridViewTextBoxColumn
            // 
            this.ccoimpmonlocDataGridViewTextBoxColumn.DataPropertyName = "cco_impmonloc";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.ccoimpmonlocDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.ccoimpmonlocDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.ccoimpmonlocDataGridViewTextBoxColumn.Name = "ccoimpmonlocDataGridViewTextBoxColumn";
            this.ccoimpmonlocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ccosaldomonlocDataGridViewTextBoxColumn
            // 
            this.ccosaldomonlocDataGridViewTextBoxColumn.DataPropertyName = "cco_saldomonloc";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ccosaldomonlocDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.ccosaldomonlocDataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.ccosaldomonlocDataGridViewTextBoxColumn.Name = "ccosaldomonlocDataGridViewTextBoxColumn";
            this.ccosaldomonlocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ccofemisionDataGridViewTextBoxColumn
            // 
            this.ccofemisionDataGridViewTextBoxColumn.DataPropertyName = "cco_femision";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ccofemisionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.ccofemisionDataGridViewTextBoxColumn.HeaderText = "F. Emisióm";
            this.ccofemisionDataGridViewTextBoxColumn.Name = "ccofemisionDataGridViewTextBoxColumn";
            this.ccofemisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ccofcontabDataGridViewTextBoxColumn
            // 
            this.ccofcontabDataGridViewTextBoxColumn.DataPropertyName = "cco_fcontab";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ccofcontabDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.ccofcontabDataGridViewTextBoxColumn.HeaderText = "F. Contab.";
            this.ccofcontabDataGridViewTextBoxColumn.Name = "ccofcontabDataGridViewTextBoxColumn";
            this.ccofcontabDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ccofvtoDataGridViewTextBoxColumn
            // 
            this.ccofvtoDataGridViewTextBoxColumn.DataPropertyName = "cco_fvto";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ccofvtoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.ccofvtoDataGridViewTextBoxColumn.HeaderText = "F. Vto.";
            this.ccofvtoDataGridViewTextBoxColumn.Name = "ccofvtoDataGridViewTextBoxColumn";
            this.ccofvtoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ccocodproDataGridViewTextBoxColumn
            // 
            this.ccocodproDataGridViewTextBoxColumn.DataPropertyName = "cco_codpro";
            this.ccocodproDataGridViewTextBoxColumn.HeaderText = "cco_codpro";
            this.ccocodproDataGridViewTextBoxColumn.Name = "ccocodproDataGridViewTextBoxColumn";
            this.ccocodproDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSourceFacturas
            // 
            this.bindingSourceFacturas.DataSource = typeof(Entities.Procedures.FACTURASCARGADASPROVEEDOR);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerHasta);
            this.groupBox1.Controls.Add(this.dateTimePickerDesde);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxProveed);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxEmpresa);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHasta.Location = new System.Drawing.Point(118, 55);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(108, 20);
            this.dateTimePickerHasta.TabIndex = 2;
            this.dateTimePickerHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerHasta_KeyDown);
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDesde.Location = new System.Drawing.Point(118, 21);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(108, 20);
            this.dateTimePickerDesde.TabIndex = 1;
            this.dateTimePickerDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerDesde_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fecha Contab. Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha Contab. Desde:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "Proveedor:";
            // 
            // comboBoxProveed
            // 
            this.comboBoxProveed.BackColor = System.Drawing.Color.White;
            this.comboBoxProveed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProveed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProveed.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProveed.FormattingEnabled = true;
            this.comboBoxProveed.Location = new System.Drawing.Point(327, 32);
            this.comboBoxProveed.Name = "comboBoxProveed";
            this.comboBoxProveed.Size = new System.Drawing.Size(453, 22);
            this.comboBoxProveed.TabIndex = 3;
            this.comboBoxProveed.SelectedIndexChanged += new System.EventHandler(this.comboBoxProveed_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(785, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Empresa Ingresada:";
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Items.AddRange(new object[] {
            "EGESAC S.A.",
            "RSC S.A."});
            this.comboBoxEmpresa.Location = new System.Drawing.Point(892, 12);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(166, 21);
            this.comboBoxEmpresa.TabIndex = 10;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(482, 469);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(97, 34);
            this.buttonMostrar.TabIndex = 17;
            this.buttonMostrar.Text = "MOSTRAR";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // labelMes1
            // 
            this.labelMes1.AutoSize = true;
            this.labelMes1.Location = new System.Drawing.Point(43, 490);
            this.labelMes1.Name = "labelMes1";
            this.labelMes1.Size = new System.Drawing.Size(0, 13);
            this.labelMes1.TabIndex = 11;
            // 
            // labelMes2
            // 
            this.labelMes2.AutoSize = true;
            this.labelMes2.Location = new System.Drawing.Point(277, 490);
            this.labelMes2.Name = "labelMes2";
            this.labelMes2.Size = new System.Drawing.Size(0, 13);
            this.labelMes2.TabIndex = 12;
            // 
            // labelMes3
            // 
            this.labelMes3.AutoSize = true;
            this.labelMes3.Location = new System.Drawing.Point(509, 490);
            this.labelMes3.Name = "labelMes3";
            this.labelMes3.Size = new System.Drawing.Size(0, 13);
            this.labelMes3.TabIndex = 13;
            // 
            // labelImporte1
            // 
            this.labelImporte1.AutoSize = true;
            this.labelImporte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImporte1.Location = new System.Drawing.Point(119, 490);
            this.labelImporte1.Name = "labelImporte1";
            this.labelImporte1.Size = new System.Drawing.Size(0, 13);
            this.labelImporte1.TabIndex = 14;
            // 
            // labelImporte2
            // 
            this.labelImporte2.AutoSize = true;
            this.labelImporte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImporte2.Location = new System.Drawing.Point(353, 490);
            this.labelImporte2.Name = "labelImporte2";
            this.labelImporte2.Size = new System.Drawing.Size(0, 13);
            this.labelImporte2.TabIndex = 15;
            // 
            // labelImporte3
            // 
            this.labelImporte3.AutoSize = true;
            this.labelImporte3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImporte3.Location = new System.Drawing.Point(585, 490);
            this.labelImporte3.Name = "labelImporte3";
            this.labelImporte3.Size = new System.Drawing.Size(0, 13);
            this.labelImporte3.TabIndex = 16;
            // 
            // Frm_FacturasCargadasProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1070, 512);
            this.ControlBox = false;
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.labelImporte3);
            this.Controls.Add(this.labelImporte2);
            this.Controls.Add(this.labelImporte1);
            this.Controls.Add(this.labelMes3);
            this.Controls.Add(this.labelMes2);
            this.Controls.Add(this.labelMes1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripEvents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_FacturasCargadasProveedor";
            this.Text = "Facturas de Proveedor cargadas en Bejerman";
            this.Load += new System.EventHandler(this.Frm_FacturasCargadasProveedor_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFacturas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProveed;
        private System.Windows.Forms.DataGridView dataGridViewFacturas;
        private System.Windows.Forms.BindingSource bindingSourceFacturas;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn VerDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccoempcodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccosuccodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cconrocuotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccocodpvtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccoletraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccotcocodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cconroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccoimpmonlocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccosaldomonlocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccofemisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccofcontabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccofvtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccocodproDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelMes1;
        private System.Windows.Forms.Label labelMes2;
        private System.Windows.Forms.Label labelMes3;
        private System.Windows.Forms.Label labelImporte1;
        private System.Windows.Forms.Label labelImporte2;
        private System.Windows.Forms.Label labelImporte3;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.Button buttonMostrar;
    }
}
