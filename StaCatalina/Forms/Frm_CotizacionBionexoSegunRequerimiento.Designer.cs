namespace StaCatalina.Forms
{
    partial class Frm_CotizacionBionexoSegunRequerimiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CotizacionBionexoSegunRequerimiento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxSeleccionar = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewReqDisponibles = new System.Windows.Forms.DataGridView();
            this.codEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sector_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeleccionaReq = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Requerimiento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewConsolidado = new System.Windows.Forms.DataGridView();
            this.Selecciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReqDisponibles)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsolidado)).BeginInit();
            this.toolStripEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxSeleccionar);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.toolStripEvents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 664);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxSeleccionar
            // 
            this.checkBoxSeleccionar.AutoSize = true;
            this.checkBoxSeleccionar.Location = new System.Drawing.Point(75, 262);
            this.checkBoxSeleccionar.Name = "checkBoxSeleccionar";
            this.checkBoxSeleccionar.Size = new System.Drawing.Size(115, 17);
            this.checkBoxSeleccionar.TabIndex = 18;
            this.checkBoxSeleccionar.Text = "Seleccionar Todos";
            this.checkBoxSeleccionar.UseVisualStyleBackColor = true;
            this.checkBoxSeleccionar.CheckedChanged += new System.EventHandler(this.checkBoxSeleccionar_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewReqDisponibles);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1116, 256);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Requerimientos Disponibles";
            // 
            // dataGridViewReqDisponibles
            // 
            this.dataGridViewReqDisponibles.AllowUserToAddRows = false;
            this.dataGridViewReqDisponibles.AllowUserToDeleteRows = false;
            this.dataGridViewReqDisponibles.AllowUserToResizeColumns = false;
            this.dataGridViewReqDisponibles.AllowUserToResizeRows = false;
            this.dataGridViewReqDisponibles.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReqDisponibles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReqDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReqDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEmp,
            this.Sector_id,
            this.SeleccionaReq,
            this.Requerimiento_id,
            this.Fecha,
            this.Sector,
            this.Observaciones});
            this.dataGridViewReqDisponibles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReqDisponibles.EnableHeadersVisualStyles = false;
            this.dataGridViewReqDisponibles.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewReqDisponibles.Name = "dataGridViewReqDisponibles";
            this.dataGridViewReqDisponibles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewReqDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewReqDisponibles.Size = new System.Drawing.Size(1110, 237);
            this.dataGridViewReqDisponibles.TabIndex = 0;
            this.dataGridViewReqDisponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReqDisponibles_CellContentClick);
            this.dataGridViewReqDisponibles.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewReqDisponibles_CurrentCellDirtyStateChanged);
            // 
            // codEmp
            // 
            this.codEmp.HeaderText = "codEmp";
            this.codEmp.Name = "codEmp";
            this.codEmp.ReadOnly = true;
            // 
            // Sector_id
            // 
            this.Sector_id.HeaderText = "Sector_id";
            this.Sector_id.Name = "Sector_id";
            this.Sector_id.ReadOnly = true;
            this.Sector_id.Visible = false;
            // 
            // SeleccionaReq
            // 
            this.SeleccionaReq.HeaderText = "Selecciona";
            this.SeleccionaReq.Name = "SeleccionaReq";
            // 
            // Requerimiento_id
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Requerimiento_id.DefaultCellStyle = dataGridViewCellStyle2;
            this.Requerimiento_id.HeaderText = "Requerimiento";
            this.Requerimiento_id.Name = "Requerimiento_id";
            this.Requerimiento_id.ReadOnly = true;
            this.Requerimiento_id.Width = 120;
            // 
            // Fecha
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle3;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 110;
            // 
            // Sector
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Sector.DefaultCellStyle = dataGridViewCellStyle4;
            this.Sector.HeaderText = "Sector";
            this.Sector.Name = "Sector";
            this.Sector.ReadOnly = true;
            this.Sector.Width = 250;
            // 
            // Observaciones
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Observaciones.DefaultCellStyle = dataGridViewCellStyle5;
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Width = 380;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewConsolidado);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1116, 347);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "                                                                                 " +
    "              Requerimientos Consolidados";
            // 
            // dataGridViewConsolidado
            // 
            this.dataGridViewConsolidado.AllowUserToAddRows = false;
            this.dataGridViewConsolidado.AllowUserToDeleteRows = false;
            this.dataGridViewConsolidado.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewConsolidado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewConsolidado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsolidado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecciona,
            this.Articulo,
            this.Descripcion,
            this.Unidad,
            this.Cantidad});
            this.dataGridViewConsolidado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewConsolidado.EnableHeadersVisualStyles = false;
            this.dataGridViewConsolidado.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewConsolidado.MultiSelect = false;
            this.dataGridViewConsolidado.Name = "dataGridViewConsolidado";
            this.dataGridViewConsolidado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewConsolidado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewConsolidado.Size = new System.Drawing.Size(1110, 328);
            this.dataGridViewConsolidado.TabIndex = 0;
            this.dataGridViewConsolidado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConsolidado_CellContentClick);
            this.dataGridViewConsolidado.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConsolidado_CellValueChanged);
            this.dataGridViewConsolidado.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewConsolidado_CurrentCellDirtyStateChanged);
            this.dataGridViewConsolidado.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewConsolidado_EditingControlShowing);
            // 
            // Selecciona
            // 
            this.Selecciona.HeaderText = "Incluir";
            this.Selecciona.Name = "Selecciona";
            this.Selecciona.Width = 80;
            // 
            // Articulo
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Articulo.DefaultCellStyle = dataGridViewCellStyle7;
            this.Articulo.HeaderText = "Artículo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            this.Articulo.Width = 90;
            // 
            // Descripcion
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.NullValue = null;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle8;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 500;
            // 
            // Unidad
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Unidad.DefaultCellStyle = dataGridViewCellStyle9;
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            this.Unidad.Width = 80;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.NullValue = null;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle10;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 90;
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonClose});
            this.toolStripEvents.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripEvents.Location = new System.Drawing.Point(0, 614);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(1116, 50);
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
            this.toolStripButtonSave.Size = new System.Drawing.Size(200, 47);
            this.toolStripButtonSave.Text = "Generar Archivo Bionexo";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClose.Image")));
            this.toolStripButtonClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Size = new System.Drawing.Size(86, 47);
            this.toolStripButtonClose.Text = "Cerrar";
            this.toolStripButtonClose.ToolTipText = "Cerrar";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // Frm_CotizacionBionexoSegunRequerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1116, 664);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CotizacionBionexoSegunRequerimiento";
            this.Text = "Generar Archivo Cotización Bionexo";
            this.Load += new System.EventHandler(this.Frm_CotizacionBionexoSegunRequerimiento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReqDisponibles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsolidado)).EndInit();
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewConsolidado;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.CheckBox checkBoxSeleccionar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecciona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewReqDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sector_id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SeleccionaReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requerimiento_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
    }
}
