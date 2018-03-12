namespace StaCatalina.Forms
{
    partial class Frm_AnularOC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AnularOC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewOC = new System.Windows.Forms.DataGridView();
            this.USUARIO_AUTORIZA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anular = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NumOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaReq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectorReqID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectorRequerimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObsRequerimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModificaCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.textBoxOC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOC)).BeginInit();
            this.toolStripEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxOC);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dataGridViewOC);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 469);
            this.panel1.TabIndex = 12;
            // 
            // dataGridViewOC
            // 
            this.dataGridViewOC.AllowUserToAddRows = false;
            this.dataGridViewOC.AllowUserToDeleteRows = false;
            this.dataGridViewOC.AllowUserToResizeColumns = false;
            this.dataGridViewOC.AllowUserToResizeRows = false;
            this.dataGridViewOC.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USUARIO_AUTORIZA,
            this.CodEmp,
            this.Anular,
            this.NumOC,
            this.FechaReq,
            this.SectorReqID,
            this.SectorRequerimiento,
            this.ObsRequerimiento,
            this.condPago,
            this.ModificaCosto,
            this.usuario,
            this.TIPOOC});
            this.dataGridViewOC.EnableHeadersVisualStyles = false;
            this.dataGridViewOC.Location = new System.Drawing.Point(12, 25);
            this.dataGridViewOC.MultiSelect = false;
            this.dataGridViewOC.Name = "dataGridViewOC";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOC.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewOC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOC.Size = new System.Drawing.Size(1090, 391);
            this.dataGridViewOC.TabIndex = 4;
            this.dataGridViewOC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOC_CellContentClick);
            this.dataGridViewOC.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewOC_CurrentCellDirtyStateChanged);
            // 
            // USUARIO_AUTORIZA
            // 
            this.USUARIO_AUTORIZA.HeaderText = "USUARIO_AUTORIZA";
            this.USUARIO_AUTORIZA.Name = "USUARIO_AUTORIZA";
            this.USUARIO_AUTORIZA.ReadOnly = true;
            this.USUARIO_AUTORIZA.Visible = false;
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
            // NumOC
            // 
            this.NumOC.HeaderText = "Nº O.C";
            this.NumOC.Name = "NumOC";
            this.NumOC.Width = 120;
            // 
            // FechaReq
            // 
            this.FechaReq.HeaderText = "Fecha";
            this.FechaReq.Name = "FechaReq";
            this.FechaReq.ReadOnly = true;
            this.FechaReq.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FechaReq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SectorReqID
            // 
            this.SectorReqID.HeaderText = "codPro";
            this.SectorReqID.Name = "SectorReqID";
            this.SectorReqID.ReadOnly = true;
            this.SectorReqID.Visible = false;
            // 
            // SectorRequerimiento
            // 
            this.SectorRequerimiento.HeaderText = "Proveedor";
            this.SectorRequerimiento.Name = "SectorRequerimiento";
            this.SectorRequerimiento.ReadOnly = true;
            this.SectorRequerimiento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SectorRequerimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SectorRequerimiento.Width = 180;
            // 
            // ObsRequerimiento
            // 
            this.ObsRequerimiento.HeaderText = "Motivo Anulación";
            this.ObsRequerimiento.Name = "ObsRequerimiento";
            this.ObsRequerimiento.Width = 420;
            // 
            // condPago
            // 
            this.condPago.HeaderText = "condPago";
            this.condPago.Name = "condPago";
            this.condPago.ReadOnly = true;
            this.condPago.Visible = false;
            // 
            // ModificaCosto
            // 
            this.ModificaCosto.HeaderText = "ModificaCosto";
            this.ModificaCosto.Name = "ModificaCosto";
            this.ModificaCosto.ReadOnly = true;
            this.ModificaCosto.Visible = false;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Visible = false;
            // 
            // TIPOOC
            // 
            this.TIPOOC.HeaderText = "TIPOOC";
            this.TIPOOC.Name = "TIPOOC";
            this.TIPOOC.ReadOnly = true;
            this.TIPOOC.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione una Orden de Compra a anular";
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 419);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(1114, 50);
            this.toolStripEvents.TabIndex = 13;
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
            // textBoxOC
            // 
            this.textBoxOC.Location = new System.Drawing.Point(576, 2);
            this.textBoxOC.Name = "textBoxOC";
            this.textBoxOC.Size = new System.Drawing.Size(100, 20);
            this.textBoxOC.TabIndex = 30;
            this.textBoxOC.TextChanged += new System.EventHandler(this.textBoxOC_TextChanged);
            this.textBoxOC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOC_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Buscar O.C.: ";
            // 
            // Frm_AnularOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 469);
            this.ControlBox = false;
            this.Controls.Add(this.toolStripEvents);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_AnularOC";
            this.Text = "Anular Orden de Compra";
            this.Load += new System.EventHandler(this.Frm_AnularOC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOC)).EndInit();
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewOC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO_AUTORIZA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodEmp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Anular;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectorReqID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectorRequerimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObsRequerimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn condPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModificaCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOOC;
        private System.Windows.Forms.TextBox textBoxOC;
        private System.Windows.Forms.Label label4;
    }
}