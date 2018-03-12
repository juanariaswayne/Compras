namespace StaCatalina.Catalogos
{
    partial class Frm_Menues
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStrip MenuToolStrip;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menues));
            this.cmdNuevoIngreso = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdGrabarUsuario = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdSalirUsuario = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDescrip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboModulos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboMenuPadre = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            MenuToolStrip = new System.Windows.Forms.ToolStrip();
            MenuToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuToolStrip
            // 
            MenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdNuevoIngreso,
            this.ToolStripSeparator3,
            this.cmdGrabarUsuario,
            this.ToolStripSeparator4,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.cmdSalirUsuario});
            MenuToolStrip.Location = new System.Drawing.Point(0, 0);
            MenuToolStrip.Name = "MenuToolStrip";
            MenuToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            MenuToolStrip.Size = new System.Drawing.Size(516, 68);
            MenuToolStrip.TabIndex = 35;
            MenuToolStrip.Text = "Menu Principal";
            // 
            // cmdNuevoIngreso
            // 
            this.cmdNuevoIngreso.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cmdNuevoIngreso.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevoIngreso.Image")));
            this.cmdNuevoIngreso.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdNuevoIngreso.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdNuevoIngreso.Name = "cmdNuevoIngreso";
            this.cmdNuevoIngreso.Size = new System.Drawing.Size(142, 65);
            this.cmdNuevoIngreso.Text = "Nuevo Ingreso";
            this.cmdNuevoIngreso.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.cmdNuevoIngreso.ToolTipText = "Nuevo Ingreso";
            this.cmdNuevoIngreso.Click += new System.EventHandler(this.cmdNuevoIngreso_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 68);
            // 
            // cmdGrabarUsuario
            // 
            this.cmdGrabarUsuario.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrabarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("cmdGrabarUsuario.Image")));
            this.cmdGrabarUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdGrabarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdGrabarUsuario.Name = "cmdGrabarUsuario";
            this.cmdGrabarUsuario.Size = new System.Drawing.Size(104, 65);
            this.cmdGrabarUsuario.Text = "Grabar";
            this.cmdGrabarUsuario.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.cmdGrabarUsuario.ToolTipText = "Graba Operación";
            this.cmdGrabarUsuario.Click += new System.EventHandler(this.cmdGrabarUsuario_Click);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 68);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(124, 65);
            this.toolStripLabel1.Text = "                                       ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 68);
            // 
            // cmdSalirUsuario
            // 
            this.cmdSalirUsuario.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalirUsuario.Image")));
            this.cmdSalirUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdSalirUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSalirUsuario.Name = "cmdSalirUsuario";
            this.cmdSalirUsuario.Size = new System.Drawing.Size(93, 65);
            this.cmdSalirUsuario.Text = "Salir";
            this.cmdSalirUsuario.ToolTipText = "Salir del sistema";
            this.cmdSalirUsuario.Click += new System.EventHandler(this.cmdSalirUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 187);
            this.panel1.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textNombre);
            this.groupBox2.Controls.Add(this.textDescrip);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(0, 96);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(516, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuevo Menú";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(111, 54);
            this.textNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(288, 20);
            this.textNombre.TabIndex = 3;
            // 
            // textDescrip
            // 
            this.textDescrip.Location = new System.Drawing.Point(111, 25);
            this.textDescrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textDescrip.Name = "textDescrip";
            this.textDescrip.Size = new System.Drawing.Size(288, 20);
            this.textDescrip.TabIndex = 2;
            this.textDescrip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textDescrip_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre Formulario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descripción";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboModulos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboMenuPadre);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(516, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Módulos y Menúes Padres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label2.Location = new System.Drawing.Point(67, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Módulo";
            // 
            // comboModulos
            // 
            this.comboModulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboModulos.FormattingEnabled = true;
            this.comboModulos.Location = new System.Drawing.Point(111, 24);
            this.comboModulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboModulos.Name = "comboModulos";
            this.comboModulos.Size = new System.Drawing.Size(288, 22);
            this.comboModulos.TabIndex = 2;
            this.comboModulos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboModulos_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Padre";
            // 
            // comboMenuPadre
            // 
            this.comboMenuPadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMenuPadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboMenuPadre.FormattingEnabled = true;
            this.comboMenuPadre.Location = new System.Drawing.Point(111, 57);
            this.comboMenuPadre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboMenuPadre.Name = "comboMenuPadre";
            this.comboMenuPadre.Size = new System.Drawing.Size(288, 22);
            this.comboMenuPadre.TabIndex = 0;
            this.comboMenuPadre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboMenuPadre_KeyDown);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Frm_Menues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 255);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(MenuToolStrip);
            this.Name = "Frm_Menues";
            this.Text = "Alta de Menues";
            this.Load += new System.EventHandler(this.Frm_Menues_Load);
            MenuToolStrip.ResumeLayout(false);
            MenuToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripButton cmdNuevoIngreso;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripButton cmdGrabarUsuario;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton cmdSalirUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMenuPadre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboModulos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textDescrip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}