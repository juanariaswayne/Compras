namespace StaCatalina.Forms
{
    partial class Frm_InformeOC
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_InformeOC));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxEGES = new System.Windows.Forms.CheckBox();
            this.checkBoxRSC = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxProveed = new System.Windows.Forms.ComboBox();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.radioButtonProveedor = new System.Windows.Forms.RadioButton();
            this.radioButtonCompleta = new System.Windows.Forms.RadioButton();
            this.radioButtonPendAuto = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.radioButtonAnulados = new System.Windows.Forms.RadioButton();
            this.radioButtonTodo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonAutorizados = new System.Windows.Forms.RadioButton();
            this.radioButtonRechazados = new System.Windows.Forms.RadioButton();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.checkBoxGSC = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStripEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha Desde";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.toolStripEvents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 433);
            this.panel1.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxGSC);
            this.groupBox2.Controls.Add(this.checkBoxEGES);
            this.groupBox2.Controls.Add(this.checkBoxRSC);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 68);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Empresa";
            // 
            // checkBoxEGES
            // 
            this.checkBoxEGES.AutoSize = true;
            this.checkBoxEGES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEGES.Location = new System.Drawing.Point(74, 33);
            this.checkBoxEGES.Name = "checkBoxEGES";
            this.checkBoxEGES.Size = new System.Drawing.Size(103, 17);
            this.checkBoxEGES.TabIndex = 10;
            this.checkBoxEGES.Text = "EGESAC S.A.";
            this.checkBoxEGES.UseVisualStyleBackColor = true;
            this.checkBoxEGES.CheckedChanged += new System.EventHandler(this.checkBoxEGES_CheckedChanged);
            this.checkBoxEGES.Click += new System.EventHandler(this.checkBoxEGES_Click);
            // 
            // checkBoxRSC
            // 
            this.checkBoxRSC.AutoSize = true;
            this.checkBoxRSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRSC.Location = new System.Drawing.Point(227, 33);
            this.checkBoxRSC.Name = "checkBoxRSC";
            this.checkBoxRSC.Size = new System.Drawing.Size(79, 17);
            this.checkBoxRSC.TabIndex = 11;
            this.checkBoxRSC.Text = "RSC S.A.";
            this.checkBoxRSC.UseVisualStyleBackColor = true;
            this.checkBoxRSC.CheckedChanged += new System.EventHandler(this.checkBoxRSC_CheckedChanged);
            this.checkBoxRSC.Click += new System.EventHandler(this.checkBoxRSC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxProveed);
            this.groupBox1.Controls.Add(this.labelProveedor);
            this.groupBox1.Controls.Add(this.radioButtonProveedor);
            this.groupBox1.Controls.Add(this.radioButtonCompleta);
            this.groupBox1.Controls.Add(this.radioButtonPendAuto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimeFechaDesde);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimeFechaHasta);
            this.groupBox1.Controls.Add(this.radioButtonAnulados);
            this.groupBox1.Controls.Add(this.radioButtonTodo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioButtonAutorizados);
            this.groupBox1.Controls.Add(this.radioButtonRechazados);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 309);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // comboBoxProveed
            // 
            this.comboBoxProveed.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxProveed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProveed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProveed.FormattingEnabled = true;
            this.comboBoxProveed.Location = new System.Drawing.Point(107, 268);
            this.comboBoxProveed.Name = "comboBoxProveed";
            this.comboBoxProveed.Size = new System.Drawing.Size(375, 21);
            this.comboBoxProveed.TabIndex = 14;
            this.comboBoxProveed.Visible = false;
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Location = new System.Drawing.Point(42, 271);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(59, 13);
            this.labelProveedor.TabIndex = 13;
            this.labelProveedor.Text = "Proveedor:";
            this.labelProveedor.Visible = false;
            // 
            // radioButtonProveedor
            // 
            this.radioButtonProveedor.AutoSize = true;
            this.radioButtonProveedor.Location = new System.Drawing.Point(192, 245);
            this.radioButtonProveedor.Name = "radioButtonProveedor";
            this.radioButtonProveedor.Size = new System.Drawing.Size(106, 17);
            this.radioButtonProveedor.TabIndex = 11;
            this.radioButtonProveedor.TabStop = true;
            this.radioButtonProveedor.Text = "De un Proveedor";
            this.radioButtonProveedor.UseVisualStyleBackColor = true;
            this.radioButtonProveedor.CheckedChanged += new System.EventHandler(this.radioButtonProveedor_CheckedChanged);
            // 
            // radioButtonCompleta
            // 
            this.radioButtonCompleta.AutoSize = true;
            this.radioButtonCompleta.Location = new System.Drawing.Point(192, 222);
            this.radioButtonCompleta.Name = "radioButtonCompleta";
            this.radioButtonCompleta.Size = new System.Drawing.Size(198, 17);
            this.radioButtonCompleta.TabIndex = 10;
            this.radioButtonCompleta.TabStop = true;
            this.radioButtonCompleta.Text = "Completas/Finalizadas Manualmente";
            this.radioButtonCompleta.UseVisualStyleBackColor = true;
            this.radioButtonCompleta.CheckedChanged += new System.EventHandler(this.radioButtonCompleta_CheckedChanged);
            // 
            // radioButtonPendAuto
            // 
            this.radioButtonPendAuto.AutoSize = true;
            this.radioButtonPendAuto.Location = new System.Drawing.Point(192, 200);
            this.radioButtonPendAuto.Name = "radioButtonPendAuto";
            this.radioButtonPendAuto.Size = new System.Drawing.Size(134, 17);
            this.radioButtonPendAuto.TabIndex = 9;
            this.radioButtonPendAuto.TabStop = true;
            this.radioButtonPendAuto.Text = "Pendiente Autorización";
            this.radioButtonPendAuto.UseVisualStyleBackColor = true;
            this.radioButtonPendAuto.CheckedChanged += new System.EventHandler(this.radioButtonPendAuto_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha Desde";
            // 
            // dateTimeFechaDesde
            // 
            this.dateTimeFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaDesde.Location = new System.Drawing.Point(181, 20);
            this.dateTimeFechaDesde.Name = "dateTimeFechaDesde";
            this.dateTimeFechaDesde.Size = new System.Drawing.Size(125, 20);
            this.dateTimeFechaDesde.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha Hasta";
            // 
            // dateTimeFechaHasta
            // 
            this.dateTimeFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaHasta.Location = new System.Drawing.Point(181, 58);
            this.dateTimeFechaHasta.Name = "dateTimeFechaHasta";
            this.dateTimeFechaHasta.Size = new System.Drawing.Size(125, 20);
            this.dateTimeFechaHasta.TabIndex = 3;
            // 
            // radioButtonAnulados
            // 
            this.radioButtonAnulados.AutoSize = true;
            this.radioButtonAnulados.Location = new System.Drawing.Point(192, 132);
            this.radioButtonAnulados.Name = "radioButtonAnulados";
            this.radioButtonAnulados.Size = new System.Drawing.Size(69, 17);
            this.radioButtonAnulados.TabIndex = 8;
            this.radioButtonAnulados.TabStop = true;
            this.radioButtonAnulados.Text = "Anuladas";
            this.radioButtonAnulados.UseVisualStyleBackColor = true;
            this.radioButtonAnulados.CheckedChanged += new System.EventHandler(this.radioButtonAnulados_CheckedChanged);
            // 
            // radioButtonTodo
            // 
            this.radioButtonTodo.AutoSize = true;
            this.radioButtonTodo.Checked = true;
            this.radioButtonTodo.Location = new System.Drawing.Point(192, 109);
            this.radioButtonTodo.Name = "radioButtonTodo";
            this.radioButtonTodo.Size = new System.Drawing.Size(55, 17);
            this.radioButtonTodo.TabIndex = 4;
            this.radioButtonTodo.TabStop = true;
            this.radioButtonTodo.Text = "Todas";
            this.radioButtonTodo.UseVisualStyleBackColor = true;
            this.radioButtonTodo.CheckedChanged += new System.EventHandler(this.radioButtonTodo_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ordenes de Compra";
            // 
            // radioButtonAutorizados
            // 
            this.radioButtonAutorizados.AutoSize = true;
            this.radioButtonAutorizados.Location = new System.Drawing.Point(192, 155);
            this.radioButtonAutorizados.Name = "radioButtonAutorizados";
            this.radioButtonAutorizados.Size = new System.Drawing.Size(80, 17);
            this.radioButtonAutorizados.TabIndex = 5;
            this.radioButtonAutorizados.TabStop = true;
            this.radioButtonAutorizados.Text = "Autorizadas";
            this.radioButtonAutorizados.UseVisualStyleBackColor = true;
            this.radioButtonAutorizados.CheckedChanged += new System.EventHandler(this.radioButtonAutorizados_CheckedChanged);
            // 
            // radioButtonRechazados
            // 
            this.radioButtonRechazados.AutoSize = true;
            this.radioButtonRechazados.Location = new System.Drawing.Point(192, 178);
            this.radioButtonRechazados.Name = "radioButtonRechazados";
            this.radioButtonRechazados.Size = new System.Drawing.Size(85, 17);
            this.radioButtonRechazados.TabIndex = 6;
            this.radioButtonRechazados.TabStop = true;
            this.radioButtonRechazados.Text = "Rechazadas";
            this.radioButtonRechazados.UseVisualStyleBackColor = true;
            this.radioButtonRechazados.CheckedChanged += new System.EventHandler(this.radioButtonRechazados_CheckedChanged);
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
            this.toolStripEvents.Size = new System.Drawing.Size(529, 50);
            this.toolStripEvents.TabIndex = 9;
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
            // checkBoxGSC
            // 
            this.checkBoxGSC.AutoSize = true;
            this.checkBoxGSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGSC.Location = new System.Drawing.Point(392, 33);
            this.checkBoxGSC.Name = "checkBoxGSC";
            this.checkBoxGSC.Size = new System.Drawing.Size(79, 17);
            this.checkBoxGSC.TabIndex = 12;
            this.checkBoxGSC.Text = "GSC S.A.";
            this.checkBoxGSC.UseVisualStyleBackColor = true;
            this.checkBoxGSC.CheckedChanged += new System.EventHandler(this.checkBoxGSC_CheckedChanged);
            // 
            // Frm_InformeOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(529, 433);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_InformeOC";
            this.Text = "Informe Ordenes de Compra";
            this.Load += new System.EventHandler(this.Frm_InformeOC_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
    
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonAnulados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonRechazados;
        private System.Windows.Forms.RadioButton radioButtonAutorizados;
        private System.Windows.Forms.RadioButton radioButtonTodo;
        private System.Windows.Forms.DateTimePicker dateTimeFechaHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeFechaDesde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.CheckBox checkBoxRSC;
        private System.Windows.Forms.CheckBox checkBoxEGES;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonPendAuto;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.RadioButton radioButtonCompleta;
        private System.Windows.Forms.RadioButton radioButtonProveedor;
        private System.Windows.Forms.ComboBox comboBoxProveed;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.CheckBox checkBoxGSC;
    }
}
