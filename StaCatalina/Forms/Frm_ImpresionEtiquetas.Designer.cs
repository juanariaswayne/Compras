namespace StaCatalina.Forms
{
    partial class Frm_ImpresionEtiquetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ImpresionEtiquetas));
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDescripUniMed = new System.Windows.Forms.Label();
            this.textBoxUniMedBejerman = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelVto = new System.Windows.Forms.Label();
            this.dateTimeVto = new System.Windows.Forms.DateTimePicker();
            this.labelDescripcionArt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUniXBulto = new System.Windows.Forms.TextBox();
            this.textBoxCantEtiquetas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripEvents.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPrint,
            this.toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 210);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(675, 50);
            this.toolStripEvents.TabIndex = 7;
            this.toolStripEvents.Text = "toolStrip1";
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrint.Image")));
            this.toolStripButtonPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(105, 47);
            this.toolStripButtonPrint.Text = "Imprimir";
            this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 210);
            this.panel1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDescripUniMed);
            this.groupBox1.Controls.Add(this.textBoxUniMedBejerman);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelVto);
            this.groupBox1.Controls.Add(this.dateTimeVto);
            this.groupBox1.Controls.Add(this.labelDescripcionArt);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBoxCodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxUniXBulto);
            this.groupBox1.Controls.Add(this.textBoxCantEtiquetas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxProductos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // labelDescripUniMed
            // 
            this.labelDescripUniMed.AutoSize = true;
            this.labelDescripUniMed.Location = new System.Drawing.Point(446, 77);
            this.labelDescripUniMed.Name = "labelDescripUniMed";
            this.labelDescripUniMed.Size = new System.Drawing.Size(0, 13);
            this.labelDescripUniMed.TabIndex = 32;
            // 
            // textBoxUniMedBejerman
            // 
            this.textBoxUniMedBejerman.Enabled = false;
            this.textBoxUniMedBejerman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUniMedBejerman.ForeColor = System.Drawing.Color.Red;
            this.textBoxUniMedBejerman.Location = new System.Drawing.Point(375, 72);
            this.textBoxUniMedBejerman.Name = "textBoxUniMedBejerman";
            this.textBoxUniMedBejerman.Size = new System.Drawing.Size(65, 22);
            this.textBoxUniMedBejerman.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Uni. Med. Bejerman:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(144, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Unidades x Bulto: es la cantidad por la que se dará de baja en el stock";
            // 
            // labelVto
            // 
            this.labelVto.AutoSize = true;
            this.labelVto.Location = new System.Drawing.Point(284, 154);
            this.labelVto.Name = "labelVto";
            this.labelVto.Size = new System.Drawing.Size(68, 13);
            this.labelVto.TabIndex = 28;
            this.labelVto.Text = "Vencimiento:";
            this.labelVto.Visible = false;
            // 
            // dateTimeVto
            // 
            this.dateTimeVto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeVto.Location = new System.Drawing.Point(356, 150);
            this.dateTimeVto.Name = "dateTimeVto";
            this.dateTimeVto.Size = new System.Drawing.Size(101, 20);
            this.dateTimeVto.TabIndex = 27;
            this.dateTimeVto.Visible = false;
            // 
            // labelDescripcionArt
            // 
            this.labelDescripcionArt.AutoSize = true;
            this.labelDescripcionArt.Location = new System.Drawing.Point(149, 50);
            this.labelDescripcionArt.Name = "labelDescripcionArt";
            this.labelDescripcionArt.Size = new System.Drawing.Size(0, 13);
            this.labelDescripcionArt.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(617, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 132);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Enabled = false;
            this.textBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.ForeColor = System.Drawing.Color.Red;
            this.textBoxCodigo.Location = new System.Drawing.Point(149, 72);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 22);
            this.textBoxCodigo.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Código:";
            // 
            // textBoxUniXBulto
            // 
            this.textBoxUniXBulto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUniXBulto.Location = new System.Drawing.Point(149, 149);
            this.textBoxUniXBulto.Name = "textBoxUniXBulto";
            this.textBoxUniXBulto.Size = new System.Drawing.Size(100, 22);
            this.textBoxUniXBulto.TabIndex = 2;
            this.textBoxUniXBulto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUniXBulto_KeyPress);
            // 
            // textBoxCantEtiquetas
            // 
            this.textBoxCantEtiquetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantEtiquetas.Location = new System.Drawing.Point(149, 110);
            this.textBoxCantEtiquetas.Name = "textBoxCantEtiquetas";
            this.textBoxCantEtiquetas.Size = new System.Drawing.Size(100, 22);
            this.textBoxCantEtiquetas.TabIndex = 1;
            this.textBoxCantEtiquetas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCantEtiquetas_KeyDown);
            this.textBoxCantEtiquetas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantEtiquetas_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Unidades x Bulto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cantidad Etiquetas:";
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProductos.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Location = new System.Drawing.Point(149, 18);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(484, 21);
            this.comboBoxProductos.TabIndex = 0;
            this.comboBoxProductos.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductos_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Artículo:";
            // 
            // Frm_ImpresionEtiquetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(675, 260);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripEvents);
            this.Name = "Frm_ImpresionEtiquetas";
            this.Text = "Impresión de Etiquetas";
            this.Load += new System.EventHandler(this.Frm_ImpresionEtiquetas_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDescripUniMed;
        private System.Windows.Forms.TextBox textBoxUniMedBejerman;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelVto;
        private System.Windows.Forms.DateTimePicker dateTimeVto;
        private System.Windows.Forms.Label labelDescripcionArt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUniXBulto;
        private System.Windows.Forms.TextBox textBoxCantEtiquetas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProductos;
        private System.Windows.Forms.Label label4;
    }
}
