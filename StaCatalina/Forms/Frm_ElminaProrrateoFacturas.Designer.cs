namespace StaCatalina.Forms
{
    partial class Frm_ElminaProrrateoFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ElminaProrrateoFacturas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewFacturas = new System.Windows.Forms.DataGridView();
            this.codEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeleccionaReq = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.scc_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sccsuc_Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sccemp_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProrrateo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Letra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoComprob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripComprob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProveed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonTodas = new System.Windows.Forms.RadioButton();
            this.radioButtonCuotas = new System.Windows.Forms.RadioButton();
            this.radioButtonEmpresa = new System.Windows.Forms.RadioButton();
            this.toolStripEvents.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturas)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.toolStripEvents.Location = new System.Drawing.Point(0, 611);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(1272, 50);
            this.toolStripEvents.TabIndex = 12;
            this.toolStripEvents.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(101, 47);
            this.toolStripButtonSave.Text = "Guardar";
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
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridViewFacturas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 611);
            this.panel1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimeHasta);
            this.groupBox1.Controls.Add(this.dateTimeDesde);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1272, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese un Rango de Fecha";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(772, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(488, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota: Si la Factura está en ambas Empresas, debe seleccionar todas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Emisión Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Emisión Desde:";
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeHasta.Location = new System.Drawing.Point(291, 48);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(105, 20);
            this.dateTimeHasta.TabIndex = 1;
            this.dateTimeHasta.ValueChanged += new System.EventHandler(this.dateTimeHasta_ValueChanged);
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDesde.Location = new System.Drawing.Point(291, 16);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(105, 20);
            this.dateTimeDesde.TabIndex = 0;
            this.dateTimeDesde.ValueChanged += new System.EventHandler(this.dateTimeDesde_ValueChanged);
            // 
            // dataGridViewFacturas
            // 
            this.dataGridViewFacturas.AllowUserToAddRows = false;
            this.dataGridViewFacturas.AllowUserToDeleteRows = false;
            this.dataGridViewFacturas.AllowUserToResizeColumns = false;
            this.dataGridViewFacturas.AllowUserToResizeRows = false;
            this.dataGridViewFacturas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridViewFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEmp,
            this.SeleccionaReq,
            this.scc_ID,
            this.sccsuc_Cod,
            this.sccemp_Codigo,
            this.TipoProrrateo,
            this.FEmision,
            this.Letra,
            this.CodigoComprob,
            this.DescripComprob,
            this.Comprobante,
            this.codProveed,
            this.RazonSocial});
            this.dataGridViewFacturas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewFacturas.EnableHeadersVisualStyles = false;
            this.dataGridViewFacturas.Location = new System.Drawing.Point(0, 79);
            this.dataGridViewFacturas.Name = "dataGridViewFacturas";
            this.dataGridViewFacturas.RowHeadersVisible = false;
            this.dataGridViewFacturas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewFacturas.Size = new System.Drawing.Size(1272, 532);
            this.dataGridViewFacturas.TabIndex = 1;
            this.dataGridViewFacturas.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewFacturas_CurrentCellDirtyStateChanged);
            // 
            // codEmp
            // 
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codEmp.DefaultCellStyle = dataGridViewCellStyle32;
            this.codEmp.HeaderText = "codEmp";
            this.codEmp.Name = "codEmp";
            this.codEmp.ReadOnly = true;
            // 
            // SeleccionaReq
            // 
            this.SeleccionaReq.HeaderText = "Selecciona";
            this.SeleccionaReq.Name = "SeleccionaReq";
            // 
            // scc_ID
            // 
            this.scc_ID.HeaderText = "scc_ID";
            this.scc_ID.Name = "scc_ID";
            this.scc_ID.Visible = false;
            // 
            // sccsuc_Cod
            // 
            this.sccsuc_Cod.HeaderText = "sccsuc_Cod";
            this.sccsuc_Cod.Name = "sccsuc_Cod";
            this.sccsuc_Cod.Visible = false;
            // 
            // sccemp_Codigo
            // 
            this.sccemp_Codigo.HeaderText = "sccemp_Codigo";
            this.sccemp_Codigo.Name = "sccemp_Codigo";
            this.sccemp_Codigo.Visible = false;
            // 
            // TipoProrrateo
            // 
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TipoProrrateo.DefaultCellStyle = dataGridViewCellStyle33;
            this.TipoProrrateo.HeaderText = "Tipo Prorrateo";
            this.TipoProrrateo.Name = "TipoProrrateo";
            this.TipoProrrateo.ReadOnly = true;
            // 
            // FEmision
            // 
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FEmision.DefaultCellStyle = dataGridViewCellStyle34;
            this.FEmision.HeaderText = "F. Emisión";
            this.FEmision.Name = "FEmision";
            this.FEmision.ReadOnly = true;
            this.FEmision.Width = 80;
            // 
            // Letra
            // 
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Letra.DefaultCellStyle = dataGridViewCellStyle35;
            this.Letra.HeaderText = "Letra";
            this.Letra.Name = "Letra";
            this.Letra.ReadOnly = true;
            this.Letra.Width = 40;
            // 
            // CodigoComprob
            // 
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CodigoComprob.DefaultCellStyle = dataGridViewCellStyle36;
            this.CodigoComprob.HeaderText = "Código";
            this.CodigoComprob.Name = "CodigoComprob";
            this.CodigoComprob.ReadOnly = true;
            this.CodigoComprob.Width = 60;
            // 
            // DescripComprob
            // 
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DescripComprob.DefaultCellStyle = dataGridViewCellStyle37;
            this.DescripComprob.HeaderText = "Descrip. Comprob.";
            this.DescripComprob.Name = "DescripComprob";
            this.DescripComprob.ReadOnly = true;
            // 
            // Comprobante
            // 
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Comprobante.DefaultCellStyle = dataGridViewCellStyle38;
            this.Comprobante.HeaderText = "Comprobante";
            this.Comprobante.Name = "Comprobante";
            this.Comprobante.ReadOnly = true;
            // 
            // codProveed
            // 
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.codProveed.DefaultCellStyle = dataGridViewCellStyle39;
            this.codProveed.HeaderText = "codProveed";
            this.codProveed.Name = "codProveed";
            this.codProveed.ReadOnly = true;
            // 
            // RazonSocial
            // 
            this.RazonSocial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.RazonSocial.DefaultCellStyle = dataGridViewCellStyle40;
            this.RazonSocial.HeaderText = "RazonSocial";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonEmpresa);
            this.groupBox2.Controls.Add(this.radioButtonCuotas);
            this.groupBox2.Controls.Add(this.radioButtonTodas);
            this.groupBox2.Location = new System.Drawing.Point(438, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 66);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro Prorrateo";
            // 
            // radioButtonTodas
            // 
            this.radioButtonTodas.AutoSize = true;
            this.radioButtonTodas.Checked = true;
            this.radioButtonTodas.Location = new System.Drawing.Point(20, 31);
            this.radioButtonTodas.Name = "radioButtonTodas";
            this.radioButtonTodas.Size = new System.Drawing.Size(55, 17);
            this.radioButtonTodas.TabIndex = 0;
            this.radioButtonTodas.TabStop = true;
            this.radioButtonTodas.Text = "Todas";
            this.radioButtonTodas.UseVisualStyleBackColor = true;
            this.radioButtonTodas.CheckedChanged += new System.EventHandler(this.radioButtonTodas_CheckedChanged);
            // 
            // radioButtonCuotas
            // 
            this.radioButtonCuotas.AutoSize = true;
            this.radioButtonCuotas.Location = new System.Drawing.Point(117, 31);
            this.radioButtonCuotas.Name = "radioButtonCuotas";
            this.radioButtonCuotas.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCuotas.TabIndex = 1;
            this.radioButtonCuotas.Text = "Cuotas";
            this.radioButtonCuotas.UseVisualStyleBackColor = true;
            this.radioButtonCuotas.CheckedChanged += new System.EventHandler(this.radioButtonCuotas_CheckedChanged);
            // 
            // radioButtonEmpresa
            // 
            this.radioButtonEmpresa.AutoSize = true;
            this.radioButtonEmpresa.Location = new System.Drawing.Point(213, 31);
            this.radioButtonEmpresa.Name = "radioButtonEmpresa";
            this.radioButtonEmpresa.Size = new System.Drawing.Size(66, 17);
            this.radioButtonEmpresa.TabIndex = 2;
            this.radioButtonEmpresa.Text = "Empresa";
            this.radioButtonEmpresa.UseVisualStyleBackColor = true;
            this.radioButtonEmpresa.CheckedChanged += new System.EventHandler(this.radioButtonEmpresa_CheckedChanged);
            // 
            // Frm_ElminaProrrateoFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1272, 661);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripEvents);
            this.Name = "Frm_ElminaProrrateoFacturas";
            this.Text = "Elimina Prorrateo Facturas";
            this.Load += new System.EventHandler(this.Frm_ElminaProrrateoFacturas_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private System.Windows.Forms.DataGridView dataGridViewFacturas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SeleccionaReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn scc_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sccsuc_Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn sccemp_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProrrateo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Letra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoComprob;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripComprob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProveed;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonEmpresa;
        private System.Windows.Forms.RadioButton radioButtonCuotas;
        private System.Windows.Forms.RadioButton radioButtonTodas;
    }
}
