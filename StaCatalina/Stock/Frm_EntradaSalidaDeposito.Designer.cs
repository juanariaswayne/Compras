namespace StaCatalina.Stock
{
    partial class Frm_EntradaSalidaDeposito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EntradaSalidaDeposito));
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDeposito = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonArticulo = new System.Windows.Forms.RadioButton();
            this.radioButtonSubRubro = new System.Windows.Forms.RadioButton();
            this.radioButtonRubro = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxArticulo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSubRubro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRubro = new System.Windows.Forms.ComboBox();
            this.checkBoxInicial = new System.Windows.Forms.CheckBox();
            this.toolStripEvents.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPrint,
            this.toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 471);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripEvents.Size = new System.Drawing.Size(1018, 77);
            this.toolStripEvents.TabIndex = 19;
            this.toolStripEvents.Text = "toolStrip1";
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrint.Image")));
            this.toolStripButtonPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(132, 74);
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
            this.toolStripButtonClose.Size = new System.Drawing.Size(103, 74);
            this.toolStripButtonClose.Text = "Cerrar";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxInicial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimeFechaHasta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimeFechaDesde);
            this.groupBox1.Controls.Add(this.comboBoxDeposito);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.radioButtonTodos);
            this.groupBox1.Controls.Add(this.radioButtonArticulo);
            this.groupBox1.Controls.Add(this.radioButtonSubRubro);
            this.groupBox1.Controls.Add(this.radioButtonRubro);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1018, 237);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Depósito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Fecha Desde:";
            // 
            // dateTimeFechaHasta
            // 
            this.dateTimeFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaHasta.Location = new System.Drawing.Point(614, 38);
            this.dateTimeFechaHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimeFechaHasta.Name = "dateTimeFechaHasta";
            this.dateTimeFechaHasta.Size = new System.Drawing.Size(146, 26);
            this.dateTimeFechaHasta.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Fecha Hasta:";
            // 
            // dateTimeFechaDesde
            // 
            this.dateTimeFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaDesde.Location = new System.Drawing.Point(322, 38);
            this.dateTimeFechaDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimeFechaDesde.Name = "dateTimeFechaDesde";
            this.dateTimeFechaDesde.Size = new System.Drawing.Size(146, 26);
            this.dateTimeFechaDesde.TabIndex = 31;
            // 
            // comboBoxDeposito
            // 
            this.comboBoxDeposito.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDeposito.FormattingEnabled = true;
            this.comboBoxDeposito.Location = new System.Drawing.Point(195, 166);
            this.comboBoxDeposito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDeposito.Name = "comboBoxDeposito";
            this.comboBoxDeposito.Size = new System.Drawing.Size(714, 28);
            this.comboBoxDeposito.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Depósito";
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(748, 103);
            this.radioButtonTodos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(165, 24);
            this.radioButtonTodos.TabIndex = 15;
            this.radioButtonTodos.Text = "Todos los artículos";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            this.radioButtonTodos.CheckedChanged += new System.EventHandler(this.radioButtonTodos_CheckedChanged);
            // 
            // radioButtonArticulo
            // 
            this.radioButtonArticulo.AutoSize = true;
            this.radioButtonArticulo.Location = new System.Drawing.Point(480, 103);
            this.radioButtonArticulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonArticulo.Name = "radioButtonArticulo";
            this.radioButtonArticulo.Size = new System.Drawing.Size(110, 24);
            this.radioButtonArticulo.TabIndex = 14;
            this.radioButtonArticulo.Text = "Un artículo";
            this.radioButtonArticulo.UseVisualStyleBackColor = true;
            this.radioButtonArticulo.CheckedChanged += new System.EventHandler(this.radioButtonArticulo_CheckedChanged);
            // 
            // radioButtonSubRubro
            // 
            this.radioButtonSubRubro.AutoSize = true;
            this.radioButtonSubRubro.Location = new System.Drawing.Point(266, 103);
            this.radioButtonSubRubro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonSubRubro.Name = "radioButtonSubRubro";
            this.radioButtonSubRubro.Size = new System.Drawing.Size(139, 24);
            this.radioButtonSubRubro.TabIndex = 13;
            this.radioButtonSubRubro.Text = "Por Sub Rubro";
            this.radioButtonSubRubro.UseVisualStyleBackColor = true;
            this.radioButtonSubRubro.CheckedChanged += new System.EventHandler(this.radioButtonSubRubro_CheckedChanged);
            // 
            // radioButtonRubro
            // 
            this.radioButtonRubro.AutoSize = true;
            this.radioButtonRubro.Checked = true;
            this.radioButtonRubro.Location = new System.Drawing.Point(74, 103);
            this.radioButtonRubro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonRubro.Name = "radioButtonRubro";
            this.radioButtonRubro.Size = new System.Drawing.Size(106, 24);
            this.radioButtonRubro.TabIndex = 12;
            this.radioButtonRubro.TabStop = true;
            this.radioButtonRubro.Text = "Por Rubro";
            this.radioButtonRubro.UseVisualStyleBackColor = true;
            this.radioButtonRubro.CheckedChanged += new System.EventHandler(this.radioButtonRubro_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBoxArticulo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxSubRubro);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxRubro);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 237);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1018, 223);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Articulo:";
            // 
            // comboBoxArticulo
            // 
            this.comboBoxArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxArticulo.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxArticulo.FormattingEnabled = true;
            this.comboBoxArticulo.Location = new System.Drawing.Point(195, 137);
            this.comboBoxArticulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxArticulo.Name = "comboBoxArticulo";
            this.comboBoxArticulo.Size = new System.Drawing.Size(646, 28);
            this.comboBoxArticulo.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sub Rubro:";
            // 
            // comboBoxSubRubro
            // 
            this.comboBoxSubRubro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxSubRubro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSubRubro.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxSubRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSubRubro.FormattingEnabled = true;
            this.comboBoxSubRubro.Location = new System.Drawing.Point(195, 83);
            this.comboBoxSubRubro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSubRubro.Name = "comboBoxSubRubro";
            this.comboBoxSubRubro.Size = new System.Drawing.Size(456, 28);
            this.comboBoxSubRubro.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Rubro:";
            // 
            // comboBoxRubro
            // 
            this.comboBoxRubro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxRubro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxRubro.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRubro.FormattingEnabled = true;
            this.comboBoxRubro.Location = new System.Drawing.Point(195, 29);
            this.comboBoxRubro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxRubro.Name = "comboBoxRubro";
            this.comboBoxRubro.Size = new System.Drawing.Size(456, 28);
            this.comboBoxRubro.TabIndex = 21;
            // 
            // checkBoxInicial
            // 
            this.checkBoxInicial.AutoSize = true;
            this.checkBoxInicial.ForeColor = System.Drawing.Color.Red;
            this.checkBoxInicial.Location = new System.Drawing.Point(810, 39);
            this.checkBoxInicial.Name = "checkBoxInicial";
            this.checkBoxInicial.Size = new System.Drawing.Size(193, 24);
            this.checkBoxInicial.TabIndex = 35;
            this.checkBoxInicial.Text = "Solo Mov. Stock Inicial";
            this.checkBoxInicial.UseVisualStyleBackColor = true;
            // 
            // Frm_EntradaSalidaDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1018, 548);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripEvents);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Frm_EntradaSalidaDeposito";
            this.Text = "Movimiento de Stock";
            this.Load += new System.EventHandler(this.Frm_EntradaSalidaDeposito_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonArticulo;
        private System.Windows.Forms.RadioButton radioButtonSubRubro;
        private System.Windows.Forms.RadioButton radioButtonRubro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxArticulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSubRubro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRubro;
        private System.Windows.Forms.ComboBox comboBoxDeposito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeFechaHasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeFechaDesde;
        private System.Windows.Forms.CheckBox checkBoxInicial;
    }
}
