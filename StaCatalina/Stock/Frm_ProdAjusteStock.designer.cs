namespace StaCatalina.Stock
{
    partial class Frm_ProdAjusteStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ProdAjusteStock));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxrubro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProdAjusteStock = new System.Windows.Forms.DataGridView();
            this.bindingSourceIngStock = new System.Windows.Forms.BindingSource(this.components);
            this.artcodgenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artdescgenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unimedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cladescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llevavencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdAjusteStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceIngStock)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxrubro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.textBoxBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1084, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador";
            // 
            // comboBoxrubro
            // 
            this.comboBoxrubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxrubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxrubro.FormattingEnabled = true;
            this.comboBoxrubro.Location = new System.Drawing.Point(147, 29);
            this.comboBoxrubro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxrubro.Name = "comboBoxrubro";
            this.comboBoxrubro.Size = new System.Drawing.Size(625, 28);
            this.comboBoxrubro.TabIndex = 7;
            this.comboBoxrubro.SelectedIndexChanged += new System.EventHandler(this.comboBoxrubro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rubro:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonSearch.Location = new System.Drawing.Point(778, 74);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(112, 35);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(147, 75);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(625, 26);
            this.textBoxBuscar.TabIndex = 1;
            this.textBoxBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBuscar_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // dataGridViewProdAjusteStock
            // 
            this.dataGridViewProdAjusteStock.AllowUserToAddRows = false;
            this.dataGridViewProdAjusteStock.AllowUserToDeleteRows = false;
            this.dataGridViewProdAjusteStock.AutoGenerateColumns = false;
            this.dataGridViewProdAjusteStock.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProdAjusteStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProdAjusteStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdAjusteStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artcodgenDataGridViewTextBoxColumn,
            this.artdescgenDataGridViewTextBoxColumn,
            this.unimedDataGridViewTextBoxColumn,
            this.cladescDataGridViewTextBoxColumn,
            this.llevavencimiento});
            this.dataGridViewProdAjusteStock.DataSource = this.bindingSourceIngStock;
            this.dataGridViewProdAjusteStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProdAjusteStock.EnableHeadersVisualStyles = false;
            this.dataGridViewProdAjusteStock.Location = new System.Drawing.Point(0, 123);
            this.dataGridViewProdAjusteStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewProdAjusteStock.Name = "dataGridViewProdAjusteStock";
            this.dataGridViewProdAjusteStock.ReadOnly = true;
            this.dataGridViewProdAjusteStock.Size = new System.Drawing.Size(1084, 717);
            this.dataGridViewProdAjusteStock.TabIndex = 3;
            this.dataGridViewProdAjusteStock.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdIngStock_CellContentDoubleClick);
            this.dataGridViewProdAjusteStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewProdAjusteStock_KeyDown);
            // 
            // bindingSourceIngStock
            // 
            this.bindingSourceIngStock.DataSource = typeof(Entities.Procedures.H_ARTICULOSDEPOSITO);
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
            this.artdescgenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.artdescgenDataGridViewTextBoxColumn.DataPropertyName = "art_descgen";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.artdescgenDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.artdescgenDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.artdescgenDataGridViewTextBoxColumn.Name = "artdescgenDataGridViewTextBoxColumn";
            this.artdescgenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unimedDataGridViewTextBoxColumn
            // 
            this.unimedDataGridViewTextBoxColumn.DataPropertyName = "unimed";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.unimedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.unimedDataGridViewTextBoxColumn.HeaderText = "Uni. Med";
            this.unimedDataGridViewTextBoxColumn.Name = "unimedDataGridViewTextBoxColumn";
            this.unimedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cladescDataGridViewTextBoxColumn
            // 
            this.cladescDataGridViewTextBoxColumn.DataPropertyName = "cla_desc";
            this.cladescDataGridViewTextBoxColumn.HeaderText = "cla_desc";
            this.cladescDataGridViewTextBoxColumn.Name = "cladescDataGridViewTextBoxColumn";
            this.cladescDataGridViewTextBoxColumn.ReadOnly = true;
            this.cladescDataGridViewTextBoxColumn.Visible = false;
            // 
            // llevavencimiento
            // 
            this.llevavencimiento.DataPropertyName = "llevavencimiento";
            this.llevavencimiento.HeaderText = "llevavencimiento";
            this.llevavencimiento.Name = "llevavencimiento";
            this.llevavencimiento.ReadOnly = true;
            this.llevavencimiento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.llevavencimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.llevavencimiento.Visible = false;
            // 
            // Frm_ProdAjusteStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 840);
            this.Controls.Add(this.dataGridViewProdAjusteStock);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ProdAjusteStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Frm_ProdAjusteStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdAjusteStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceIngStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProdAjusteStock;
        private System.Windows.Forms.BindingSource bindingSourceIngStock;
        private System.Windows.Forms.ComboBox comboBoxrubro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn artcodgenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artdescgenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unimedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cladescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn llevavencimiento;
    }
}