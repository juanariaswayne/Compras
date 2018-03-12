namespace StaCatalina.Catalogos
{
    partial class Frm_UsuarioSubRubroArticulos
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
            System.Windows.Forms.ToolStrip MenuToolStrip;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UsuarioSubRubroArticulos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdGrabarUsuario = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdSalirUsuario = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxUsuario = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewUsuariosRubro = new System.Windows.Forms.DataGridView();
            this.Incluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CodRubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MenuToolStrip = new System.Windows.Forms.ToolStrip();
            MenuToolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuariosRubro)).BeginInit();
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
            MenuToolStrip.Size = new System.Drawing.Size(559, 68);
            MenuToolStrip.TabIndex = 36;
            MenuToolStrip.Text = "Menu Principal";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxUsuario);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 73);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione un Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(109, 29);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(418, 21);
            this.comboBoxUsuario.TabIndex = 0;
            this.comboBoxUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsuario_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewUsuariosRubro);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 353);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SubRubros Asignados";
            // 
            // dataGridViewUsuariosRubro
            // 
            this.dataGridViewUsuariosRubro.AllowUserToAddRows = false;
            this.dataGridViewUsuariosRubro.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsuariosRubro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewUsuariosRubro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuariosRubro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Incluir,
            this.CodRubro,
            this.Descripcion});
            this.dataGridViewUsuariosRubro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsuariosRubro.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewUsuariosRubro.Name = "dataGridViewUsuariosRubro";
            this.dataGridViewUsuariosRubro.Size = new System.Drawing.Size(553, 334);
            this.dataGridViewUsuariosRubro.TabIndex = 1;
            this.dataGridViewUsuariosRubro.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewUsuariosRubro_CurrentCellDirtyStateChanged);
            // 
            // Incluir
            // 
            this.Incluir.DataPropertyName = "Incluido";
            this.Incluir.HeaderText = "Incluir";
            this.Incluir.Name = "Incluir";
            this.Incluir.Width = 80;
            // 
            // CodRubro
            // 
            this.CodRubro.DataPropertyName = "artda2_Cod";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CodRubro.DefaultCellStyle = dataGridViewCellStyle5;
            this.CodRubro.HeaderText = "Sub Rubro";
            this.CodRubro.Name = "CodRubro";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "da2_Desc";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle6;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 300;
            // 
            // Frm_UsuarioSubRubroArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(559, 506);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(MenuToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_UsuarioSubRubroArticulos";
            this.Text = "Admistrar Sub Rubros Artículos";
            this.Load += new System.EventHandler(this.Frm_UsuarioRubroArticulos_Load);
            MenuToolStrip.ResumeLayout(false);
            MenuToolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuariosRubro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripButton cmdGrabarUsuario;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton cmdSalirUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxUsuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewUsuariosRubro;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Incluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodRubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}
