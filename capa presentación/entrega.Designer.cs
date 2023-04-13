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
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(228, 129);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(92, 29);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "IdUsuario";
            // 
            // lblMarisco
            // 
            this.lblMarisco.AutoSize = true;
            this.lblMarisco.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarisco.Location = new System.Drawing.Point(176, 83);
            this.lblMarisco.Name = "lblMarisco";
            this.lblMarisco.Size = new System.Drawing.Size(144, 29);
            this.lblMarisco.TabIndex = 3;
            this.lblMarisco.Text = "Tipo De Marisco";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(262, 181);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(58, 29);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPeso.Location = new System.Drawing.Point(222, 237);
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
            this.cmbTipoMarisco.Location = new System.Drawing.Point(323, 86);
            this.cmbTipoMarisco.Name = "cmbTipoMarisco";
            this.cmbTipoMarisco.Size = new System.Drawing.Size(151, 28);
            this.cmbTipoMarisco.TabIndex = 6;
            this.cmbTipoMarisco.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(323, 132);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(151, 30);
            this.txtIdUsuario.TabIndex = 7;
            this.txtIdUsuario.TextChanged += new System.EventHandler(this.txtIdUsuario_TextChanged);
            // 
            // txtPesoTotal
            // 
            this.txtPesoTotal.Location = new System.Drawing.Point(323, 240);
            this.txtPesoTotal.Name = "txtPesoTotal";
            this.txtPesoTotal.Size = new System.Drawing.Size(151, 30);
            this.txtPesoTotal.TabIndex = 9;
            this.txtPesoTotal.TextChanged += new System.EventHandler(this.txtPesoTotal_TextChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(313, 316);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(326, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 30);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // entrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
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
    }
}