namespace StaCatalina.Forms
{
    partial class Frm_informeDeFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_informeDeFacturacion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.check_Catamarca = new System.Windows.Forms.CheckBox();
            this.labelUniNegocio = new System.Windows.Forms.Label();
            this.check_Venezuela = new System.Windows.Forms.CheckBox();
            this.check_Mexico = new System.Windows.Forms.CheckBox();
            this.informeFacturacion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTimefechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimefechaDesde = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.check_Catamarca);
            this.groupBox1.Controls.Add(this.labelUniNegocio);
            this.groupBox1.Controls.Add(this.check_Venezuela);
            this.groupBox1.Controls.Add(this.check_Mexico);
            this.groupBox1.Controls.Add(this.informeFacturacion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DateTimefechaHasta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DateTimefechaDesde);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Fechas a realizar el informe";
            // 
            // check_Catamarca
            // 
            this.check_Catamarca.AutoSize = true;
            this.check_Catamarca.Location = new System.Drawing.Point(189, 214);
            this.check_Catamarca.Name = "check_Catamarca";
            this.check_Catamarca.Size = new System.Drawing.Size(77, 17);
            this.check_Catamarca.TabIndex = 8;
            this.check_Catamarca.Text = "Catamarca";
            this.check_Catamarca.UseVisualStyleBackColor = true;
            // 
            // labelUniNegocio
            // 
            this.labelUniNegocio.AutoSize = true;
            this.labelUniNegocio.Location = new System.Drawing.Point(176, 155);
            this.labelUniNegocio.Name = "labelUniNegocio";
            this.labelUniNegocio.Size = new System.Drawing.Size(99, 13);
            this.labelUniNegocio.TabIndex = 7;
            this.labelUniNegocio.Text = "Unidad de Negocio";
            // 
            // check_Venezuela
            // 
            this.check_Venezuela.AutoSize = true;
            this.check_Venezuela.Location = new System.Drawing.Point(133, 191);
            this.check_Venezuela.Name = "check_Venezuela";
            this.check_Venezuela.Size = new System.Drawing.Size(76, 17);
            this.check_Venezuela.TabIndex = 6;
            this.check_Venezuela.Text = "Venezuela";
            this.check_Venezuela.UseVisualStyleBackColor = true;
            // 
            // check_Mexico
            // 
            this.check_Mexico.AutoSize = true;
            this.check_Mexico.Location = new System.Drawing.Point(253, 191);
            this.check_Mexico.Name = "check_Mexico";
            this.check_Mexico.Size = new System.Drawing.Size(60, 17);
            this.check_Mexico.TabIndex = 5;
            this.check_Mexico.Text = "Mexico";
            this.check_Mexico.UseVisualStyleBackColor = true;
            // 
            // informeFacturacion
            // 
            this.informeFacturacion.Location = new System.Drawing.Point(189, 247);
            this.informeFacturacion.Name = "informeFacturacion";
            this.informeFacturacion.Size = new System.Drawing.Size(75, 23);
            this.informeFacturacion.TabIndex = 4;
            this.informeFacturacion.Text = "Enviar";
            this.informeFacturacion.UseVisualStyleBackColor = true;
            this.informeFacturacion.Click += new System.EventHandler(this.informeFacturacion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta";
            // 
            // DateTimefechaHasta
            // 
            this.DateTimefechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimefechaHasta.Location = new System.Drawing.Point(133, 115);
            this.DateTimefechaHasta.Name = "DateTimefechaHasta";
            this.DateTimefechaHasta.Size = new System.Drawing.Size(97, 20);
            this.DateTimefechaHasta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde";
            // 
            // DateTimefechaDesde
            // 
            this.DateTimefechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimefechaDesde.Location = new System.Drawing.Point(133, 58);
            this.DateTimefechaDesde.Name = "DateTimefechaDesde";
            this.DateTimefechaDesde.Size = new System.Drawing.Size(97, 20);
            this.DateTimefechaDesde.TabIndex = 0;
            // 
            // Frm_informeDeFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 292);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_informeDeFacturacion";
            this.Text = "Informe de Facturacion";
            this.Load += new System.EventHandler(this.informeDeFacturacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button informeFacturacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateTimefechaHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateTimefechaDesde;
        private System.Windows.Forms.Label labelUniNegocio;
        private System.Windows.Forms.CheckBox check_Venezuela;
        private System.Windows.Forms.CheckBox check_Mexico;
        private System.Windows.Forms.CheckBox check_Catamarca;
    }
}