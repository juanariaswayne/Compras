namespace StaCatalina.Forms
{
    partial class Frm_ReclamoMercaderia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ReclamoMercaderia));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSubRubro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDeposito = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRemito = new System.Windows.Forms.TextBox();
            this.comboBoxArticulo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFactura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewArticulos = new System.Windows.Forms.DataGridView();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.NumPlantilla = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Articulo_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant_Faltante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant_RecibidaDeMas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant_RecibidaError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anotacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulos)).BeginInit();
            this.toolStripEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "SubRubro:";
            // 
            // comboBoxSubRubro
            // 
            this.comboBoxSubRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSubRubro.FormattingEnabled = true;
            this.comboBoxSubRubro.Location = new System.Drawing.Point(602, 6);
            this.comboBoxSubRubro.Name = "comboBoxSubRubro";
            this.comboBoxSubRubro.Size = new System.Drawing.Size(294, 21);
            this.comboBoxSubRubro.TabIndex = 27;
            this.comboBoxSubRubro.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubRubro_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sector:";
            // 
            // comboBoxSector
            // 
            this.comboBoxSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSector.FormattingEnabled = true;
            this.comboBoxSector.Location = new System.Drawing.Point(353, 6);
            this.comboBoxSector.Name = "comboBoxSector";
            this.comboBoxSector.Size = new System.Drawing.Size(183, 21);
            this.comboBoxSector.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Depósito Origen:";
            // 
            // comboBoxDeposito
            // 
            this.comboBoxDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDeposito.FormattingEnabled = true;
            this.comboBoxDeposito.Location = new System.Drawing.Point(110, 6);
            this.comboBoxDeposito.Name = "comboBoxDeposito";
            this.comboBoxDeposito.Size = new System.Drawing.Size(183, 21);
            this.comboBoxDeposito.TabIndex = 21;
            this.comboBoxDeposito.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeposito_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxRemito);
            this.panel1.Controls.Add(this.comboBoxArticulo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBoxSubRubro);
            this.panel1.Controls.Add(this.textBoxFactura);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxSector);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxDeposito);
            this.panel1.Location = new System.Drawing.Point(15, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 82);
            this.panel1.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Articulo:";
            // 
            // textBoxRemito
            // 
            this.textBoxRemito.Location = new System.Drawing.Point(317, 49);
            this.textBoxRemito.Name = "textBoxRemito";
            this.textBoxRemito.Size = new System.Drawing.Size(127, 20);
            this.textBoxRemito.TabIndex = 3;
            // 
            // comboBoxArticulo
            // 
            this.comboBoxArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxArticulo.FormattingEnabled = true;
            this.comboBoxArticulo.Location = new System.Drawing.Point(512, 48);
            this.comboBoxArticulo.Name = "comboBoxArticulo";
            this.comboBoxArticulo.Size = new System.Drawing.Size(384, 21);
            this.comboBoxArticulo.TabIndex = 33;
            this.comboBoxArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxArticulo_KeyPress);
            this.comboBoxArticulo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxArticulo_MouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Num. Remito:";
            // 
            // textBoxFactura
            // 
            this.textBoxFactura.Location = new System.Drawing.Point(93, 49);
            this.textBoxFactura.Name = "textBoxFactura";
            this.textBoxFactura.Size = new System.Drawing.Size(138, 20);
            this.textBoxFactura.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Num. Factura:";
            // 
            // dataGridViewArticulos
            // 
            this.dataGridViewArticulos.AllowUserToAddRows = false;
            this.dataGridViewArticulos.AllowUserToOrderColumns = true;
            this.dataGridViewArticulos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Articulo_ID,
            this.Articulo,
            this.Cant_Faltante,
            this.Cant_RecibidaDeMas,
            this.Cant_RecibidaError,
            this.Anotacion});
            this.dataGridViewArticulos.EnableHeadersVisualStyles = false;
            this.dataGridViewArticulos.Location = new System.Drawing.Point(15, 122);
            this.dataGridViewArticulos.Name = "dataGridViewArticulos";
            this.dataGridViewArticulos.Size = new System.Drawing.Size(1008, 332);
            this.dataGridViewArticulos.TabIndex = 30;
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPrint,
            this.toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 457);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(1035, 50);
            this.toolStripEvents.TabIndex = 31;
            this.toolStripEvents.Text = "toolStrip1";
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.Image = global::StaCatalina.Properties.Resources.user;
            this.toolStripButtonPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(101, 47);
            this.toolStripButtonPrint.Text = "Enviar Mail";
            this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Num. Plantilla";
            // 
            // NumPlantilla
            // 
            this.NumPlantilla.AutoSize = true;
            this.NumPlantilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPlantilla.Location = new System.Drawing.Point(85, 10);
            this.NumPlantilla.Name = "NumPlantilla";
            this.NumPlantilla.Size = new System.Drawing.Size(40, 16);
            this.NumPlantilla.TabIndex = 32;
            this.NumPlantilla.Text = "0001";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(357, 472);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(194, 23);
            this.progressBar1.TabIndex = 33;
            // 
            // Articulo_ID
            // 
            this.Articulo_ID.HeaderText = "Codigo";
            this.Articulo_ID.Name = "Articulo_ID";
            this.Articulo_ID.ReadOnly = true;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            this.Articulo.Width = 179;
            // 
            // Cant_Faltante
            // 
            this.Cant_Faltante.HeaderText = "Cant. Faltante";
            this.Cant_Faltante.Name = "Cant_Faltante";
            this.Cant_Faltante.Width = 150;
            // 
            // Cant_RecibidaDeMas
            // 
            this.Cant_RecibidaDeMas.HeaderText = "Cant. recibida de mas";
            this.Cant_RecibidaDeMas.Name = "Cant_RecibidaDeMas";
            this.Cant_RecibidaDeMas.Width = 178;
            // 
            // Cant_RecibidaError
            // 
            this.Cant_RecibidaError.HeaderText = "Recibido por error";
            this.Cant_RecibidaError.Name = "Cant_RecibidaError";
            this.Cant_RecibidaError.Width = 179;
            // 
            // Anotacion
            // 
            this.Anotacion.HeaderText = "Anotación";
            this.Anotacion.Name = "Anotacion";
            this.Anotacion.Width = 150;
            // 
            // Frm_ReclamoMercaderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 507);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.NumPlantilla);
            this.Controls.Add(this.toolStripEvents);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewArticulos);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ReclamoMercaderia";
            this.Text = "Reclamo de Mercadería";
            this.Load += new System.EventHandler(this.Frm_ReclamoMercaderia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulos)).EndInit();
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSubRubro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDeposito;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxRemito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewArticulos;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.Label NumPlantilla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxArticulo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant_Faltante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant_RecibidaDeMas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant_RecibidaError;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anotacion;
    }
}