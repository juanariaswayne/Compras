namespace StaCatalina.Stock
{
    partial class Frm_PosicionContraStockMinimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PosicionContraStockMinimo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDeposito = new System.Windows.Forms.DataGridView();
            this.Deposito_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Incluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonArticulo = new System.Windows.Forms.RadioButton();
            this.radioButtonSubRubro = new System.Windows.Forms.RadioButton();
            this.radioButtonRubro = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxcodEmp = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxArticulo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSubRubro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRubro = new System.Windows.Forms.ComboBox();
            this.toolStripEvents.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeposito)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPrint,
            this.toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 364);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(702, 54);
            this.toolStripEvents.TabIndex = 21;
            this.toolStripEvents.Text = "toolStrip1";
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrint.Image")));
            this.toolStripButtonPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(105, 51);
            this.toolStripButtonPrint.Text = "Imprimir";
            this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClose.Image")));
            this.toolStripButtonClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Size = new System.Drawing.Size(83, 51);
            this.toolStripButtonClose.Text = "Cerrar";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.radioButtonTodos);
            this.groupBox1.Controls.Add(this.radioButtonArticulo);
            this.groupBox1.Controls.Add(this.radioButtonSubRubro);
            this.groupBox1.Controls.Add(this.radioButtonRubro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxcodEmp);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 198);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Depósito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Depósitos:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewDeposito);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(333, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 179);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // dataGridViewDeposito
            // 
            this.dataGridViewDeposito.AllowUserToAddRows = false;
            this.dataGridViewDeposito.AllowUserToDeleteRows = false;
            this.dataGridViewDeposito.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDeposito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDeposito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeposito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deposito_id,
            this.Incluir,
            this.codEmp,
            this.Descripcion});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDeposito.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDeposito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDeposito.EnableHeadersVisualStyles = false;
            this.dataGridViewDeposito.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDeposito.Name = "dataGridViewDeposito";
            this.dataGridViewDeposito.RowHeadersVisible = false;
            this.dataGridViewDeposito.Size = new System.Drawing.Size(360, 160);
            this.dataGridViewDeposito.TabIndex = 16;
            this.dataGridViewDeposito.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewDeposito_CurrentCellDirtyStateChanged);
            // 
            // Deposito_id
            // 
            this.Deposito_id.HeaderText = "Deposito_id";
            this.Deposito_id.Name = "Deposito_id";
            this.Deposito_id.Visible = false;
            // 
            // Incluir
            // 
            this.Incluir.HeaderText = "Incluir";
            this.Incluir.Name = "Incluir";
            this.Incluir.Width = 50;
            // 
            // codEmp
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codEmp.DefaultCellStyle = dataGridViewCellStyle2;
            this.codEmp.HeaderText = "Empresa";
            this.codEmp.Name = "codEmp";
            this.codEmp.Width = 70;
            // 
            // Descripcion
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 210;
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(192, 120);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(115, 17);
            this.radioButtonTodos.TabIndex = 15;
            this.radioButtonTodos.Text = "Todos los artículos";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            this.radioButtonTodos.CheckedChanged += new System.EventHandler(this.radioButtonTodos_CheckedChanged);
            // 
            // radioButtonArticulo
            // 
            this.radioButtonArticulo.AutoSize = true;
            this.radioButtonArticulo.Location = new System.Drawing.Point(192, 87);
            this.radioButtonArticulo.Name = "radioButtonArticulo";
            this.radioButtonArticulo.Size = new System.Drawing.Size(78, 17);
            this.radioButtonArticulo.TabIndex = 14;
            this.radioButtonArticulo.Text = "Un artículo";
            this.radioButtonArticulo.UseVisualStyleBackColor = true;
            this.radioButtonArticulo.CheckedChanged += new System.EventHandler(this.radioButtonArticulo_CheckedChanged);
            // 
            // radioButtonSubRubro
            // 
            this.radioButtonSubRubro.AutoSize = true;
            this.radioButtonSubRubro.Location = new System.Drawing.Point(50, 120);
            this.radioButtonSubRubro.Name = "radioButtonSubRubro";
            this.radioButtonSubRubro.Size = new System.Drawing.Size(95, 17);
            this.radioButtonSubRubro.TabIndex = 13;
            this.radioButtonSubRubro.Text = "Por Sub Rubro";
            this.radioButtonSubRubro.UseVisualStyleBackColor = true;
            this.radioButtonSubRubro.CheckedChanged += new System.EventHandler(this.radioButtonSubRubro_CheckedChanged);
            // 
            // radioButtonRubro
            // 
            this.radioButtonRubro.AutoSize = true;
            this.radioButtonRubro.Checked = true;
            this.radioButtonRubro.Location = new System.Drawing.Point(50, 87);
            this.radioButtonRubro.Name = "radioButtonRubro";
            this.radioButtonRubro.Size = new System.Drawing.Size(73, 17);
            this.radioButtonRubro.TabIndex = 12;
            this.radioButtonRubro.TabStop = true;
            this.radioButtonRubro.Text = "Por Rubro";
            this.radioButtonRubro.UseVisualStyleBackColor = true;
            this.radioButtonRubro.CheckedChanged += new System.EventHandler(this.radioButtonRubro_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Empresa:";
            this.label5.Visible = false;
            // 
            // comboBoxcodEmp
            // 
            this.comboBoxcodEmp.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxcodEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxcodEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxcodEmp.FormattingEnabled = true;
            this.comboBoxcodEmp.Items.AddRange(new object[] {
            "Ambas Empresas",
            "EGESAC S.A.",
            "RSC S.A."});
            this.comboBoxcodEmp.Location = new System.Drawing.Point(223, 16);
            this.comboBoxcodEmp.Name = "comboBoxcodEmp";
            this.comboBoxcodEmp.Size = new System.Drawing.Size(50, 21);
            this.comboBoxcodEmp.TabIndex = 10;
            this.comboBoxcodEmp.Visible = false;
            this.comboBoxcodEmp.SelectedIndexChanged += new System.EventHandler(this.comboBoxcodEmp_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBoxArticulo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxSubRubro);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxRubro);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 174);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Articulo:";
            // 
            // comboBoxArticulo
            // 
            this.comboBoxArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxArticulo.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxArticulo.FormattingEnabled = true;
            this.comboBoxArticulo.Location = new System.Drawing.Point(130, 105);
            this.comboBoxArticulo.Name = "comboBoxArticulo";
            this.comboBoxArticulo.Size = new System.Drawing.Size(432, 21);
            this.comboBoxArticulo.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sub Rubro:";
            // 
            // comboBoxSubRubro
            // 
            this.comboBoxSubRubro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxSubRubro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSubRubro.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxSubRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSubRubro.FormattingEnabled = true;
            this.comboBoxSubRubro.Location = new System.Drawing.Point(130, 73);
            this.comboBoxSubRubro.Name = "comboBoxSubRubro";
            this.comboBoxSubRubro.Size = new System.Drawing.Size(305, 21);
            this.comboBoxSubRubro.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Rubro:";
            // 
            // comboBoxRubro
            // 
            this.comboBoxRubro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxRubro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxRubro.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRubro.FormattingEnabled = true;
            this.comboBoxRubro.Location = new System.Drawing.Point(130, 38);
            this.comboBoxRubro.Name = "comboBoxRubro";
            this.comboBoxRubro.Size = new System.Drawing.Size(305, 21);
            this.comboBoxRubro.TabIndex = 21;
            // 
            // Frm_PosicionContraStockMinimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(702, 418);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripEvents);
            this.Name = "Frm_PosicionContraStockMinimo";
            this.Text = "Posición contra Stock Mínimo";
            this.Load += new System.EventHandler(this.Frm_PosicionContraStockMinimo_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeposito)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewDeposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposito_id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Incluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonArticulo;
        private System.Windows.Forms.RadioButton radioButtonSubRubro;
        private System.Windows.Forms.RadioButton radioButtonRubro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxcodEmp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxArticulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSubRubro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRubro;
        private System.Windows.Forms.Label label2;
    }
}
