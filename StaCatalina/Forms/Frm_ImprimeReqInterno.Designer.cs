namespace StaCatalina.Forms
{
    partial class Frm_ImprimeReqInterno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ImprimeReqInterno));
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNroReq = new System.Windows.Forms.TextBox();
            this.radioButtonPorNro = new System.Windows.Forms.RadioButton();
            this.radioButtonSectorUnico = new System.Windows.Forms.RadioButton();
            this.radioButtonPendientes = new System.Windows.Forms.RadioButton();
            this.radioButtonAnulados = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonRechazados = new System.Windows.Forms.RadioButton();
            this.radioButtonAutorizados = new System.Windows.Forms.RadioButton();
            this.radioButtonTodo = new System.Windows.Forms.RadioButton();
            this.dateTimePickerFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripEvents.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPrint,
            this.toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 334);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(739, 62);
            this.toolStripEvents.TabIndex = 10;
            this.toolStripEvents.Text = "toolStrip1";
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrint.Image")));
            this.toolStripButtonPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(118, 59);
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
            this.toolStripButtonClose.Size = new System.Drawing.Size(93, 59);
            this.toolStripButtonClose.Text = "Cerrar";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNroReq);
            this.groupBox1.Controls.Add(this.radioButtonPorNro);
            this.groupBox1.Controls.Add(this.radioButtonSectorUnico);
            this.groupBox1.Controls.Add(this.radioButtonPendientes);
            this.groupBox1.Controls.Add(this.radioButtonAnulados);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioButtonRechazados);
            this.groupBox1.Controls.Add(this.radioButtonAutorizados);
            this.groupBox1.Controls.Add(this.radioButtonTodo);
            this.groupBox1.Controls.Add(this.dateTimePickerFechaHasta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePickerFechaDesde);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 334);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // textBoxNroReq
            // 
            this.textBoxNroReq.Location = new System.Drawing.Point(440, 293);
            this.textBoxNroReq.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNroReq.Name = "textBoxNroReq";
            this.textBoxNroReq.Size = new System.Drawing.Size(132, 22);
            this.textBoxNroReq.TabIndex = 26;
            // 
            // radioButtonPorNro
            // 
            this.radioButtonPorNro.AutoSize = true;
            this.radioButtonPorNro.Location = new System.Drawing.Point(315, 293);
            this.radioButtonPorNro.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonPorNro.Name = "radioButtonPorNro";
            this.radioButtonPorNro.Size = new System.Drawing.Size(112, 21);
            this.radioButtonPorNro.TabIndex = 25;
            this.radioButtonPorNro.TabStop = true;
            this.radioButtonPorNro.Text = "Por Nro.Req.";
            this.radioButtonPorNro.UseVisualStyleBackColor = true;
            this.radioButtonPorNro.CheckedChanged += new System.EventHandler(this.radioButtonPorNro_CheckedChanged);
            // 
            // radioButtonSectorUnico
            // 
            this.radioButtonSectorUnico.AutoSize = true;
            this.radioButtonSectorUnico.Location = new System.Drawing.Point(315, 265);
            this.radioButtonSectorUnico.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSectorUnico.Name = "radioButtonSectorUnico";
            this.radioButtonSectorUnico.Size = new System.Drawing.Size(250, 21);
            this.radioButtonSectorUnico.TabIndex = 24;
            this.radioButtonSectorUnico.TabStop = true;
            this.radioButtonSectorUnico.Text = "Unicamente mi sector (autorizante)";
            this.radioButtonSectorUnico.UseVisualStyleBackColor = true;
            // 
            // radioButtonPendientes
            // 
            this.radioButtonPendientes.AutoSize = true;
            this.radioButtonPendientes.Location = new System.Drawing.Point(315, 237);
            this.radioButtonPendientes.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonPendientes.Name = "radioButtonPendientes";
            this.radioButtonPendientes.Size = new System.Drawing.Size(202, 21);
            this.radioButtonPendientes.TabIndex = 23;
            this.radioButtonPendientes.TabStop = true;
            this.radioButtonPendientes.Text = "Pendientes de Autorizacion";
            this.radioButtonPendientes.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnulados
            // 
            this.radioButtonAnulados.AutoSize = true;
            this.radioButtonAnulados.Location = new System.Drawing.Point(315, 208);
            this.radioButtonAnulados.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonAnulados.Name = "radioButtonAnulados";
            this.radioButtonAnulados.Size = new System.Drawing.Size(88, 21);
            this.radioButtonAnulados.TabIndex = 22;
            this.radioButtonAnulados.TabStop = true;
            this.radioButtonAnulados.Text = "Anulados";
            this.radioButtonAnulados.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Requerimientos";
            // 
            // radioButtonRechazados
            // 
            this.radioButtonRechazados.AutoSize = true;
            this.radioButtonRechazados.Location = new System.Drawing.Point(315, 180);
            this.radioButtonRechazados.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonRechazados.Name = "radioButtonRechazados";
            this.radioButtonRechazados.Size = new System.Drawing.Size(108, 21);
            this.radioButtonRechazados.TabIndex = 20;
            this.radioButtonRechazados.TabStop = true;
            this.radioButtonRechazados.Text = "Rechazados";
            this.radioButtonRechazados.UseVisualStyleBackColor = true;
            // 
            // radioButtonAutorizados
            // 
            this.radioButtonAutorizados.AutoSize = true;
            this.radioButtonAutorizados.Location = new System.Drawing.Point(315, 152);
            this.radioButtonAutorizados.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonAutorizados.Name = "radioButtonAutorizados";
            this.radioButtonAutorizados.Size = new System.Drawing.Size(289, 21);
            this.radioButtonAutorizados.TabIndex = 19;
            this.radioButtonAutorizados.TabStop = true;
            this.radioButtonAutorizados.Text = "Autorizados (toma fecha de autorización)";
            this.radioButtonAutorizados.UseVisualStyleBackColor = true;
            // 
            // radioButtonTodo
            // 
            this.radioButtonTodo.AutoSize = true;
            this.radioButtonTodo.Location = new System.Drawing.Point(315, 124);
            this.radioButtonTodo.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonTodo.Name = "radioButtonTodo";
            this.radioButtonTodo.Size = new System.Drawing.Size(69, 21);
            this.radioButtonTodo.TabIndex = 18;
            this.radioButtonTodo.TabStop = true;
            this.radioButtonTodo.Text = "Todos";
            this.radioButtonTodo.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFechaHasta
            // 
            this.dateTimePickerFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaHasta.Location = new System.Drawing.Point(315, 71);
            this.dateTimePickerFechaHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFechaHasta.Name = "dateTimePickerFechaHasta";
            this.dateTimePickerFechaHasta.Size = new System.Drawing.Size(165, 22);
            this.dateTimePickerFechaHasta.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fecha Autorización Hasta";
            // 
            // dateTimePickerFechaDesde
            // 
            this.dateTimePickerFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaDesde.Location = new System.Drawing.Point(315, 19);
            this.dateTimePickerFechaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFechaDesde.Name = "dateTimePickerFechaDesde";
            this.dateTimePickerFechaDesde.Size = new System.Drawing.Size(165, 22);
            this.dateTimePickerFechaDesde.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fecha Autorización Desde";
            // 
            // FrmImprimeReqInterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(739, 396);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripEvents);
            this.Name = "FrmImprimeReqInterno";
            this.Text = "Impresión de Requerimientos Interno";
            this.Load += new System.EventHandler(this.FrmImprimeReqInterno_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNroReq;
        private System.Windows.Forms.RadioButton radioButtonPorNro;
        private System.Windows.Forms.RadioButton radioButtonSectorUnico;
        private System.Windows.Forms.RadioButton radioButtonPendientes;
        private System.Windows.Forms.RadioButton radioButtonAnulados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonRechazados;
        private System.Windows.Forms.RadioButton radioButtonAutorizados;
        private System.Windows.Forms.RadioButton radioButtonTodo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDesde;
        private System.Windows.Forms.Label label1;
    }
}
