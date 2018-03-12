namespace StaCatalina.Bejerman
{
    partial class Frm_ABMSubCuentas
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
            System.Windows.Forms.ToolStripButton toolStripButtonClose;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABMSubCuentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescripSub = new System.Windows.Forms.TextBox();
            this.dataGridViewSubCuentas = new System.Windows.Forms.DataGridView();
            this.CentroCosto_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripButtonClose
            // 
            toolStripButtonClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            toolStripButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClose.Image")));
            toolStripButtonClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonClose.Name = "toolStripButtonClose";
            toolStripButtonClose.Size = new System.Drawing.Size(83, 47);
            toolStripButtonClose.Text = "Cerrar";
            toolStripButtonClose.ToolTipText = "Cerrar";
            toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripLabel1,
            this.toolStripButtonNew,
            toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 421);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(796, 50);
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(166, 47);
            this.toolStripLabel1.Text = "                                                     ";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(136, 47);
            this.toolStripButtonNew.Text = "Nuevo Ingreso";
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxDescripSub);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewSubCuentas);
            this.splitContainer1.Size = new System.Drawing.Size(796, 421);
            this.splitContainer1.SplitterDistance = 345;
            this.splitContainer1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripción Sub Cuenta";
            // 
            // textBoxDescripSub
            // 
            this.textBoxDescripSub.Location = new System.Drawing.Point(12, 157);
            this.textBoxDescripSub.Name = "textBoxDescripSub";
            this.textBoxDescripSub.Size = new System.Drawing.Size(308, 20);
            this.textBoxDescripSub.TabIndex = 0;
            // 
            // dataGridViewSubCuentas
            // 
            this.dataGridViewSubCuentas.AllowUserToAddRows = false;
            this.dataGridViewSubCuentas.AllowUserToDeleteRows = false;
            this.dataGridViewSubCuentas.AllowUserToResizeRows = false;
            this.dataGridViewSubCuentas.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSubCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSubCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CentroCosto_id,
            this.Descripcion});
            this.dataGridViewSubCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubCuentas.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSubCuentas.MultiSelect = false;
            this.dataGridViewSubCuentas.Name = "dataGridViewSubCuentas";
            this.dataGridViewSubCuentas.ReadOnly = true;
            this.dataGridViewSubCuentas.RowHeadersVisible = false;
            this.dataGridViewSubCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSubCuentas.Size = new System.Drawing.Size(447, 421);
            this.dataGridViewSubCuentas.TabIndex = 3;
            this.dataGridViewSubCuentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSubCuentas_CellClick);
            this.dataGridViewSubCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSubCuentas_CellContentClick);
            this.dataGridViewSubCuentas.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewSubCuentas_CurrentCellDirtyStateChanged);
            // 
            // CentroCosto_id
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CentroCosto_id.DefaultCellStyle = dataGridViewCellStyle2;
            this.CentroCosto_id.HeaderText = "Codigo";
            this.CentroCosto_id.Name = "CentroCosto_id";
            this.CentroCosto_id.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Frm_ABMSubCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(796, 471);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripEvents);
            this.Name = "Frm_ABMSubCuentas";
            this.Text = "ABM  de Sub Cuentas para Artículos";
            this.Load += new System.EventHandler(this.Frm_ABMSubCuentas_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubCuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescripSub;
        private System.Windows.Forms.DataGridView dataGridViewSubCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentroCosto_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}
