namespace StaCatalina.Stock
{
    partial class Frm_NecesidadReposicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NecesidadReposicion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxProrrateo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButtonArticulo = new System.Windows.Forms.RadioButton();
            this.radioButtonRubro = new System.Windows.Forms.RadioButton();
            this.radioButtonSubRubro = new System.Windows.Forms.RadioButton();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonConNecesidad = new System.Windows.Forms.RadioButton();
            this.radioButtonNecesidadTodos = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeFHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFDesde = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDeposito = new System.Windows.Forms.DataGridView();
            this.Deposito_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Incluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxcodEmp = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxArticulo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSubRubro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRubro = new System.Windows.Forms.ComboBox();
            this.toolStripEvents.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.toolStripEvents.Location = new System.Drawing.Point(0, 368);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(703, 50);
            this.toolStripEvents.TabIndex = 20;
            this.toolStripEvents.Text = "toolStrip1";
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrint.Image")));
            this.toolStripButtonPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(105, 47);
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
            this.toolStripButtonClose.Size = new System.Drawing.Size(83, 47);
            this.toolStripButtonClose.Text = "Cerrar";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxProrrateo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimeFHasta);
            this.groupBox1.Controls.Add(this.dateTimeFDesde);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxcodEmp);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 178);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Fecha desde Hasta";
            // 
            // textBoxProrrateo
            // 
            this.textBoxProrrateo.Location = new System.Drawing.Point(198, 146);
            this.textBoxProrrateo.Name = "textBoxProrrateo";
            this.textBoxProrrateo.Size = new System.Drawing.Size(48, 20);
            this.textBoxProrrateo.TabIndex = 25;
            this.textBoxProrrateo.Text = "50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Porcentaje Prorrateo para EGES(%):";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButtonArticulo);
            this.groupBox5.Controls.Add(this.radioButtonRubro);
            this.groupBox5.Controls.Add(this.radioButtonSubRubro);
            this.groupBox5.Controls.Add(this.radioButtonTodos);
            this.groupBox5.Location = new System.Drawing.Point(235, 46);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(262, 98);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Opciones";
            // 
            // radioButtonArticulo
            // 
            this.radioButtonArticulo.AutoSize = true;
            this.radioButtonArticulo.Location = new System.Drawing.Point(139, 19);
            this.radioButtonArticulo.Name = "radioButtonArticulo";
            this.radioButtonArticulo.Size = new System.Drawing.Size(78, 17);
            this.radioButtonArticulo.TabIndex = 14;
            this.radioButtonArticulo.Text = "Un artículo";
            this.radioButtonArticulo.UseVisualStyleBackColor = true;
            this.radioButtonArticulo.CheckedChanged += new System.EventHandler(this.radioButtonArticulo_CheckedChanged);
            // 
            // radioButtonRubro
            // 
            this.radioButtonRubro.AutoSize = true;
            this.radioButtonRubro.Checked = true;
            this.radioButtonRubro.Location = new System.Drawing.Point(13, 19);
            this.radioButtonRubro.Name = "radioButtonRubro";
            this.radioButtonRubro.Size = new System.Drawing.Size(73, 17);
            this.radioButtonRubro.TabIndex = 12;
            this.radioButtonRubro.TabStop = true;
            this.radioButtonRubro.Text = "Por Rubro";
            this.radioButtonRubro.UseVisualStyleBackColor = true;
            this.radioButtonRubro.CheckedChanged += new System.EventHandler(this.radioButtonRubro_CheckedChanged);
            // 
            // radioButtonSubRubro
            // 
            this.radioButtonSubRubro.AutoSize = true;
            this.radioButtonSubRubro.Location = new System.Drawing.Point(13, 52);
            this.radioButtonSubRubro.Name = "radioButtonSubRubro";
            this.radioButtonSubRubro.Size = new System.Drawing.Size(95, 17);
            this.radioButtonSubRubro.TabIndex = 13;
            this.radioButtonSubRubro.Text = "Por Sub Rubro";
            this.radioButtonSubRubro.UseVisualStyleBackColor = true;
            this.radioButtonSubRubro.CheckedChanged += new System.EventHandler(this.radioButtonSubRubro_CheckedChanged);
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(139, 52);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(115, 17);
            this.radioButtonTodos.TabIndex = 15;
            this.radioButtonTodos.Text = "Todos los artículos";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            this.radioButtonTodos.CheckedChanged += new System.EventHandler(this.radioButtonTodos_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonConNecesidad);
            this.groupBox4.Controls.Add(this.radioButtonNecesidadTodos);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox4.Location = new System.Drawing.Point(503, 44);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(123, 100);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mostrar";
            // 
            // radioButtonConNecesidad
            // 
            this.radioButtonConNecesidad.AutoSize = true;
            this.radioButtonConNecesidad.Location = new System.Drawing.Point(22, 65);
            this.radioButtonConNecesidad.Name = "radioButtonConNecesidad";
            this.radioButtonConNecesidad.Size = new System.Drawing.Size(98, 17);
            this.radioButtonConNecesidad.TabIndex = 1;
            this.radioButtonConNecesidad.Text = "Con Necesidad";
            this.radioButtonConNecesidad.UseVisualStyleBackColor = true;
            // 
            // radioButtonNecesidadTodos
            // 
            this.radioButtonNecesidadTodos.AutoSize = true;
            this.radioButtonNecesidadTodos.Checked = true;
            this.radioButtonNecesidadTodos.Location = new System.Drawing.Point(22, 32);
            this.radioButtonNecesidadTodos.Name = "radioButtonNecesidadTodos";
            this.radioButtonNecesidadTodos.Size = new System.Drawing.Size(55, 17);
            this.radioButtonNecesidadTodos.TabIndex = 0;
            this.radioButtonNecesidadTodos.TabStop = true;
            this.radioButtonNecesidadTodos.Text = "Todos";
            this.radioButtonNecesidadTodos.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Fecha Hasta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Fecha Desde:";
            // 
            // dateTimeFHasta
            // 
            this.dateTimeFHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFHasta.Location = new System.Drawing.Point(91, 97);
            this.dateTimeFHasta.Name = "dateTimeFHasta";
            this.dateTimeFHasta.Size = new System.Drawing.Size(109, 20);
            this.dateTimeFHasta.TabIndex = 19;
            // 
            // dateTimeFDesde
            // 
            this.dateTimeFDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFDesde.Location = new System.Drawing.Point(91, 59);
            this.dateTimeFDesde.Name = "dateTimeFDesde";
            this.dateTimeFDesde.Size = new System.Drawing.Size(109, 20);
            this.dateTimeFDesde.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewDeposito);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(656, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(44, 159);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
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
            this.dataGridViewDeposito.Size = new System.Drawing.Size(38, 140);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 17);
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
            "EGESAC S.A.",
            "RSC S.A."});
            this.comboBoxcodEmp.Location = new System.Drawing.Point(605, 12);
            this.comboBoxcodEmp.Name = "comboBoxcodEmp";
            this.comboBoxcodEmp.Size = new System.Drawing.Size(32, 21);
            this.comboBoxcodEmp.TabIndex = 10;
            this.comboBoxcodEmp.Visible = false;
            this.comboBoxcodEmp.SelectedIndexChanged += new System.EventHandler(this.comboBoxcodEmp_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBoxArticulo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxSubRubro);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxRubro);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 187);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(178, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Para el cálculo, se toma mes completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 109);
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
            this.comboBoxArticulo.Enabled = false;
            this.comboBoxArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxArticulo.FormattingEnabled = true;
            this.comboBoxArticulo.Location = new System.Drawing.Point(78, 105);
            this.comboBoxArticulo.Name = "comboBoxArticulo";
            this.comboBoxArticulo.Size = new System.Drawing.Size(432, 21);
            this.comboBoxArticulo.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 74);
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
            this.comboBoxSubRubro.Enabled = false;
            this.comboBoxSubRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSubRubro.FormattingEnabled = true;
            this.comboBoxSubRubro.Location = new System.Drawing.Point(130, 70);
            this.comboBoxSubRubro.Name = "comboBoxSubRubro";
            this.comboBoxSubRubro.Size = new System.Drawing.Size(305, 21);
            this.comboBoxSubRubro.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 39);
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
            this.comboBoxRubro.Location = new System.Drawing.Point(130, 35);
            this.comboBoxRubro.Name = "comboBoxRubro";
            this.comboBoxRubro.Size = new System.Drawing.Size(305, 21);
            this.comboBoxRubro.TabIndex = 21;
            // 
            // Frm_NecesidadReposicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(703, 418);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripEvents);
            this.Name = "Frm_NecesidadReposicion";
            this.Text = "Necesidad de Reposición";
            this.Load += new System.EventHandler(this.Frm_NecesidadReposicion_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeFHasta;
        private System.Windows.Forms.DateTimePicker dateTimeFDesde;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonConNecesidad;
        private System.Windows.Forms.RadioButton radioButtonNecesidadTodos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxProrrateo;
        private System.Windows.Forms.Label label2;
    }
}
