namespace StaCatalina.Forms
{
    partial class Frm_InformeRequerimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_InformeRequerimientos));
            this.dateTimePickerFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStripEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerFechaDesde
            // 
            this.dateTimePickerFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaDesde.Location = new System.Drawing.Point(165, 43);
            this.dateTimePickerFechaDesde.Name = "dateTimePickerFechaDesde";
            this.dateTimePickerFechaDesde.Size = new System.Drawing.Size(125, 20);
            this.dateTimePickerFechaDesde.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha Autorización Desde";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxNroReq);
            this.panel1.Controls.Add(this.radioButtonPorNro);
            this.panel1.Controls.Add(this.radioButtonSectorUnico);
            this.panel1.Controls.Add(this.radioButtonPendientes);
            this.panel1.Controls.Add(this.radioButtonAnulados);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.radioButtonRechazados);
            this.panel1.Controls.Add(this.radioButtonAutorizados);
            this.panel1.Controls.Add(this.radioButtonTodo);
            this.panel1.Controls.Add(this.dateTimePickerFechaHasta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePickerFechaDesde);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.toolStripEvents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 365);
            this.panel1.TabIndex = 2;
            // 
            // textBoxNroReq
            // 
            this.textBoxNroReq.Location = new System.Drawing.Point(259, 266);
            this.textBoxNroReq.Name = "textBoxNroReq";
            this.textBoxNroReq.Size = new System.Drawing.Size(100, 20);
            this.textBoxNroReq.TabIndex = 13;
            // 
            // radioButtonPorNro
            // 
            this.radioButtonPorNro.AutoSize = true;
            this.radioButtonPorNro.Location = new System.Drawing.Point(165, 266);
            this.radioButtonPorNro.Name = "radioButtonPorNro";
            this.radioButtonPorNro.Size = new System.Drawing.Size(87, 17);
            this.radioButtonPorNro.TabIndex = 12;
            this.radioButtonPorNro.TabStop = true;
            this.radioButtonPorNro.Text = "Por Nro.Req.";
            this.radioButtonPorNro.UseVisualStyleBackColor = true;
            this.radioButtonPorNro.CheckedChanged += new System.EventHandler(this.radioButtonPorNro_CheckedChanged);
            // 
            // radioButtonSectorUnico
            // 
            this.radioButtonSectorUnico.AutoSize = true;
            this.radioButtonSectorUnico.Location = new System.Drawing.Point(165, 243);
            this.radioButtonSectorUnico.Name = "radioButtonSectorUnico";
            this.radioButtonSectorUnico.Size = new System.Drawing.Size(188, 17);
            this.radioButtonSectorUnico.TabIndex = 11;
            this.radioButtonSectorUnico.TabStop = true;
            this.radioButtonSectorUnico.Text = "Unicamente mi sector (autorizante)";
            this.radioButtonSectorUnico.UseVisualStyleBackColor = true;
            // 
            // radioButtonPendientes
            // 
            this.radioButtonPendientes.AutoSize = true;
            this.radioButtonPendientes.Location = new System.Drawing.Point(165, 220);
            this.radioButtonPendientes.Name = "radioButtonPendientes";
            this.radioButtonPendientes.Size = new System.Drawing.Size(154, 17);
            this.radioButtonPendientes.TabIndex = 10;
            this.radioButtonPendientes.TabStop = true;
            this.radioButtonPendientes.Text = "Pendientes de Autorizacion";
            this.radioButtonPendientes.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnulados
            // 
            this.radioButtonAnulados.AutoSize = true;
            this.radioButtonAnulados.Location = new System.Drawing.Point(165, 197);
            this.radioButtonAnulados.Name = "radioButtonAnulados";
            this.radioButtonAnulados.Size = new System.Drawing.Size(69, 17);
            this.radioButtonAnulados.TabIndex = 8;
            this.radioButtonAnulados.TabStop = true;
            this.radioButtonAnulados.Text = "Anulados";
            this.radioButtonAnulados.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Requerimientos";
            // 
            // radioButtonRechazados
            // 
            this.radioButtonRechazados.AutoSize = true;
            this.radioButtonRechazados.Location = new System.Drawing.Point(165, 174);
            this.radioButtonRechazados.Name = "radioButtonRechazados";
            this.radioButtonRechazados.Size = new System.Drawing.Size(85, 17);
            this.radioButtonRechazados.TabIndex = 6;
            this.radioButtonRechazados.TabStop = true;
            this.radioButtonRechazados.Text = "Rechazados";
            this.radioButtonRechazados.UseVisualStyleBackColor = true;
            // 
            // radioButtonAutorizados
            // 
            this.radioButtonAutorizados.AutoSize = true;
            this.radioButtonAutorizados.Location = new System.Drawing.Point(165, 151);
            this.radioButtonAutorizados.Name = "radioButtonAutorizados";
            this.radioButtonAutorizados.Size = new System.Drawing.Size(217, 17);
            this.radioButtonAutorizados.TabIndex = 5;
            this.radioButtonAutorizados.TabStop = true;
            this.radioButtonAutorizados.Text = "Autorizados (toma fecha de autorización)";
            this.radioButtonAutorizados.UseVisualStyleBackColor = true;
            // 
            // radioButtonTodo
            // 
            this.radioButtonTodo.AutoSize = true;
            this.radioButtonTodo.Location = new System.Drawing.Point(165, 128);
            this.radioButtonTodo.Name = "radioButtonTodo";
            this.radioButtonTodo.Size = new System.Drawing.Size(55, 17);
            this.radioButtonTodo.TabIndex = 4;
            this.radioButtonTodo.TabStop = true;
            this.radioButtonTodo.Text = "Todos";
            this.radioButtonTodo.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFechaHasta
            // 
            this.dateTimePickerFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaHasta.Location = new System.Drawing.Point(165, 85);
            this.dateTimePickerFechaHasta.Name = "dateTimePickerFechaHasta";
            this.dateTimePickerFechaHasta.Size = new System.Drawing.Size(125, 20);
            this.dateTimePickerFechaHasta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Autorización Hasta";
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPrint,
            this.toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 315);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(445, 50);
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
            // Frm_InformeRequerimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(445, 365);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_InformeRequerimientos";
            this.Text = "Informe Estado de Requerimientos";
            this.Load += new System.EventHandler(this.Frm_InformeRequerimientos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonAnulados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonRechazados;
        private System.Windows.Forms.RadioButton radioButtonAutorizados;
        private System.Windows.Forms.RadioButton radioButtonTodo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.RadioButton radioButtonPendientes;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.RadioButton radioButtonSectorUnico;
        private System.Windows.Forms.TextBox textBoxNroReq;
        private System.Windows.Forms.RadioButton radioButtonPorNro;
    }
}
