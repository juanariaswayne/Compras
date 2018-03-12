namespace StaCatalina.Forms
{
    partial class Frm_ModificacionOC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ModificacionOC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewOCItems = new System.Windows.Forms.DataGridView();
            this.Buscador = new System.Windows.Forms.DataGridViewButtonColumn();
            this.codigoEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOrdenCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxOC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxdiaria = new System.Windows.Forms.CheckBox();
            this.labelEntrega = new System.Windows.Forms.Label();
            this.comboBoxLugarEntrega = new System.Windows.Forms.ComboBox();
            this.comboBoxProveed = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewOCCab = new System.Windows.Forms.DataGridView();
            this.codEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioAutoriza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroOrdenCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectorEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoNoPrevisto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOCItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOCCab)).BeginInit();
            this.toolStripEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 588);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewOCItems);
            this.groupBox2.Location = new System.Drawing.Point(0, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1039, 244);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Para Eliminar un renglón utilice la tecla DELETE";
            // 
            // dataGridViewOCItems
            // 
            this.dataGridViewOCItems.AllowUserToOrderColumns = true;
            this.dataGridViewOCItems.AllowUserToResizeColumns = false;
            this.dataGridViewOCItems.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOCItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOCItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOCItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Buscador,
            this.codigoEmp,
            this.numOrdenCompra,
            this.nroItem,
            this.CodProd,
            this.DescripProd,
            this.UniMed,
            this.Precio,
            this.Cantidad});
            this.dataGridViewOCItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOCItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewOCItems.EnableHeadersVisualStyles = false;
            this.dataGridViewOCItems.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOCItems.MultiSelect = false;
            this.dataGridViewOCItems.Name = "dataGridViewOCItems";
            this.dataGridViewOCItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOCItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOCItems.Size = new System.Drawing.Size(1033, 225);
            this.dataGridViewOCItems.TabIndex = 13;
            this.dataGridViewOCItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOCItems_CellContentClick);
            this.dataGridViewOCItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOCItems_CellEndEdit);
            this.dataGridViewOCItems.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewOCItems_CurrentCellDirtyStateChanged);
            this.dataGridViewOCItems.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewOCItems_EditingControlShowing);
            this.dataGridViewOCItems.SelectionChanged += new System.EventHandler(this.dataGridViewOCItems_SelectionChanged);
            this.dataGridViewOCItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewOCItems_KeyDown);
            // 
            // Buscador
            // 
            this.Buscador.HeaderText = "";
            this.Buscador.Name = "Buscador";
            this.Buscador.Width = 50;
            // 
            // codigoEmp
            // 
            this.codigoEmp.HeaderText = "codEmp";
            this.codigoEmp.Name = "codigoEmp";
            this.codigoEmp.ReadOnly = true;
            this.codigoEmp.Visible = false;
            // 
            // numOrdenCompra
            // 
            this.numOrdenCompra.HeaderText = "nroOrdenCompra";
            this.numOrdenCompra.Name = "numOrdenCompra";
            this.numOrdenCompra.ReadOnly = true;
            this.numOrdenCompra.Visible = false;
            // 
            // nroItem
            // 
            this.nroItem.HeaderText = "nroItem";
            this.nroItem.Name = "nroItem";
            this.nroItem.ReadOnly = true;
            this.nroItem.Visible = false;
            // 
            // CodProd
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CodProd.DefaultCellStyle = dataGridViewCellStyle2;
            this.CodProd.HeaderText = "Código";
            this.CodProd.Name = "CodProd";
            this.CodProd.ReadOnly = true;
            // 
            // DescripProd
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DescripProd.DefaultCellStyle = dataGridViewCellStyle3;
            this.DescripProd.HeaderText = "Descripción";
            this.DescripProd.Name = "DescripProd";
            this.DescripProd.ReadOnly = true;
            this.DescripProd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DescripProd.Width = 460;
            // 
            // UniMed
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.UniMed.DefaultCellStyle = dataGridViewCellStyle4;
            this.UniMed.HeaderText = "UniMed";
            this.UniMed.Name = "UniMed";
            this.UniMed.ReadOnly = true;
            this.UniMed.Width = 55;
            // 
            // Precio
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle5;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.NullValue = null;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle6;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxOC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBoxdiaria);
            this.groupBox1.Controls.Add(this.labelEntrega);
            this.groupBox1.Controls.Add(this.comboBoxLugarEntrega);
            this.groupBox1.Controls.Add(this.comboBoxProveed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxObs);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridViewOCCab);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1039, 271);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenes de Compra disponibles";
            // 
            // textBoxOC
            // 
            this.textBoxOC.Location = new System.Drawing.Point(927, 191);
            this.textBoxOC.Name = "textBoxOC";
            this.textBoxOC.Size = new System.Drawing.Size(100, 20);
            this.textBoxOC.TabIndex = 28;
            this.textBoxOC.TextChanged += new System.EventHandler(this.textBoxOC_TextChanged);
            this.textBoxOC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOC_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(851, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Buscar O.C.: ";
            // 
            // checkBoxdiaria
            // 
            this.checkBoxdiaria.AutoSize = true;
            this.checkBoxdiaria.Location = new System.Drawing.Point(863, 246);
            this.checkBoxdiaria.Name = "checkBoxdiaria";
            this.checkBoxdiaria.Size = new System.Drawing.Size(164, 17);
            this.checkBoxdiaria.TabIndex = 23;
            this.checkBoxdiaria.Text = "Orden de Compra no prevista";
            this.checkBoxdiaria.UseVisualStyleBackColor = true;
            // 
            // labelEntrega
            // 
            this.labelEntrega.AutoSize = true;
            this.labelEntrega.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelEntrega.Location = new System.Drawing.Point(528, 249);
            this.labelEntrega.Name = "labelEntrega";
            this.labelEntrega.Size = new System.Drawing.Size(65, 13);
            this.labelEntrega.TabIndex = 22;
            this.labelEntrega.Text = "Entregar en:";
            // 
            // comboBoxLugarEntrega
            // 
            this.comboBoxLugarEntrega.FormattingEnabled = true;
            this.comboBoxLugarEntrega.Location = new System.Drawing.Point(598, 244);
            this.comboBoxLugarEntrega.Name = "comboBoxLugarEntrega";
            this.comboBoxLugarEntrega.Size = new System.Drawing.Size(197, 21);
            this.comboBoxLugarEntrega.TabIndex = 21;
            // 
            // comboBoxProveed
            // 
            this.comboBoxProveed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProveed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProveed.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxProveed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProveed.FormattingEnabled = true;
            this.comboBoxProveed.Location = new System.Drawing.Point(523, 219);
            this.comboBoxProveed.Name = "comboBoxProveed";
            this.comboBoxProveed.Size = new System.Drawing.Size(510, 21);
            this.comboBoxProveed.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Proveedor:";
            // 
            // textBoxObs
            // 
            this.textBoxObs.Location = new System.Drawing.Point(50, 203);
            this.textBoxObs.Multiline = true;
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.Size = new System.Drawing.Size(467, 46);
            this.textBoxObs.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "OBS:";
            // 
            // dataGridViewOCCab
            // 
            this.dataGridViewOCCab.AllowUserToAddRows = false;
            this.dataGridViewOCCab.AllowUserToDeleteRows = false;
            this.dataGridViewOCCab.AllowUserToResizeColumns = false;
            this.dataGridViewOCCab.AllowUserToResizeRows = false;
            this.dataGridViewOCCab.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOCCab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewOCCab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOCCab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEmp,
            this.UsuarioAutoriza,
            this.Empresa,
            this.NroOrdenCompra,
            this.Fecha,
            this.Proveedor,
            this.Observaciones,
            this.SectorEntrega,
            this.pedidoNoPrevisto});
            this.dataGridViewOCCab.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewOCCab.EnableHeadersVisualStyles = false;
            this.dataGridViewOCCab.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOCCab.MultiSelect = false;
            this.dataGridViewOCCab.Name = "dataGridViewOCCab";
            this.dataGridViewOCCab.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOCCab.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewOCCab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOCCab.Size = new System.Drawing.Size(1033, 169);
            this.dataGridViewOCCab.TabIndex = 1;
            this.dataGridViewOCCab.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOCCab_CellClick);
            this.dataGridViewOCCab.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOCCab_CellContentClick);
            // 
            // codEmp
            // 
            this.codEmp.HeaderText = "codEmp";
            this.codEmp.Name = "codEmp";
            this.codEmp.ReadOnly = true;
            this.codEmp.Visible = false;
            // 
            // UsuarioAutoriza
            // 
            this.UsuarioAutoriza.HeaderText = "UsuarioAutoriza";
            this.UsuarioAutoriza.Name = "UsuarioAutoriza";
            this.UsuarioAutoriza.ReadOnly = true;
            this.UsuarioAutoriza.Visible = false;
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            // 
            // NroOrdenCompra
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.NroOrdenCompra.DefaultCellStyle = dataGridViewCellStyle8;
            this.NroOrdenCompra.HeaderText = "Orden Compra";
            this.NroOrdenCompra.Name = "NroOrdenCompra";
            this.NroOrdenCompra.ReadOnly = true;
            this.NroOrdenCompra.Width = 120;
            // 
            // Fecha
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle9;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Proveedor
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Proveedor.DefaultCellStyle = dataGridViewCellStyle10;
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            this.Proveedor.Width = 360;
            // 
            // Observaciones
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Observaciones.DefaultCellStyle = dataGridViewCellStyle11;
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Width = 280;
            // 
            // SectorEntrega
            // 
            this.SectorEntrega.HeaderText = "SectorEntrega";
            this.SectorEntrega.Name = "SectorEntrega";
            this.SectorEntrega.ReadOnly = true;
            this.SectorEntrega.Visible = false;
            // 
            // pedidoNoPrevisto
            // 
            this.pedidoNoPrevisto.HeaderText = "pedidoNoPrevisto";
            this.pedidoNoPrevisto.Name = "pedidoNoPrevisto";
            this.pedidoNoPrevisto.ReadOnly = true;
            this.pedidoNoPrevisto.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordenes de compra";
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 538);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(1039, 50);
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
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle13.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.ToolTipText = "Eliminar";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle14.NullValue")));
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 25;
            // 
            // Frm_ModificacionOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1039, 588);
            this.ControlBox = false;
            this.Controls.Add(this.toolStripEvents);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ModificacionOC";
            this.Text = "Modificacion de Orden de Compra";
            this.Load += new System.EventHandler(this.Frm_ModificacionOC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOCItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOCCab)).EndInit();
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewOCCab;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dataGridViewOCItems;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.TextBox textBoxObs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn Buscador;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.ComboBox comboBoxProveed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelEntrega;
        private System.Windows.Forms.ComboBox comboBoxLugarEntrega;
        private System.Windows.Forms.CheckBox checkBoxdiaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioAutoriza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroOrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectorEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedidoNoPrevisto;
        private System.Windows.Forms.TextBox textBoxOC;
        private System.Windows.Forms.Label label4;
    }
}
