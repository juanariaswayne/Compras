namespace StaCatalina.Forms
{
    partial class Frm_ArticulosParaNuevoRequerimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ArticulosParaNuevoRequerimiento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSeleccionar = new System.Windows.Forms.CheckBox();
            this.dataGridViewDetalleReqDisponibles = new System.Windows.Forms.DataGridView();
            this.labelEntrega = new System.Windows.Forms.Label();
            this.comboBoxLugarEntrega = new System.Windows.Forms.ComboBox();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.codEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Incluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unimed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripEvents.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleReqDisponibles)).BeginInit();
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
            this.toolStripEvents.Location = new System.Drawing.Point(0, 312);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(915, 50);
            this.toolStripEvents.TabIndex = 14;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSeleccionar);
            this.groupBox1.Controls.Add(this.dataGridViewDetalleReqDisponibles);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(915, 265);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "                                                                                 " +
    " Seleccione los artículos a los cuales desea generar un nuevo requerimiento";
            // 
            // checkBoxSeleccionar
            // 
            this.checkBoxSeleccionar.AutoSize = true;
            this.checkBoxSeleccionar.Location = new System.Drawing.Point(21, 0);
            this.checkBoxSeleccionar.Name = "checkBoxSeleccionar";
            this.checkBoxSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.checkBoxSeleccionar.TabIndex = 19;
            this.checkBoxSeleccionar.Text = "Incluir Todo";
            this.checkBoxSeleccionar.UseVisualStyleBackColor = true;
            this.checkBoxSeleccionar.CheckedChanged += new System.EventHandler(this.checkBoxSeleccionar_CheckedChanged);
            // 
            // dataGridViewDetalleReqDisponibles
            // 
            this.dataGridViewDetalleReqDisponibles.AllowUserToAddRows = false;
            this.dataGridViewDetalleReqDisponibles.AllowUserToDeleteRows = false;
            this.dataGridViewDetalleReqDisponibles.AllowUserToResizeColumns = false;
            this.dataGridViewDetalleReqDisponibles.AllowUserToResizeRows = false;
            this.dataGridViewDetalleReqDisponibles.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDetalleReqDisponibles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDetalleReqDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalleReqDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEmpresa,
            this.Incluir,
            this.Articulo,
            this.Descripcion,
            this.Unimed,
            this.Cantidad,
            this.marca});
            this.dataGridViewDetalleReqDisponibles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDetalleReqDisponibles.EnableHeadersVisualStyles = false;
            this.dataGridViewDetalleReqDisponibles.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDetalleReqDisponibles.Name = "dataGridViewDetalleReqDisponibles";
            this.dataGridViewDetalleReqDisponibles.RowHeadersVisible = false;
            this.dataGridViewDetalleReqDisponibles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewDetalleReqDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewDetalleReqDisponibles.Size = new System.Drawing.Size(909, 246);
            this.dataGridViewDetalleReqDisponibles.TabIndex = 1;
            this.dataGridViewDetalleReqDisponibles.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewDetalleReqDisponibles_CurrentCellDirtyStateChanged);
            // 
            // labelEntrega
            // 
            this.labelEntrega.AutoSize = true;
            this.labelEntrega.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelEntrega.Location = new System.Drawing.Point(568, 15);
            this.labelEntrega.Name = "labelEntrega";
            this.labelEntrega.Size = new System.Drawing.Size(65, 13);
            this.labelEntrega.TabIndex = 17;
            this.labelEntrega.Text = "Entregar en:";
            // 
            // comboBoxLugarEntrega
            // 
            this.comboBoxLugarEntrega.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxLugarEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLugarEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLugarEntrega.FormattingEnabled = true;
            this.comboBoxLugarEntrega.Location = new System.Drawing.Point(639, 11);
            this.comboBoxLugarEntrega.Name = "comboBoxLugarEntrega";
            this.comboBoxLugarEntrega.Size = new System.Drawing.Size(264, 21);
            this.comboBoxLugarEntrega.TabIndex = 16;
            // 
            // textBoxObs
            // 
            this.textBoxObs.Location = new System.Drawing.Point(43, 3);
            this.textBoxObs.Multiline = true;
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.Size = new System.Drawing.Size(519, 38);
            this.textBoxObs.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Obs:";
            // 
            // codEmpresa
            // 
            this.codEmpresa.HeaderText = "codEmpresa";
            this.codEmpresa.Name = "codEmpresa";
            this.codEmpresa.Visible = false;
            // 
            // Incluir
            // 
            this.Incluir.HeaderText = "Incluir";
            this.Incluir.Name = "Incluir";
            this.Incluir.Width = 50;
            // 
            // Articulo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Articulo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Articulo.HeaderText = "Artículo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            this.Articulo.Width = 70;
            // 
            // Descripcion
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 350;
            // 
            // Unimed
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Unimed.DefaultCellStyle = dataGridViewCellStyle4;
            this.Unimed.HeaderText = "Uni. Med.";
            this.Unimed.Name = "Unimed";
            this.Unimed.Width = 80;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.NullValue = null;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle5;
            this.Cantidad.HeaderText = "Cantidad Adeudada";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 80;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.marca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.marca.Width = 250;
            // 
            // Frm_ArticulosParaNuevoRequerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 362);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxObs);
            this.Controls.Add(this.labelEntrega);
            this.Controls.Add(this.comboBoxLugarEntrega);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripEvents);
            this.Name = "Frm_ArticulosParaNuevoRequerimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artículos para generar un nuevo Requerimiento";
            this.Load += new System.EventHandler(this.Frm_ArticulosParaNuevoRequerimiento_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleReqDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewDetalleReqDisponibles;
        private System.Windows.Forms.CheckBox checkBoxSeleccionar;
        private System.Windows.Forms.Label labelEntrega;
        private System.Windows.Forms.ComboBox comboBoxLugarEntrega;
        private System.Windows.Forms.TextBox textBoxObs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmpresa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Incluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unimed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
    }
}