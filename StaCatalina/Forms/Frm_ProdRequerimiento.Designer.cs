namespace StaCatalina.Forms
{
    partial class Frm_ProdRequerimiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ProdRequerimiento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewProdReq = new System.Windows.Forms.DataGridView();
            this.artcodgenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artdescgenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unimedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cladescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceReq = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxrubro = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceReq)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewProdReq);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 539);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewProdReq
            // 
            this.dataGridViewProdReq.AllowUserToAddRows = false;
            this.dataGridViewProdReq.AllowUserToDeleteRows = false;
            this.dataGridViewProdReq.AutoGenerateColumns = false;
            this.dataGridViewProdReq.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProdReq.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProdReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdReq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artcodgenDataGridViewTextBoxColumn,
            this.artdescgenDataGridViewTextBoxColumn,
            this.unimedDataGridViewTextBoxColumn,
            this.cladescDataGridViewTextBoxColumn,
            this.presentacion,
            this.medida});
            this.dataGridViewProdReq.DataSource = this.bindingSourceReq;
            this.dataGridViewProdReq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProdReq.EnableHeadersVisualStyles = false;
            this.dataGridViewProdReq.Location = new System.Drawing.Point(0, 81);
            this.dataGridViewProdReq.Name = "dataGridViewProdReq";
            this.dataGridViewProdReq.Size = new System.Drawing.Size(909, 458);
            this.dataGridViewProdReq.TabIndex = 1;
            this.dataGridViewProdReq.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdReq_CellContentDoubleClick);
            this.dataGridViewProdReq.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewProdReq_KeyDown);
            // 
            // artcodgenDataGridViewTextBoxColumn
            // 
            this.artcodgenDataGridViewTextBoxColumn.DataPropertyName = "art_codgen";
            this.artcodgenDataGridViewTextBoxColumn.HeaderText = "Código";
            this.artcodgenDataGridViewTextBoxColumn.Name = "artcodgenDataGridViewTextBoxColumn";
            // 
            // artdescgenDataGridViewTextBoxColumn
            // 
            this.artdescgenDataGridViewTextBoxColumn.DataPropertyName = "art_descgen";
            this.artdescgenDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.artdescgenDataGridViewTextBoxColumn.Name = "artdescgenDataGridViewTextBoxColumn";
            this.artdescgenDataGridViewTextBoxColumn.Width = 450;
            // 
            // unimedDataGridViewTextBoxColumn
            // 
            this.unimedDataGridViewTextBoxColumn.DataPropertyName = "unimed";
            this.unimedDataGridViewTextBoxColumn.HeaderText = "Uni. Med";
            this.unimedDataGridViewTextBoxColumn.Name = "unimedDataGridViewTextBoxColumn";
            // 
            // cladescDataGridViewTextBoxColumn
            // 
            this.cladescDataGridViewTextBoxColumn.DataPropertyName = "cla_desc";
            this.cladescDataGridViewTextBoxColumn.HeaderText = "cla_desc";
            this.cladescDataGridViewTextBoxColumn.Name = "cladescDataGridViewTextBoxColumn";
            this.cladescDataGridViewTextBoxColumn.Visible = false;
            // 
            // presentacion
            // 
            this.presentacion.DataPropertyName = "presentacion";
            this.presentacion.HeaderText = "Presentación";
            this.presentacion.Name = "presentacion";
            this.presentacion.Width = 130;
            // 
            // medida
            // 
            this.medida.DataPropertyName = "medida";
            this.medida.HeaderText = "Medida";
            this.medida.Name = "medida";
            this.medida.Width = 60;
            // 
            // bindingSourceReq
            // 
            this.bindingSourceReq.DataSource = typeof(Entities.Procedures.H_ARTICULOSDEPOSITO);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxrubro);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.textBoxBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(909, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sub Rubro:";
            // 
            // comboBoxrubro
            // 
            this.comboBoxrubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxrubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxrubro.FormattingEnabled = true;
            this.comboBoxrubro.Location = new System.Drawing.Point(98, 19);
            this.comboBoxrubro.Name = "comboBoxrubro";
            this.comboBoxrubro.Size = new System.Drawing.Size(418, 21);
            this.comboBoxrubro.TabIndex = 6;
            this.comboBoxrubro.SelectedIndexChanged += new System.EventHandler(this.comboBoxrubro_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonSearch.Location = new System.Drawing.Point(517, 50);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(98, 51);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(418, 20);
            this.textBoxBuscar.TabIndex = 1;
            this.textBoxBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBuscar_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // Frm_ProdRequerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 539);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ProdRequerimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Frm_ProdRequerimiento_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceReq)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewProdReq;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSourceReq;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxrubro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn artcodgenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artdescgenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unimedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cladescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn medida;
    }
}