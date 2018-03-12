namespace StaCatalina.Forms
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.Gbx_Login = new System.Windows.Forms.GroupBox();
            this.buttonCambios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Txt_Contrasenia = new System.Windows.Forms.TextBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Lbl_Contrasenia = new System.Windows.Forms.Label();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Gbx_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Gbx_Login
            // 
            this.Gbx_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gbx_Login.Controls.Add(this.buttonCambios);
            this.Gbx_Login.Controls.Add(this.label1);
            this.Gbx_Login.Controls.Add(this.comboBoxEmpresa);
            this.Gbx_Login.Controls.Add(this.Btn_Salir);
            this.Gbx_Login.Controls.Add(this.Btn_Aceptar);
            this.Gbx_Login.Controls.Add(this.pictureBox2);
            this.Gbx_Login.Controls.Add(this.pictureBox1);
            this.Gbx_Login.Controls.Add(this.Txt_Contrasenia);
            this.Gbx_Login.Controls.Add(this.Txt_Usuario);
            this.Gbx_Login.Controls.Add(this.Lbl_Contrasenia);
            this.Gbx_Login.Controls.Add(this.Lbl_Usuario);
            this.Gbx_Login.Location = new System.Drawing.Point(12, 12);
            this.Gbx_Login.Name = "Gbx_Login";
            this.Gbx_Login.Size = new System.Drawing.Size(407, 212);
            this.Gbx_Login.TabIndex = 1;
            this.Gbx_Login.TabStop = false;
            // 
            // buttonCambios
            // 
            this.buttonCambios.BackColor = System.Drawing.Color.LightBlue;
            this.buttonCambios.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCambios.Location = new System.Drawing.Point(0, 189);
            this.buttonCambios.Name = "buttonCambios";
            this.buttonCambios.Size = new System.Drawing.Size(175, 23);
            this.buttonCambios.TabIndex = 10;
            this.buttonCambios.Text = "Ver cambios de la nueva version";
            this.buttonCambios.UseVisualStyleBackColor = false;
            this.buttonCambios.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Empresa:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Location = new System.Drawing.Point(116, 105);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(191, 21);
            this.comboBoxEmpresa.TabIndex = 8;
            this.comboBoxEmpresa.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmpresa_SelectedIndexChanged);
            this.comboBoxEmpresa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxEmpresa_KeyDown);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Salir.Location = new System.Drawing.Point(229, 137);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(75, 33);
            this.Btn_Salir.TabIndex = 7;
            this.Btn_Salir.Text = "&Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Aceptar.Location = new System.Drawing.Point(116, 137);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(75, 33);
            this.Btn_Aceptar.TabIndex = 6;
            this.Btn_Aceptar.Text = "&Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::StaCatalina.Properties.Resources.pswd;
            this.pictureBox2.Location = new System.Drawing.Point(340, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 37);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::StaCatalina.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(340, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 37);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Txt_Contrasenia
            // 
            this.Txt_Contrasenia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Contrasenia.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Txt_Contrasenia.Location = new System.Drawing.Point(116, 67);
            this.Txt_Contrasenia.Name = "Txt_Contrasenia";
            this.Txt_Contrasenia.PasswordChar = 'l';
            this.Txt_Contrasenia.Size = new System.Drawing.Size(191, 20);
            this.Txt_Contrasenia.TabIndex = 3;
            this.Txt_Contrasenia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Contrasenia_KeyDown);
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Usuario.Location = new System.Drawing.Point(116, 28);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(191, 20);
            this.Txt_Usuario.TabIndex = 2;
            this.Txt_Usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Usuario_KeyDown);
            // 
            // Lbl_Contrasenia
            // 
            this.Lbl_Contrasenia.Location = new System.Drawing.Point(24, 67);
            this.Lbl_Contrasenia.Name = "Lbl_Contrasenia";
            this.Lbl_Contrasenia.Size = new System.Drawing.Size(86, 22);
            this.Lbl_Contrasenia.TabIndex = 1;
            this.Lbl_Contrasenia.Text = "Contraseña:";
            this.Lbl_Contrasenia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.Location = new System.Drawing.Point(24, 28);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(86, 22);
            this.Lbl_Usuario.TabIndex = 0;
            this.Lbl_Usuario.Text = "Usuario:";
            this.Lbl_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 236);
            this.ControlBox = false;
            this.Controls.Add(this.Gbx_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.Gbx_Login.ResumeLayout(false);
            this.Gbx_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbx_Login;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Txt_Contrasenia;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label Lbl_Contrasenia;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.Button buttonCambios;
    }
}