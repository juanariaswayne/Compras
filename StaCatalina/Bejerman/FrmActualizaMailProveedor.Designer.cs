namespace StaCatalina.Bejerman
{
    partial class FrmActualizaMailProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActualizaMailProveedor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxcodEmp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxProveed = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMails = new System.Windows.Forms.DataGridView();
            this.Inactivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripEvents.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMails)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripButtonClose
            // 
            toolStripButtonClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            toolStripButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClose.Image")));
            toolStripButtonClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonClose.Name = "toolStripButtonClose";
            toolStripButtonClose.Size = new System.Drawing.Size(93, 59);
            toolStripButtonClose.Text = "Cerrar";
            toolStripButtonClose.ToolTipText = "Cerrar";
            toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripLabel1,
            this.toolStripButtonNew,
            toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 560);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripEvents.Size = new System.Drawing.Size(927, 62);
            this.toolStripEvents.TabIndex = 14;
            this.toolStripEvents.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(106, 59);
            this.toolStripButtonSave.Text = "Grabar";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(221, 59);
            this.toolStripLabel1.Text = "                                                     ";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(157, 59);
            this.toolStripButtonNew.Text = "Nuevo Ingreso";
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxcodEmp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxProveed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(927, 98);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxcodEmp
            // 
            this.comboBoxcodEmp.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxcodEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxcodEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxcodEmp.FormattingEnabled = true;
            this.comboBoxcodEmp.Location = new System.Drawing.Point(95, 21);
            this.comboBoxcodEmp.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxcodEmp.Name = "comboBoxcodEmp";
            this.comboBoxcodEmp.Size = new System.Drawing.Size(315, 24);
            this.comboBoxcodEmp.TabIndex = 13;
            this.comboBoxcodEmp.SelectedIndexChanged += new System.EventHandler(this.comboBoxcodEmp_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Empresa:";
            // 
            // comboBoxProveed
            // 
            this.comboBoxProveed.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxProveed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProveed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProveed.FormattingEnabled = true;
            this.comboBoxProveed.Location = new System.Drawing.Point(95, 54);
            this.comboBoxProveed.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxProveed.Name = "comboBoxProveed";
            this.comboBoxProveed.Size = new System.Drawing.Size(811, 24);
            this.comboBoxProveed.TabIndex = 11;
            this.comboBoxProveed.SelectedIndexChanged += new System.EventHandler(this.comboBoxProveed_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Proveedor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewMails);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 98);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(927, 462);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mails";
            // 
            // dataGridViewMails
            // 
            this.dataGridViewMails.AllowUserToDeleteRows = false;
            this.dataGridViewMails.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Inactivo,
            this.Email});
            this.dataGridViewMails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMails.Location = new System.Drawing.Point(3, 17);
            this.dataGridViewMails.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMails.MultiSelect = false;
            this.dataGridViewMails.Name = "dataGridViewMails";
            this.dataGridViewMails.RowHeadersVisible = false;
            this.dataGridViewMails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewMails.Size = new System.Drawing.Size(921, 443);
            this.dataGridViewMails.TabIndex = 6;
            this.dataGridViewMails.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewMails_CurrentCellDirtyStateChanged);
            // 
            // Inactivo
            // 
            this.Inactivo.HeaderText = "Inactivo";
            this.Inactivo.Name = "Inactivo";
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Email.DefaultCellStyle = dataGridViewCellStyle4;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // FrmActualizaMailProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(927, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripEvents);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmActualizaMailProveedor";
            this.Text = "Actualiza Mails Proveedores";
            this.Load += new System.EventHandler(this.FrmActualizaMailProveedor_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewMails;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Inactivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.ComboBox comboBoxcodEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxProveed;
        private System.Windows.Forms.Label label1;
    }
}
