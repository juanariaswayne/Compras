namespace StaCatalina.Stock
{
    partial class Frm_InformeIngresoMercaderia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_InformeIngresoMercaderia));
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxOC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxProveed = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonProveed = new System.Windows.Forms.RadioButton();
            this.radioButtonOC = new System.Windows.Forms.RadioButton();
            this.radioButtonTodo = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButtonIncumplidas = new System.Windows.Forms.RadioButton();
            this.radioButtonParcialCumplida = new System.Windows.Forms.RadioButton();
            this.radioButtonTodosProveed = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.comboBoxcodEmp = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButtonPorFechaOC = new System.Windows.Forms.RadioButton();
            this.radioButtonPorFechaIngreso = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeFechaIngHasta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeFechaIngDesde = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDeposito = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStripEvents.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
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
            this.toolStripEvents.Location = new System.Drawing.Point(0, 383);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(783, 50);
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
            this.groupBox2.Controls.Add(this.textBoxOC);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBoxProveed);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 85);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // textBoxOC
            // 
            this.textBoxOC.Location = new System.Drawing.Point(166, 18);
            this.textBoxOC.Name = "textBoxOC";
            this.textBoxOC.Size = new System.Drawing.Size(131, 20);
            this.textBoxOC.TabIndex = 34;
            this.textBoxOC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOC_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Proveedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Orden Compra Nro.:";
            // 
            // comboBoxProveed
            // 
            this.comboBoxProveed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxProveed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProveed.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxProveed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProveed.FormattingEnabled = true;
            this.comboBoxProveed.Location = new System.Drawing.Point(166, 49);
            this.comboBoxProveed.Name = "comboBoxProveed";
            this.comboBoxProveed.Size = new System.Drawing.Size(499, 21);
            this.comboBoxProveed.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.comboBoxcodEmp);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(783, 127);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // radioButtonProveed
            // 
            this.radioButtonProveed.AutoSize = true;
            this.radioButtonProveed.Location = new System.Drawing.Point(45, 74);
            this.radioButtonProveed.Name = "radioButtonProveed";
            this.radioButtonProveed.Size = new System.Drawing.Size(91, 17);
            this.radioButtonProveed.TabIndex = 29;
            this.radioButtonProveed.Text = "Un Proveedor";
            this.radioButtonProveed.UseVisualStyleBackColor = true;
            this.radioButtonProveed.CheckedChanged += new System.EventHandler(this.radioButtonProveed_CheckedChanged);
            // 
            // radioButtonOC
            // 
            this.radioButtonOC.AutoSize = true;
            this.radioButtonOC.Location = new System.Drawing.Point(45, 44);
            this.radioButtonOC.Name = "radioButtonOC";
            this.radioButtonOC.Size = new System.Drawing.Size(131, 17);
            this.radioButtonOC.TabIndex = 27;
            this.radioButtonOC.Text = "Una Orden de Compra";
            this.radioButtonOC.UseVisualStyleBackColor = true;
            this.radioButtonOC.CheckedChanged += new System.EventHandler(this.radioButtonOC_CheckedChanged);
            // 
            // radioButtonTodo
            // 
            this.radioButtonTodo.AutoSize = true;
            this.radioButtonTodo.Checked = true;
            this.radioButtonTodo.Location = new System.Drawing.Point(45, 19);
            this.radioButtonTodo.Name = "radioButtonTodo";
            this.radioButtonTodo.Size = new System.Drawing.Size(50, 17);
            this.radioButtonTodo.TabIndex = 25;
            this.radioButtonTodo.TabStop = true;
            this.radioButtonTodo.Text = "Todo";
            this.radioButtonTodo.UseVisualStyleBackColor = true;
            this.radioButtonTodo.CheckedChanged += new System.EventHandler(this.radioButtonTodo_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButtonIncumplidas);
            this.groupBox5.Controls.Add(this.radioButtonParcialCumplida);
            this.groupBox5.Controls.Add(this.radioButtonTodosProveed);
            this.groupBox5.ForeColor = System.Drawing.Color.Blue;
            this.groupBox5.Location = new System.Drawing.Point(599, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(172, 95);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mostrar";
            // 
            // radioButtonIncumplidas
            // 
            this.radioButtonIncumplidas.AutoSize = true;
            this.radioButtonIncumplidas.Location = new System.Drawing.Point(30, 71);
            this.radioButtonIncumplidas.Name = "radioButtonIncumplidas";
            this.radioButtonIncumplidas.Size = new System.Drawing.Size(83, 17);
            this.radioButtonIncumplidas.TabIndex = 16;
            this.radioButtonIncumplidas.Text = "Inclumplidas";
            this.radioButtonIncumplidas.UseVisualStyleBackColor = true;
            // 
            // radioButtonParcialCumplida
            // 
            this.radioButtonParcialCumplida.AutoSize = true;
            this.radioButtonParcialCumplida.Location = new System.Drawing.Point(30, 48);
            this.radioButtonParcialCumplida.Name = "radioButtonParcialCumplida";
            this.radioButtonParcialCumplida.Size = new System.Drawing.Size(132, 17);
            this.radioButtonParcialCumplida.TabIndex = 15;
            this.radioButtonParcialCumplida.Text = "Parcialmente Cumplido";
            this.radioButtonParcialCumplida.UseVisualStyleBackColor = true;
            // 
            // radioButtonTodosProveed
            // 
            this.radioButtonTodosProveed.AutoSize = true;
            this.radioButtonTodosProveed.Checked = true;
            this.radioButtonTodosProveed.Location = new System.Drawing.Point(30, 25);
            this.radioButtonTodosProveed.Name = "radioButtonTodosProveed";
            this.radioButtonTodosProveed.Size = new System.Drawing.Size(55, 17);
            this.radioButtonTodosProveed.TabIndex = 14;
            this.radioButtonTodosProveed.TabStop = true;
            this.radioButtonTodosProveed.Text = "Todos";
            this.radioButtonTodosProveed.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fecha Autorización O.C. Desde:";
            // 
            // dateTimeFechaDesde
            // 
            this.dateTimeFechaDesde.Enabled = false;
            this.dateTimeFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaDesde.Location = new System.Drawing.Point(579, 26);
            this.dateTimeFechaDesde.Name = "dateTimeFechaDesde";
            this.dateTimeFechaDesde.Size = new System.Drawing.Size(99, 20);
            this.dateTimeFechaDesde.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fecha Autorización O.C. Hasta:";
            // 
            // dateTimeFechaHasta
            // 
            this.dateTimeFechaHasta.Enabled = false;
            this.dateTimeFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaHasta.Location = new System.Drawing.Point(579, 54);
            this.dateTimeFechaHasta.Name = "dateTimeFechaHasta";
            this.dateTimeFechaHasta.Size = new System.Drawing.Size(99, 20);
            this.dateTimeFechaHasta.TabIndex = 22;
            // 
            // comboBoxcodEmp
            // 
            this.comboBoxcodEmp.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxcodEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxcodEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxcodEmp.FormattingEnabled = true;
            this.comboBoxcodEmp.Items.AddRange(new object[] {
            "EGESAC S.A.",
            "RSC S.A."});
            this.comboBoxcodEmp.Location = new System.Drawing.Point(12, 19);
            this.comboBoxcodEmp.Name = "comboBoxcodEmp";
            this.comboBoxcodEmp.Size = new System.Drawing.Size(41, 21);
            this.comboBoxcodEmp.TabIndex = 15;
            this.comboBoxcodEmp.Visible = false;
            this.comboBoxcodEmp.SelectedIndexChanged += new System.EventHandler(this.comboBoxcodEmp_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxDeposito);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimeFechaIngHasta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimeFechaIngDesde);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimeFechaHasta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimeFechaDesde);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 134);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonTodo);
            this.groupBox4.Controls.Add(this.radioButtonProveed);
            this.groupBox4.Controls.Add(this.radioButtonOC);
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(65, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informe";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButtonPorFechaIngreso);
            this.groupBox6.Controls.Add(this.radioButtonPorFechaOC);
            this.groupBox6.ForeColor = System.Drawing.Color.Blue;
            this.groupBox6.Location = new System.Drawing.Point(306, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(251, 100);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Fecha";
            // 
            // radioButtonPorFechaOC
            // 
            this.radioButtonPorFechaOC.AutoSize = true;
            this.radioButtonPorFechaOC.Location = new System.Drawing.Point(47, 71);
            this.radioButtonPorFechaOC.Name = "radioButtonPorFechaOC";
            this.radioButtonPorFechaOC.Size = new System.Drawing.Size(113, 17);
            this.radioButtonPorFechaOC.TabIndex = 0;
            this.radioButtonPorFechaOC.Text = "Por Fecha de O.C.";
            this.radioButtonPorFechaOC.UseVisualStyleBackColor = true;
            this.radioButtonPorFechaOC.CheckedChanged += new System.EventHandler(this.radioButtonPorFechaOC_CheckedChanged);
            // 
            // radioButtonPorFechaIngreso
            // 
            this.radioButtonPorFechaIngreso.AutoSize = true;
            this.radioButtonPorFechaIngreso.Checked = true;
            this.radioButtonPorFechaIngreso.Location = new System.Drawing.Point(47, 31);
            this.radioButtonPorFechaIngreso.Name = "radioButtonPorFechaIngreso";
            this.radioButtonPorFechaIngreso.Size = new System.Drawing.Size(173, 17);
            this.radioButtonPorFechaIngreso.TabIndex = 1;
            this.radioButtonPorFechaIngreso.TabStop = true;
            this.radioButtonPorFechaIngreso.Text = "Por Fecha de Ingreso de Stock";
            this.radioButtonPorFechaIngreso.UseVisualStyleBackColor = true;
            this.radioButtonPorFechaIngreso.CheckedChanged += new System.EventHandler(this.radioButtonPorFechaIngreso_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Fecha Ingreso Desde:";
            // 
            // dateTimeFechaIngHasta
            // 
            this.dateTimeFechaIngHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaIngHasta.Location = new System.Drawing.Point(201, 54);
            this.dateTimeFechaIngHasta.Name = "dateTimeFechaIngHasta";
            this.dateTimeFechaIngHasta.Size = new System.Drawing.Size(99, 20);
            this.dateTimeFechaIngHasta.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Fecha Ingreso Hasta:";
            // 
            // dateTimeFechaIngDesde
            // 
            this.dateTimeFechaIngDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaIngDesde.Location = new System.Drawing.Point(201, 26);
            this.dateTimeFechaIngDesde.Name = "dateTimeFechaIngDesde";
            this.dateTimeFechaIngDesde.Size = new System.Drawing.Size(99, 20);
            this.dateTimeFechaIngDesde.TabIndex = 23;
            // 
            // comboBoxDeposito
            // 
            this.comboBoxDeposito.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDeposito.FormattingEnabled = true;
            this.comboBoxDeposito.Location = new System.Drawing.Point(201, 94);
            this.comboBoxDeposito.Name = "comboBoxDeposito";
            this.comboBoxDeposito.Size = new System.Drawing.Size(477, 21);
            this.comboBoxDeposito.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Depósito";
            // 
            // Frm_InformeIngresoMercaderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(783, 433);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStripEvents);
            this.Name = "Frm_InformeIngresoMercaderia";
            this.Text = "Ingreso de Mercadería Por Orden de Compra";
            this.Load += new System.EventHandler(this.Frm_InformeIngresoMercaderia_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxProveed;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxcodEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeFechaDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeFechaHasta;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButtonIncumplidas;
        private System.Windows.Forms.RadioButton radioButtonParcialCumplida;
        private System.Windows.Forms.RadioButton radioButtonTodosProveed;
        private System.Windows.Forms.RadioButton radioButtonProveed;
        private System.Windows.Forms.RadioButton radioButtonOC;
        private System.Windows.Forms.RadioButton radioButtonTodo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOC;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButtonPorFechaIngreso;
        private System.Windows.Forms.RadioButton radioButtonPorFechaOC;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeFechaIngHasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeFechaIngDesde;
        private System.Windows.Forms.ComboBox comboBoxDeposito;
        private System.Windows.Forms.Label label6;
    }
}
