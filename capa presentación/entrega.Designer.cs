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
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(115, 126);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(92, 29);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "IdUsuario";
            // 
            // lblMarisco
            // 
            this.lblMarisco.AutoSize = true;
            this.lblMarisco.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarisco.Location = new System.Drawing.Point(63, 80);
            this.lblMarisco.Name = "lblMarisco";
            this.lblMarisco.Size = new System.Drawing.Size(144, 29);
            this.lblMarisco.TabIndex = 3;
            this.lblMarisco.Text = "Tipo De Marisco";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(149, 178);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(58, 29);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPeso.Location = new System.Drawing.Point(109, 234);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(95, 29);
            this.lblPeso.TabIndex = 5;
            this.lblPeso.Text = "Peso Total";
            // 
            // cmbTipoMarisco
            // 
            this.cmbTipoMarisco.FormattingEnabled = true;
            this.cmbTipoMarisco.Items.AddRange(new object[] {
            "pescado",
            "jaiba",
            "camaron"});
            this.cmbTipoMarisco.Location = new System.Drawing.Point(210, 83);
            this.cmbTipoMarisco.Name = "cmbTipoMarisco";
            this.cmbTipoMarisco.Size = new System.Drawing.Size(151, 28);
            this.cmbTipoMarisco.TabIndex = 6;
            this.cmbTipoMarisco.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbTipoMarisco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTipoMarisco_KeyPress);
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(210, 129);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(151, 30);
            this.txtIdUsuario.TabIndex = 7;
            this.txtIdUsuario.TextChanged += new System.EventHandler(this.txtIdUsuario_TextChanged);
            this.txtIdUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdUsuario_KeyPress);
            // 
            // txtPesoTotal
            // 
            this.txtPesoTotal.Location = new System.Drawing.Point(210, 237);
            this.txtPesoTotal.Name = "txtPesoTotal";
            this.txtPesoTotal.Size = new System.Drawing.Size(151, 30);
            this.txtPesoTotal.TabIndex = 9;
            this.txtPesoTotal.TextChanged += new System.EventHandler(this.txtPesoTotal_TextChanged);
            this.txtPesoTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesoTotal_KeyPress_1);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(200, 313);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(213, 177);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 30);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // btnEntregaPersonal
            // 
            this.btnEntregaPersonal.Location = new System.Drawing.Point(200, 30);
            this.btnEntregaPersonal.Name = "btnEntregaPersonal";
            this.btnEntregaPersonal.Size = new System.Drawing.Size(161, 29);
            this.btnEntregaPersonal.TabIndex = 12;
            this.btnEntregaPersonal.Text = "Entrega";
            this.btnEntregaPersonal.UseVisualStyleBackColor = true;
            this.btnEntregaPersonal.Visible = false;
            // 
            // btnExportarProovedores
            // 
            this.btnExportarProovedores.Location = new System.Drawing.Point(485, 30);
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
            this.lblIdCompañia.Location = new System.Drawing.Point(379, 80);
            this.lblIdCompañia.Name = "lblIdCompañia";
            this.lblIdCompañia.Size = new System.Drawing.Size(110, 29);
            this.lblIdCompañia.TabIndex = 14;
            this.lblIdCompañia.Text = "IdCompañia";
            // 
            // lblIdMarisco
            // 
            this.lblIdMarisco.AutoSize = true;
            this.lblIdMarisco.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdMarisco.Location = new System.Drawing.Point(379, 126);
            this.lblIdMarisco.Name = "lblIdMarisco";
            this.lblIdMarisco.Size = new System.Drawing.Size(93, 29);
            this.lblIdMarisco.TabIndex = 15;
            this.lblIdMarisco.Text = "IdMarisco";
            // 
            // lblPesoTotalProovedores
            // 
            this.lblPesoTotalProovedores.AutoSize = true;
            this.lblPesoTotalProovedores.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPesoTotalProovedores.Location = new System.Drawing.Point(379, 179);
            this.lblPesoTotalProovedores.Name = "lblPesoTotalProovedores";
            this.lblPesoTotalProovedores.Size = new System.Drawing.Size(95, 29);
            this.lblPesoTotalProovedores.TabIndex = 16;
            this.lblPesoTotalProovedores.Text = "Peso Total";
            // 
            // idCom
            // 
            this.idCom.Location = new System.Drawing.Point(495, 83);
            this.idCom.Name = "idCom";
            this.idCom.Size = new System.Drawing.Size(151, 30);
            this.idCom.TabIndex = 17;
            this.idCom.TextChanged += new System.EventHandler(this.idCom_TextChanged);
            // 
            // IdMarExp
            // 
            this.IdMarExp.Location = new System.Drawing.Point(495, 129);
            this.IdMarExp.Name = "IdMarExp";
            this.IdMarExp.Size = new System.Drawing.Size(151, 30);
            this.IdMarExp.TabIndex = 18;
            // 
            // PesTotExp
            // 
            this.PesTotExp.Location = new System.Drawing.Point(495, 178);
            this.PesTotExp.Name = "PesTotExp";
            this.PesTotExp.Size = new System.Drawing.Size(151, 30);
            this.PesTotExp.TabIndex = 19;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(485, 236);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(161, 29);
            this.btnExportar.TabIndex = 20;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click_1);
            // 
            // entrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
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
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "entrega";
            this.Text = "                                                                        ENTREGA";
            this.Load += new System.EventHandler(this.entrega_Load);
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
    }
}