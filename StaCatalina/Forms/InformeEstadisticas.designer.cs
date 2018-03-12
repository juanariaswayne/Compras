namespace EstadisticasFacturacion
{
    partial class InformeEstadisticas
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
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.textBoxMesDesde = new System.Windows.Forms.TextBox();
            this.textBoxAnioDesde = new System.Windows.Forms.TextBox();
            this.textBoxMesHasta = new System.Windows.Forms.TextBox();
            this.textBoxAnioHasta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxSede = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxModulos = new System.Windows.Forms.ComboBox();
            this.checkBoxTodos = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(315, 341);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(105, 31);
            this.buttonEnviar.TabIndex = 0;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // textBoxMesDesde
            // 
            this.textBoxMesDesde.Location = new System.Drawing.Point(23, 186);
            this.textBoxMesDesde.Name = "textBoxMesDesde";
            this.textBoxMesDesde.Size = new System.Drawing.Size(71, 20);
            this.textBoxMesDesde.TabIndex = 1;
            // 
            // textBoxAnioDesde
            // 
            this.textBoxAnioDesde.Location = new System.Drawing.Point(112, 186);
            this.textBoxAnioDesde.Name = "textBoxAnioDesde";
            this.textBoxAnioDesde.Size = new System.Drawing.Size(71, 20);
            this.textBoxAnioDesde.TabIndex = 2;
            // 
            // textBoxMesHasta
            // 
            this.textBoxMesHasta.Location = new System.Drawing.Point(241, 186);
            this.textBoxMesHasta.Name = "textBoxMesHasta";
            this.textBoxMesHasta.Size = new System.Drawing.Size(71, 20);
            this.textBoxMesHasta.TabIndex = 3;
            // 
            // textBoxAnioHasta
            // 
            this.textBoxAnioHasta.Location = new System.Drawing.Point(326, 186);
            this.textBoxAnioHasta.Name = "textBoxAnioHasta";
            this.textBoxAnioHasta.Size = new System.Drawing.Size(71, 20);
            this.textBoxAnioHasta.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(23, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mes y año desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(238, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mes y año hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(23, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(109, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Año";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(324, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Año";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(238, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mes";
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Items.AddRange(new object[] {
            "EGES",
            "RSC",
            "TODAS"});
            this.comboBoxEmpresa.Location = new System.Drawing.Point(23, 89);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(160, 21);
            this.comboBoxEmpresa.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Empresa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Sede";
            // 
            // comboBoxSede
            // 
            this.comboBoxSede.FormattingEnabled = true;
            this.comboBoxSede.Items.AddRange(new object[] {
            "Venezuela",
            "Mexico",
            "Adultos",
            "Pediatria",
            "Todas"});
            this.comboBoxSede.Location = new System.Drawing.Point(241, 89);
            this.comboBoxSede.Name = "comboBoxSede";
            this.comboBoxSede.Size = new System.Drawing.Size(156, 21);
            this.comboBoxSede.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Modulo";
            // 
            // comboBoxModulos
            // 
            this.comboBoxModulos.FormattingEnabled = true;
            this.comboBoxModulos.Items.AddRange(new object[] {
            "Traqueo",
            "ARM",
            "Aislado",
            "Individual",
            "ARM individual",
            "Comun",
            "Hosp. Medio dia",
            "Cohorte",
            "SPS"});
            this.comboBoxModulos.Location = new System.Drawing.Point(241, 260);
            this.comboBoxModulos.Name = "comboBoxModulos";
            this.comboBoxModulos.Size = new System.Drawing.Size(156, 21);
            this.comboBoxModulos.TabIndex = 15;
            // 
            // checkBoxTodos
            // 
            this.checkBoxTodos.AutoSize = true;
            this.checkBoxTodos.Location = new System.Drawing.Point(23, 262);
            this.checkBoxTodos.Name = "checkBoxTodos";
            this.checkBoxTodos.Size = new System.Drawing.Size(114, 17);
            this.checkBoxTodos.TabIndex = 17;
            this.checkBoxTodos.Text = "Todos los modulos";
            this.checkBoxTodos.UseVisualStyleBackColor = true;
            // 
            // InformeEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 395);
            this.Controls.Add(this.checkBoxTodos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxModulos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxSede);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxEmpresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAnioHasta);
            this.Controls.Add(this.textBoxMesHasta);
            this.Controls.Add(this.textBoxAnioDesde);
            this.Controls.Add(this.textBoxMesDesde);
            this.Controls.Add(this.buttonEnviar);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "InformeEstadisticas";
            this.Resizable = false;
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.InformeEstadisticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.TextBox textBoxMesDesde;
        private System.Windows.Forms.TextBox textBoxAnioDesde;
        private System.Windows.Forms.TextBox textBoxMesHasta;
        private System.Windows.Forms.TextBox textBoxAnioHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxSede;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxModulos;
        private System.Windows.Forms.CheckBox checkBoxTodos;
    }
}