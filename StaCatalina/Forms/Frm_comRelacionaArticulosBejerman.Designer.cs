namespace StaCatalina.Forms
{
    partial class Frm_comRelacionaArticulosBejerman
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_comRelacionaArticulosBejerman));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Selecciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODPROVISORIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODEMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEQUERIMIENTOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nROITEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pENDIENTEENBEJERMANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRESENTACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIMEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARCADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMBALAJEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodBejerman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoAsociar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.USUARIO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO_MAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceArt = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceArt)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStripEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 519);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1249, 419);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Requerimientos con artículos Provisorios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecciona,
            this.iDDataGridViewTextBoxColumn,
            this.cODPROVISORIODataGridViewTextBoxColumn,
            this.cODEMPDataGridViewTextBoxColumn,
            this.rEQUERIMIENTOIDDataGridViewTextBoxColumn,
            this.nROITEMDataGridViewTextBoxColumn,
            this.pENDIENTEENBEJERMANDataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn,
            this.pRESENTACIONDataGridViewTextBoxColumn,
            this.uNIMEDDataGridViewTextBoxColumn,
            this.mARCADataGridViewTextBoxColumn,
            this.eMBALAJEDataGridViewTextBoxColumn,
            this.cANTIDADDataGridViewTextBoxColumn,
            this.CodBejerman,
            this.NoAsociar,
            this.USUARIO_ID,
            this.USUARIO_MAIL});
            this.dataGridView1.DataSource = this.bindingSourceArt;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1243, 400);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            // 
            // Selecciona
            // 
            this.Selecciona.HeaderText = "Selecciona";
            this.Selecciona.Name = "Selecciona";
            this.Selecciona.Width = 80;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODPROVISORIODataGridViewTextBoxColumn
            // 
            this.cODPROVISORIODataGridViewTextBoxColumn.DataPropertyName = "CODPROVISORIO";
            this.cODPROVISORIODataGridViewTextBoxColumn.HeaderText = "CODPROVISORIO";
            this.cODPROVISORIODataGridViewTextBoxColumn.Name = "cODPROVISORIODataGridViewTextBoxColumn";
            this.cODPROVISORIODataGridViewTextBoxColumn.Visible = false;
            // 
            // cODEMPDataGridViewTextBoxColumn
            // 
            this.cODEMPDataGridViewTextBoxColumn.DataPropertyName = "CODEMP";
            this.cODEMPDataGridViewTextBoxColumn.HeaderText = "CODEMP";
            this.cODEMPDataGridViewTextBoxColumn.Name = "cODEMPDataGridViewTextBoxColumn";
            this.cODEMPDataGridViewTextBoxColumn.Visible = false;
            // 
            // rEQUERIMIENTOIDDataGridViewTextBoxColumn
            // 
            this.rEQUERIMIENTOIDDataGridViewTextBoxColumn.DataPropertyName = "REQUERIMIENTO_ID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.rEQUERIMIENTOIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.rEQUERIMIENTOIDDataGridViewTextBoxColumn.HeaderText = "Nro. Requerimiento";
            this.rEQUERIMIENTOIDDataGridViewTextBoxColumn.Name = "rEQUERIMIENTOIDDataGridViewTextBoxColumn";
            this.rEQUERIMIENTOIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEQUERIMIENTOIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // nROITEMDataGridViewTextBoxColumn
            // 
            this.nROITEMDataGridViewTextBoxColumn.DataPropertyName = "NROITEM";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nROITEMDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.nROITEMDataGridViewTextBoxColumn.HeaderText = "Nro. Item";
            this.nROITEMDataGridViewTextBoxColumn.Name = "nROITEMDataGridViewTextBoxColumn";
            this.nROITEMDataGridViewTextBoxColumn.ReadOnly = true;
            this.nROITEMDataGridViewTextBoxColumn.Width = 80;
            // 
            // pENDIENTEENBEJERMANDataGridViewTextBoxColumn
            // 
            this.pENDIENTEENBEJERMANDataGridViewTextBoxColumn.DataPropertyName = "PENDIENTEENBEJERMAN";
            this.pENDIENTEENBEJERMANDataGridViewTextBoxColumn.HeaderText = "PENDIENTEENBEJERMAN";
            this.pENDIENTEENBEJERMANDataGridViewTextBoxColumn.Name = "pENDIENTEENBEJERMANDataGridViewTextBoxColumn";
            this.pENDIENTEENBEJERMANDataGridViewTextBoxColumn.Visible = false;
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dESCRIPCIONDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            this.dESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCRIPCIONDataGridViewTextBoxColumn.Width = 330;
            // 
            // pRESENTACIONDataGridViewTextBoxColumn
            // 
            this.pRESENTACIONDataGridViewTextBoxColumn.DataPropertyName = "PRESENTACION";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.pRESENTACIONDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.pRESENTACIONDataGridViewTextBoxColumn.HeaderText = "Presentación";
            this.pRESENTACIONDataGridViewTextBoxColumn.Name = "pRESENTACIONDataGridViewTextBoxColumn";
            this.pRESENTACIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uNIMEDDataGridViewTextBoxColumn
            // 
            this.uNIMEDDataGridViewTextBoxColumn.DataPropertyName = "UNIMED";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.uNIMEDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.uNIMEDDataGridViewTextBoxColumn.HeaderText = "Uni. Med";
            this.uNIMEDDataGridViewTextBoxColumn.Name = "uNIMEDDataGridViewTextBoxColumn";
            this.uNIMEDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uNIMEDDataGridViewTextBoxColumn.Width = 80;
            // 
            // mARCADataGridViewTextBoxColumn
            // 
            this.mARCADataGridViewTextBoxColumn.DataPropertyName = "MARCA";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.mARCADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.mARCADataGridViewTextBoxColumn.HeaderText = "Marca";
            this.mARCADataGridViewTextBoxColumn.Name = "mARCADataGridViewTextBoxColumn";
            this.mARCADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMBALAJEDataGridViewTextBoxColumn
            // 
            this.eMBALAJEDataGridViewTextBoxColumn.DataPropertyName = "EMBALAJE";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.eMBALAJEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.eMBALAJEDataGridViewTextBoxColumn.HeaderText = "Embalaje";
            this.eMBALAJEDataGridViewTextBoxColumn.Name = "eMBALAJEDataGridViewTextBoxColumn";
            this.eMBALAJEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cANTIDADDataGridViewTextBoxColumn
            // 
            this.cANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.cANTIDADDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.cANTIDADDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cANTIDADDataGridViewTextBoxColumn.Name = "cANTIDADDataGridViewTextBoxColumn";
            this.cANTIDADDataGridViewTextBoxColumn.ReadOnly = true;
            this.cANTIDADDataGridViewTextBoxColumn.Width = 80;
            // 
            // CodBejerman
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CodBejerman.DefaultCellStyle = dataGridViewCellStyle10;
            this.CodBejerman.HeaderText = "Cod. Bejerman";
            this.CodBejerman.Name = "CodBejerman";
            // 
            // NoAsociar
            // 
            this.NoAsociar.HeaderText = "No Asoc.";
            this.NoAsociar.Name = "NoAsociar";
            this.NoAsociar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NoAsociar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NoAsociar.Text = "No Asociar";
            this.NoAsociar.UseColumnTextForButtonValue = true;
            // 
            // USUARIO_ID
            // 
            this.USUARIO_ID.DataPropertyName = "USUARIO_ID";
            this.USUARIO_ID.HeaderText = "USUARIO_ID";
            this.USUARIO_ID.Name = "USUARIO_ID";
            this.USUARIO_ID.Visible = false;
            // 
            // USUARIO_MAIL
            // 
            this.USUARIO_MAIL.DataPropertyName = "USUARIO_MAIL";
            this.USUARIO_MAIL.HeaderText = "USUARIO_MAIL";
            this.USUARIO_MAIL.Name = "USUARIO_MAIL";
            this.USUARIO_MAIL.Visible = false;
            // 
            // bindingSourceArt
            // 
            this.bindingSourceArt.DataSource = typeof(Entities.Tables.COMARTICULOSPROVISORIOS);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxEmpresa);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1249, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(325, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Empresa seleccionada:";
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Location = new System.Drawing.Point(485, 12);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(166, 21);
            this.comboBoxEmpresa.TabIndex = 8;
            this.comboBoxEmpresa.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmpresa_SelectedIndexChanged);
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.AutoSize = false;
            this.toolStripEvents.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonClose});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 469);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(1249, 50);
            this.toolStripEvents.TabIndex = 16;
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
            this.toolStripButtonClose.ToolTipText = "Cerrar";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // Frm_comRelacionaArticulosBejerman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1249, 519);
            this.ControlBox = false;
            this.Controls.Add(this.toolStripEvents);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_comRelacionaArticulosBejerman";
            this.Text = "Asignar artículos de Bejerman";
            this.Load += new System.EventHandler(this.Frm_comRelacionaArticulosBejerman_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceArt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSourceArt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecciona;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPROVISORIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODEMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEQUERIMIENTOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nROITEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pENDIENTEENBEJERMANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRESENTACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIMEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARCADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMBALAJEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodBejerman;
        private System.Windows.Forms.DataGridViewButtonColumn NoAsociar;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO_MAIL;
    }
}
