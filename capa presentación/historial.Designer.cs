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
            this.chkDia = new System.Windows.Forms.CheckBox();
            this.chkId = new System.Windows.Forms.CheckBox();
            this.chkTIpoMarisco = new System.Windows.Forms.CheckBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnproovedores = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1234, 407);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.Location = new System.Drawing.Point(589, 28);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(161, 29);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrdenar.Location = new System.Drawing.Point(12, 28);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(129, 20);
            this.lblOrdenar.TabIndex = 12;
            this.lblOrdenar.Text = "Ordenar Por:";
            // 
            // chkDia
            // 
            this.chkDia.AutoSize = true;
            this.chkDia.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkDia.Location = new System.Drawing.Point(147, 28);
            this.chkDia.Name = "chkDia";
            this.chkDia.Size = new System.Drawing.Size(56, 19);
            this.chkDia.TabIndex = 13;
            this.chkDia.Text = "Hoy";
            this.chkDia.UseVisualStyleBackColor = true;
            this.chkDia.CheckedChanged += new System.EventHandler(this.chkDia_CheckedChanged);
            // 
            // chkId
            // 
            this.chkId.AutoSize = true;
            this.chkId.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkId.Location = new System.Drawing.Point(316, 29);
            this.chkId.Name = "chkId";
            this.chkId.Size = new System.Drawing.Size(47, 19);
            this.chkId.TabIndex = 14;
            this.chkId.Text = "ID";
            this.chkId.UseVisualStyleBackColor = true;
            this.chkId.CheckedChanged += new System.EventHandler(this.chkId_CheckedChanged);
            // 
            // chkTIpoMarisco
            // 
            this.chkTIpoMarisco.AutoSize = true;
            this.chkTIpoMarisco.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkTIpoMarisco.Location = new System.Drawing.Point(209, 28);
            this.chkTIpoMarisco.Name = "chkTIpoMarisco";
            this.chkTIpoMarisco.Size = new System.Drawing.Size(101, 19);
            this.chkTIpoMarisco.TabIndex = 15;
            this.chkTIpoMarisco.Text = "Mariscos";
            this.chkTIpoMarisco.UseVisualStyleBackColor = true;
            this.chkTIpoMarisco.CheckedChanged += new System.EventHandler(this.chkTIpoMarisco_CheckedChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(359, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(95, 15);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "Ingresa ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(450, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(101, 27);
            this.txtId.TabIndex = 17;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // btnPersonal
            // 
            this.btnPersonal.Location = new System.Drawing.Point(801, 28);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(94, 29);
            this.btnPersonal.TabIndex = 18;
            this.btnPersonal.Text = "personal";
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnproovedores
            // 
            this.btnproovedores.Location = new System.Drawing.Point(915, 29);
            this.btnproovedores.Name = "btnproovedores";
            this.btnproovedores.Size = new System.Drawing.Size(121, 29);
            this.btnproovedores.TabIndex = 19;
            this.btnproovedores.Text = "proovedores";
            this.btnproovedores.UseVisualStyleBackColor = true;
            this.btnproovedores.Click += new System.EventHandler(this.btnproovedores_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsalir.Location = new System.Drawing.Point(1121, 16);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(113, 55);
            this.btnsalir.TabIndex = 33;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 497);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnproovedores);
            this.Controls.Add(this.btnPersonal);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.chkTIpoMarisco);
            this.Controls.Add(this.chkId);
            this.Controls.Add(this.chkDia);
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
        private CheckBox chkDia;
        private CheckBox chkId;
        private CheckBox chkTIpoMarisco;
        private Label lblId;
        private TextBox txtId;
        private Button btnPersonal;
        private Button btnproovedores;
        private Button btnsalir;
    }
}