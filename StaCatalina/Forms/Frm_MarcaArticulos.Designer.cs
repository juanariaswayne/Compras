namespace StaCatalina.Forms
{
    partial class Frm_MarcaArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MarcaArticulos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewMarcas = new System.Windows.Forms.DataGridView();
            this.bindingSourceMarca = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBuscarMarca = new System.Windows.Forms.Button();
            this.buttonBuscarDesc = new System.Windows.Forms.Button();
            this.textBoxBuscarMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBuscarDescrip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.artcodGenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artDescGenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMarca)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStripEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewMarcas);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 543);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewMarcas
            // 
            this.dataGridViewMarcas.AllowUserToAddRows = false;
            this.dataGridViewMarcas.AllowUserToDeleteRows = false;
            this.dataGridViewMarcas.AutoGenerateColumns = false;
            this.dataGridViewMarcas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMarcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artcodGenDataGridViewTextBoxColumn,
            this.artDescGenDataGridViewTextBoxColumn,
            this.marca1DataGridViewTextBoxColumn,
            this.marca2DataGridViewTextBoxColumn,
            this.marca3DataGridViewTextBoxColumn,
            this.marca4DataGridViewTextBoxColumn,
            this.marca5DataGridViewTextBoxColumn});
            this.dataGridViewMarcas.DataSource = this.bindingSourceMarca;
            this.dataGridViewMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewMarcas.EnableHeadersVisualStyles = false;
            this.dataGridViewMarcas.Location = new System.Drawing.Point(0, 67);
            this.dataGridViewMarcas.Name = "dataGridViewMarcas";
            this.dataGridViewMarcas.Size = new System.Drawing.Size(1264, 423);
            this.dataGridViewMarcas.TabIndex = 1;
            this.dataGridViewMarcas.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewMarcas_CurrentCellDirtyStateChanged);
            // 
            // bindingSourceMarca
            // 
            this.bindingSourceMarca.DataSource = typeof(Entities.Procedures.H_ARTICULOSMARCA);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBuscarMarca);
            this.groupBox1.Controls.Add(this.buttonBuscarDesc);
            this.groupBox1.Controls.Add(this.textBoxBuscarMarca);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxBuscarDescrip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxEmpresa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1264, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empresa";
            // 
            // buttonBuscarMarca
            // 
            this.buttonBuscarMarca.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonBuscarMarca.Location = new System.Drawing.Point(1159, 38);
            this.buttonBuscarMarca.Name = "buttonBuscarMarca";
            this.buttonBuscarMarca.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarMarca.TabIndex = 22;
            this.buttonBuscarMarca.Text = "Buscar";
            this.buttonBuscarMarca.UseVisualStyleBackColor = false;
            this.buttonBuscarMarca.Click += new System.EventHandler(this.buttonBuscarMarca_Click);
            // 
            // buttonBuscarDesc
            // 
            this.buttonBuscarDesc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonBuscarDesc.Location = new System.Drawing.Point(553, 38);
            this.buttonBuscarDesc.Name = "buttonBuscarDesc";
            this.buttonBuscarDesc.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarDesc.TabIndex = 21;
            this.buttonBuscarDesc.Text = "Buscar";
            this.buttonBuscarDesc.UseVisualStyleBackColor = false;
            this.buttonBuscarDesc.Click += new System.EventHandler(this.buttonBuscarDesc_Click);
            // 
            // textBoxBuscarMarca
            // 
            this.textBoxBuscarMarca.Location = new System.Drawing.Point(741, 39);
            this.textBoxBuscarMarca.Name = "textBoxBuscarMarca";
            this.textBoxBuscarMarca.Size = new System.Drawing.Size(418, 20);
            this.textBoxBuscarMarca.TabIndex = 20;
            this.textBoxBuscarMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBuscarMarca_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Buscar por Marca:";
            // 
            // textBoxBuscarDescrip
            // 
            this.textBoxBuscarDescrip.Location = new System.Drawing.Point(134, 39);
            this.textBoxBuscarDescrip.Name = "textBoxBuscarDescrip";
            this.textBoxBuscarDescrip.Size = new System.Drawing.Size(418, 20);
            this.textBoxBuscarDescrip.TabIndex = 18;
            this.textBoxBuscarDescrip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBuscarDescrip_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Buscar por Descripción:";
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Items.AddRange(new object[] {
            "EGESAC S.A.",
            "RSC S.A."});
            this.comboBoxEmpresa.Location = new System.Drawing.Point(424, 12);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(31, 21);
            this.comboBoxEmpresa.TabIndex = 15;
            this.comboBoxEmpresa.Visible = false;
            this.comboBoxEmpresa.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmpresa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Empresa Seleccionada:";
            this.label1.Visible = false;
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 493);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(1264, 50);
            this.toolStripEvents.TabIndex = 7;
            this.toolStripEvents.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(94, 47);
            this.toolStripButtonSave.Text = "Grabar";
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
            // artcodGenDataGridViewTextBoxColumn
            // 
            this.artcodGenDataGridViewTextBoxColumn.DataPropertyName = "Art_codGen";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.artcodGenDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.artcodGenDataGridViewTextBoxColumn.HeaderText = "Artículo";
            this.artcodGenDataGridViewTextBoxColumn.Name = "artcodGenDataGridViewTextBoxColumn";
            this.artcodGenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artDescGenDataGridViewTextBoxColumn
            // 
            this.artDescGenDataGridViewTextBoxColumn.DataPropertyName = "Art_DescGen";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.artDescGenDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.artDescGenDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.artDescGenDataGridViewTextBoxColumn.Name = "artDescGenDataGridViewTextBoxColumn";
            this.artDescGenDataGridViewTextBoxColumn.ReadOnly = true;
            this.artDescGenDataGridViewTextBoxColumn.Width = 350;
            // 
            // marca1DataGridViewTextBoxColumn
            // 
            this.marca1DataGridViewTextBoxColumn.DataPropertyName = "Marca1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.marca1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.marca1DataGridViewTextBoxColumn.HeaderText = "Marca1";
            this.marca1DataGridViewTextBoxColumn.Name = "marca1DataGridViewTextBoxColumn";
            this.marca1DataGridViewTextBoxColumn.Width = 150;
            // 
            // marca2DataGridViewTextBoxColumn
            // 
            this.marca2DataGridViewTextBoxColumn.DataPropertyName = "Marca2";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.marca2DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.marca2DataGridViewTextBoxColumn.HeaderText = "Marca2";
            this.marca2DataGridViewTextBoxColumn.Name = "marca2DataGridViewTextBoxColumn";
            this.marca2DataGridViewTextBoxColumn.Width = 150;
            // 
            // marca3DataGridViewTextBoxColumn
            // 
            this.marca3DataGridViewTextBoxColumn.DataPropertyName = "Marca3";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.marca3DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.marca3DataGridViewTextBoxColumn.HeaderText = "Marca3";
            this.marca3DataGridViewTextBoxColumn.Name = "marca3DataGridViewTextBoxColumn";
            this.marca3DataGridViewTextBoxColumn.Width = 150;
            // 
            // marca4DataGridViewTextBoxColumn
            // 
            this.marca4DataGridViewTextBoxColumn.DataPropertyName = "Marca4";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.marca4DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.marca4DataGridViewTextBoxColumn.HeaderText = "Marca4";
            this.marca4DataGridViewTextBoxColumn.Name = "marca4DataGridViewTextBoxColumn";
            this.marca4DataGridViewTextBoxColumn.Width = 150;
            // 
            // marca5DataGridViewTextBoxColumn
            // 
            this.marca5DataGridViewTextBoxColumn.DataPropertyName = "Marca5";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.marca5DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.marca5DataGridViewTextBoxColumn.HeaderText = "Marca5";
            this.marca5DataGridViewTextBoxColumn.Name = "marca5DataGridViewTextBoxColumn";
            this.marca5DataGridViewTextBoxColumn.Width = 150;
            // 
            // Frm_MarcaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 543);
            this.ControlBox = false;
            this.Controls.Add(this.toolStripEvents);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_MarcaArticulos";
            this.Text = "Ingreso de Marcas";
            this.Load += new System.EventHandler(this.Frm_MarcaArticulos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMarca)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBuscarMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBuscarDescrip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBuscarDesc;
        private System.Windows.Forms.BindingSource bindingSourceMarca;
        private System.Windows.Forms.Button buttonBuscarMarca;
        private System.Windows.Forms.DataGridView dataGridViewMarcas;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn artcodGenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artDescGenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca5DataGridViewTextBoxColumn;
    }
}