namespace StaCatalina.Forms
{
    partial class Frm_ModificacionRequerimientoInterno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ModificacionRequerimientoInterno));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewReqInternoCab = new System.Windows.Forms.DataGridView();
            this.codEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioAutoriza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requerimiento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sector_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositoOrigenId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorDepositoOrigenId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositoDestinoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorDepositoDestinoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewReqItemsInterno = new System.Windows.Forms.DataGridView();
            this.Buscador = new System.Windows.Forms.DataGridViewButtonColumn();
            this.codigoEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numReq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxSectorDestino = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxDepositoDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxSectorOrigen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxDepositoOrigen = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReqInternoCab)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReqItemsInterno)).BeginInit();
            this.toolStripEvents.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewReqInternoCab);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 198);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Requerimientos disponibles";
            // 
            // dataGridViewReqInternoCab
            // 
            this.dataGridViewReqInternoCab.AllowUserToAddRows = false;
            this.dataGridViewReqInternoCab.AllowUserToDeleteRows = false;
            this.dataGridViewReqInternoCab.AllowUserToResizeColumns = false;
            this.dataGridViewReqInternoCab.AllowUserToResizeRows = false;
            this.dataGridViewReqInternoCab.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReqInternoCab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewReqInternoCab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReqInternoCab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEmp,
            this.UsuarioAutoriza,
            this.requerimiento_id,
            this.Fecha,
            this.Sector_ID,
            this.Observaciones,
            this.depositoOrigenId,
            this.sectorDepositoOrigenId,
            this.depositoDestinoId,
            this.sectorDepositoDestinoId});
            this.dataGridViewReqInternoCab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReqInternoCab.EnableHeadersVisualStyles = false;
            this.dataGridViewReqInternoCab.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewReqInternoCab.MultiSelect = false;
            this.dataGridViewReqInternoCab.Name = "dataGridViewReqInternoCab";
            this.dataGridViewReqInternoCab.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReqInternoCab.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewReqInternoCab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReqInternoCab.Size = new System.Drawing.Size(881, 179);
            this.dataGridViewReqInternoCab.TabIndex = 1;
            this.dataGridViewReqInternoCab.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOCCab_CellClick);
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
            // requerimiento_id
            // 
            this.requerimiento_id.HeaderText = "Nro. Requerimiento";
            this.requerimiento_id.Name = "requerimiento_id";
            this.requerimiento_id.ReadOnly = true;
            this.requerimiento_id.Width = 130;
            // 
            // Fecha
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle11;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Sector_ID
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Sector_ID.DefaultCellStyle = dataGridViewCellStyle12;
            this.Sector_ID.HeaderText = "Sector_ID";
            this.Sector_ID.Name = "Sector_ID";
            this.Sector_ID.ReadOnly = true;
            this.Sector_ID.Visible = false;
            this.Sector_ID.Width = 320;
            // 
            // Observaciones
            // 
            this.Observaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            // 
            // depositoOrigenId
            // 
            this.depositoOrigenId.HeaderText = "depositoOrigenId";
            this.depositoOrigenId.Name = "depositoOrigenId";
            this.depositoOrigenId.ReadOnly = true;
            this.depositoOrigenId.Visible = false;
            // 
            // sectorDepositoOrigenId
            // 
            this.sectorDepositoOrigenId.HeaderText = "sectorDepositoOrigenId";
            this.sectorDepositoOrigenId.Name = "sectorDepositoOrigenId";
            this.sectorDepositoOrigenId.ReadOnly = true;
            this.sectorDepositoOrigenId.Visible = false;
            // 
            // depositoDestinoId
            // 
            this.depositoDestinoId.HeaderText = "depositoDestinoId";
            this.depositoDestinoId.Name = "depositoDestinoId";
            this.depositoDestinoId.ReadOnly = true;
            this.depositoDestinoId.Visible = false;
            // 
            // sectorDepositoDestinoId
            // 
            this.sectorDepositoDestinoId.HeaderText = "sectorDepositoDestinoId";
            this.sectorDepositoDestinoId.Name = "sectorDepositoDestinoId";
            this.sectorDepositoDestinoId.ReadOnly = true;
            this.sectorDepositoDestinoId.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewReqItemsInterno);
            this.groupBox2.Location = new System.Drawing.Point(12, 390);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(859, 290);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // dataGridViewReqItemsInterno
            // 
            this.dataGridViewReqItemsInterno.AllowUserToOrderColumns = true;
            this.dataGridViewReqItemsInterno.AllowUserToResizeColumns = false;
            this.dataGridViewReqItemsInterno.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReqItemsInterno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewReqItemsInterno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReqItemsInterno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Buscador,
            this.codigoEmp,
            this.numReq,
            this.nroItem,
            this.CodProd,
            this.DescripProd,
            this.UniMed,
            this.Cantidad});
            this.dataGridViewReqItemsInterno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReqItemsInterno.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewReqItemsInterno.EnableHeadersVisualStyles = false;
            this.dataGridViewReqItemsInterno.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewReqItemsInterno.MultiSelect = false;
            this.dataGridViewReqItemsInterno.Name = "dataGridViewReqItemsInterno";
            this.dataGridViewReqItemsInterno.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewReqItemsInterno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReqItemsInterno.Size = new System.Drawing.Size(853, 271);
            this.dataGridViewReqItemsInterno.TabIndex = 13;
            this.dataGridViewReqItemsInterno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOCItems_CellContentClick);
            this.dataGridViewReqItemsInterno.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOCItems_CellEndEdit);
            this.dataGridViewReqItemsInterno.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewOCItems_CurrentCellDirtyStateChanged);
            this.dataGridViewReqItemsInterno.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewOCItems_EditingControlShowing);
            this.dataGridViewReqItemsInterno.SelectionChanged += new System.EventHandler(this.dataGridViewOCItems_SelectionChanged);
            this.dataGridViewReqItemsInterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewOCItems_KeyDown);
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
            // numReq
            // 
            this.numReq.HeaderText = "nroReq";
            this.numReq.Name = "numReq";
            this.numReq.ReadOnly = true;
            this.numReq.Visible = false;
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CodProd.DefaultCellStyle = dataGridViewCellStyle15;
            this.CodProd.HeaderText = "Código";
            this.CodProd.Name = "CodProd";
            this.CodProd.ReadOnly = true;
            // 
            // DescripProd
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DescripProd.DefaultCellStyle = dataGridViewCellStyle16;
            this.DescripProd.HeaderText = "Descripción";
            this.DescripProd.Name = "DescripProd";
            this.DescripProd.ReadOnly = true;
            this.DescripProd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DescripProd.Width = 480;
            // 
            // UniMed
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.UniMed.DefaultCellStyle = dataGridViewCellStyle17;
            this.UniMed.HeaderText = "UniMed";
            this.UniMed.Name = "UniMed";
            this.UniMed.ReadOnly = true;
            this.UniMed.Width = 55;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N2";
            dataGridViewCellStyle18.NullValue = null;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle18;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 683);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(887, 50);
            this.toolStripEvents.TabIndex = 15;
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
            // textBoxObs
            // 
            this.textBoxObs.Location = new System.Drawing.Point(64, 338);
            this.textBoxObs.Multiline = true;
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.Size = new System.Drawing.Size(602, 46);
            this.textBoxObs.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "OBS:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxSectorDestino);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboBoxDepositoDestino);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(590, 61);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Depósito y  Sector";
            // 
            // comboBoxSectorDestino
            // 
            this.comboBoxSectorDestino.FormattingEnabled = true;
            this.comboBoxSectorDestino.Location = new System.Drawing.Point(359, 27);
            this.comboBoxSectorDestino.Name = "comboBoxSectorDestino";
            this.comboBoxSectorDestino.Size = new System.Drawing.Size(197, 21);
            this.comboBoxSectorDestino.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(312, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Sector:";
            // 
            // comboBoxDepositoDestino
            // 
            this.comboBoxDepositoDestino.FormattingEnabled = true;
            this.comboBoxDepositoDestino.Location = new System.Drawing.Point(105, 27);
            this.comboBoxDepositoDestino.Name = "comboBoxDepositoDestino";
            this.comboBoxDepositoDestino.Size = new System.Drawing.Size(197, 21);
            this.comboBoxDepositoDestino.TabIndex = 28;
            this.comboBoxDepositoDestino.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepositoDestino_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Pedido al Depósito:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxSectorOrigen);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.comboBoxDepositoOrigen);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(15, 267);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(590, 62);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Depósito y  Sector de Entrega";
            // 
            // comboBoxSectorOrigen
            // 
            this.comboBoxSectorOrigen.FormattingEnabled = true;
            this.comboBoxSectorOrigen.Location = new System.Drawing.Point(386, 27);
            this.comboBoxSectorOrigen.Name = "comboBoxSectorOrigen";
            this.comboBoxSectorOrigen.Size = new System.Drawing.Size(197, 21);
            this.comboBoxSectorOrigen.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(303, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Sector Entrega:";
            // 
            // comboBoxDepositoOrigen
            // 
            this.comboBoxDepositoOrigen.FormattingEnabled = true;
            this.comboBoxDepositoOrigen.Location = new System.Drawing.Point(104, 26);
            this.comboBoxDepositoOrigen.Name = "comboBoxDepositoOrigen";
            this.comboBoxDepositoOrigen.Size = new System.Drawing.Size(197, 21);
            this.comboBoxDepositoOrigen.TabIndex = 28;
            this.comboBoxDepositoOrigen.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepositoOrigen_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(10, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Depósito Entrega:";
            // 
            // Frm_ModificacionRequerimientoInterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 733);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBoxObs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStripEvents);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ModificacionRequerimientoInterno";
            this.Text = "Modificación requerimiento Interno";
            this.Load += new System.EventHandler(this.Frm_ModificacionRequerimientoInterno_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReqInternoCab)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReqItemsInterno)).EndInit();
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewReqInternoCab;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dataGridViewReqItemsInterno;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.TextBox textBoxObs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxSectorDestino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxDepositoDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxSectorOrigen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxDepositoOrigen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewButtonColumn Buscador;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn numReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioAutoriza;
        private System.Windows.Forms.DataGridViewTextBoxColumn requerimiento_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sector_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositoOrigenId;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorDepositoOrigenId;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositoDestinoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorDepositoDestinoId;
    }
}