namespace StaCatalina.Forms
{
    partial class Frm_ExcluirArticulosReq
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ExcluirArticulosReq));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewOCCab = new System.Windows.Forms.DataGridView();
            this.UsuarioAutorizo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requerimiento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewOCItem = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nroItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artcodgenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artdescgenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unimedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotivoExlusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOCCab)).BeginInit();
            this.toolStripEvents.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOCItem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewOCCab);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1128, 210);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Requerimientos";
            // 
            // dataGridViewOCCab
            // 
            this.dataGridViewOCCab.AllowUserToAddRows = false;
            this.dataGridViewOCCab.AllowUserToDeleteRows = false;
            this.dataGridViewOCCab.AllowUserToResizeColumns = false;
            this.dataGridViewOCCab.AllowUserToResizeRows = false;
            this.dataGridViewOCCab.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOCCab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOCCab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOCCab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsuarioAutorizo,
            this.codEmp,
            this.Requerimiento_id,
            this.Fecha,
            this.Observaciones});
            this.dataGridViewOCCab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOCCab.EnableHeadersVisualStyles = false;
            this.dataGridViewOCCab.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOCCab.MultiSelect = false;
            this.dataGridViewOCCab.Name = "dataGridViewOCCab";
            this.dataGridViewOCCab.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOCCab.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewOCCab.RowHeadersVisible = false;
            this.dataGridViewOCCab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOCCab.Size = new System.Drawing.Size(1122, 191);
            this.dataGridViewOCCab.TabIndex = 1;
            this.dataGridViewOCCab.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOCCab_CellClick);
            this.dataGridViewOCCab.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewOCCab_CurrentCellDirtyStateChanged);
            // 
            // UsuarioAutorizo
            // 
            this.UsuarioAutorizo.HeaderText = "UsuarioAutorizo";
            this.UsuarioAutorizo.Name = "UsuarioAutorizo";
            this.UsuarioAutorizo.ReadOnly = true;
            this.UsuarioAutorizo.Visible = false;
            // 
            // codEmp
            // 
            this.codEmp.HeaderText = "Empresa";
            this.codEmp.Name = "codEmp";
            this.codEmp.ReadOnly = true;
            // 
            // Requerimiento_id
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Requerimiento_id.DefaultCellStyle = dataGridViewCellStyle2;
            this.Requerimiento_id.HeaderText = "Nro. Requerimiento";
            this.Requerimiento_id.Name = "Requerimiento_id";
            this.Requerimiento_id.ReadOnly = true;
            this.Requerimiento_id.Width = 150;
            // 
            // Fecha
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle3;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Observaciones
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Observaciones.DefaultCellStyle = dataGridViewCellStyle4;
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Width = 450;
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 494);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(1128, 50);
            this.toolStripEvents.TabIndex = 16;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewOCItem);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1128, 278);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // dataGridViewOCItem
            // 
            this.dataGridViewOCItem.AllowUserToAddRows = false;
            this.dataGridViewOCItem.AllowUserToDeleteRows = false;
            this.dataGridViewOCItem.AllowUserToResizeColumns = false;
            this.dataGridViewOCItem.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOCItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewOCItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOCItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir,
            this.nroItem,
            this.artcodgenDataGridViewTextBoxColumn,
            this.artdescgenDataGridViewTextBoxColumn,
            this.unimedDataGridViewTextBoxColumn,
            this.MotivoExlusion});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOCItem.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewOCItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOCItem.EnableHeadersVisualStyles = false;
            this.dataGridViewOCItem.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOCItem.MultiSelect = false;
            this.dataGridViewOCItem.Name = "dataGridViewOCItem";
            this.dataGridViewOCItem.RowHeadersVisible = false;
            this.dataGridViewOCItem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOCItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewOCItem.Size = new System.Drawing.Size(1122, 259);
            this.dataGridViewOCItem.TabIndex = 13;
            this.dataGridViewOCItem.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewOCItem_CurrentCellDirtyStateChanged);
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            // 
            // nroItem
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.nroItem.DefaultCellStyle = dataGridViewCellStyle7;
            this.nroItem.HeaderText = "NroItem";
            this.nroItem.Name = "nroItem";
            this.nroItem.ReadOnly = true;
            this.nroItem.Width = 70;
            // 
            // artcodgenDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.artcodgenDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.artcodgenDataGridViewTextBoxColumn.HeaderText = "Artículo";
            this.artcodgenDataGridViewTextBoxColumn.Name = "artcodgenDataGridViewTextBoxColumn";
            this.artcodgenDataGridViewTextBoxColumn.ReadOnly = true;
            this.artcodgenDataGridViewTextBoxColumn.Width = 80;
            // 
            // artdescgenDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.artdescgenDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.artdescgenDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.artdescgenDataGridViewTextBoxColumn.Name = "artdescgenDataGridViewTextBoxColumn";
            this.artdescgenDataGridViewTextBoxColumn.ReadOnly = true;
            this.artdescgenDataGridViewTextBoxColumn.Width = 350;
            // 
            // unimedDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.unimedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.unimedDataGridViewTextBoxColumn.HeaderText = "Uni. Med.";
            this.unimedDataGridViewTextBoxColumn.Name = "unimedDataGridViewTextBoxColumn";
            this.unimedDataGridViewTextBoxColumn.ReadOnly = true;
            this.unimedDataGridViewTextBoxColumn.Width = 90;
            // 
            // MotivoExlusion
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.MotivoExlusion.DefaultCellStyle = dataGridViewCellStyle11;
            this.MotivoExlusion.HeaderText = "Motivo Exlusión";
            this.MotivoExlusion.Name = "MotivoExlusion";
            this.MotivoExlusion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MotivoExlusion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MotivoExlusion.Width = 400;
            // 
            // Frm_ExcluirArticulosReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1128, 544);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStripEvents);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_ExcluirArticulosReq";
            this.Text = "Excluir Artículos del Requerimiento";
            this.Load += new System.EventHandler(this.Frm_ExcluirArticulosReq_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOCCab)).EndInit();
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOCItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewOCCab;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dataGridViewOCItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Excluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn artcodgenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artdescgenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unimedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotivoExlusion;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioAutorizo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requerimiento_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
    }
}
