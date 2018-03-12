namespace StaCatalina.Forms
{
    partial class Frm_HistorialReclamo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HistorialReclamo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewHistComent = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCOEMPCODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCOSUCCODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceHist = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNewComentario = new System.Windows.Forms.TextBox();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripEvents.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistComent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHist)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.toolStripEvents.Location = new System.Drawing.Point(0, 369);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(851, 50);
            this.toolStripEvents.TabIndex = 7;
            this.toolStripEvents.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(101, 47);
            this.toolStripButtonSave.Text = "Guardar";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 369);
            this.panel1.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewHistComent);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(851, 244);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial comentarios";
            // 
            // dataGridViewHistComent
            // 
            this.dataGridViewHistComent.AllowUserToAddRows = false;
            this.dataGridViewHistComent.AllowUserToDeleteRows = false;
            this.dataGridViewHistComent.AutoGenerateColumns = false;
            this.dataGridViewHistComent.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistComent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewHistComent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistComent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.cCOEMPCODIGODataGridViewTextBoxColumn,
            this.cCOSUCCODDataGridViewTextBoxColumn,
            this.cCOIDDataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn,
            this.oBSDataGridViewTextBoxColumn});
            this.dataGridViewHistComent.DataSource = this.bindingSourceHist;
            this.dataGridViewHistComent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHistComent.EnableHeadersVisualStyles = false;
            this.dataGridViewHistComent.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewHistComent.Name = "dataGridViewHistComent";
            this.dataGridViewHistComent.RowHeadersVisible = false;
            this.dataGridViewHistComent.Size = new System.Drawing.Size(845, 225);
            this.dataGridViewHistComent.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cCOEMPCODIGODataGridViewTextBoxColumn
            // 
            this.cCOEMPCODIGODataGridViewTextBoxColumn.DataPropertyName = "CCOEMP_CODIGO";
            this.cCOEMPCODIGODataGridViewTextBoxColumn.HeaderText = "CCOEMP_CODIGO";
            this.cCOEMPCODIGODataGridViewTextBoxColumn.Name = "cCOEMPCODIGODataGridViewTextBoxColumn";
            this.cCOEMPCODIGODataGridViewTextBoxColumn.Visible = false;
            // 
            // cCOSUCCODDataGridViewTextBoxColumn
            // 
            this.cCOSUCCODDataGridViewTextBoxColumn.DataPropertyName = "CCOSUC_COD";
            this.cCOSUCCODDataGridViewTextBoxColumn.HeaderText = "CCOSUC_COD";
            this.cCOSUCCODDataGridViewTextBoxColumn.Name = "cCOSUCCODDataGridViewTextBoxColumn";
            this.cCOSUCCODDataGridViewTextBoxColumn.Visible = false;
            // 
            // cCOIDDataGridViewTextBoxColumn
            // 
            this.cCOIDDataGridViewTextBoxColumn.DataPropertyName = "CCO_ID";
            this.cCOIDDataGridViewTextBoxColumn.HeaderText = "CCO_ID";
            this.cCOIDDataGridViewTextBoxColumn.Name = "cCOIDDataGridViewTextBoxColumn";
            this.cCOIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fECHADataGridViewTextBoxColumn
            // 
            this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
            this.fECHADataGridViewTextBoxColumn.HeaderText = "Fecha Reclamo";
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
            this.fECHADataGridViewTextBoxColumn.Width = 110;
            // 
            // oBSDataGridViewTextBoxColumn
            // 
            this.oBSDataGridViewTextBoxColumn.DataPropertyName = "OBS";
            this.oBSDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.oBSDataGridViewTextBoxColumn.Name = "oBSDataGridViewTextBoxColumn";
            this.oBSDataGridViewTextBoxColumn.Width = 700;
            // 
            // bindingSourceHist
            // 
            this.bindingSourceHist.DataSource = typeof(Entities.Tables.HISTORIALSEGUIMIENTO);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNewComentario);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo comentario";
            // 
            // textBoxNewComentario
            // 
            this.textBoxNewComentario.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNewComentario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNewComentario.Location = new System.Drawing.Point(3, 16);
            this.textBoxNewComentario.Multiline = true;
            this.textBoxNewComentario.Name = "textBoxNewComentario";
            this.textBoxNewComentario.Size = new System.Drawing.Size(845, 106);
            this.textBoxNewComentario.TabIndex = 0;
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
            // Frm_HistorialReclamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 419);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripEvents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_HistorialReclamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial Reclamo";
            this.Load += new System.EventHandler(this.Frm_HistorialReclamo_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistComent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHist)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewHistComent;
        private System.Windows.Forms.TextBox textBoxNewComentario;
        private System.Windows.Forms.BindingSource bindingSourceHist;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCOEMPCODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCOSUCCODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
    }
}