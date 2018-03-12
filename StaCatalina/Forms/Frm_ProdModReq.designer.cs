namespace StaCatalina.Forms
{
    partial class Frm_ProdModReq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ProdModReq));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSourceModReq = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewProdModReq = new System.Windows.Forms.DataGridView();
            this.artcodgenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artdescgenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unimedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cladescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceModReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdModReq)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.textBoxBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonSearch.Location = new System.Drawing.Point(518, 19);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(98, 21);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(418, 20);
            this.textBoxBuscar.TabIndex = 1;
            this.textBoxBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBuscar_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // bindingSourceModReq
            // 
            this.bindingSourceModReq.DataSource = typeof(Entities.Procedures.H_ARTICULOSDEPOSITO);
            // 
            // dataGridViewProdModReq
            // 
            this.dataGridViewProdModReq.AllowUserToAddRows = false;
            this.dataGridViewProdModReq.AllowUserToDeleteRows = false;
            this.dataGridViewProdModReq.AutoGenerateColumns = false;
            this.dataGridViewProdModReq.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProdModReq.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProdModReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdModReq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artcodgenDataGridViewTextBoxColumn,
            this.artdescgenDataGridViewTextBoxColumn,
            this.unimedDataGridViewTextBoxColumn,
            this.cladescDataGridViewTextBoxColumn});
            this.dataGridViewProdModReq.DataSource = this.bindingSourceModReq;
            this.dataGridViewProdModReq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProdModReq.EnableHeadersVisualStyles = false;
            this.dataGridViewProdModReq.Location = new System.Drawing.Point(0, 53);
            this.dataGridViewProdModReq.Name = "dataGridViewProdModReq";
            this.dataGridViewProdModReq.ReadOnly = true;
            this.dataGridViewProdModReq.Size = new System.Drawing.Size(695, 513);
            this.dataGridViewProdModReq.TabIndex = 3;
            this.dataGridViewProdModReq.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdModReq_CellContentDoubleClick_1);
            this.dataGridViewProdModReq.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewProdModReq_KeyDown);
            // 
            // artcodgenDataGridViewTextBoxColumn
            // 
            this.artcodgenDataGridViewTextBoxColumn.DataPropertyName = "art_codgen";
            this.artcodgenDataGridViewTextBoxColumn.HeaderText = "Código";
            this.artcodgenDataGridViewTextBoxColumn.Name = "artcodgenDataGridViewTextBoxColumn";
            this.artcodgenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artdescgenDataGridViewTextBoxColumn
            // 
            this.artdescgenDataGridViewTextBoxColumn.DataPropertyName = "art_descgen";
            this.artdescgenDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.artdescgenDataGridViewTextBoxColumn.Name = "artdescgenDataGridViewTextBoxColumn";
            this.artdescgenDataGridViewTextBoxColumn.ReadOnly = true;
            this.artdescgenDataGridViewTextBoxColumn.Width = 450;
            // 
            // unimedDataGridViewTextBoxColumn
            // 
            this.unimedDataGridViewTextBoxColumn.DataPropertyName = "unimed";
            this.unimedDataGridViewTextBoxColumn.HeaderText = "Uni Med";
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
            // Frm_ProdModReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 566);
            this.Controls.Add(this.dataGridViewProdModReq);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ProdModReq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ProdModReq";
            this.Load += new System.EventHandler(this.Frm_ProdModReq_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceModReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdModReq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSourceModReq;
        private System.Windows.Forms.DataGridView dataGridViewProdModReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn artcodgenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artdescgenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unimedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cladescDataGridViewTextBoxColumn;
    }
}