namespace StaCatalina.Bejerman
{
    partial class Frm_CreaSubCuenta_Concepto
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripButton toolStripButtonClose;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CreaSubCuenta_Concepto));
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxSubCuenta = new System.Windows.Forms.ComboBox();
            this.labelCodigoConcepto = new System.Windows.Forms.Label();
            this.labelDescripCtaContable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCodigoConc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCuentaContable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxConcepto = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripEvents.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.toolStripEvents.Location = new System.Drawing.Point(0, 202);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(672, 50);
            this.toolStripEvents.TabIndex = 12;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxSubCuenta);
            this.groupBox1.Controls.Add(this.labelCodigoConcepto);
            this.groupBox1.Controls.Add(this.labelDescripCtaContable);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxCodigoConc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labelCuentaContable);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxConcepto);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 202);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conceptos";
            // 
            // comboBoxSubCuenta
            // 
            this.comboBoxSubCuenta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxSubCuenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSubCuenta.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxSubCuenta.FormattingEnabled = true;
            this.comboBoxSubCuenta.Location = new System.Drawing.Point(107, 122);
            this.comboBoxSubCuenta.Name = "comboBoxSubCuenta";
            this.comboBoxSubCuenta.Size = new System.Drawing.Size(375, 21);
            this.comboBoxSubCuenta.TabIndex = 38;
            // 
            // labelCodigoConcepto
            // 
            this.labelCodigoConcepto.AutoSize = true;
            this.labelCodigoConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoConcepto.Location = new System.Drawing.Point(537, 45);
            this.labelCodigoConcepto.Name = "labelCodigoConcepto";
            this.labelCodigoConcepto.Size = new System.Drawing.Size(0, 13);
            this.labelCodigoConcepto.TabIndex = 37;
            // 
            // labelDescripCtaContable
            // 
            this.labelDescripCtaContable.AutoSize = true;
            this.labelDescripCtaContable.Location = new System.Drawing.Point(230, 89);
            this.labelDescripCtaContable.Name = "labelDescripCtaContable";
            this.labelDescripCtaContable.Size = new System.Drawing.Size(0, 13);
            this.labelDescripCtaContable.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Sub Cuenta:";
            // 
            // comboBoxCodigoConc
            // 
            this.comboBoxCodigoConc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxCodigoConc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCodigoConc.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxCodigoConc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCodigoConc.FormattingEnabled = true;
            this.comboBoxCodigoConc.Location = new System.Drawing.Point(554, 159);
            this.comboBoxCodigoConc.Name = "comboBoxCodigoConc";
            this.comboBoxCodigoConc.Size = new System.Drawing.Size(85, 21);
            this.comboBoxCodigoConc.TabIndex = 32;
            this.comboBoxCodigoConc.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(488, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Codigo:";
            // 
            // labelCuentaContable
            // 
            this.labelCuentaContable.AutoSize = true;
            this.labelCuentaContable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuentaContable.Location = new System.Drawing.Point(107, 88);
            this.labelCuentaContable.Name = "labelCuentaContable";
            this.labelCuentaContable.Size = new System.Drawing.Size(0, 15);
            this.labelCuentaContable.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuenta Contable:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Concepto:";
            // 
            // comboBoxConcepto
            // 
            this.comboBoxConcepto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxConcepto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxConcepto.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxConcepto.FormattingEnabled = true;
            this.comboBoxConcepto.Location = new System.Drawing.Point(107, 41);
            this.comboBoxConcepto.Name = "comboBoxConcepto";
            this.comboBoxConcepto.Size = new System.Drawing.Size(375, 21);
            this.comboBoxConcepto.TabIndex = 0;
            this.comboBoxConcepto.SelectedIndexChanged += new System.EventHandler(this.comboBoxConcepto_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_CreaSubCuenta_Concepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 252);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripEvents);
            this.Name = "Frm_CreaSubCuenta_Concepto";
            this.Text = "Asociar Sub Cuenta x Concepto";
            this.Load += new System.EventHandler(this.Frm_CreaSubCuenta_Concepto_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCuentaContable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxConcepto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCodigoConc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelDescripCtaContable;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelCodigoConcepto;
        private System.Windows.Forms.ComboBox comboBoxSubCuenta;
    }
}
