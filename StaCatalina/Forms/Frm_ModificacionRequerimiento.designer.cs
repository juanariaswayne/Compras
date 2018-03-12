namespace StaCatalina.Forms
{
    partial class Frm_ModificacionRequerimiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ModificacionRequerimiento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewReqCab = new System.Windows.Forms.DataGridView();
            this.codEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioAutoriza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requerimiento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sector_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrega_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LugarEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewReqItems = new System.Windows.Forms.DataGridView();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewProvisorios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProvisorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codEmpprov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requerimiento_idprov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroitemprov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendienteBejerman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emblaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProvisorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEntrega = new System.Windows.Forms.Label();
            this.comboBoxLugarEntrega = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReqCab)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReqItems)).BeginInit();
            this.toolStripEvents.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProvisorios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewReqCab);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 241);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Requerimientos disponibles";
            // 
            // dataGridViewReqCab
            // 
            this.dataGridViewReqCab.AllowUserToAddRows = false;
            this.dataGridViewReqCab.AllowUserToDeleteRows = false;
            this.dataGridViewReqCab.AllowUserToResizeColumns = false;
            this.dataGridViewReqCab.AllowUserToResizeRows = false;
            this.dataGridViewReqCab.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReqCab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReqCab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReqCab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEmp,
            this.UsuarioAutoriza,
            this.Empresa,
            this.requerimiento_id,
            this.Fecha,
            this.Sector_ID,
            this.Sector,
            this.Observaciones,
            this.Entrega_id,
            this.LugarEntrega});
            this.dataGridViewReqCab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReqCab.EnableHeadersVisualStyles = false;
            this.dataGridViewReqCab.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewReqCab.MultiSelect = false;
            this.dataGridViewReqCab.Name = "dataGridViewReqCab";
            this.dataGridViewReqCab.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReqCab.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewReqCab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReqCab.Size = new System.Drawing.Size(1028, 222);
            this.dataGridViewReqCab.TabIndex = 1;
            this.dataGridViewReqCab.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOCCab_CellClick);
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
            // requerimiento_id
            // 
            this.requerimiento_id.HeaderText = "Nro. Requerimiento";
            this.requerimiento_id.Name = "requerimiento_id";
            this.requerimiento_id.ReadOnly = true;
            this.requerimiento_id.Width = 130;
            // 
            // Fecha
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Sector_ID
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Sector_ID.DefaultCellStyle = dataGridViewCellStyle3;
            this.Sector_ID.HeaderText = "Sector_ID";
            this.Sector_ID.Name = "Sector_ID";
            this.Sector_ID.ReadOnly = true;
            this.Sector_ID.Visible = false;
            this.Sector_ID.Width = 320;
            // 
            // Sector
            // 
            this.Sector.HeaderText = "Sector";
            this.Sector.Name = "Sector";
            this.Sector.ReadOnly = true;
            this.Sector.Width = 200;
            // 
            // Observaciones
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Observaciones.DefaultCellStyle = dataGridViewCellStyle4;
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Width = 420;
            // 
            // Entrega_id
            // 
            this.Entrega_id.HeaderText = "Entrega_id";
            this.Entrega_id.Name = "Entrega_id";
            this.Entrega_id.ReadOnly = true;
            this.Entrega_id.Visible = false;
            // 
            // LugarEntrega
            // 
            this.LugarEntrega.HeaderText = "LugarEntrega";
            this.LugarEntrega.Name = "LugarEntrega";
            this.LugarEntrega.ReadOnly = true;
            this.LugarEntrega.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewReqItems);
            this.groupBox2.Location = new System.Drawing.Point(0, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1031, 256);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // dataGridViewReqItems
            // 
            this.dataGridViewReqItems.AllowUserToOrderColumns = true;
            this.dataGridViewReqItems.AllowUserToResizeColumns = false;
            this.dataGridViewReqItems.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReqItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewReqItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReqItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Buscador,
            this.codigoEmp,
            this.numReq,
            this.nroItem,
            this.CodProd,
            this.DescripProd,
            this.UniMed,
            this.Cantidad});
            this.dataGridViewReqItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReqItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewReqItems.EnableHeadersVisualStyles = false;
            this.dataGridViewReqItems.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewReqItems.MultiSelect = false;
            this.dataGridViewReqItems.Name = "dataGridViewReqItems";
            this.dataGridViewReqItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewReqItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReqItems.Size = new System.Drawing.Size(1025, 237);
            this.dataGridViewReqItems.TabIndex = 13;
            this.dataGridViewReqItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOCItems_CellContentClick);
            this.dataGridViewReqItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOCItems_CellEndEdit);
            this.dataGridViewReqItems.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewOCItems_CurrentCellDirtyStateChanged);
            this.dataGridViewReqItems.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewOCItems_EditingControlShowing);
            this.dataGridViewReqItems.SelectionChanged += new System.EventHandler(this.dataGridViewOCItems_SelectionChanged);
            this.dataGridViewReqItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewOCItems_KeyDown);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CodProd.DefaultCellStyle = dataGridViewCellStyle7;
            this.CodProd.HeaderText = "Código";
            this.CodProd.Name = "CodProd";
            this.CodProd.ReadOnly = true;
            // 
            // DescripProd
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DescripProd.DefaultCellStyle = dataGridViewCellStyle8;
            this.DescripProd.HeaderText = "Descripción";
            this.DescripProd.Name = "DescripProd";
            this.DescripProd.ReadOnly = true;
            this.DescripProd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DescripProd.Width = 480;
            // 
            // UniMed
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.UniMed.DefaultCellStyle = dataGridViewCellStyle9;
            this.UniMed.HeaderText = "UniMed";
            this.UniMed.Name = "UniMed";
            this.UniMed.ReadOnly = true;
            this.UniMed.Width = 55;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle10;
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
            this.toolStripEvents.Size = new System.Drawing.Size(1034, 50);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewProvisorios);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 546);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1034, 137);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Artículos que no están en Bejerman";
            // 
            // dataGridViewProvisorios
            // 
            this.dataGridViewProvisorios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProvisorios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewProvisorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProvisorios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.codProvisorio,
            this.codEmpprov,
            this.requerimiento_idprov,
            this.nroitemprov,
            this.pendienteBejerman,
            this.Descripcion,
            this.Presentacion,
            this.dataGridViewTextBoxColumn1,
            this.Marca,
            this.Emblaje,
            this.CantidadProvisorio});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProvisorios.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewProvisorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProvisorios.EnableHeadersVisualStyles = false;
            this.dataGridViewProvisorios.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewProvisorios.Name = "dataGridViewProvisorios";
            this.dataGridViewProvisorios.Size = new System.Drawing.Size(1028, 118);
            this.dataGridViewProvisorios.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // codProvisorio
            // 
            this.codProvisorio.HeaderText = "codProvisorio";
            this.codProvisorio.Name = "codProvisorio";
            this.codProvisorio.Visible = false;
            // 
            // codEmpprov
            // 
            this.codEmpprov.HeaderText = "codEmpprov";
            this.codEmpprov.Name = "codEmpprov";
            this.codEmpprov.Visible = false;
            // 
            // requerimiento_idprov
            // 
            this.requerimiento_idprov.HeaderText = "requerimiento_id";
            this.requerimiento_idprov.Name = "requerimiento_idprov";
            this.requerimiento_idprov.Visible = false;
            // 
            // nroitemprov
            // 
            this.nroitemprov.HeaderText = "nroitemprov";
            this.nroitemprov.Name = "nroitemprov";
            this.nroitemprov.Visible = false;
            // 
            // pendienteBejerman
            // 
            this.pendienteBejerman.HeaderText = "pendienteBejerman";
            this.pendienteBejerman.Name = "pendienteBejerman";
            this.pendienteBejerman.Visible = false;
            // 
            // Descripcion
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle12;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 300;
            // 
            // Presentacion
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Presentacion.DefaultCellStyle = dataGridViewCellStyle13;
            this.Presentacion.HeaderText = "Presentación";
            this.Presentacion.Name = "Presentacion";
            this.Presentacion.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn1.HeaderText = "Uni. Med";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // Marca
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Marca.DefaultCellStyle = dataGridViewCellStyle15;
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.Width = 140;
            // 
            // Emblaje
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Emblaje.DefaultCellStyle = dataGridViewCellStyle16;
            this.Emblaje.HeaderText = "Embalaje";
            this.Emblaje.Name = "Emblaje";
            this.Emblaje.Width = 140;
            // 
            // CantidadProvisorio
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewCellStyle17.NullValue = null;
            this.CantidadProvisorio.DefaultCellStyle = dataGridViewCellStyle17;
            this.CantidadProvisorio.HeaderText = "Cantidad";
            this.CantidadProvisorio.Name = "CantidadProvisorio";
            // 
            // textBoxObs
            // 
            this.textBoxObs.Location = new System.Drawing.Point(63, 247);
            this.textBoxObs.Multiline = true;
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.Size = new System.Drawing.Size(602, 46);
            this.textBoxObs.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "OBS:";
            // 
            // labelEntrega
            // 
            this.labelEntrega.AutoSize = true;
            this.labelEntrega.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelEntrega.Location = new System.Drawing.Point(672, 259);
            this.labelEntrega.Name = "labelEntrega";
            this.labelEntrega.Size = new System.Drawing.Size(65, 13);
            this.labelEntrega.TabIndex = 20;
            this.labelEntrega.Text = "Entregar en:";
            // 
            // comboBoxLugarEntrega
            // 
            this.comboBoxLugarEntrega.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxLugarEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLugarEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLugarEntrega.FormattingEnabled = true;
            this.comboBoxLugarEntrega.Location = new System.Drawing.Point(742, 255);
            this.comboBoxLugarEntrega.Name = "comboBoxLugarEntrega";
            this.comboBoxLugarEntrega.Size = new System.Drawing.Size(286, 21);
            this.comboBoxLugarEntrega.TabIndex = 19;
            // 
            // Frm_ModificacionRequerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 733);
            this.ControlBox = false;
            this.Controls.Add(this.labelEntrega);
            this.Controls.Add(this.comboBoxLugarEntrega);
            this.Controls.Add(this.textBoxObs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.toolStripEvents);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ModificacionRequerimiento";
            this.Text = "Modificación requerimiento";
            this.Load += new System.EventHandler(this.Frm_ModificacionRequerimiento_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReqCab)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReqItems)).EndInit();
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProvisorios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewReqCab;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dataGridViewReqItems;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.DataGridViewButtonColumn Buscador;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn numReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewProvisorios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProvisorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmpprov;
        private System.Windows.Forms.DataGridViewTextBoxColumn requerimiento_idprov;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroitemprov;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendienteBejerman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emblaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProvisorio;
        private System.Windows.Forms.TextBox textBoxObs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEntrega;
        private System.Windows.Forms.ComboBox comboBoxLugarEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioAutoriza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn requerimiento_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sector_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrega_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LugarEntrega;
    }
}