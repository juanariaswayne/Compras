namespace StaCatalina.Forms
{
    partial class Frm_AnularRequerimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AnularRequerimiento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewReq = new System.Windows.Forms.DataGridView();
            this.UsuarioAutoriza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anular = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NumReq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaReq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectorReqID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectorRequerimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObsRequerimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripEvents.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReq)).BeginInit();
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
            this.toolStripEvents.Location = new System.Drawing.Point(0, 488);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(1220, 50);
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
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 488);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewReq);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 488);
            this.panel2.TabIndex = 5;
            // 
            // dataGridViewReq
            // 
            this.dataGridViewReq.AllowUserToAddRows = false;
            this.dataGridViewReq.AllowUserToDeleteRows = false;
            this.dataGridViewReq.AllowUserToResizeColumns = false;
            this.dataGridViewReq.AllowUserToResizeRows = false;
            this.dataGridViewReq.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReq.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsuarioAutoriza,
            this.CodEmp,
            this.Anular,
            this.NumReq,
            this.FechaReq,
            this.SectorReqID,
            this.SectorRequerimiento,
            this.Motivo,
            this.ObsRequerimiento});
            this.dataGridViewReq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReq.EnableHeadersVisualStyles = false;
            this.dataGridViewReq.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewReq.MultiSelect = false;
            this.dataGridViewReq.Name = "dataGridViewReq";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReq.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewReq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewReq.Size = new System.Drawing.Size(1220, 488);
            this.dataGridViewReq.TabIndex = 4;
            this.dataGridViewReq.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReq_CellContentClick);
            this.dataGridViewReq.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewReq_CurrentCellDirtyStateChanged);
            // 
            // UsuarioAutoriza
            // 
            this.UsuarioAutoriza.HeaderText = "UsuarioAutoriza";
            this.UsuarioAutoriza.Name = "UsuarioAutoriza";
            this.UsuarioAutoriza.Visible = false;
            // 
            // CodEmp
            // 
            this.CodEmp.HeaderText = "CodEmp";
            this.CodEmp.Name = "CodEmp";
            this.CodEmp.ReadOnly = true;
            // 
            // Anular
            // 
            this.Anular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Anular.HeaderText = "Anular";
            this.Anular.Name = "Anular";
            this.Anular.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Anular.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NumReq
            // 
            this.NumReq.HeaderText = "Nº Requerimiento";
            this.NumReq.Name = "NumReq";
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
            // SectorReqID
            // 
            this.SectorReqID.HeaderText = "SectorReqID";
            this.SectorReqID.Name = "SectorReqID";
            this.SectorReqID.ReadOnly = true;
            this.SectorReqID.Visible = false;
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
            // Motivo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Motivo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.Width = 550;
            // 
            // ObsRequerimiento
            // 
            this.ObsRequerimiento.HeaderText = "Observaciones";
            this.ObsRequerimiento.Name = "ObsRequerimiento";
            this.ObsRequerimiento.ReadOnly = true;
            this.ObsRequerimiento.Visible = false;
            this.ObsRequerimiento.Width = 200;
            // 
            // Frm_AnularRequerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1220, 538);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripEvents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_AnularRequerimiento";
            this.Text = "Anular Requerimientos";
            this.Load += new System.EventHandler(this.Frm_AnularRequerimiento_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewReq;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioAutoriza;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodEmp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Anular;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectorReqID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectorRequerimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObsRequerimiento;
    }
}
