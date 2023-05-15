namespace Cooperativa_Julian_vega_felix.capa_presentación
{
    partial class entrega
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblId = new System.Windows.Forms.Label();
            this.lblMarisco = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.cmbTipoMarisco = new System.Windows.Forms.ComboBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtPesoTotal = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.btnEntregaPersonal = new System.Windows.Forms.Button();
            this.btnExportarProovedores = new System.Windows.Forms.Button();
            this.lblIdCompañia = new System.Windows.Forms.Label();
            this.lblIdMarisco = new System.Windows.Forms.Label();
            this.lblPesoTotalProovedores = new System.Windows.Forms.Label();
            this.idCom = new System.Windows.Forms.TextBox();
            this.IdMarExp = new System.Windows.Forms.TextBox();
            this.PesTotExp = new System.Windows.Forms.TextBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblTrabajadores = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoMariscoExportar = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new CustomControls.RJControls.RJButton();
            this.btnAyudaProveedor = new CustomControls.RJControls.RJButton();
            this.btnAyudaCompañia = new CustomControls.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblId.Location = new System.Drawing.Point(4, 121);
            this.lblId.Name = "lblId";
            this.lblId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblId.Size = new System.Drawing.Size(113, 29);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "IdProovedor";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // lblMarisco
            // 
            this.lblMarisco.AutoSize = true;
            this.lblMarisco.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarisco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMarisco.Location = new System.Drawing.Point(4, 275);
            this.lblMarisco.Name = "lblMarisco";
            this.lblMarisco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMarisco.Size = new System.Drawing.Size(118, 29);
            this.lblMarisco.TabIndex = 3;
            this.lblMarisco.Text = "Tipo Marisco";
            this.lblMarisco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFecha.Location = new System.Drawing.Point(49, 166);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFecha.Size = new System.Drawing.Size(58, 29);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPeso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPeso.Location = new System.Drawing.Point(12, 216);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPeso.Size = new System.Drawing.Size(95, 29);
            this.lblPeso.TabIndex = 5;
            this.lblPeso.Text = "Peso Total";
            this.lblPeso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTipoMarisco
            // 
            this.cmbTipoMarisco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMarisco.FormattingEnabled = true;
            this.cmbTipoMarisco.Items.AddRange(new object[] {
            "pescado",
            "jaiba",
            "camaron"});
            this.cmbTipoMarisco.Location = new System.Drawing.Point(119, 278);
            this.cmbTipoMarisco.Name = "cmbTipoMarisco";
            this.cmbTipoMarisco.Size = new System.Drawing.Size(151, 28);
            this.cmbTipoMarisco.TabIndex = 6;
            this.cmbTipoMarisco.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbTipoMarisco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTipoMarisco_KeyDown);
            this.cmbTipoMarisco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTipoMarisco_KeyPress);
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(116, 124);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(151, 30);
            this.txtIdUsuario.TabIndex = 7;
            this.txtIdUsuario.TextChanged += new System.EventHandler(this.txtIdUsuario_TextChanged);
            this.txtIdUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdUsuario_KeyPress);
            // 
            // txtPesoTotal
            // 
            this.txtPesoTotal.Location = new System.Drawing.Point(119, 219);
            this.txtPesoTotal.Name = "txtPesoTotal";
            this.txtPesoTotal.Size = new System.Drawing.Size(151, 30);
            this.txtPesoTotal.TabIndex = 9;
            this.txtPesoTotal.TextChanged += new System.EventHandler(this.txtPesoTotal_TextChanged);
            this.txtPesoTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesoTotal_KeyDown);
            this.txtPesoTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesoTotal_KeyPress_1);
            this.txtPesoTotal.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtPesoTotal_PreviewKeyDown);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(116, 334);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(161, 29);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "Entregar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 30);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // btnEntregaPersonal
            // 
            this.btnEntregaPersonal.Location = new System.Drawing.Point(116, 89);
            this.btnEntregaPersonal.Name = "btnEntregaPersonal";
            this.btnEntregaPersonal.Size = new System.Drawing.Size(151, 29);
            this.btnEntregaPersonal.TabIndex = 12;
            this.btnEntregaPersonal.Text = "Entrega";
            this.btnEntregaPersonal.UseVisualStyleBackColor = true;
            this.btnEntregaPersonal.Visible = false;
            // 
            // btnExportarProovedores
            // 
            this.btnExportarProovedores.Location = new System.Drawing.Point(418, 89);
            this.btnExportarProovedores.Name = "btnExportarProovedores";
            this.btnExportarProovedores.Size = new System.Drawing.Size(161, 29);
            this.btnExportarProovedores.TabIndex = 13;
            this.btnExportarProovedores.Text = "Exportar";
            this.btnExportarProovedores.UseVisualStyleBackColor = true;
            this.btnExportarProovedores.Visible = false;
            this.btnExportarProovedores.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lblIdCompañia
            // 
            this.lblIdCompañia.AutoSize = true;
            this.lblIdCompañia.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdCompañia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdCompañia.Location = new System.Drawing.Point(312, 121);
            this.lblIdCompañia.Name = "lblIdCompañia";
            this.lblIdCompañia.Size = new System.Drawing.Size(110, 29);
            this.lblIdCompañia.TabIndex = 14;
            this.lblIdCompañia.Text = "IdCompañia";
            // 
            // lblIdMarisco
            // 
            this.lblIdMarisco.AutoSize = true;
            this.lblIdMarisco.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdMarisco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdMarisco.Location = new System.Drawing.Point(329, 260);
            this.lblIdMarisco.Name = "lblIdMarisco";
            this.lblIdMarisco.Size = new System.Drawing.Size(93, 29);
            this.lblIdMarisco.TabIndex = 15;
            this.lblIdMarisco.Text = "IdMarisco";
            // 
            // lblPesoTotalProovedores
            // 
            this.lblPesoTotalProovedores.AutoSize = true;
            this.lblPesoTotalProovedores.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPesoTotalProovedores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPesoTotalProovedores.Location = new System.Drawing.Point(327, 216);
            this.lblPesoTotalProovedores.Name = "lblPesoTotalProovedores";
            this.lblPesoTotalProovedores.Size = new System.Drawing.Size(95, 29);
            this.lblPesoTotalProovedores.TabIndex = 16;
            this.lblPesoTotalProovedores.Text = "Peso Total";
            // 
            // idCom
            // 
            this.idCom.Location = new System.Drawing.Point(426, 124);
            this.idCom.Name = "idCom";
            this.idCom.Size = new System.Drawing.Size(151, 30);
            this.idCom.TabIndex = 17;
            this.idCom.TextChanged += new System.EventHandler(this.idCom_TextChanged);
            this.idCom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idCom_KeyPress);
            // 
            // IdMarExp
            // 
            this.IdMarExp.Location = new System.Drawing.Point(372, 372);
            this.IdMarExp.Name = "IdMarExp";
            this.IdMarExp.Size = new System.Drawing.Size(151, 30);
            this.IdMarExp.TabIndex = 18;
            this.IdMarExp.Visible = false;
            this.IdMarExp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdMarExp_KeyPress);
            // 
            // PesTotExp
            // 
            this.PesTotExp.Location = new System.Drawing.Point(428, 219);
            this.PesTotExp.Name = "PesTotExp";
            this.PesTotExp.Size = new System.Drawing.Size(151, 30);
            this.PesTotExp.TabIndex = 19;
            this.PesTotExp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PesTotExp_KeyPress);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(418, 308);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(161, 29);
            this.btnExportar.TabIndex = 20;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click_1);
            // 
            // lblTrabajadores
            // 
            this.lblTrabajadores.AutoSize = true;
            this.lblTrabajadores.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrabajadores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTrabajadores.Location = new System.Drawing.Point(146, 63);
            this.lblTrabajadores.Name = "lblTrabajadores";
            this.lblTrabajadores.Size = new System.Drawing.Size(101, 23);
            this.lblTrabajadores.TabIndex = 22;
            this.lblTrabajadores.Text = "Entrega";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(426, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Exportar";
            // 
            // cmbTipoMariscoExportar
            // 
            this.cmbTipoMariscoExportar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMariscoExportar.FormattingEnabled = true;
            this.cmbTipoMariscoExportar.Items.AddRange(new object[] {
            "pescado",
            "jaiba",
            "camaron"});
            this.cmbTipoMariscoExportar.Location = new System.Drawing.Point(428, 265);
            this.cmbTipoMariscoExportar.Name = "cmbTipoMariscoExportar";
            this.cmbTipoMariscoExportar.Size = new System.Drawing.Size(151, 28);
            this.cmbTipoMariscoExportar.TabIndex = 24;
            this.cmbTipoMariscoExportar.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMariscoExportar_SelectedIndexChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Location = new System.Drawing.Point(431, 167);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(148, 30);
            this.dateTimePicker2.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(367, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fecha";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DeepPink;
            this.btnSalir.BackgroundColor = System.Drawing.Color.DeepPink;
            this.btnSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalir.BorderRadius = 0;
            this.btnSalir.BorderSize = 0;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(4, 552);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(188, 50);
            this.btnSalir.TabIndex = 35;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnAyudaProveedor
            // 
            this.btnAyudaProveedor.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAyudaProveedor.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAyudaProveedor.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAyudaProveedor.BorderRadius = 0;
            this.btnAyudaProveedor.BorderSize = 0;
            this.btnAyudaProveedor.FlatAppearance.BorderSize = 0;
            this.btnAyudaProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyudaProveedor.ForeColor = System.Drawing.Color.White;
            this.btnAyudaProveedor.Location = new System.Drawing.Point(273, 124);
            this.btnAyudaProveedor.Name = "btnAyudaProveedor";
            this.btnAyudaProveedor.Size = new System.Drawing.Size(42, 33);
            this.btnAyudaProveedor.TabIndex = 36;
            this.btnAyudaProveedor.Text = "?";
            this.btnAyudaProveedor.TextColor = System.Drawing.Color.White;
            this.btnAyudaProveedor.UseVisualStyleBackColor = false;
            this.btnAyudaProveedor.Click += new System.EventHandler(this.btnAyudaProveedor_Click);
            // 
            // btnAyudaCompañia
            // 
            this.btnAyudaCompañia.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAyudaCompañia.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAyudaCompañia.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAyudaCompañia.BorderRadius = 0;
            this.btnAyudaCompañia.BorderSize = 0;
            this.btnAyudaCompañia.FlatAppearance.BorderSize = 0;
            this.btnAyudaCompañia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyudaCompañia.ForeColor = System.Drawing.Color.White;
            this.btnAyudaCompañia.Location = new System.Drawing.Point(585, 124);
            this.btnAyudaCompañia.Name = "btnAyudaCompañia";
            this.btnAyudaCompañia.Size = new System.Drawing.Size(42, 33);
            this.btnAyudaCompañia.TabIndex = 37;
            this.btnAyudaCompañia.Text = "?";
            this.btnAyudaCompañia.TextColor = System.Drawing.Color.White;
            this.btnAyudaCompañia.UseVisualStyleBackColor = false;
            this.btnAyudaCompañia.Click += new System.EventHandler(this.btnAyudaCompañia_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(633, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 604);
            this.panel1.TabIndex = 38;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(617, 604);
            this.dataGridView1.TabIndex = 1;
            // 
            // entrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1250, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAyudaCompañia);
            this.Controls.Add(this.btnAyudaProveedor);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoMariscoExportar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTrabajadores);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.PesTotExp);
            this.Controls.Add(this.IdMarExp);
            this.Controls.Add(this.idCom);
            this.Controls.Add(this.lblPesoTotalProovedores);
            this.Controls.Add(this.lblIdMarisco);
            this.Controls.Add(this.lblIdCompañia);
            this.Controls.Add(this.btnExportarProovedores);
            this.Controls.Add(this.btnEntregaPersonal);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtPesoTotal);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.cmbTipoMarisco);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblMarisco);
            this.Controls.Add(this.lblId);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "entrega";
            this.Text = "                                                                        ENTREGA";
            this.Load += new System.EventHandler(this.entrega_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblId;
        private Label lblMarisco;
        private Label lblFecha;
        private Label lblPeso;
        private ComboBox cmbTipoMarisco;
        private TextBox txtIdUsuario;
        private TextBox txtPesoTotal;
        private Button btnEnviar;
        private DateTimePicker dateTimePicker1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnEntregaPersonal;
        private Button btnExportarProovedores;
        private Label lblIdCompañia;
        private Label lblIdMarisco;
        private Label lblPesoTotalProovedores;
        private TextBox idCom;
        private TextBox IdMarExp;
        private TextBox PesTotExp;
        private Button btnExportar;
        private Label lblTrabajadores;
        private Label label1;
        private ComboBox cmbTipoMariscoExportar;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private CustomControls.RJControls.RJButton btnSalir;
        private CustomControls.RJControls.RJButton btnAyudaProveedor;
        private CustomControls.RJControls.RJButton btnAyudaCompañia;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}