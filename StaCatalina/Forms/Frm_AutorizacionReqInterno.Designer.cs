namespace StaCatalina.Forms
{
    partial class Frm_AutorizacionReqInterno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AutorizacionReqInterno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewReqInternoCab = new System.Windows.Forms.DataGridView();
            this.CodEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumReq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaReq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectorRequerimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObsRequerimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxSeleccionar = new System.Windows.Forms.CheckBox();
            this.dataGridViewReqInternoItem = new System.Windows.Forms.DataGridView();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReqInternoCab)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReqInternoItem)).BeginInit();
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
            this.toolStripEvents.Location = new System.Drawing.Point(0, 604);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(1075, 50);
            this.toolStripEvents.TabIndex = 10;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewReqInternoCab);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1075, 275);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Requerimientos para autorizar";
            // 
            // dataGridViewReqInternoCab
            // 
            this.dataGridViewReqInternoCab.AllowUserToAddRows = false;
            this.dataGridViewReqInternoCab.AllowUserToDeleteRows = false;
            this.dataGridViewReqInternoCab.AllowUserToResizeColumns = false;
            this.dataGridViewReqInternoCab.AllowUserToResizeRows = false;
            this.dataGridViewReqInternoCab.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReqInternoCab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReqInternoCab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReqInternoCab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodEmp,
            this.NumReq,
            this.FechaReq,
            this.SectorRequerimiento,
            this.usuario,
            this.ObsRequerimiento});
            this.dataGridViewReqInternoCab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReqInternoCab.EnableHeadersVisualStyles = false;
            this.dataGridViewReqInternoCab.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewReqInternoCab.MultiSelect = false;
            this.dataGridViewReqInternoCab.Name = "dataGridViewReqInternoCab";
            this.dataGridViewReqInternoCab.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReqInternoCab.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewReqInternoCab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReqInternoCab.Size = new System.Drawing.Size(1069, 256);
            this.dataGridViewReqInternoCab.TabIndex = 1;
            this.dataGridViewReqInternoCab.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReqInternoCab_CellClick);
            this.dataGridViewReqInternoCab.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewReqInternoCab_CurrentCellDirtyStateChanged);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.usuario.DefaultCellStyle = dataGridViewCellStyle2;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxSeleccionar);
            this.groupBox2.Controls.Add(this.dataGridViewReqInternoItem);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1075, 323);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // checkBoxSeleccionar
            // 
            this.checkBoxSeleccionar.AutoSize = true;
            this.checkBoxSeleccionar.Location = new System.Drawing.Point(68, -1);
            this.checkBoxSeleccionar.Name = "checkBoxSeleccionar";
            this.checkBoxSeleccionar.Size = new System.Drawing.Size(115, 17);
            this.checkBoxSeleccionar.TabIndex = 13;
            this.checkBoxSeleccionar.Text = "Seleccionar Todos";
            this.checkBoxSeleccionar.UseVisualStyleBackColor = true;
            this.checkBoxSeleccionar.CheckedChanged += new System.EventHandler(this.checkBoxSeleccionar_CheckedChanged);
            // 
            // dataGridViewReqInternoItem
            // 
            this.dataGridViewReqInternoItem.AllowUserToAddRows = false;
            this.dataGridViewReqInternoItem.AllowUserToDeleteRows = false;
            this.dataGridViewReqInternoItem.AllowUserToResizeColumns = false;
            this.dataGridViewReqInternoItem.AllowUserToResizeRows = false;
            this.dataGridViewReqInternoItem.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReqInternoItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewReqInternoItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReqInternoItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewReqInternoItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReqInternoItem.EnableHeadersVisualStyles = false;
            this.dataGridViewReqInternoItem.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewReqInternoItem.MultiSelect = false;
            this.dataGridViewReqInternoItem.Name = "dataGridViewReqInternoItem";
            this.dataGridViewReqInternoItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewReqInternoItem.Size = new System.Drawing.Size(1069, 304);
            this.dataGridViewReqInternoItem.TabIndex = 2;
            this.dataGridViewReqInternoItem.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewReqInternoItem_CurrentCellDirtyStateChanged);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.NullValue = false;
            this.Autoriza.DefaultCellStyle = dataGridViewCellStyle5;
            this.Autoriza.HeaderText = "Autoriza";
            this.Autoriza.Name = "Autoriza";
            this.Autoriza.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Autoriza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Autoriza.Width = 80;
            // 
            // NoAutoriza
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.NullValue = false;
            this.NoAutoriza.DefaultCellStyle = dataGridViewCellStyle6;
            this.NoAutoriza.HeaderText = "No Autoriza";
            this.NoAutoriza.Name = "NoAutoriza";
            this.NoAutoriza.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NoAutoriza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Articulo
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Articulo.DefaultCellStyle = dataGridViewCellStyle7;
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            this.Articulo.Width = 380;
            // 
            // UniMed
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.UniMed.DefaultCellStyle = dataGridViewCellStyle8;
            this.UniMed.HeaderText = "Uni. Med";
            this.UniMed.Name = "UniMed";
            this.UniMed.ReadOnly = true;
            this.UniMed.Width = 80;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.NullValue = null;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle9;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Marca
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Marca.DefaultCellStyle = dataGridViewCellStyle10;
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 150;
            // 
            // FechaEntrega
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FechaEntrega.DefaultCellStyle = dataGridViewCellStyle11;
            this.FechaEntrega.HeaderText = "Fecha Entrega";
            this.FechaEntrega.Name = "FechaEntrega";
            this.FechaEntrega.ReadOnly = true;
            this.FechaEntrega.Visible = false;
            this.FechaEntrega.Width = 110;
            // 
            // Frm_AutorizacionReqInterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1075, 654);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripEvents);
            this.Name = "Frm_AutorizacionReqInterno";
            this.Text = "Autorización Requerimiento Interno";
            this.Load += new System.EventHandler(this.Frm_AutorizacionReqInterno_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReqInternoCab)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReqInternoItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewReqInternoCab;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectorRequerimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObsRequerimiento;
        private System.Windows.Forms.DataGridView dataGridViewReqInternoItem;
        private System.Windows.Forms.CheckBox checkBoxSeleccionar;
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
