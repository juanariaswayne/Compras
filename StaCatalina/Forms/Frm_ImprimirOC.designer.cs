namespace StaCatalina.Forms
{
    partial class Frm_ImprimirOC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ImprimirOC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxProveed = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimeProveedHasta = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeProveedDesde = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxOCHasta = new System.Windows.Forms.TextBox();
            this.textBoxOCDesde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonProveedor = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.radioButtonPorFecha = new System.Windows.Forms.RadioButton();
            this.radioButtonPorOC = new System.Windows.Forms.RadioButton();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStripEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.toolStripEvents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 486);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxProveed);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.dateTimeProveedHasta);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.dateTimeProveedDesde);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 301);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(684, 100);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seleccione un Proveedor y un rango de fechas";
            // 
            // comboBoxProveed
            // 
            this.comboBoxProveed.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxProveed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProveed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProveed.FormattingEnabled = true;
            this.comboBoxProveed.Location = new System.Drawing.Point(81, 38);
            this.comboBoxProveed.Name = "comboBoxProveed";
            this.comboBoxProveed.Size = new System.Drawing.Size(375, 21);
            this.comboBoxProveed.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Proveedor:";
            // 
            // dateTimeProveedHasta
            // 
            this.dateTimeProveedHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeProveedHasta.Location = new System.Drawing.Point(557, 55);
            this.dateTimeProveedHasta.Name = "dateTimeProveedHasta";
            this.dateTimeProveedHasta.Size = new System.Drawing.Size(100, 20);
            this.dateTimeProveedHasta.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha Desde";
            // 
            // dateTimeProveedDesde
            // 
            this.dateTimeProveedDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeProveedDesde.Location = new System.Drawing.Point(557, 19);
            this.dateTimeProveedDesde.Name = "dateTimeProveedDesde";
            this.dateTimeProveedDesde.Size = new System.Drawing.Size(100, 20);
            this.dateTimeProveedDesde.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha Hasta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePickerFechaHasta);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dateTimePickerFechaDesde);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(684, 100);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingrese un rango de fechas";
            // 
            // dateTimePickerFechaHasta
            // 
            this.dateTimePickerFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaHasta.Location = new System.Drawing.Point(271, 61);
            this.dateTimePickerFechaHasta.Name = "dateTimePickerFechaHasta";
            this.dateTimePickerFechaHasta.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerFechaHasta.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha Desde";
            // 
            // dateTimePickerFechaDesde
            // 
            this.dateTimePickerFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaDesde.Location = new System.Drawing.Point(271, 25);
            this.dateTimePickerFechaDesde.Name = "dateTimePickerFechaDesde";
            this.dateTimePickerFechaDesde.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerFechaDesde.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Hasta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxOCHasta);
            this.groupBox2.Controls.Add(this.textBoxOCDesde);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 97);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingrese un valor para O.C. desde y O.C. hasta";
            // 
            // textBoxOCHasta
            // 
            this.textBoxOCHasta.Location = new System.Drawing.Point(275, 66);
            this.textBoxOCHasta.Name = "textBoxOCHasta";
            this.textBoxOCHasta.Size = new System.Drawing.Size(100, 20);
            this.textBoxOCHasta.TabIndex = 3;
            this.textBoxOCHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOCHasta_KeyPress);
            // 
            // textBoxOCDesde
            // 
            this.textBoxOCDesde.Location = new System.Drawing.Point(275, 30);
            this.textBoxOCDesde.Name = "textBoxOCDesde";
            this.textBoxOCDesde.Size = new System.Drawing.Size(100, 20);
            this.textBoxOCDesde.TabIndex = 2;
            this.textBoxOCDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOCDesde_KeyDown);
            this.textBoxOCDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOCDesde_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº de Orden de Compra Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nº de Orden de Compra Hasta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonProveedor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxEmpresa);
            this.groupBox1.Controls.Add(this.radioButtonPorFecha);
            this.groupBox1.Controls.Add(this.radioButtonPorOC);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 104);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opción General";
            // 
            // radioButtonProveedor
            // 
            this.radioButtonProveedor.AutoSize = true;
            this.radioButtonProveedor.Location = new System.Drawing.Point(507, 64);
            this.radioButtonProveedor.Name = "radioButtonProveedor";
            this.radioButtonProveedor.Size = new System.Drawing.Size(93, 17);
            this.radioButtonProveedor.TabIndex = 4;
            this.radioButtonProveedor.Text = "Por Proveedor";
            this.radioButtonProveedor.UseVisualStyleBackColor = true;
            this.radioButtonProveedor.CheckedChanged += new System.EventHandler(this.radioButtonProveedor_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccione una empresa";
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Location = new System.Drawing.Point(208, 20);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(157, 21);
            this.comboBoxEmpresa.TabIndex = 2;
            this.comboBoxEmpresa.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmpresa_SelectedIndexChanged);
            // 
            // radioButtonPorFecha
            // 
            this.radioButtonPorFecha.AutoSize = true;
            this.radioButtonPorFecha.Location = new System.Drawing.Point(326, 64);
            this.radioButtonPorFecha.Name = "radioButtonPorFecha";
            this.radioButtonPorFecha.Size = new System.Drawing.Size(71, 17);
            this.radioButtonPorFecha.TabIndex = 1;
            this.radioButtonPorFecha.Text = "Por fecha";
            this.radioButtonPorFecha.UseVisualStyleBackColor = true;
            this.radioButtonPorFecha.CheckedChanged += new System.EventHandler(this.radioButtonPorFecha_CheckedChanged);
            // 
            // radioButtonPorOC
            // 
            this.radioButtonPorOC.AutoSize = true;
            this.radioButtonPorOC.Checked = true;
            this.radioButtonPorOC.Location = new System.Drawing.Point(105, 64);
            this.radioButtonPorOC.Name = "radioButtonPorOC";
            this.radioButtonPorOC.Size = new System.Drawing.Size(126, 17);
            this.radioButtonPorOC.TabIndex = 0;
            this.radioButtonPorOC.TabStop = true;
            this.radioButtonPorOC.Text = "Por Orden de compra";
            this.radioButtonPorOC.UseVisualStyleBackColor = true;
            this.radioButtonPorOC.CheckedChanged += new System.EventHandler(this.radioButtonPorOC_CheckedChanged);
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPrint,
            this.toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 436);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(684, 50);
            this.toolStripEvents.TabIndex = 10;
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
            this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click_1);
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
            // Frm_ImprimirOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 486);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ImprimirOC";
            this.Text = "Imprimir Ordenes de Compra";
            this.Load += new System.EventHandler(this.Frm_ImprimirOC_Load_1);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDesde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxOCHasta;
        private System.Windows.Forms.TextBox textBoxOCDesde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonPorFecha;
        private System.Windows.Forms.RadioButton radioButtonPorOC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimeProveedHasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeProveedDesde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonProveedor;
        private System.Windows.Forms.ComboBox comboBoxProveed;
        private System.Windows.Forms.Label label8;
    }
}