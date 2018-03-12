namespace StaCatalina.Forms
{
    partial class Frm_PrecioCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PrecioCompra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonOrdenProveed = new System.Windows.Forms.RadioButton();
            this.radioButtonOrdenRubro = new System.Windows.Forms.RadioButton();
            this.radioButtonOrdenArticulo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLike = new System.Windows.Forms.TextBox();
            this.comboBoxArticulo = new System.Windows.Forms.ComboBox();
            this.comboBoxRubro = new System.Windows.Forms.ComboBox();
            this.radioButtonLike = new System.Windows.Forms.RadioButton();
            this.radioButtonArticulo = new System.Windows.Forms.RadioButton();
            this.radioButtonRubro = new System.Windows.Forms.RadioButton();
            this.radioButtonGeneral = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTresUltimas = new System.Windows.Forms.RadioButton();
            this.radioButtonUltima = new System.Windows.Forms.RadioButton();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStripEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 363);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonOrdenProveed);
            this.groupBox3.Controls.Add(this.radioButtonOrdenRubro);
            this.groupBox3.Controls.Add(this.radioButtonOrdenArticulo);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(537, 50);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ordenado por:";
            // 
            // radioButtonOrdenProveed
            // 
            this.radioButtonOrdenProveed.AutoSize = true;
            this.radioButtonOrdenProveed.Location = new System.Drawing.Point(411, 19);
            this.radioButtonOrdenProveed.Name = "radioButtonOrdenProveed";
            this.radioButtonOrdenProveed.Size = new System.Drawing.Size(74, 17);
            this.radioButtonOrdenProveed.TabIndex = 2;
            this.radioButtonOrdenProveed.Text = "Proveedor";
            this.radioButtonOrdenProveed.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrdenRubro
            // 
            this.radioButtonOrdenRubro.AutoSize = true;
            this.radioButtonOrdenRubro.Location = new System.Drawing.Point(259, 19);
            this.radioButtonOrdenRubro.Name = "radioButtonOrdenRubro";
            this.radioButtonOrdenRubro.Size = new System.Drawing.Size(54, 17);
            this.radioButtonOrdenRubro.TabIndex = 1;
            this.radioButtonOrdenRubro.Text = "Rubro";
            this.radioButtonOrdenRubro.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrdenArticulo
            // 
            this.radioButtonOrdenArticulo.AutoSize = true;
            this.radioButtonOrdenArticulo.Checked = true;
            this.radioButtonOrdenArticulo.Location = new System.Drawing.Point(104, 19);
            this.radioButtonOrdenArticulo.Name = "radioButtonOrdenArticulo";
            this.radioButtonOrdenArticulo.Size = new System.Drawing.Size(62, 17);
            this.radioButtonOrdenArticulo.TabIndex = 0;
            this.radioButtonOrdenArticulo.TabStop = true;
            this.radioButtonOrdenArticulo.Text = "Artículo";
            this.radioButtonOrdenArticulo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxLike);
            this.groupBox2.Controls.Add(this.comboBoxArticulo);
            this.groupBox2.Controls.Add(this.comboBoxRubro);
            this.groupBox2.Controls.Add(this.radioButtonLike);
            this.groupBox2.Controls.Add(this.radioButtonArticulo);
            this.groupBox2.Controls.Add(this.radioButtonRubro);
            this.groupBox2.Controls.Add(this.radioButtonGeneral);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 177);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones particulares";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(529, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(529, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-------------";
            // 
            // textBoxLike
            // 
            this.textBoxLike.Location = new System.Drawing.Point(195, 140);
            this.textBoxLike.Name = "textBoxLike";
            this.textBoxLike.Size = new System.Drawing.Size(186, 20);
            this.textBoxLike.TabIndex = 6;
            // 
            // comboBoxArticulo
            // 
            this.comboBoxArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArticulo.FormattingEnabled = true;
            this.comboBoxArticulo.Location = new System.Drawing.Point(195, 100);
            this.comboBoxArticulo.Name = "comboBoxArticulo";
            this.comboBoxArticulo.Size = new System.Drawing.Size(305, 21);
            this.comboBoxArticulo.TabIndex = 5;
            // 
            // comboBoxRubro
            // 
            this.comboBoxRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRubro.FormattingEnabled = true;
            this.comboBoxRubro.Location = new System.Drawing.Point(195, 60);
            this.comboBoxRubro.Name = "comboBoxRubro";
            this.comboBoxRubro.Size = new System.Drawing.Size(305, 21);
            this.comboBoxRubro.TabIndex = 4;
            // 
            // radioButtonLike
            // 
            this.radioButtonLike.AutoSize = true;
            this.radioButtonLike.Location = new System.Drawing.Point(52, 143);
            this.radioButtonLike.Name = "radioButtonLike";
            this.radioButtonLike.Size = new System.Drawing.Size(137, 17);
            this.radioButtonLike.TabIndex = 3;
            this.radioButtonLike.Text = "Artículo comienza con..";
            this.radioButtonLike.UseVisualStyleBackColor = true;
            this.radioButtonLike.CheckedChanged += new System.EventHandler(this.radioButtonLike_CheckedChanged);
            // 
            // radioButtonArticulo
            // 
            this.radioButtonArticulo.AutoSize = true;
            this.radioButtonArticulo.Location = new System.Drawing.Point(52, 104);
            this.radioButtonArticulo.Name = "radioButtonArticulo";
            this.radioButtonArticulo.Size = new System.Drawing.Size(62, 17);
            this.radioButtonArticulo.TabIndex = 2;
            this.radioButtonArticulo.Text = "Artículo";
            this.radioButtonArticulo.UseVisualStyleBackColor = true;
            this.radioButtonArticulo.CheckedChanged += new System.EventHandler(this.radioButtonArticulo_CheckedChanged);
            // 
            // radioButtonRubro
            // 
            this.radioButtonRubro.AutoSize = true;
            this.radioButtonRubro.Location = new System.Drawing.Point(52, 64);
            this.radioButtonRubro.Name = "radioButtonRubro";
            this.radioButtonRubro.Size = new System.Drawing.Size(76, 17);
            this.radioButtonRubro.TabIndex = 1;
            this.radioButtonRubro.Text = "Sub Rubro";
            this.radioButtonRubro.UseVisualStyleBackColor = true;
            this.radioButtonRubro.CheckedChanged += new System.EventHandler(this.radioButtonRubro_CheckedChanged);
            // 
            // radioButtonGeneral
            // 
            this.radioButtonGeneral.AutoSize = true;
            this.radioButtonGeneral.Checked = true;
            this.radioButtonGeneral.Location = new System.Drawing.Point(52, 26);
            this.radioButtonGeneral.Name = "radioButtonGeneral";
            this.radioButtonGeneral.Size = new System.Drawing.Size(62, 17);
            this.radioButtonGeneral.TabIndex = 0;
            this.radioButtonGeneral.TabStop = true;
            this.radioButtonGeneral.Text = "General";
            this.radioButtonGeneral.UseVisualStyleBackColor = true;
            this.radioButtonGeneral.CheckedChanged += new System.EventHandler(this.radioButtonGeneral_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTresUltimas);
            this.groupBox1.Controls.Add(this.radioButtonUltima);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones Generales";
            // 
            // radioButtonTresUltimas
            // 
            this.radioButtonTresUltimas.AutoSize = true;
            this.radioButtonTresUltimas.Location = new System.Drawing.Point(299, 39);
            this.radioButtonTresUltimas.Name = "radioButtonTresUltimas";
            this.radioButtonTresUltimas.Size = new System.Drawing.Size(159, 17);
            this.radioButtonTresUltimas.TabIndex = 1;
            this.radioButtonTresUltimas.Text = "Evolución 3 últimas compras";
            this.radioButtonTresUltimas.UseVisualStyleBackColor = true;
            this.radioButtonTresUltimas.CheckedChanged += new System.EventHandler(this.radioButtonTresUltimas_CheckedChanged);
            // 
            // radioButtonUltima
            // 
            this.radioButtonUltima.AutoSize = true;
            this.radioButtonUltima.Checked = true;
            this.radioButtonUltima.Location = new System.Drawing.Point(52, 39);
            this.radioButtonUltima.Name = "radioButtonUltima";
            this.radioButtonUltima.Size = new System.Drawing.Size(92, 17);
            this.radioButtonUltima.TabIndex = 0;
            this.radioButtonUltima.TabStop = true;
            this.radioButtonUltima.Text = "Última compra";
            this.radioButtonUltima.UseVisualStyleBackColor = true;
            this.radioButtonUltima.CheckedChanged += new System.EventHandler(this.radioButtonUltima_CheckedChanged);
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPrint,
            this.toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 313);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(537, 50);
            this.toolStripEvents.TabIndex = 6;
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
            // Frm_PrecioCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 363);
            this.ControlBox = false;
            this.Controls.Add(this.toolStripEvents);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_PrecioCompra";
            this.Text = "Análisis precios de compra";
            this.Load += new System.EventHandler(this.FrmPrecioCompra_Load);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxLike;
        private System.Windows.Forms.ComboBox comboBoxArticulo;
        private System.Windows.Forms.ComboBox comboBoxRubro;
        private System.Windows.Forms.RadioButton radioButtonLike;
        private System.Windows.Forms.RadioButton radioButtonArticulo;
        private System.Windows.Forms.RadioButton radioButtonRubro;
        private System.Windows.Forms.RadioButton radioButtonGeneral;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTresUltimas;
        private System.Windows.Forms.RadioButton radioButtonUltima;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonOrdenProveed;
        private System.Windows.Forms.RadioButton radioButtonOrdenRubro;
        private System.Windows.Forms.RadioButton radioButtonOrdenArticulo;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
    }
}