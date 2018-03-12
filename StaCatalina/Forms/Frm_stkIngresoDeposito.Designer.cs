namespace StaCatalina.Forms
{
    partial class Frm_stkIngresoDeposito
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_stkIngresoDeposito));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewDetalle = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewRemitos = new System.Windows.Forms.DataGridView();
            this.codEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codEmpstk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprobanteStk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBoxRecibido = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDeposito = new System.Windows.Forms.ComboBox();
            this.comboBoxSector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unimed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadPedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadOrig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadRecib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalle)).BeginInit();
            this.panel5.SuspendLayout();
            this.toolStripEvents.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemitos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 569);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridViewDetalle);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(235, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1018, 527);
            this.panel4.TabIndex = 2;
            // 
            // dataGridViewDetalle
            // 
            this.dataGridViewDetalle.AllowUserToAddRows = false;
            this.dataGridViewDetalle.AllowUserToDeleteRows = false;
            this.dataGridViewDetalle.AllowUserToOrderColumns = true;
            this.dataGridViewDetalle.AllowUserToResizeColumns = false;
            this.dataGridViewDetalle.AllowUserToResizeRows = false;
            this.dataGridViewDetalle.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Comprobante,
            this.nroItem,
            this.articulo_id,
            this.Articulo,
            this.unimed,
            this.CantidadPedida,
            this.cantidadOrig,
            this.CantidadRecib});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDetalle.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDetalle.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewDetalle.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDetalle.Name = "dataGridViewDetalle";
            this.dataGridViewDetalle.RowHeadersVisible = false;
            this.dataGridViewDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDetalle.Size = new System.Drawing.Size(1018, 474);
            this.dataGridViewDetalle.TabIndex = 1;
            this.dataGridViewDetalle.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewDetalle_CurrentCellDirtyStateChanged);
            this.dataGridViewDetalle.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewDetalle_EditingControlShowing_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.toolStripEvents);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 474);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1018, 53);
            this.panel5.TabIndex = 0;
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonClose});
            this.toolStripEvents.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripEvents.Location = new System.Drawing.Point(0, 0);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(1018, 53);
            this.toolStripEvents.TabIndex = 11;
            this.toolStripEvents.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(97, 50);
            this.toolStripButtonSave.Text = "Grabar";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonClose.Image = global::StaCatalina.Properties.Resources.shut_down_white_40x40;
            this.toolStripButtonClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Size = new System.Drawing.Size(83, 50);
            this.toolStripButtonClose.Text = "Cerrar";
            this.toolStripButtonClose.ToolTipText = "Cerrar";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewRemitos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 527);
            this.panel2.TabIndex = 0;
            // 
            // dataGridViewRemitos
            // 
            this.dataGridViewRemitos.AllowUserToAddRows = false;
            this.dataGridViewRemitos.AllowUserToDeleteRows = false;
            this.dataGridViewRemitos.AllowUserToOrderColumns = true;
            this.dataGridViewRemitos.AllowUserToResizeColumns = false;
            this.dataGridViewRemitos.AllowUserToResizeRows = false;
            this.dataGridViewRemitos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewRemitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRemitos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEmp,
            this.Remito,
            this.fechaR,
            this.Sucursal,
            this.Comp,
            this.letra,
            this.codEmpstk,
            this.comprobanteStk});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRemitos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewRemitos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRemitos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRemitos.Name = "dataGridViewRemitos";
            this.dataGridViewRemitos.ReadOnly = true;
            this.dataGridViewRemitos.RowHeadersVisible = false;
            this.dataGridViewRemitos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRemitos.Size = new System.Drawing.Size(235, 527);
            this.dataGridViewRemitos.TabIndex = 0;
            this.dataGridViewRemitos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRemitos_CellClick);
            this.dataGridViewRemitos.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewRemitos_CurrentCellDirtyStateChanged);
            // 
            // codEmp
            // 
            this.codEmp.HeaderText = "codEmp";
            this.codEmp.Name = "codEmp";
            this.codEmp.ReadOnly = true;
            this.codEmp.Visible = false;
            // 
            // Remito
            // 
            this.Remito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remito.HeaderText = "Remito";
            this.Remito.Name = "Remito";
            this.Remito.ReadOnly = true;
            // 
            // fechaR
            // 
            this.fechaR.HeaderText = "Fecha";
            this.fechaR.Name = "fechaR";
            this.fechaR.ReadOnly = true;
            // 
            // Sucursal
            // 
            this.Sucursal.HeaderText = "sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            this.Sucursal.Visible = false;
            // 
            // Comp
            // 
            this.Comp.HeaderText = "Comprobante";
            this.Comp.Name = "Comp";
            this.Comp.ReadOnly = true;
            this.Comp.Visible = false;
            // 
            // letra
            // 
            this.letra.HeaderText = "letra";
            this.letra.Name = "letra";
            this.letra.ReadOnly = true;
            this.letra.Visible = false;
            // 
            // codEmpstk
            // 
            this.codEmpstk.HeaderText = "codEmpstk";
            this.codEmpstk.Name = "codEmpstk";
            this.codEmpstk.ReadOnly = true;
            this.codEmpstk.Visible = false;
            // 
            // comprobanteStk
            // 
            this.comprobanteStk.HeaderText = "comprobanteStk";
            this.comprobanteStk.Name = "comprobanteStk";
            this.comprobanteStk.ReadOnly = true;
            this.comprobanteStk.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBoxRecibido);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dateTimeFechaHasta);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dateTimeFechaDesde);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.comboBoxDeposito);
            this.panel3.Controls.Add(this.comboBoxSector);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1253, 42);
            this.panel3.TabIndex = 1;
            // 
            // checkBoxRecibido
            // 
            this.checkBoxRecibido.AutoSize = true;
            this.checkBoxRecibido.Location = new System.Drawing.Point(1157, 19);
            this.checkBoxRecibido.Name = "checkBoxRecibido";
            this.checkBoxRecibido.Size = new System.Drawing.Size(87, 17);
            this.checkBoxRecibido.TabIndex = 15;
            this.checkBoxRecibido.Text = "Recibir Todo";
            this.checkBoxRecibido.UseVisualStyleBackColor = true;
            this.checkBoxRecibido.CheckedChanged += new System.EventHandler(this.checkBoxRecibido_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(940, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha Hasta";
            // 
            // dateTimeFechaHasta
            // 
            this.dateTimeFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaHasta.Location = new System.Drawing.Point(1011, 12);
            this.dateTimeFechaHasta.Name = "dateTimeFechaHasta";
            this.dateTimeFechaHasta.Size = new System.Drawing.Size(100, 20);
            this.dateTimeFechaHasta.TabIndex = 13;
            this.dateTimeFechaHasta.ValueChanged += new System.EventHandler(this.dateTimeFechaHasta_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(725, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fecha Desde";
            // 
            // dateTimeFechaDesde
            // 
            this.dateTimeFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaDesde.Location = new System.Drawing.Point(802, 12);
            this.dateTimeFechaDesde.Name = "dateTimeFechaDesde";
            this.dateTimeFechaDesde.Size = new System.Drawing.Size(97, 20);
            this.dateTimeFechaDesde.TabIndex = 11;
            this.dateTimeFechaDesde.ValueChanged += new System.EventHandler(this.dateTimeFechaDesde_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sector Destino";
            // 
            // comboBoxDeposito
            // 
            this.comboBoxDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDeposito.FormattingEnabled = true;
            this.comboBoxDeposito.Location = new System.Drawing.Point(113, 12);
            this.comboBoxDeposito.Name = "comboBoxDeposito";
            this.comboBoxDeposito.Size = new System.Drawing.Size(239, 21);
            this.comboBoxDeposito.TabIndex = 7;
            this.comboBoxDeposito.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeposito_SelectedIndexChanged);
            // 
            // comboBoxSector
            // 
            this.comboBoxSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSector.FormattingEnabled = true;
            this.comboBoxSector.Location = new System.Drawing.Point(455, 12);
            this.comboBoxSector.Name = "comboBoxSector";
            this.comboBoxSector.Size = new System.Drawing.Size(239, 21);
            this.comboBoxSector.TabIndex = 9;
            this.comboBoxSector.SelectedIndexChanged += new System.EventHandler(this.comboBoxSector_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Depósito Destino";
            // 
            // Comprobante
            // 
            this.Comprobante.HeaderText = "Comprobante";
            this.Comprobante.Name = "Comprobante";
            this.Comprobante.Visible = false;
            // 
            // nroItem
            // 
            this.nroItem.HeaderText = "nroItem";
            this.nroItem.Name = "nroItem";
            this.nroItem.Visible = false;
            // 
            // articulo_id
            // 
            this.articulo_id.HeaderText = "Cod";
            this.articulo_id.Name = "articulo_id";
            this.articulo_id.ReadOnly = true;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            this.Articulo.Width = 500;
            // 
            // unimed
            // 
            this.unimed.HeaderText = "UniMed";
            this.unimed.Name = "unimed";
            this.unimed.ReadOnly = true;
            // 
            // CantidadPedida
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CantidadPedida.DefaultCellStyle = dataGridViewCellStyle2;
            this.CantidadPedida.HeaderText = "Cant. Pedida";
            this.CantidadPedida.Name = "CantidadPedida";
            this.CantidadPedida.ReadOnly = true;
            // 
            // cantidadOrig
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cantidadOrig.DefaultCellStyle = dataGridViewCellStyle3;
            this.cantidadOrig.HeaderText = "Cant. Enviada";
            this.cantidadOrig.Name = "cantidadOrig";
            this.cantidadOrig.ReadOnly = true;
            // 
            // CantidadRecib
            // 
            this.CantidadRecib.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CantidadRecib.DefaultCellStyle = dataGridViewCellStyle4;
            this.CantidadRecib.HeaderText = "Cant. Recibida";
            this.CantidadRecib.Name = "CantidadRecib";
            // 
            // Frm_stkIngresoDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1253, 569);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_stkIngresoDeposito";
            this.Text = "Recepción de mercaderia desde depósito";
            this.Load += new System.EventHandler(this.Frm_stkIngresoDeposito_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalle)).EndInit();
            this.panel5.ResumeLayout(false);
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemitos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewDetalle;
        private System.Windows.Forms.DataGridView dataGridViewRemitos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDeposito;
        private System.Windows.Forms.ComboBox comboBoxSector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeFechaHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeFechaDesde;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.CheckBox checkBoxRecibido;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remito;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comp;
        private System.Windows.Forms.DataGridViewTextBoxColumn letra;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmpstk;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprobanteStk;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn unimed;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadPedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadOrig;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadRecib;
    }
}