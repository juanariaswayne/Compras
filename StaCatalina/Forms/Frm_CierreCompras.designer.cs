namespace StaCatalina.Forms
{
    partial class Frm_CierreCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CierreCompras));
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxEnviaInforme = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonSindistribucion = new System.Windows.Forms.RadioButton();
            this.radioButtonCondistribución = new System.Windows.Forms.RadioButton();
            this.textBoxPorcentDistrib = new System.Windows.Forms.TextBox();
            this.labelDistribucion = new System.Windows.Forms.Label();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.radioButtonPorCuenta = new System.Windows.Forms.RadioButton();
            this.radioButtonPorMedicamentos = new System.Windows.Forms.RadioButton();
            this.radioButtonPorRubro = new System.Windows.Forms.RadioButton();
            this.radioButtonDetallado = new System.Windows.Forms.RadioButton();
            this.radioButtonSintetico = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.toolStripEvents.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxTipo.SuspendLayout();
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
            this.toolStripEvents.Location = new System.Drawing.Point(0, 310);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(445, 50);
            this.toolStripEvents.TabIndex = 5;
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
            this.panel1.Size = new System.Drawing.Size(445, 310);
            this.panel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxEnviaInforme);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBoxTipo);
            this.groupBox1.Controls.Add(this.radioButtonDetallado);
            this.groupBox1.Controls.Add(this.radioButtonSintetico);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimeHasta);
            this.groupBox1.Controls.Add(this.dateTimeDesde);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // checkBoxEnviaInforme
            // 
            this.checkBoxEnviaInforme.AutoSize = true;
            this.checkBoxEnviaInforme.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnviaInforme.Location = new System.Drawing.Point(210, 256);
            this.checkBoxEnviaInforme.Name = "checkBoxEnviaInforme";
            this.checkBoxEnviaInforme.Size = new System.Drawing.Size(223, 18);
            this.checkBoxEnviaInforme.TabIndex = 10;
            this.checkBoxEnviaInforme.Text = "Solo envío de Mail (No muestra informes)";
            this.checkBoxEnviaInforme.UseVisualStyleBackColor = true;
            this.checkBoxEnviaInforme.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonSindistribucion);
            this.groupBox2.Controls.Add(this.radioButtonCondistribución);
            this.groupBox2.Controls.Add(this.textBoxPorcentDistrib);
            this.groupBox2.Controls.Add(this.labelDistribucion);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 98);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Distribución";
            // 
            // radioButtonSindistribucion
            // 
            this.radioButtonSindistribucion.AutoSize = true;
            this.radioButtonSindistribucion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSindistribucion.Location = new System.Drawing.Point(256, 23);
            this.radioButtonSindistribucion.Name = "radioButtonSindistribucion";
            this.radioButtonSindistribucion.Size = new System.Drawing.Size(99, 18);
            this.radioButtonSindistribucion.TabIndex = 7;
            this.radioButtonSindistribucion.Text = "Sin Distribución";
            this.radioButtonSindistribucion.UseVisualStyleBackColor = true;
            this.radioButtonSindistribucion.CheckedChanged += new System.EventHandler(this.radioButtonSindistribucion_CheckedChanged);
            // 
            // radioButtonCondistribución
            // 
            this.radioButtonCondistribución.AutoSize = true;
            this.radioButtonCondistribución.Checked = true;
            this.radioButtonCondistribución.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCondistribución.Location = new System.Drawing.Point(79, 23);
            this.radioButtonCondistribución.Name = "radioButtonCondistribución";
            this.radioButtonCondistribución.Size = new System.Drawing.Size(102, 18);
            this.radioButtonCondistribución.TabIndex = 6;
            this.radioButtonCondistribución.TabStop = true;
            this.radioButtonCondistribución.Text = "Con distribución";
            this.radioButtonCondistribución.UseVisualStyleBackColor = true;
            this.radioButtonCondistribución.CheckedChanged += new System.EventHandler(this.radioButtonCondistribución_CheckedChanged);
            // 
            // textBoxPorcentDistrib
            // 
            this.textBoxPorcentDistrib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPorcentDistrib.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPorcentDistrib.Location = new System.Drawing.Point(245, 58);
            this.textBoxPorcentDistrib.Name = "textBoxPorcentDistrib";
            this.textBoxPorcentDistrib.Size = new System.Drawing.Size(50, 21);
            this.textBoxPorcentDistrib.TabIndex = 5;
            this.textBoxPorcentDistrib.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPorcentDistrib_KeyPress);
            // 
            // labelDistribucion
            // 
            this.labelDistribucion.AutoSize = true;
            this.labelDistribucion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistribucion.Location = new System.Drawing.Point(109, 62);
            this.labelDistribucion.Name = "labelDistribucion";
            this.labelDistribucion.Size = new System.Drawing.Size(133, 14);
            this.labelDistribucion.TabIndex = 4;
            this.labelDistribucion.Text = "% Distribución Venezuela:";
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Controls.Add(this.radioButtonPorCuenta);
            this.groupBoxTipo.Controls.Add(this.radioButtonPorMedicamentos);
            this.groupBoxTipo.Controls.Add(this.radioButtonPorRubro);
            this.groupBoxTipo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxTipo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTipo.Location = new System.Drawing.Point(3, 289);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(439, 18);
            this.groupBoxTipo.TabIndex = 8;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Tipo de Informe";
            this.groupBoxTipo.Visible = false;
            // 
            // radioButtonPorCuenta
            // 
            this.radioButtonPorCuenta.AutoSize = true;
            this.radioButtonPorCuenta.Checked = true;
            this.radioButtonPorCuenta.Location = new System.Drawing.Point(64, 19);
            this.radioButtonPorCuenta.Name = "radioButtonPorCuenta";
            this.radioButtonPorCuenta.Size = new System.Drawing.Size(177, 18);
            this.radioButtonPorCuenta.TabIndex = 2;
            this.radioButtonPorCuenta.TabStop = true;
            this.radioButtonPorCuenta.Text = "Cuenta Contable(no lo muestro)";
            this.radioButtonPorCuenta.UseVisualStyleBackColor = true;
            this.radioButtonPorCuenta.Visible = false;
            // 
            // radioButtonPorMedicamentos
            // 
            this.radioButtonPorMedicamentos.AutoSize = true;
            this.radioButtonPorMedicamentos.Location = new System.Drawing.Point(349, 19);
            this.radioButtonPorMedicamentos.Name = "radioButtonPorMedicamentos";
            this.radioButtonPorMedicamentos.Size = new System.Drawing.Size(74, 18);
            this.radioButtonPorMedicamentos.TabIndex = 1;
            this.radioButtonPorMedicamentos.Text = "No se usa";
            this.radioButtonPorMedicamentos.UseVisualStyleBackColor = true;
            this.radioButtonPorMedicamentos.Visible = false;
            // 
            // radioButtonPorRubro
            // 
            this.radioButtonPorRubro.AutoSize = true;
            this.radioButtonPorRubro.Location = new System.Drawing.Point(247, 12);
            this.radioButtonPorRubro.Name = "radioButtonPorRubro";
            this.radioButtonPorRubro.Size = new System.Drawing.Size(113, 18);
            this.radioButtonPorRubro.TabIndex = 0;
            this.radioButtonPorRubro.Text = "Rubro (no se usa)";
            this.radioButtonPorRubro.UseVisualStyleBackColor = true;
            this.radioButtonPorRubro.Visible = false;
            // 
            // radioButtonDetallado
            // 
            this.radioButtonDetallado.AutoSize = true;
            this.radioButtonDetallado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radioButtonDetallado.Location = new System.Drawing.Point(265, 220);
            this.radioButtonDetallado.Name = "radioButtonDetallado";
            this.radioButtonDetallado.Size = new System.Drawing.Size(75, 18);
            this.radioButtonDetallado.TabIndex = 7;
            this.radioButtonDetallado.Text = "Detallado";
            this.radioButtonDetallado.UseVisualStyleBackColor = true;
            this.radioButtonDetallado.CheckedChanged += new System.EventHandler(this.radioButtonDetallado_CheckedChanged);
            // 
            // radioButtonSintetico
            // 
            this.radioButtonSintetico.AutoSize = true;
            this.radioButtonSintetico.Checked = true;
            this.radioButtonSintetico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radioButtonSintetico.Location = new System.Drawing.Point(73, 220);
            this.radioButtonSintetico.Name = "radioButtonSintetico";
            this.radioButtonSintetico.Size = new System.Drawing.Size(73, 18);
            this.radioButtonSintetico.TabIndex = 6;
            this.radioButtonSintetico.TabStop = true;
            this.radioButtonSintetico.Text = "Sintético";
            this.radioButtonSintetico.UseVisualStyleBackColor = true;
            this.radioButtonSintetico.CheckedChanged += new System.EventHandler(this.radioButtonSintetico_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Contable Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Contable Desde:";
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeHasta.Location = new System.Drawing.Point(152, 57);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(99, 20);
            this.dateTimeHasta.TabIndex = 1;
            this.dateTimeHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimeHasta_KeyDown);
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDesde.Location = new System.Drawing.Point(152, 21);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(99, 20);
            this.dateTimeDesde.TabIndex = 0;
            this.dateTimeDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimeDesde_KeyDown);
            // 
            // Frm_CierreCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 360);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripEvents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CierreCompras";
            this.Tag = "1";
            this.Text = "Imputaciones de Compras";
            this.Load += new System.EventHandler(this.CierreCompras_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDetallado;
        private System.Windows.Forms.RadioButton radioButtonSintetico;
        private System.Windows.Forms.TextBox textBoxPorcentDistrib;
        private System.Windows.Forms.Label labelDistribucion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.RadioButton radioButtonPorCuenta;
        private System.Windows.Forms.RadioButton radioButtonPorMedicamentos;
        private System.Windows.Forms.RadioButton radioButtonPorRubro;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonSindistribucion;
        private System.Windows.Forms.RadioButton radioButtonCondistribución;
        private System.Windows.Forms.CheckBox checkBoxEnviaInforme;
    }
}