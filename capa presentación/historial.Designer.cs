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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnproovedores = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdProovedor = new System.Windows.Forms.TextBox();
            this.sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCompañia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnhoyPersonal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtIdMarisco = new System.Windows.Forms.TextBox();
            this.txtIdmariscoExp = new System.Windows.Forms.TextBox();
            this.btnAyudaProveedor = new CustomControls.RJControls.RJButton();
            this.BtnMariscoIDD = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.btnAyudaExp = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.lblOrdenar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOrdenar.Location = new System.Drawing.Point(12, 31);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(129, 20);
            this.lblOrdenar.TabIndex = 12;
            this.lblOrdenar.Text = "Ordenar Por:";
            // 
            // btnPersonal
            // 
            this.btnPersonal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.btnproovedores.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.btnsalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsalir.Location = new System.Drawing.Point(1137, 66);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(113, 30);
            this.btnsalir.TabIndex = 33;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(209, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Por Mariscos ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 27);
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
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(472, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Por ID Compañia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(209, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Por Mariscos ID:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(979, 106);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(208, 27);
            this.dateTimePicker2.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(886, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 46;
            this.label7.Text = "Por Fecha:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.btnhoyPersonal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(1193, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 29);
            this.button3.TabIndex = 51;
            this.button3.Text = "fecha";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(1193, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 29);
            this.button4.TabIndex = 52;
            this.button4.Text = "fecha";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1268, 466);
            this.panel1.TabIndex = 53;
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
            this.dataGridView1.Size = new System.Drawing.Size(1268, 466);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtIdMarisco
            // 
            this.txtIdMarisco.Location = new System.Drawing.Point(341, 29);
            this.txtIdMarisco.Name = "txtIdMarisco";
            this.txtIdMarisco.Size = new System.Drawing.Size(125, 27);
            this.txtIdMarisco.TabIndex = 54;
            this.txtIdMarisco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdMarisco_KeyDown);
            this.txtIdMarisco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdMarisco_KeyPress);
            // 
            // txtIdmariscoExp
            // 
            this.txtIdmariscoExp.Location = new System.Drawing.Point(341, 100);
            this.txtIdmariscoExp.Name = "txtIdmariscoExp";
            this.txtIdmariscoExp.Size = new System.Drawing.Size(125, 27);
            this.txtIdmariscoExp.TabIndex = 55;
            this.txtIdmariscoExp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdmariscoExp_KeyPress);
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
            this.btnAyudaProveedor.Location = new System.Drawing.Point(424, -3);
            this.btnAyudaProveedor.Name = "btnAyudaProveedor";
            this.btnAyudaProveedor.Size = new System.Drawing.Size(42, 33);
            this.btnAyudaProveedor.TabIndex = 56;
            this.btnAyudaProveedor.Text = "?";
            this.btnAyudaProveedor.TextColor = System.Drawing.Color.White;
            this.btnAyudaProveedor.UseVisualStyleBackColor = false;
            this.btnAyudaProveedor.Click += new System.EventHandler(this.btnAyudaProveedor_Click);
            // 
            // BtnMariscoIDD
            // 
            this.BtnMariscoIDD.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnMariscoIDD.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnMariscoIDD.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnMariscoIDD.BorderRadius = 0;
            this.BtnMariscoIDD.BorderSize = 0;
            this.BtnMariscoIDD.FlatAppearance.BorderSize = 0;
            this.BtnMariscoIDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMariscoIDD.ForeColor = System.Drawing.Color.White;
            this.BtnMariscoIDD.Location = new System.Drawing.Point(424, 68);
            this.BtnMariscoIDD.Name = "BtnMariscoIDD";
            this.BtnMariscoIDD.Size = new System.Drawing.Size(42, 33);
            this.BtnMariscoIDD.TabIndex = 57;
            this.BtnMariscoIDD.Text = "?";
            this.BtnMariscoIDD.TextColor = System.Drawing.Color.White;
            this.BtnMariscoIDD.UseVisualStyleBackColor = false;
            this.BtnMariscoIDD.Click += new System.EventHandler(this.BtnMariscoIDD_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(693, -1);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(42, 33);
            this.rjButton2.TabIndex = 58;
            this.rjButton2.Text = "?";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // btnAyudaExp
            // 
            this.btnAyudaExp.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAyudaExp.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAyudaExp.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAyudaExp.BorderRadius = 0;
            this.btnAyudaExp.BorderSize = 0;
            this.btnAyudaExp.FlatAppearance.BorderSize = 0;
            this.btnAyudaExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyudaExp.ForeColor = System.Drawing.Color.White;
            this.btnAyudaExp.Location = new System.Drawing.Point(693, 70);
            this.btnAyudaExp.Name = "btnAyudaExp";
            this.btnAyudaExp.Size = new System.Drawing.Size(42, 33);
            this.btnAyudaExp.TabIndex = 59;
            this.btnAyudaExp.Text = "?";
            this.btnAyudaExp.TextColor = System.Drawing.Color.White;
            this.btnAyudaExp.UseVisualStyleBackColor = false;
            this.btnAyudaExp.Click += new System.EventHandler(this.btnAyudaExp_Click);
            // 
            // historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1268, 619);
            this.Controls.Add(this.btnAyudaExp);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.BtnMariscoIDD);
            this.Controls.Add(this.btnAyudaProveedor);
            this.Controls.Add(this.txtIdmariscoExp);
            this.Controls.Add(this.txtIdMarisco);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnhoyPersonal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCompañia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdProovedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnproovedores);
            this.Controls.Add(this.btnPersonal);
            this.Controls.Add(this.lblOrdenar);
            this.Controls.Add(this.btnActualizar);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "historial";
            this.Text = "historial";
            this.Load += new System.EventHandler(this.historial_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnActualizar;
        private Label lblOrdenar;
        private Button btnPersonal;
        private Button btnproovedores;
        private Button btnsalir;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIdProovedor;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox txtCompañia;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private Button button1;
        private Button btnhoyPersonal;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private DataGridView dataGridView1;
        private TextBox txtIdMarisco;
        private TextBox txtIdmariscoExp;
        private CustomControls.RJControls.RJButton btnAyudaProveedor;
        private CustomControls.RJControls.RJButton BtnMariscoIDD;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton btnAyudaExp;
    }
}