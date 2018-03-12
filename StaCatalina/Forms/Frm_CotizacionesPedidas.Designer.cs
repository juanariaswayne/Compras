namespace StaCatalina.Forms
{
    partial class Frm_CotizacionesPedidas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CotizacionesPedidas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDescripArticulo = new System.Windows.Forms.Label();
            this.labelArticulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewArticulosCotizadosProveed = new System.Windows.Forms.DataGridView();
            this.NroCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codEmpresaCotiza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveed_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulosCotizadosProveed)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelDescripArticulo);
            this.panel1.Controls.Add(this.labelArticulo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewArticulosCotizadosProveed);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 283);
            this.panel1.TabIndex = 0;
            // 
            // labelDescripArticulo
            // 
            this.labelDescripArticulo.AutoSize = true;
            this.labelDescripArticulo.Location = new System.Drawing.Point(164, 13);
            this.labelDescripArticulo.Name = "labelDescripArticulo";
            this.labelDescripArticulo.Size = new System.Drawing.Size(0, 13);
            this.labelDescripArticulo.TabIndex = 3;
            // 
            // labelArticulo
            // 
            this.labelArticulo.AutoSize = true;
            this.labelArticulo.Location = new System.Drawing.Point(91, 13);
            this.labelArticulo.Name = "labelArticulo";
            this.labelArticulo.Size = new System.Drawing.Size(0, 13);
            this.labelArticulo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artículo:";
            // 
            // dataGridViewArticulosCotizadosProveed
            // 
            this.dataGridViewArticulosCotizadosProveed.AllowUserToAddRows = false;
            this.dataGridViewArticulosCotizadosProveed.AllowUserToDeleteRows = false;
            this.dataGridViewArticulosCotizadosProveed.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArticulosCotizadosProveed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewArticulosCotizadosProveed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticulosCotizadosProveed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroCotizacion,
            this.Fecha,
            this.codEmpresaCotiza,
            this.proveed_id,
            this.RazonSocial,
            this.Cantidad});
            this.dataGridViewArticulosCotizadosProveed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewArticulosCotizadosProveed.EnableHeadersVisualStyles = false;
            this.dataGridViewArticulosCotizadosProveed.Location = new System.Drawing.Point(0, 42);
            this.dataGridViewArticulosCotizadosProveed.Name = "dataGridViewArticulosCotizadosProveed";
            this.dataGridViewArticulosCotizadosProveed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewArticulosCotizadosProveed.Size = new System.Drawing.Size(912, 241);
            this.dataGridViewArticulosCotizadosProveed.TabIndex = 0;
            // 
            // NroCotizacion
            // 
            this.NroCotizacion.DataPropertyName = "NroCotizacion";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.NroCotizacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.NroCotizacion.HeaderText = "Nro Cotización";
            this.NroCotizacion.Name = "NroCotizacion";
            this.NroCotizacion.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle3;
            this.Fecha.HeaderText = "Fecha Cotización";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 120;
            // 
            // codEmpresaCotiza
            // 
            this.codEmpresaCotiza.DataPropertyName = "codEmp";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codEmpresaCotiza.DefaultCellStyle = dataGridViewCellStyle4;
            this.codEmpresaCotiza.HeaderText = "Empresa";
            this.codEmpresaCotiza.Name = "codEmpresaCotiza";
            this.codEmpresaCotiza.ReadOnly = true;
            this.codEmpresaCotiza.Width = 80;
            // 
            // proveed_id
            // 
            this.proveed_id.DataPropertyName = "proveed_id";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.proveed_id.DefaultCellStyle = dataGridViewCellStyle5;
            this.proveed_id.HeaderText = "Proveedor";
            this.proveed_id.Name = "proveed_id";
            this.proveed_id.ReadOnly = true;
            this.proveed_id.Width = 90;
            // 
            // RazonSocial
            // 
            this.RazonSocial.DataPropertyName = "pro_RazSoc";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.RazonSocial.DefaultCellStyle = dataGridViewCellStyle6;
            this.RazonSocial.HeaderText = "Razón Social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Width = 350;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle7;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Frm_CotizacionesPedidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 283);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CotizacionesPedidas";
            this.Text = "Pedidos de Cotización";
            this.Load += new System.EventHandler(this.Frm_CotizacionesPedidas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulosCotizadosProveed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewArticulosCotizadosProveed;
        private System.Windows.Forms.Label labelDescripArticulo;
        private System.Windows.Forms.Label labelArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmpresaCotiza;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveed_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}