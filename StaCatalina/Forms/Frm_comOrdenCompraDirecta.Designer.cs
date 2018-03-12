namespace StaCatalina.Forms
{
    partial class Frm_comOrdenCompraDirecta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_comOrdenCompraDirecta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewOCDirecta = new System.Windows.Forms.DataGridView();
            this.CodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelImporteOC = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelEntrega = new System.Windows.Forms.Label();
            this.comboBoxLugarEntrega = new System.Windows.Forms.ComboBox();
            this.checkBoxdiaria = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxRubro2 = new System.Windows.Forms.ComboBox();
            this.comboBoxrubro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonSi = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.comboBoxcodEmp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxProveed = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOCDirecta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStripEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 640);
            this.panel1.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewOCDirecta);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1140, 437);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // dataGridViewOCDirecta
            // 
            this.dataGridViewOCDirecta.AllowUserToAddRows = false;
            this.dataGridViewOCDirecta.AllowUserToDeleteRows = false;
            this.dataGridViewOCDirecta.AllowUserToResizeColumns = false;
            this.dataGridViewOCDirecta.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOCDirecta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOCDirecta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOCDirecta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProd,
            this.DescripProd,
            this.UniMed,
            this.Precio,
            this.Cantidad,
            this.Marca});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOCDirecta.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewOCDirecta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOCDirecta.EnableHeadersVisualStyles = false;
            this.dataGridViewOCDirecta.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOCDirecta.MultiSelect = false;
            this.dataGridViewOCDirecta.Name = "dataGridViewOCDirecta";
            this.dataGridViewOCDirecta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOCDirecta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewOCDirecta.Size = new System.Drawing.Size(1134, 418);
            this.dataGridViewOCDirecta.TabIndex = 13;
            this.dataGridViewOCDirecta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOCDirecta_CellContentClick);
            this.dataGridViewOCDirecta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOCDirecta_CellEndEdit);
            this.dataGridViewOCDirecta.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewOCDirecta_CurrentCellDirtyStateChanged);
            this.dataGridViewOCDirecta.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewOCDirecta_DataError);
            this.dataGridViewOCDirecta.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewOCDirecta_EditingControlShowing);
            this.dataGridViewOCDirecta.SelectionChanged += new System.EventHandler(this.dataGridViewOCDirecta_SelectionChanged);
            this.dataGridViewOCDirecta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewOCDirecta_KeyDown);
            // 
            // CodProd
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CodProd.DefaultCellStyle = dataGridViewCellStyle2;
            this.CodProd.HeaderText = "Código";
            this.CodProd.Name = "CodProd";
            // 
            // DescripProd
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DescripProd.DefaultCellStyle = dataGridViewCellStyle3;
            this.DescripProd.HeaderText = "Descripción";
            this.DescripProd.Name = "DescripProd";
            this.DescripProd.ReadOnly = true;
            this.DescripProd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DescripProd.Width = 450;
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
            this.Precio.DefaultCellStyle = dataGridViewCellStyle5;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle6;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelImporteOC);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelEntrega);
            this.groupBox1.Controls.Add(this.comboBoxLugarEntrega);
            this.groupBox1.Controls.Add(this.checkBoxdiaria);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxBuscar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.comboBoxcodEmp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxObs);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxProveed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1140, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // labelImporteOC
            // 
            this.labelImporteOC.AutoSize = true;
            this.labelImporteOC.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImporteOC.Location = new System.Drawing.Point(754, 171);
            this.labelImporteOC.Name = "labelImporteOC";
            this.labelImporteOC.Size = new System.Drawing.Size(0, 20);
            this.labelImporteOC.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(621, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Importe Total O.C.:";
            // 
            // labelEntrega
            // 
            this.labelEntrega.AutoSize = true;
            this.labelEntrega.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelEntrega.Location = new System.Drawing.Point(601, 140);
            this.labelEntrega.Name = "labelEntrega";
            this.labelEntrega.Size = new System.Drawing.Size(65, 13);
            this.labelEntrega.TabIndex = 20;
            this.labelEntrega.Text = "Entregar en:";
            // 
            // comboBoxLugarEntrega
            // 
            this.comboBoxLugarEntrega.FormattingEnabled = true;
            this.comboBoxLugarEntrega.Location = new System.Drawing.Point(671, 135);
            this.comboBoxLugarEntrega.Name = "comboBoxLugarEntrega";
            this.comboBoxLugarEntrega.Size = new System.Drawing.Size(197, 21);
            this.comboBoxLugarEntrega.TabIndex = 19;
            // 
            // checkBoxdiaria
            // 
            this.checkBoxdiaria.AutoSize = true;
            this.checkBoxdiaria.Checked = true;
            this.checkBoxdiaria.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxdiaria.Location = new System.Drawing.Point(671, 102);
            this.checkBoxdiaria.Name = "checkBoxdiaria";
            this.checkBoxdiaria.Size = new System.Drawing.Size(164, 17);
            this.checkBoxdiaria.TabIndex = 18;
            this.checkBoxdiaria.Text = "Orden de Compra no prevista";
            this.checkBoxdiaria.UseVisualStyleBackColor = true;
            this.checkBoxdiaria.CheckedChanged += new System.EventHandler(this.checkBoxdiaria_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.comboBoxRubro2);
            this.groupBox4.Controls.Add(this.comboBoxrubro);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(74, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(521, 73);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Búsqueda por Rubro o Subrubro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(37, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Rubro:";
            // 
            // comboBoxRubro2
            // 
            this.comboBoxRubro2.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxRubro2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRubro2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRubro2.FormattingEnabled = true;
            this.comboBoxRubro2.Location = new System.Drawing.Point(80, 19);
            this.comboBoxRubro2.Name = "comboBoxRubro2";
            this.comboBoxRubro2.Size = new System.Drawing.Size(418, 21);
            this.comboBoxRubro2.TabIndex = 15;
            this.comboBoxRubro2.SelectedIndexChanged += new System.EventHandler(this.comboBoxRubro2_SelectedIndexChanged);
            // 
            // comboBoxrubro
            // 
            this.comboBoxrubro.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxrubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxrubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxrubro.FormattingEnabled = true;
            this.comboBoxrubro.Location = new System.Drawing.Point(80, 48);
            this.comboBoxrubro.Name = "comboBoxrubro";
            this.comboBoxrubro.Size = new System.Drawing.Size(418, 21);
            this.comboBoxrubro.TabIndex = 13;
            this.comboBoxrubro.SelectedIndexChanged += new System.EventHandler(this.comboBoxrubro_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(13, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sub Rubro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(622, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Buscar:";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(671, 71);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(309, 20);
            this.textBoxBuscar.TabIndex = 16;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonSi);
            this.groupBox3.Controls.Add(this.radioButtonNo);
            this.groupBox3.Location = new System.Drawing.Point(802, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 24);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modifica Costo";
            this.groupBox3.Visible = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // radioButtonSi
            // 
            this.radioButtonSi.AutoSize = true;
            this.radioButtonSi.Location = new System.Drawing.Point(117, 33);
            this.radioButtonSi.Name = "radioButtonSi";
            this.radioButtonSi.Size = new System.Drawing.Size(34, 17);
            this.radioButtonSi.TabIndex = 1;
            this.radioButtonSi.Text = "Si";
            this.radioButtonSi.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Checked = true;
            this.radioButtonNo.Location = new System.Drawing.Point(44, 33);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNo.TabIndex = 0;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // comboBoxcodEmp
            // 
            this.comboBoxcodEmp.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxcodEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxcodEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxcodEmp.FormattingEnabled = true;
            this.comboBoxcodEmp.Location = new System.Drawing.Point(74, 15);
            this.comboBoxcodEmp.Name = "comboBoxcodEmp";
            this.comboBoxcodEmp.Size = new System.Drawing.Size(237, 21);
            this.comboBoxcodEmp.TabIndex = 9;
            this.comboBoxcodEmp.SelectedIndexChanged += new System.EventHandler(this.comboBoxcodEmp_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Empresa:";
            // 
            // textBoxObs
            // 
            this.textBoxObs.Location = new System.Drawing.Point(74, 146);
            this.textBoxObs.Multiline = true;
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.Size = new System.Drawing.Size(521, 49);
            this.textBoxObs.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Obs:";
            // 
            // comboBoxProveed
            // 
            this.comboBoxProveed.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxProveed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProveed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProveed.FormattingEnabled = true;
            this.comboBoxProveed.Location = new System.Drawing.Point(74, 42);
            this.comboBoxProveed.Name = "comboBoxProveed";
            this.comboBoxProveed.Size = new System.Drawing.Size(609, 21);
            this.comboBoxProveed.TabIndex = 1;
            this.comboBoxProveed.SelectedIndexChanged += new System.EventHandler(this.comboBoxProveed_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor:";
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
            this.toolStripEvents.Location = new System.Drawing.Point(0, 640);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(1140, 50);
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(265, 47);
            this.toolStripLabel1.Text = "                                                                                 " +
    "     ";
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_comOrdenCompraDirecta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1140, 690);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripEvents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_comOrdenCompraDirecta";
            this.Text = "Orden de Compra Directa";
            this.Load += new System.EventHandler(this.Frm_comOrdenCompraDirecta_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOCDirecta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dataGridViewOCDirecta;
        private System.Windows.Forms.ComboBox comboBoxProveed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxObs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxcodEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonSi;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxrubro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxRubro2;
        private System.Windows.Forms.CheckBox checkBoxdiaria;
        private System.Windows.Forms.Label labelEntrega;
        private System.Windows.Forms.ComboBox comboBoxLugarEntrega;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelImporteOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewComboBoxColumn Marca;
    }
}
