namespace StaCatalina.Catalogos
{
    partial class Frm_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Usuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdNuevoIngreso = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdGrabarUsuario = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdSalirUsuario = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inactivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sector_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSector = new System.Windows.Forms.ComboBox();
            this.checkInactivo = new System.Windows.Forms.CheckBox();
            this.comboPerfil = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextClave = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            MenuToolStrip = new System.Windows.Forms.ToolStrip();
            MenuToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
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
            MenuToolStrip.Size = new System.Drawing.Size(833, 68);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 452);
            this.panel1.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewUsuarios);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(833, 264);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuarios creados ";
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Email,
            this.Inactivo,
            this.IdPerfil,
            this.IdUsuario,
            this.Usuario,
            this.Nombre,
            this.Perfil,
            this.Sector_id,
            this.Sector,
            this.Empresa});
            this.dataGridViewUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(827, 245);
            this.dataGridViewUsuarios.TabIndex = 0;
            this.dataGridViewUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellClick);
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Visible = false;
            // 
            // Inactivo
            // 
            this.Inactivo.HeaderText = "Inactivo";
            this.Inactivo.Name = "Inactivo";
            this.Inactivo.Visible = false;
            // 
            // IdPerfil
            // 
            this.IdPerfil.HeaderText = "IdPerfil";
            this.IdPerfil.Name = "IdPerfil";
            this.IdPerfil.Visible = false;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "Idusuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.Visible = false;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.Width = 110;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 230;
            // 
            // Perfil
            // 
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.Name = "Perfil";
            this.Perfil.Width = 160;
            // 
            // Sector_id
            // 
            this.Sector_id.HeaderText = "Sector_id";
            this.Sector_id.Name = "Sector_id";
            this.Sector_id.Visible = false;
            // 
            // Sector
            // 
            this.Sector.HeaderText = "Sector";
            this.Sector.Name = "Sector";
            this.Sector.ReadOnly = true;
            this.Sector.Width = 160;
            // 
            // Empresa
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Empresa.DefaultCellStyle = dataGridViewCellStyle2;
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxEmpresa);
            this.groupBox1.Controls.Add(this.textBoxMail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxSector);
            this.groupBox1.Controls.Add(this.checkInactivo);
            this.groupBox1.Controls.Add(this.comboPerfil);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TextClave);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.textUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 172);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descripción de Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "Empresa a la que puede acceder:";
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Items.AddRange(new object[] {
            "Ambas Empresas",
            "EGESAC S.A.",
            "RSC S.A.",
            "GSC S.A."});
            this.comboBoxEmpresa.Location = new System.Drawing.Point(550, 77);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(182, 22);
            this.comboBoxEmpresa.TabIndex = 13;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(427, 147);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(305, 20);
            this.textBoxMail.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "Dirección de Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sector:";
            // 
            // comboBoxSector
            // 
            this.comboBoxSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSector.FormattingEnabled = true;
            this.comboBoxSector.Location = new System.Drawing.Point(104, 144);
            this.comboBoxSector.Name = "comboBoxSector";
            this.comboBoxSector.Size = new System.Drawing.Size(306, 22);
            this.comboBoxSector.TabIndex = 9;
            // 
            // checkInactivo
            // 
            this.checkInactivo.AutoSize = true;
            this.checkInactivo.Location = new System.Drawing.Point(427, 118);
            this.checkInactivo.Name = "checkInactivo";
            this.checkInactivo.Size = new System.Drawing.Size(63, 18);
            this.checkInactivo.TabIndex = 8;
            this.checkInactivo.Text = "Inactivo";
            this.checkInactivo.UseVisualStyleBackColor = true;
            // 
            // comboPerfil
            // 
            this.comboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboPerfil.FormattingEnabled = true;
            this.comboPerfil.Location = new System.Drawing.Point(104, 113);
            this.comboPerfil.Name = "comboPerfil";
            this.comboPerfil.Size = new System.Drawing.Size(306, 22);
            this.comboPerfil.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Perfil:";
            // 
            // TextClave
            // 
            this.TextClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextClave.Location = new System.Drawing.Point(104, 79);
            this.TextClave.Name = "TextClave";
            this.TextClave.PasswordChar = '*';
            this.TextClave.Size = new System.Drawing.Size(391, 20);
            this.TextClave.TabIndex = 5;
            this.TextClave.Tag = "1";
            // 
            // textNombre
            // 
            this.textNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNombre.Location = new System.Drawing.Point(104, 48);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(391, 20);
            this.textNombre.TabIndex = 4;
            this.textNombre.Tag = "1";
            // 
            // textUsuario
            // 
            this.textUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUsuario.Location = new System.Drawing.Point(104, 22);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(391, 20);
            this.textUsuario.TabIndex = 3;
            this.textUsuario.Tag = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Completo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // Frm_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 520);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(MenuToolStrip);
            this.Name = "Frm_Usuarios";
            this.Text = "Usuarios del sistema";
            this.Load += new System.EventHandler(this.Frm_Usuarios_Load);
            MenuToolStrip.ResumeLayout(false);
            MenuToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkInactivo;
        protected internal System.Windows.Forms.ComboBox comboPerfil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextClave;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.ComboBox comboBoxSector;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inactivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sector_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
    }
}