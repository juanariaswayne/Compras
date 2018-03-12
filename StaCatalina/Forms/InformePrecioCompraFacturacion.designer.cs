namespace StaCatalina.Forms
{
    partial class InformePrecioCompraFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformePrecioCompraFacturacion));
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxAnio = new System.Windows.Forms.TextBox();
            this.textBoxMes = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxObraSocial = new System.Windows.Forms.ComboBox();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoInf = new System.Windows.Forms.ComboBox();
            this.checkBoxListaPreciosOS = new System.Windows.Forms.CheckBox();
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
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPrint,
            this.toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 260);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(474, 50);
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
            this.toolStripButtonClose.ToolTipText = "Cerrar";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Año:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mes:";
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Items.AddRange(new object[] {
            "EGESAC S.A.",
            "RSC S.A."});
            this.comboBoxEmpresa.Location = new System.Drawing.Point(181, 19);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(125, 21);
            this.comboBoxEmpresa.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Empresa Ingresada";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxEmpresa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 55);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // textBoxAnio
            // 
            this.textBoxAnio.Location = new System.Drawing.Point(182, 67);
            this.textBoxAnio.Name = "textBoxAnio";
            this.textBoxAnio.Size = new System.Drawing.Size(77, 20);
            this.textBoxAnio.TabIndex = 18;
            this.textBoxAnio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAnio_KeyDown);
            this.textBoxAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAnio_KeyPress);
            // 
            // textBoxMes
            // 
            this.textBoxMes.Location = new System.Drawing.Point(182, 104);
            this.textBoxMes.Name = "textBoxMes";
            this.textBoxMes.Size = new System.Drawing.Size(77, 20);
            this.textBoxMes.TabIndex = 19;
            this.textBoxMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMes_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxObraSocial);
            this.groupBox2.Controls.Add(this.comboBoxProductos);
            this.groupBox2.Controls.Add(this.comboBoxTipoInf);
            this.groupBox2.Location = new System.Drawing.Point(12, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 106);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Informe";
            // 
            // comboBoxObraSocial
            // 
            this.comboBoxObraSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxObraSocial.FormattingEnabled = true;
            this.comboBoxObraSocial.Location = new System.Drawing.Point(20, 60);
            this.comboBoxObraSocial.Name = "comboBoxObraSocial";
            this.comboBoxObraSocial.Size = new System.Drawing.Size(424, 21);
            this.comboBoxObraSocial.TabIndex = 2;
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Location = new System.Drawing.Point(20, 60);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(424, 21);
            this.comboBoxProductos.TabIndex = 1;
            // 
            // comboBoxTipoInf
            // 
            this.comboBoxTipoInf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoInf.FormattingEnabled = true;
            this.comboBoxTipoInf.Items.AddRange(new object[] {
            "General",
            "Por Articulo",
            "Por Obra Social"});
            this.comboBoxTipoInf.Location = new System.Drawing.Point(160, 19);
            this.comboBoxTipoInf.Name = "comboBoxTipoInf";
            this.comboBoxTipoInf.Size = new System.Drawing.Size(134, 21);
            this.comboBoxTipoInf.TabIndex = 0;
            this.comboBoxTipoInf.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoInf_SelectedIndexChanged);
            // 
            // checkBoxListaPreciosOS
            // 
            this.checkBoxListaPreciosOS.AutoSize = true;
            this.checkBoxListaPreciosOS.Location = new System.Drawing.Point(299, 108);
            this.checkBoxListaPreciosOS.Name = "checkBoxListaPreciosOS";
            this.checkBoxListaPreciosOS.Size = new System.Drawing.Size(137, 17);
            this.checkBoxListaPreciosOS.TabIndex = 21;
            this.checkBoxListaPreciosOS.Text = "Lista de Precios por OS";
            this.checkBoxListaPreciosOS.UseVisualStyleBackColor = true;
            // 
            // InformePrecioCompraFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 310);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxListaPreciosOS);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxMes);
            this.Controls.Add(this.textBoxAnio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toolStripEvents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InformePrecioCompraFacturacion";
            this.Text = "Relacion Precio de Venta Vs Compras";
            this.Load += new System.EventHandler(this.InformePrecioCompraFacturacion_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxAnio;
        private System.Windows.Forms.TextBox textBoxMes;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxTipoInf;
        private System.Windows.Forms.ComboBox comboBoxObraSocial;
        private System.Windows.Forms.ComboBox comboBoxProductos;
        private System.Windows.Forms.CheckBox checkBoxListaPreciosOS;
    }
}