namespace StaCatalina.Forms
{
    partial class Frm_InformeTrazabilidadOcReq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_InformeTrazabilidadOcReq));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxReq = new System.Windows.Forms.TextBox();
            this.textBoxOC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.radioButtonPorReq = new System.Windows.Forms.RadioButton();
            this.radioButtonPorOC = new System.Windows.Forms.RadioButton();
            this.radioButtonFechas = new System.Windows.Forms.RadioButton();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSubRubro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRubro = new System.Windows.Forms.ComboBox();
            this.radioButtonPorRubro = new System.Windows.Forms.RadioButton();
            this.radioButtonPorSubRubro = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.toolStripEvents.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxReq);
            this.groupBox1.Controls.Add(this.textBoxOC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerHasta);
            this.groupBox1.Controls.Add(this.dateTimePickerDesde);
            this.groupBox1.Controls.Add(this.radioButtonPorReq);
            this.groupBox1.Controls.Add(this.radioButtonPorOC);
            this.groupBox1.Controls.Add(this.radioButtonFechas);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 184);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trazabilidad entre Requerimiento y Orden de Compra";
            // 
            // textBoxReq
            // 
            this.textBoxReq.Location = new System.Drawing.Point(148, 146);
            this.textBoxReq.Name = "textBoxReq";
            this.textBoxReq.Size = new System.Drawing.Size(100, 20);
            this.textBoxReq.TabIndex = 11;
            // 
            // textBoxOC
            // 
            this.textBoxOC.Location = new System.Drawing.Point(148, 115);
            this.textBoxOC.Name = "textBoxOC";
            this.textBoxOC.Size = new System.Drawing.Size(100, 20);
            this.textBoxOC.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Desde";
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHasta.Location = new System.Drawing.Point(206, 64);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerHasta.TabIndex = 7;
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDesde.Location = new System.Drawing.Point(61, 64);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerDesde.TabIndex = 6;
            // 
            // radioButtonPorReq
            // 
            this.radioButtonPorReq.AutoSize = true;
            this.radioButtonPorReq.Location = new System.Drawing.Point(15, 149);
            this.radioButtonPorReq.Name = "radioButtonPorReq";
            this.radioButtonPorReq.Size = new System.Drawing.Size(112, 17);
            this.radioButtonPorReq.TabIndex = 5;
            this.radioButtonPorReq.Text = "Por Requerimiento";
            this.radioButtonPorReq.UseVisualStyleBackColor = true;
            this.radioButtonPorReq.CheckedChanged += new System.EventHandler(this.radioButtonPorReq_CheckedChanged);
            // 
            // radioButtonPorOC
            // 
            this.radioButtonPorOC.AutoSize = true;
            this.radioButtonPorOC.Location = new System.Drawing.Point(15, 115);
            this.radioButtonPorOC.Name = "radioButtonPorOC";
            this.radioButtonPorOC.Size = new System.Drawing.Size(127, 17);
            this.radioButtonPorOC.TabIndex = 4;
            this.radioButtonPorOC.Text = "Por Orden de Compra";
            this.radioButtonPorOC.UseVisualStyleBackColor = true;
            this.radioButtonPorOC.CheckedChanged += new System.EventHandler(this.radioButtonPorOC_CheckedChanged);
            // 
            // radioButtonFechas
            // 
            this.radioButtonFechas.AutoSize = true;
            this.radioButtonFechas.Checked = true;
            this.radioButtonFechas.Location = new System.Drawing.Point(15, 31);
            this.radioButtonFechas.Name = "radioButtonFechas";
            this.radioButtonFechas.Size = new System.Drawing.Size(175, 17);
            this.radioButtonFechas.TabIndex = 0;
            this.radioButtonFechas.TabStop = true;
            this.radioButtonFechas.Text = "Entre Fechas (de requerimiento)";
            this.radioButtonFechas.UseVisualStyleBackColor = true;
            this.radioButtonFechas.CheckedChanged += new System.EventHandler(this.radioButtonFechas_CheckedChanged);
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPrint,
            this.toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 317);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(594, 50);
            this.toolStripEvents.TabIndex = 13;
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
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonPorSubRubro);
            this.groupBox2.Controls.Add(this.radioButtonPorRubro);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxSubRubro);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBoxRubro);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 130);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Sub Rubro:";
            // 
            // comboBoxSubRubro
            // 
            this.comboBoxSubRubro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxSubRubro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSubRubro.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxSubRubro.Enabled = false;
            this.comboBoxSubRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSubRubro.FormattingEnabled = true;
            this.comboBoxSubRubro.Location = new System.Drawing.Point(247, 64);
            this.comboBoxSubRubro.Name = "comboBoxSubRubro";
            this.comboBoxSubRubro.Size = new System.Drawing.Size(321, 21);
            this.comboBoxSubRubro.TabIndex = 27;
            this.comboBoxSubRubro.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubRubro_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Rubro:";
            // 
            // comboBoxRubro
            // 
            this.comboBoxRubro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxRubro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxRubro.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRubro.FormattingEnabled = true;
            this.comboBoxRubro.Location = new System.Drawing.Point(247, 29);
            this.comboBoxRubro.Name = "comboBoxRubro";
            this.comboBoxRubro.Size = new System.Drawing.Size(321, 21);
            this.comboBoxRubro.TabIndex = 25;
            this.comboBoxRubro.SelectedIndexChanged += new System.EventHandler(this.comboBoxRubro_SelectedIndexChanged);
            // 
            // radioButtonPorRubro
            // 
            this.radioButtonPorRubro.AutoSize = true;
            this.radioButtonPorRubro.Checked = true;
            this.radioButtonPorRubro.Location = new System.Drawing.Point(16, 28);
            this.radioButtonPorRubro.Name = "radioButtonPorRubro";
            this.radioButtonPorRubro.Size = new System.Drawing.Size(73, 17);
            this.radioButtonPorRubro.TabIndex = 29;
            this.radioButtonPorRubro.TabStop = true;
            this.radioButtonPorRubro.Text = "Por Rubro";
            this.radioButtonPorRubro.UseVisualStyleBackColor = true;
            this.radioButtonPorRubro.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonPorSubRubro
            // 
            this.radioButtonPorSubRubro.AutoSize = true;
            this.radioButtonPorSubRubro.Location = new System.Drawing.Point(16, 63);
            this.radioButtonPorSubRubro.Name = "radioButtonPorSubRubro";
            this.radioButtonPorSubRubro.Size = new System.Drawing.Size(92, 17);
            this.radioButtonPorSubRubro.TabIndex = 30;
            this.radioButtonPorSubRubro.Text = "Por SubRubro";
            this.radioButtonPorSubRubro.UseVisualStyleBackColor = true;
            this.radioButtonPorSubRubro.CheckedChanged += new System.EventHandler(this.radioButtonPorSubRubro_CheckedChanged);
            // 
            // Frm_InformeTrazabilidadOcReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 367);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStripEvents);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_InformeTrazabilidadOcReq";
            this.Text = "Informe de Trazabilidad";
            this.Load += new System.EventHandler(this.Frm_InformeTrazabilidadOcReq_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxReq;
        private System.Windows.Forms.TextBox textBoxOC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.RadioButton radioButtonPorReq;
        private System.Windows.Forms.RadioButton radioButtonPorOC;
        private System.Windows.Forms.RadioButton radioButtonFechas;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSubRubro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxRubro;
        private System.Windows.Forms.RadioButton radioButtonPorSubRubro;
        private System.Windows.Forms.RadioButton radioButtonPorRubro;
    }
}