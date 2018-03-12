namespace StaCatalina.Forms
{
    partial class Frm_Productos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Productos));
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.artcodgenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artdescgenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unimedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cladescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceProd = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxrubro = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxBuscarProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;
            this.dataGridViewProductos.AutoGenerateColumns = false;
            this.dataGridViewProductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artcodgenDataGridViewTextBoxColumn,
            this.artdescgenDataGridViewTextBoxColumn,
            this.unimedDataGridViewTextBoxColumn,
            this.cladescDataGridViewTextBoxColumn});
            this.dataGridViewProductos.DataSource = this.bindingSourceProd;
            this.dataGridViewProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewProductos.EnableHeadersVisualStyles = false;
            this.dataGridViewProductos.Location = new System.Drawing.Point(0, 88);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewProductos.Size = new System.Drawing.Size(695, 451);
            this.dataGridViewProductos.TabIndex = 0;
            this.dataGridViewProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellDoubleClick);
            this.dataGridViewProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewProductos_KeyDown);
            // 
            // artcodgenDataGridViewTextBoxColumn
            // 
            this.artcodgenDataGridViewTextBoxColumn.DataPropertyName = "art_codgen";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.artcodgenDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.artcodgenDataGridViewTextBoxColumn.HeaderText = "Código";
            this.artcodgenDataGridViewTextBoxColumn.Name = "artcodgenDataGridViewTextBoxColumn";
            this.artcodgenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artdescgenDataGridViewTextBoxColumn
            // 
            this.artdescgenDataGridViewTextBoxColumn.DataPropertyName = "art_descgen";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.artdescgenDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.artdescgenDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.artdescgenDataGridViewTextBoxColumn.Name = "artdescgenDataGridViewTextBoxColumn";
            this.artdescgenDataGridViewTextBoxColumn.ReadOnly = true;
            this.artdescgenDataGridViewTextBoxColumn.Width = 450;
            // 
            // unimedDataGridViewTextBoxColumn
            // 
            this.unimedDataGridViewTextBoxColumn.DataPropertyName = "unimed";
            this.unimedDataGridViewTextBoxColumn.HeaderText = "UniMed";
            this.unimedDataGridViewTextBoxColumn.Name = "unimedDataGridViewTextBoxColumn";
            this.unimedDataGridViewTextBoxColumn.ReadOnly = true;
            this.unimedDataGridViewTextBoxColumn.Width = 70;
            // 
            // cladescDataGridViewTextBoxColumn
            // 
            this.cladescDataGridViewTextBoxColumn.DataPropertyName = "cla_desc";
            this.cladescDataGridViewTextBoxColumn.HeaderText = "cla_desc";
            this.cladescDataGridViewTextBoxColumn.Name = "cladescDataGridViewTextBoxColumn";
            this.cladescDataGridViewTextBoxColumn.ReadOnly = true;
            this.cladescDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSourceProd
            // 
            this.bindingSourceProd.DataSource = typeof(Entities.Procedures.H_ARTICULOSDEPOSITO);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxrubro);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.textBoxBuscarProd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rubro:";
            // 
            // comboBoxrubro
            // 
            this.comboBoxrubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxrubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxrubro.FormattingEnabled = true;
            this.comboBoxrubro.Location = new System.Drawing.Point(83, 18);
            this.comboBoxrubro.Name = "comboBoxrubro";
            this.comboBoxrubro.Size = new System.Drawing.Size(418, 21);
            this.comboBoxrubro.TabIndex = 6;
            this.comboBoxrubro.SelectedIndexChanged += new System.EventHandler(this.comboBoxrubro_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonSearch.Location = new System.Drawing.Point(526, 48);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 27);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxBuscarProd
            // 
            this.textBoxBuscarProd.Location = new System.Drawing.Point(83, 50);
            this.textBoxBuscarProd.Name = "textBoxBuscarProd";
            this.textBoxBuscarProd.Size = new System.Drawing.Size(442, 20);
            this.textBoxBuscarProd.TabIndex = 1;
            this.textBoxBuscarProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBuscarProd_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // Frm_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 539);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Frm_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.BindingSource bindingSourceProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn artcodgenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artdescgenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unimedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cladescDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxBuscarProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxrubro;
        private System.Windows.Forms.Label label2;
    }
}