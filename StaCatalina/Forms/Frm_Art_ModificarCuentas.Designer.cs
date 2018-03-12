namespace StaCatalina.Forms
{
    partial class Frm_Art_ModificarCuentas
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
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescArticulo = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtCompras = new System.Windows.Forms.TextBox();
            this.txtVentas = new System.Windows.Forms.TextBox();
            this.txtInventario = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(12, 35);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtArticulo.TabIndex = 0;
            this.txtArticulo.TextChanged += new System.EventHandler(this.txtArticulo_TextChanged);
            this.txtArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArticulo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo de articulo";
            // 
            // lblDescArticulo
            // 
            this.lblDescArticulo.AutoSize = true;
            this.lblDescArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescArticulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDescArticulo.Location = new System.Drawing.Point(9, 71);
            this.lblDescArticulo.Name = "lblDescArticulo";
            this.lblDescArticulo.Size = new System.Drawing.Size(0, 15);
            this.lblDescArticulo.TabIndex = 2;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(12, 113);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 3;
            // 
            // txtCompras
            // 
            this.txtCompras.Location = new System.Drawing.Point(12, 160);
            this.txtCompras.Name = "txtCompras";
            this.txtCompras.Size = new System.Drawing.Size(100, 20);
            this.txtCompras.TabIndex = 4;
            // 
            // txtVentas
            // 
            this.txtVentas.Location = new System.Drawing.Point(12, 207);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Size = new System.Drawing.Size(100, 20);
            this.txtVentas.TabIndex = 5;
            // 
            // txtInventario
            // 
            this.txtInventario.Location = new System.Drawing.Point(12, 254);
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.Size = new System.Drawing.Size(100, 20);
            this.txtInventario.TabIndex = 6;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(210, 316);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(101, 33);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // Frm_Art_ModificarCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 351);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.txtInventario);
            this.Controls.Add(this.txtVentas);
            this.Controls.Add(this.txtCompras);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblDescArticulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArticulo);
            this.Name = "Frm_Art_ModificarCuentas";
            this.Text = "Art_ModificarCuentas";
            this.Load += new System.EventHandler(this.Art_ModificarCuentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescArticulo;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtCompras;
        private System.Windows.Forms.TextBox txtVentas;
        private System.Windows.Forms.TextBox txtInventario;
        private System.Windows.Forms.Button buttonGuardar;
    }
}