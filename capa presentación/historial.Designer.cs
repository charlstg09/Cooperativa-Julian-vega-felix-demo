namespace Cooperativa_Julian_vega_felix.capa_presentación
{
    partial class historial
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnproovedores = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoMarisco = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdProovedor = new System.Windows.Forms.TextBox();
            this.sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCompañia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMariscoExportar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnhoyPersonal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1443, 398);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.Location = new System.Drawing.Point(741, 31);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(149, 29);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar Entrega";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrdenar.Location = new System.Drawing.Point(12, 31);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(129, 20);
            this.lblOrdenar.TabIndex = 12;
            this.lblOrdenar.Text = "Ordenar Por:";
            // 
            // btnPersonal
            // 
            this.btnPersonal.Location = new System.Drawing.Point(20, -1);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(119, 29);
            this.btnPersonal.TabIndex = 18;
            this.btnPersonal.Text = "Entregas";
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnproovedores
            // 
            this.btnproovedores.Location = new System.Drawing.Point(20, 70);
            this.btnproovedores.Name = "btnproovedores";
            this.btnproovedores.Size = new System.Drawing.Size(121, 29);
            this.btnproovedores.TabIndex = 19;
            this.btnproovedores.Text = "Exportaciónes";
            this.btnproovedores.UseVisualStyleBackColor = true;
            this.btnproovedores.Click += new System.EventHandler(this.btnproovedores_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsalir.Location = new System.Drawing.Point(1330, 64);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(113, 40);
            this.btnsalir.TabIndex = 33;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Ordenar Por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(209, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Por Mariscos:";
            // 
            // cmbTipoMarisco
            // 
            this.cmbTipoMarisco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMarisco.FormattingEnabled = true;
            this.cmbTipoMarisco.Items.AddRange(new object[] {
            "pescado",
            "jaiba",
            "camaron"});
            this.cmbTipoMarisco.Location = new System.Drawing.Point(315, 27);
            this.cmbTipoMarisco.Name = "cmbTipoMarisco";
            this.cmbTipoMarisco.Size = new System.Drawing.Size(151, 28);
            this.cmbTipoMarisco.TabIndex = 37;
            this.cmbTipoMarisco.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMarisco_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(472, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Por ID Proovedor:";
            // 
            // txtIdProovedor
            // 
            this.txtIdProovedor.Location = new System.Drawing.Point(610, 31);
            this.txtIdProovedor.Name = "txtIdProovedor";
            this.txtIdProovedor.Size = new System.Drawing.Size(125, 27);
            this.txtIdProovedor.TabIndex = 39;
            this.txtIdProovedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProovedor_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(896, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "Por Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(979, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 41;
            // 
            // txtCompañia
            // 
            this.txtCompañia.Location = new System.Drawing.Point(610, 104);
            this.txtCompañia.Name = "txtCompañia";
            this.txtCompañia.Size = new System.Drawing.Size(125, 27);
            this.txtCompañia.TabIndex = 45;
            this.txtCompañia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(472, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Por ID Compañia:";
            // 
            // cmbMariscoExportar
            // 
            this.cmbMariscoExportar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMariscoExportar.FormattingEnabled = true;
            this.cmbMariscoExportar.Items.AddRange(new object[] {
            "pescado",
            "jaiba",
            "camaron"});
            this.cmbMariscoExportar.Location = new System.Drawing.Point(315, 100);
            this.cmbMariscoExportar.Name = "cmbMariscoExportar";
            this.cmbMariscoExportar.Size = new System.Drawing.Size(151, 28);
            this.cmbMariscoExportar.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(209, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Por Mariscos:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(979, 106);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker2.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(886, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 46;
            this.label7.Text = "Por Fecha:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(741, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 29);
            this.button1.TabIndex = 48;
            this.button1.Text = "Actualizar Exportadort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnhoyPersonal
            // 
            this.btnhoyPersonal.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnhoyPersonal.Location = new System.Drawing.Point(147, 29);
            this.btnhoyPersonal.Name = "btnhoyPersonal";
            this.btnhoyPersonal.Size = new System.Drawing.Size(56, 29);
            this.btnhoyPersonal.TabIndex = 49;
            this.btnhoyPersonal.Text = "Hoy";
            this.btnhoyPersonal.UseVisualStyleBackColor = true;
            this.btnhoyPersonal.Click += new System.EventHandler(this.btnhoyPersonal_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(147, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 29);
            this.button2.TabIndex = 50;
            this.button2.Text = "Hoy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(1235, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 29);
            this.button3.TabIndex = 51;
            this.button3.Text = "fecha";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(1235, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 29);
            this.button4.TabIndex = 52;
            this.button4.Text = "fecha";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 550);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnhoyPersonal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCompañia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMariscoExportar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdProovedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoMarisco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnproovedores);
            this.Controls.Add(this.btnPersonal);
            this.Controls.Add(this.lblOrdenar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "historial";
            this.Text = "historial";
            this.Load += new System.EventHandler(this.historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnActualizar;
        private Label lblOrdenar;
        private Button btnPersonal;
        private Button btnproovedores;
        private Button btnsalir;
        private Label label1;
        private Label label2;
        private ComboBox cmbTipoMarisco;
        private Label label3;
        private TextBox txtIdProovedor;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox txtCompañia;
        private Label label5;
        private ComboBox cmbMariscoExportar;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private Button button1;
        private Button btnhoyPersonal;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}