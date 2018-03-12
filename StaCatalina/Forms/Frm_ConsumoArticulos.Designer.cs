namespace StaCatalina.Forms
{
    partial class Frm_ConsumoArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConsumoArticulos));
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxLike = new System.Windows.Forms.TextBox();
            this.comboBoxArticulo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonLike = new System.Windows.Forms.RadioButton();
            this.radioButtonArticulo = new System.Windows.Forms.RadioButton();
            this.radioButtonGeneral = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMes = new System.Windows.Forms.TextBox();
            this.textBoxAnio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripEvents.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.toolStripEvents.Location = new System.Drawing.Point(0, 219);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(484, 50);
            this.toolStripEvents.TabIndex = 7;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 269);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxLike);
            this.groupBox2.Controls.Add(this.comboBoxArticulo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.radioButtonLike);
            this.groupBox2.Controls.Add(this.radioButtonArticulo);
            this.groupBox2.Controls.Add(this.radioButtonGeneral);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones particulares";
            // 
            // textBoxLike
            // 
            this.textBoxLike.Location = new System.Drawing.Point(174, 107);
            this.textBoxLike.Name = "textBoxLike";
            this.textBoxLike.Size = new System.Drawing.Size(186, 20);
            this.textBoxLike.TabIndex = 11;
            // 
            // comboBoxArticulo
            // 
            this.comboBoxArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArticulo.FormattingEnabled = true;
            this.comboBoxArticulo.Location = new System.Drawing.Point(114, 59);
            this.comboBoxArticulo.Name = "comboBoxArticulo";
            this.comboBoxArticulo.Size = new System.Drawing.Size(305, 21);
            this.comboBoxArticulo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(469, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------------------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(469, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------------------------------------------";
            // 
            // radioButtonLike
            // 
            this.radioButtonLike.AutoSize = true;
            this.radioButtonLike.Location = new System.Drawing.Point(31, 109);
            this.radioButtonLike.Name = "radioButtonLike";
            this.radioButtonLike.Size = new System.Drawing.Size(137, 17);
            this.radioButtonLike.TabIndex = 4;
            this.radioButtonLike.Text = "Artículo comienza con..";
            this.radioButtonLike.UseVisualStyleBackColor = true;
            // 
            // radioButtonArticulo
            // 
            this.radioButtonArticulo.AutoSize = true;
            this.radioButtonArticulo.Location = new System.Drawing.Point(31, 61);
            this.radioButtonArticulo.Name = "radioButtonArticulo";
            this.radioButtonArticulo.Size = new System.Drawing.Size(62, 17);
            this.radioButtonArticulo.TabIndex = 3;
            this.radioButtonArticulo.Text = "Artículo";
            this.radioButtonArticulo.UseVisualStyleBackColor = true;
            // 
            // radioButtonGeneral
            // 
            this.radioButtonGeneral.AutoSize = true;
            this.radioButtonGeneral.Checked = true;
            this.radioButtonGeneral.Location = new System.Drawing.Point(31, 19);
            this.radioButtonGeneral.Name = "radioButtonGeneral";
            this.radioButtonGeneral.Size = new System.Drawing.Size(62, 17);
            this.radioButtonGeneral.TabIndex = 1;
            this.radioButtonGeneral.TabStop = true;
            this.radioButtonGeneral.Text = "General";
            this.radioButtonGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMes);
            this.groupBox1.Controls.Add(this.textBoxAnio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcion General";
            // 
            // textBoxMes
            // 
            this.textBoxMes.Location = new System.Drawing.Point(305, 29);
            this.textBoxMes.Name = "textBoxMes";
            this.textBoxMes.Size = new System.Drawing.Size(68, 20);
            this.textBoxMes.TabIndex = 3;
            this.textBoxMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMes_KeyPress);
            this.textBoxMes.Leave += new System.EventHandler(this.textBoxMes_Leave);
            // 
            // textBoxAnio
            // 
            this.textBoxAnio.Location = new System.Drawing.Point(112, 29);
            this.textBoxAnio.Name = "textBoxAnio";
            this.textBoxAnio.Size = new System.Drawing.Size(68, 20);
            this.textBoxAnio.TabIndex = 2;
            this.textBoxAnio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAnio_KeyDown);
            this.textBoxAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAnio_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año:";
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
            // Frm_ConsumoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 269);
            this.ControlBox = false;
            this.Controls.Add(this.toolStripEvents);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ConsumoArticulos";
            this.Text = "Consumo de Artículos";
            this.Load += new System.EventHandler(this.FrmConsumoArticulos_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxMes;
        private System.Windows.Forms.TextBox textBoxAnio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonGeneral;
        private System.Windows.Forms.RadioButton radioButtonArticulo;
        private System.Windows.Forms.RadioButton radioButtonLike;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxArticulo;
        private System.Windows.Forms.TextBox textBoxLike;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
    }
}