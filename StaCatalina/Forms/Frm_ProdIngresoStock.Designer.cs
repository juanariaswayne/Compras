namespace StaCatalina.Forms
{
    partial class Frm_ProdIngresoStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ProdIngresoStock));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxrubro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProdIngStock = new System.Windows.Forms.DataGridView();
            this.bindingSourceIngStock = new System.Windows.Forms.BindingSource(this.components);
            this.artcodgenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artdescgenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unimedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cladescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llevavencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdIngStock)).BeginInit();
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
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador";
            // 
            // comboBoxrubro
            // 
            this.comboBoxrubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxrubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxrubro.FormattingEnabled = true;
            this.comboBoxrubro.Location = new System.Drawing.Point(98, 19);
            this.comboBoxrubro.Name = "comboBoxrubro";
            this.comboBoxrubro.Size = new System.Drawing.Size(418, 21);
            this.comboBoxrubro.TabIndex = 7;
            this.comboBoxrubro.SelectedIndexChanged += new System.EventHandler(this.comboBoxrubro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rubro:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonSearch.Location = new System.Drawing.Point(519, 48);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(98, 49);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(418, 20);
            this.textBoxBuscar.TabIndex = 1;
            this.textBoxBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBuscar_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // dataGridViewProdIngStock
            // 
            this.dataGridViewProdIngStock.AllowUserToAddRows = false;
            this.dataGridViewProdIngStock.AllowUserToDeleteRows = false;
            this.dataGridViewProdIngStock.AutoGenerateColumns = false;
            this.dataGridViewProdIngStock.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProdIngStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProdIngStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdIngStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artcodgenDataGridViewTextBoxColumn,
            this.artdescgenDataGridViewTextBoxColumn,
            this.unimedDataGridViewTextBoxColumn,
            this.cladescDataGridViewTextBoxColumn,
            this.llevavencimiento});
            this.dataGridViewProdIngStock.DataSource = this.bindingSourceIngStock;
            this.dataGridViewProdIngStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProdIngStock.EnableHeadersVisualStyles = false;
            this.dataGridViewProdIngStock.Location = new System.Drawing.Point(0, 80);
            this.dataGridViewProdIngStock.Name = "dataGridViewProdIngStock";
            this.dataGridViewProdIngStock.ReadOnly = true;
            this.dataGridViewProdIngStock.Size = new System.Drawing.Size(723, 466);
            this.dataGridViewProdIngStock.TabIndex = 3;
            this.dataGridViewProdIngStock.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdIngStock_CellContentDoubleClick);
            this.dataGridViewProdIngStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewProdIngStock_KeyDown);
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
            // Frm_ProdIngresoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 546);
            this.Controls.Add(this.dataGridViewProdIngStock);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ProdIngresoStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Frm_ProdIngresoStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdIngStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceIngStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProdIngStock;
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