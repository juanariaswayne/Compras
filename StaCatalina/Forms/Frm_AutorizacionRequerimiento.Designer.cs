namespace StaCatalina.Forms
{
    partial class Frm_AutorizacionRequerimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AutorizacionRequerimiento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewReqItem = new System.Windows.Forms.DataGridView();
            this.dataGridViewReqCab = new System.Windows.Forms.DataGridView();
            this.CodEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumReq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaReq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectorRequerimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObsRequerimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxSeleccionar = new System.Windows.Forms.CheckBox();
            this.checkBoxDiario = new System.Windows.Forms.CheckBox();
            this.codEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articuloId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requerimiento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autoriza = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NoAutoriza = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReqItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReqCab)).BeginInit();
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
            this.toolStripEvents.Location = new System.Drawing.Point(0, 593);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(1149, 50);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Detalle del requerimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione un Requerimiento Pendiente";
            // 
            // dataGridViewReqItem
            // 
            this.dataGridViewReqItem.AllowUserToAddRows = false;
            this.dataGridViewReqItem.AllowUserToDeleteRows = false;
            this.dataGridViewReqItem.AllowUserToResizeColumns = false;
            this.dataGridViewReqItem.AllowUserToResizeRows = false;
            this.dataGridViewReqItem.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReqItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReqItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReqItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEmpresa,
            this.articuloId,
            this.requerimiento_id,
            this.nroItem,
            this.Autoriza,
            this.NoAutoriza,
            this.Articulo,
            this.UniMed,
            this.Cantidad,
            this.Marca,
            this.FechaEntrega});
            this.dataGridViewReqItem.EnableHeadersVisualStyles = false;
            this.dataGridViewReqItem.Location = new System.Drawing.Point(15, 342);
            this.dataGridViewReqItem.MultiSelect = false;
            this.dataGridViewReqItem.Name = "dataGridViewReqItem";
            this.dataGridViewReqItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewReqItem.Size = new System.Drawing.Size(1120, 248);
            this.dataGridViewReqItem.TabIndex = 1;
            this.dataGridViewReqItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReqItem_CellContentClick);
            this.dataGridViewReqItem.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewReqItem_CurrentCellDirtyStateChanged);
            // 
            // dataGridViewReqCab
            // 
            this.dataGridViewReqCab.AllowUserToAddRows = false;
            this.dataGridViewReqCab.AllowUserToDeleteRows = false;
            this.dataGridViewReqCab.AllowUserToResizeColumns = false;
            this.dataGridViewReqCab.AllowUserToResizeRows = false;
            this.dataGridViewReqCab.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReqCab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewReqCab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReqCab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodEmp,
            this.NumReq,
            this.FechaReq,
            this.SectorRequerimiento,
            this.usuario,
            this.ObsRequerimiento});
            this.dataGridViewReqCab.EnableHeadersVisualStyles = false;
            this.dataGridViewReqCab.Location = new System.Drawing.Point(12, 25);
            this.dataGridViewReqCab.MultiSelect = false;
            this.dataGridViewReqCab.Name = "dataGridViewReqCab";
            this.dataGridViewReqCab.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReqCab.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewReqCab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReqCab.Size = new System.Drawing.Size(1123, 288);
            this.dataGridViewReqCab.TabIndex = 0;
            this.dataGridViewReqCab.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReqCab_CellClick);
            this.dataGridViewReqCab.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReqCab_CellContentClick);
            this.dataGridViewReqCab.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewReqCab_CurrentCellDirtyStateChanged);
            // 
            // CodEmp
            // 
            this.CodEmp.HeaderText = "CodEmp";
            this.CodEmp.Name = "CodEmp";
            this.CodEmp.ReadOnly = true;
            // 
            // NumReq
            // 
            this.NumReq.HeaderText = "Nº Requerimiento";
            this.NumReq.Name = "NumReq";
            this.NumReq.ReadOnly = true;
            this.NumReq.Width = 120;
            // 
            // FechaReq
            // 
            this.FechaReq.HeaderText = "Fecha de Pedido";
            this.FechaReq.Name = "FechaReq";
            this.FechaReq.ReadOnly = true;
            this.FechaReq.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FechaReq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SectorRequerimiento
            // 
            this.SectorRequerimiento.HeaderText = "Sector Requerimiento";
            this.SectorRequerimiento.Name = "SectorRequerimiento";
            this.SectorRequerimiento.ReadOnly = true;
            this.SectorRequerimiento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SectorRequerimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SectorRequerimiento.Width = 180;
            // 
            // usuario
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.usuario.DefaultCellStyle = dataGridViewCellStyle10;
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // ObsRequerimiento
            // 
            this.ObsRequerimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ObsRequerimiento.HeaderText = "Observaciones";
            this.ObsRequerimiento.Name = "ObsRequerimiento";
            this.ObsRequerimiento.ReadOnly = true;
            // 
            // checkBoxSeleccionar
            // 
            this.checkBoxSeleccionar.AutoSize = true;
            this.checkBoxSeleccionar.Location = new System.Drawing.Point(79, 322);
            this.checkBoxSeleccionar.Name = "checkBoxSeleccionar";
            this.checkBoxSeleccionar.Size = new System.Drawing.Size(115, 17);
            this.checkBoxSeleccionar.TabIndex = 10;
            this.checkBoxSeleccionar.Text = "Seleccionar Todos";
            this.checkBoxSeleccionar.UseVisualStyleBackColor = true;
            this.checkBoxSeleccionar.CheckedChanged += new System.EventHandler(this.checkBoxSeleccionar_CheckedChanged);
            // 
            // checkBoxDiario
            // 
            this.checkBoxDiario.AutoSize = true;
            this.checkBoxDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDiario.ForeColor = System.Drawing.Color.Blue;
            this.checkBoxDiario.Location = new System.Drawing.Point(568, 322);
            this.checkBoxDiario.Name = "checkBoxDiario";
            this.checkBoxDiario.Size = new System.Drawing.Size(144, 17);
            this.checkBoxDiario.TabIndex = 11;
            this.checkBoxDiario.Text = "Requerimiento Diario";
            this.checkBoxDiario.UseVisualStyleBackColor = true;
            // 
            // codEmpresa
            // 
            this.codEmpresa.HeaderText = "codEmpresa";
            this.codEmpresa.Name = "codEmpresa";
            this.codEmpresa.Visible = false;
            // 
            // articuloId
            // 
            this.articuloId.HeaderText = "articuloId";
            this.articuloId.Name = "articuloId";
            this.articuloId.ReadOnly = true;
            this.articuloId.Visible = false;
            // 
            // requerimiento_id
            // 
            this.requerimiento_id.HeaderText = "requerimiento_id";
            this.requerimiento_id.Name = "requerimiento_id";
            this.requerimiento_id.ReadOnly = true;
            this.requerimiento_id.Visible = false;
            // 
            // nroItem
            // 
            this.nroItem.HeaderText = "nroItem";
            this.nroItem.Name = "nroItem";
            this.nroItem.ReadOnly = true;
            this.nroItem.Visible = false;
            // 
            // Autoriza
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = false;
            this.Autoriza.DefaultCellStyle = dataGridViewCellStyle2;
            this.Autoriza.HeaderText = "Autoriza";
            this.Autoriza.Name = "Autoriza";
            this.Autoriza.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Autoriza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Autoriza.Width = 80;
            // 
            // NoAutoriza
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.NullValue = false;
            this.NoAutoriza.DefaultCellStyle = dataGridViewCellStyle3;
            this.NoAutoriza.HeaderText = "No Autoriza";
            this.NoAutoriza.Name = "NoAutoriza";
            this.NoAutoriza.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NoAutoriza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Articulo
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Articulo.DefaultCellStyle = dataGridViewCellStyle4;
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            this.Articulo.Width = 380;
            // 
            // UniMed
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.UniMed.DefaultCellStyle = dataGridViewCellStyle5;
            this.UniMed.HeaderText = "Uni. Med";
            this.UniMed.Name = "UniMed";
            this.UniMed.ReadOnly = true;
            this.UniMed.Width = 80;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.NullValue = null;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle6;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Marca
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Marca.DefaultCellStyle = dataGridViewCellStyle7;
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 150;
            // 
            // FechaEntrega
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FechaEntrega.DefaultCellStyle = dataGridViewCellStyle8;
            this.FechaEntrega.HeaderText = "Fecha Entrega";
            this.FechaEntrega.Name = "FechaEntrega";
            this.FechaEntrega.ReadOnly = true;
            this.FechaEntrega.Width = 110;
            // 
            // Frm_AutorizacionRequerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 643);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxDiario);
            this.Controls.Add(this.checkBoxSeleccionar);
            this.Controls.Add(this.toolStripEvents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewReqItem);
            this.Controls.Add(this.dataGridViewReqCab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_AutorizacionRequerimiento";
            this.Text = "Autorizacion de Requerimientos";
            this.Load += new System.EventHandler(this.Frm_AutorizacionRequerimiento_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReqItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReqCab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReqCab;
        private System.Windows.Forms.DataGridView dataGridViewReqItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.CheckBox checkBoxSeleccionar;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.CheckBox checkBoxDiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectorRequerimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObsRequerimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn articuloId;
        private System.Windows.Forms.DataGridViewTextBoxColumn requerimiento_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Autoriza;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NoAutoriza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEntrega;
    }
}