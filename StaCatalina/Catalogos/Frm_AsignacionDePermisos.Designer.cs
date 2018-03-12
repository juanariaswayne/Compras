namespace StaCatalina.Catalogos
{
    partial class Frm_AsignacionDePermisos
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
            System.Windows.Forms.ToolStrip MenuToolStrip;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AsignacionDePermisos));
            this.cmdGrabarUsuario = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdSalirUsuario = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboModulos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboPerfiles = new System.Windows.Forms.ComboBox();
            MenuToolStrip = new System.Windows.Forms.ToolStrip();
            MenuToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuToolStrip
            // 
            MenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdGrabarUsuario,
            this.ToolStripSeparator4,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.cmdSalirUsuario});
            MenuToolStrip.Location = new System.Drawing.Point(0, 0);
            MenuToolStrip.Name = "MenuToolStrip";
            MenuToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            MenuToolStrip.Size = new System.Drawing.Size(635, 68);
            MenuToolStrip.TabIndex = 37;
            MenuToolStrip.Text = "Menu Principal";
            // 
            // cmdGrabarUsuario
            // 
            this.cmdGrabarUsuario.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrabarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("cmdGrabarUsuario.Image")));
            this.cmdGrabarUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdGrabarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdGrabarUsuario.Name = "cmdGrabarUsuario";
            this.cmdGrabarUsuario.Size = new System.Drawing.Size(144, 65);
            this.cmdGrabarUsuario.Text = "Grabar Permiso";
            this.cmdGrabarUsuario.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.cmdGrabarUsuario.ToolTipText = "Graba Operación";
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 435);
            this.panel1.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboModulos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboPerfiles);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 87);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Perfil y Módulo";
            // 
            // comboModulos
            // 
            this.comboModulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboModulos.FormattingEnabled = true;
            this.comboModulos.Location = new System.Drawing.Point(206, 48);
            this.comboModulos.Name = "comboModulos";
            this.comboModulos.Size = new System.Drawing.Size(353, 22);
            this.comboModulos.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Módulo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "Perfil:";
            // 
            // comboPerfiles
            // 
            this.comboPerfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPerfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboPerfiles.FormattingEnabled = true;
            this.comboPerfiles.Location = new System.Drawing.Point(206, 16);
            this.comboPerfiles.Name = "comboPerfiles";
            this.comboPerfiles.Size = new System.Drawing.Size(353, 22);
            this.comboPerfiles.TabIndex = 8;
            // 
            // Frm_AsignacionDePermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(635, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(MenuToolStrip);
            this.Name = "Frm_AsignacionDePermisos";
            MenuToolStrip.ResumeLayout(false);
            MenuToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripButton cmdGrabarUsuario;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton cmdSalirUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboModulos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.ComboBox comboPerfiles;
    }
}
