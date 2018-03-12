namespace StaCatalina.Forms
{
    partial class Frm_AtributosDeProducto
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripButton toolStripButtonClose;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AtributosDeProducto));
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxReceta = new System.Windows.Forms.CheckBox();
            this.checkBoxTrazable = new System.Windows.Forms.CheckBox();
            this.checkBoxNoRequerimiento = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxSubCuenta = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxVa_a_Stock = new System.Windows.Forms.CheckBox();
            this.textBoxFactorConversion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxUniMedSecundaria = new System.Windows.Forms.ComboBox();
            this.comboBoxUniMedPrimaria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStockMaximo = new System.Windows.Forms.TextBox();
            this.textBoxStockMinimo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTolerancia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCodigosProd = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxSubrubro = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            this.comboBoxProductosBejerman = new System.Windows.Forms.ComboBox();
            this.checkBoxIncorporarArt = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBoxVencimiento = new System.Windows.Forms.CheckBox();
            toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripEvents.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripButtonClose
            // 
            toolStripButtonClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            toolStripButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClose.Image")));
            toolStripButtonClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonClose.Name = "toolStripButtonClose";
            toolStripButtonClose.Size = new System.Drawing.Size(83, 47);
            toolStripButtonClose.Text = "Cerrar";
            toolStripButtonClose.ToolTipText = "Cerrar";
            toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripLabel1,
            this.toolStripButtonNew,
            toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 431);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(771, 50);
            this.toolStripEvents.TabIndex = 11;
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(166, 47);
            this.toolStripLabel1.Text = "                                                     ";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(136, 47);
            this.toolStripButtonNew.Text = "Nuevo Ingreso";
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.comboBoxProductosBejerman);
            this.panel1.Controls.Add(this.checkBoxIncorporarArt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 431);
            this.panel1.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxVencimiento);
            this.groupBox4.Controls.Add(this.checkBoxReceta);
            this.groupBox4.Controls.Add(this.checkBoxTrazable);
            this.groupBox4.Controls.Add(this.checkBoxNoRequerimiento);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 280);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(771, 86);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Compras";
            // 
            // checkBoxReceta
            // 
            this.checkBoxReceta.AutoSize = true;
            this.checkBoxReceta.Location = new System.Drawing.Point(440, 37);
            this.checkBoxReceta.Name = "checkBoxReceta";
            this.checkBoxReceta.Size = new System.Drawing.Size(90, 17);
            this.checkBoxReceta.TabIndex = 2;
            this.checkBoxReceta.Text = "Lleva Receta";
            this.checkBoxReceta.UseVisualStyleBackColor = true;
            // 
            // checkBoxTrazable
            // 
            this.checkBoxTrazable.AutoSize = true;
            this.checkBoxTrazable.Location = new System.Drawing.Point(278, 37);
            this.checkBoxTrazable.Name = "checkBoxTrazable";
            this.checkBoxTrazable.Size = new System.Drawing.Size(67, 17);
            this.checkBoxTrazable.TabIndex = 1;
            this.checkBoxTrazable.Text = "Trazable";
            this.checkBoxTrazable.UseVisualStyleBackColor = true;
            // 
            // checkBoxNoRequerimiento
            // 
            this.checkBoxNoRequerimiento.AutoSize = true;
            this.checkBoxNoRequerimiento.Location = new System.Drawing.Point(61, 37);
            this.checkBoxNoRequerimiento.Name = "checkBoxNoRequerimiento";
            this.checkBoxNoRequerimiento.Size = new System.Drawing.Size(161, 17);
            this.checkBoxNoRequerimiento.TabIndex = 0;
            this.checkBoxNoRequerimiento.Text = "No incluir en Requerimientos";
            this.checkBoxNoRequerimiento.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxSubCuenta);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(771, 68);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estadística";
            // 
            // comboBoxSubCuenta
            // 
            this.comboBoxSubCuenta.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxSubCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSubCuenta.FormattingEnabled = true;
            this.comboBoxSubCuenta.Location = new System.Drawing.Point(193, 31);
            this.comboBoxSubCuenta.Name = "comboBoxSubCuenta";
            this.comboBoxSubCuenta.Size = new System.Drawing.Size(314, 21);
            this.comboBoxSubCuenta.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Sub Cuenta:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxVa_a_Stock);
            this.groupBox2.Controls.Add(this.textBoxFactorConversion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBoxUniMedSecundaria);
            this.groupBox2.Controls.Add(this.comboBoxUniMedPrimaria);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxStockMaximo);
            this.groupBox2.Controls.Add(this.textBoxStockMinimo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxTolerancia);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(771, 133);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock";
            // 
            // checkBoxVa_a_Stock
            // 
            this.checkBoxVa_a_Stock.AutoSize = true;
            this.checkBoxVa_a_Stock.Location = new System.Drawing.Point(152, 97);
            this.checkBoxVa_a_Stock.Name = "checkBoxVa_a_Stock";
            this.checkBoxVa_a_Stock.Size = new System.Drawing.Size(79, 17);
            this.checkBoxVa_a_Stock.TabIndex = 20;
            this.checkBoxVa_a_Stock.Text = "Va a Stock";
            this.checkBoxVa_a_Stock.UseVisualStyleBackColor = true;
            // 
            // textBoxFactorConversion
            // 
            this.textBoxFactorConversion.Location = new System.Drawing.Point(537, 94);
            this.textBoxFactorConversion.Name = "textBoxFactorConversion";
            this.textBoxFactorConversion.Size = new System.Drawing.Size(111, 20);
            this.textBoxFactorConversion.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Factor de Conversión:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBoxUniMedSecundaria
            // 
            this.comboBoxUniMedSecundaria.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxUniMedSecundaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUniMedSecundaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUniMedSecundaria.FormattingEnabled = true;
            this.comboBoxUniMedSecundaria.Location = new System.Drawing.Point(537, 56);
            this.comboBoxUniMedSecundaria.Name = "comboBoxUniMedSecundaria";
            this.comboBoxUniMedSecundaria.Size = new System.Drawing.Size(168, 21);
            this.comboBoxUniMedSecundaria.TabIndex = 15;
            // 
            // comboBoxUniMedPrimaria
            // 
            this.comboBoxUniMedPrimaria.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxUniMedPrimaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUniMedPrimaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUniMedPrimaria.FormattingEnabled = true;
            this.comboBoxUniMedPrimaria.Location = new System.Drawing.Point(150, 59);
            this.comboBoxUniMedPrimaria.Name = "comboBoxUniMedPrimaria";
            this.comboBoxUniMedPrimaria.Size = new System.Drawing.Size(169, 21);
            this.comboBoxUniMedPrimaria.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Unidad de Medida Secundaria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Unidad de Medida Primaria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Stock Maximo:";
            // 
            // textBoxStockMaximo
            // 
            this.textBoxStockMaximo.Location = new System.Drawing.Point(597, 19);
            this.textBoxStockMaximo.Name = "textBoxStockMaximo";
            this.textBoxStockMaximo.Size = new System.Drawing.Size(111, 20);
            this.textBoxStockMaximo.TabIndex = 11;
            // 
            // textBoxStockMinimo
            // 
            this.textBoxStockMinimo.Location = new System.Drawing.Point(361, 19);
            this.textBoxStockMinimo.Name = "textBoxStockMinimo";
            this.textBoxStockMinimo.Size = new System.Drawing.Size(111, 20);
            this.textBoxStockMinimo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Stock Minimo:";
            // 
            // textBoxTolerancia
            // 
            this.textBoxTolerancia.Location = new System.Drawing.Point(164, 19);
            this.textBoxTolerancia.Name = "textBoxTolerancia";
            this.textBoxTolerancia.Size = new System.Drawing.Size(111, 20);
            this.textBoxTolerancia.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tolerancia Ingreso Stock(%):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCodigosProd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBoxSubrubro);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxProductos);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 79);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artículo";
            // 
            // comboBoxCodigosProd
            // 
            this.comboBoxCodigosProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxCodigosProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCodigosProd.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxCodigosProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCodigosProd.FormattingEnabled = true;
            this.comboBoxCodigosProd.Location = new System.Drawing.Point(683, 43);
            this.comboBoxCodigosProd.Name = "comboBoxCodigosProd";
            this.comboBoxCodigosProd.Size = new System.Drawing.Size(85, 21);
            this.comboBoxCodigosProd.TabIndex = 30;
            this.comboBoxCodigosProd.SelectedIndexChanged += new System.EventHandler(this.comboBoxCodigosProd_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(640, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Codigo:";
            // 
            // comboBoxSubrubro
            // 
            this.comboBoxSubrubro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxSubrubro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSubrubro.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxSubrubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSubrubro.FormattingEnabled = true;
            this.comboBoxSubrubro.Location = new System.Drawing.Point(150, 12);
            this.comboBoxSubrubro.Name = "comboBoxSubrubro";
            this.comboBoxSubrubro.Size = new System.Drawing.Size(484, 21);
            this.comboBoxSubrubro.TabIndex = 28;
            this.comboBoxSubrubro.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubrubro_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(83, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Sub Rubro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Seleccione un producto:";
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProductos.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Location = new System.Drawing.Point(150, 43);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(484, 21);
            this.comboBoxProductos.TabIndex = 25;
            this.comboBoxProductos.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductos_SelectedIndexChanged);
            // 
            // comboBoxProductosBejerman
            // 
            this.comboBoxProductosBejerman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductosBejerman.FormattingEnabled = true;
            this.comboBoxProductosBejerman.Location = new System.Drawing.Point(112, 393);
            this.comboBoxProductosBejerman.Name = "comboBoxProductosBejerman";
            this.comboBoxProductosBejerman.Size = new System.Drawing.Size(96, 21);
            this.comboBoxProductosBejerman.TabIndex = 19;
            this.comboBoxProductosBejerman.Visible = false;
            // 
            // checkBoxIncorporarArt
            // 
            this.checkBoxIncorporarArt.AutoSize = true;
            this.checkBoxIncorporarArt.Location = new System.Drawing.Point(16, 395);
            this.checkBoxIncorporarArt.Name = "checkBoxIncorporarArt";
            this.checkBoxIncorporarArt.Size = new System.Drawing.Size(90, 17);
            this.checkBoxIncorporarArt.TabIndex = 18;
            this.checkBoxIncorporarArt.Text = "(NO SE USA)";
            this.checkBoxIncorporarArt.UseVisualStyleBackColor = true;
            this.checkBoxIncorporarArt.Visible = false;
            this.checkBoxIncorporarArt.CheckedChanged += new System.EventHandler(this.checkBoxIncorporarArt_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // checkBoxVencimiento
            // 
            this.checkBoxVencimiento.AutoSize = true;
            this.checkBoxVencimiento.ForeColor = System.Drawing.Color.Blue;
            this.checkBoxVencimiento.Location = new System.Drawing.Point(593, 37);
            this.checkBoxVencimiento.Name = "checkBoxVencimiento";
            this.checkBoxVencimiento.Size = new System.Drawing.Size(146, 17);
            this.checkBoxVencimiento.TabIndex = 3;
            this.checkBoxVencimiento.Text = "Lleva Fecha Vencimiento";
            this.checkBoxVencimiento.UseVisualStyleBackColor = true;
            // 
            // Frm_AtributosDeProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(771, 481);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripEvents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_AtributosDeProducto";
            this.Text = "Atributos de Poducto";
            this.Load += new System.EventHandler(this.Frm_AtributosDeProducto_Load);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox checkBoxIncorporarArt;
        private System.Windows.Forms.ComboBox comboBoxProductosBejerman;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxVa_a_Stock;
        private System.Windows.Forms.TextBox textBoxFactorConversion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxUniMedSecundaria;
        private System.Windows.Forms.ComboBox comboBoxUniMedPrimaria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStockMaximo;
        private System.Windows.Forms.TextBox textBoxStockMinimo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTolerancia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxSubrubro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProductos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxNoRequerimiento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxTrazable;
        private System.Windows.Forms.ComboBox comboBoxSubCuenta;
        private System.Windows.Forms.CheckBox checkBoxReceta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxCodigosProd;
        private System.Windows.Forms.CheckBox checkBoxVencimiento;
    }
}
