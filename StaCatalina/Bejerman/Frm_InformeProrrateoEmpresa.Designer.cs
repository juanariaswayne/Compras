namespace StaCatalina.Bejerman
{
    partial class Frm_InformeProrrateoEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_InformeProrrateoEmpresa));
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxMes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAnio = new System.Windows.Forms.TextBox();
            this.labelDistribucion = new System.Windows.Forms.Label();
            this.toolStripEvents.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 124);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(451, 50);
            this.toolStripEvents.TabIndex = 8;
            this.toolStripEvents.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(105, 47);
            this.toolStripButtonSave.Text = "Imprimir";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
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
            this.toolStripButtonClose.ToolTipText = "Cerrar";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxMes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxAnio);
            this.panel1.Controls.Add(this.labelDistribucion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 124);
            this.panel1.TabIndex = 9;
            // 
            // textBoxMes
            // 
            this.textBoxMes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMes.Location = new System.Drawing.Point(174, 67);
            this.textBoxMes.Name = "textBoxMes";
            this.textBoxMes.Size = new System.Drawing.Size(50, 21);
            this.textBoxMes.TabIndex = 9;
            this.textBoxMes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMes_KeyDown);
            this.textBoxMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMes_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mes:";
            // 
            // textBoxAnio
            // 
            this.textBoxAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAnio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnio.Location = new System.Drawing.Point(174, 23);
            this.textBoxAnio.Name = "textBoxAnio";
            this.textBoxAnio.Size = new System.Drawing.Size(50, 21);
            this.textBoxAnio.TabIndex = 7;
            this.textBoxAnio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAnio_KeyDown);
            this.textBoxAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAnio_KeyPress);
            // 
            // labelDistribucion
            // 
            this.labelDistribucion.AutoSize = true;
            this.labelDistribucion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistribucion.Location = new System.Drawing.Point(141, 26);
            this.labelDistribucion.Name = "labelDistribucion";
            this.labelDistribucion.Size = new System.Drawing.Size(30, 14);
            this.labelDistribucion.TabIndex = 6;
            this.labelDistribucion.Text = "Año:";
            // 
            // Frm_InformeProrrateoEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(451, 174);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripEvents);
            this.Name = "Frm_InformeProrrateoEmpresa";
            this.Text = "Informe Prorrateo Empresa Facturas Compras";
            this.Load += new System.EventHandler(this.Frm_InformeProrrateoEmpresa_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAnio;
        private System.Windows.Forms.Label labelDistribucion;
    }
}
