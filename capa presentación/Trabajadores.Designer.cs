namespace Cooperativa_Julian_vega_felix.capa_presentación
{
    partial class bntpersonal
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblRFC = new System.Windows.Forms.Label();
            this.lblCurp = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.bntEliminar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnpersonal = new System.Windows.Forms.Button();
            this.btnprovedor = new System.Windows.Forms.Button();
            this.lblTrabajadores = new System.Windows.Forms.Label();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.btnAgregarPersonal = new System.Windows.Forms.Button();
            this.txtCurpPersonal = new System.Windows.Forms.TextBox();
            this.txtRfcPersonal = new System.Windows.Forms.TextBox();
            this.txtTelefonoPersonal = new System.Windows.Forms.TextBox();
            this.txtApellidoPersonal = new System.Windows.Forms.TextBox();
            this.txtNombrePersonal = new System.Windows.Forms.TextBox();
            this.lblCurpPersonal = new System.Windows.Forms.Label();
            this.lblRFCPersonal = new System.Windows.Forms.Label();
            this.lblTelefonoPersonal = new System.Windows.Forms.Label();
            this.lblApellidoPersonal = new System.Windows.Forms.Label();
            this.lblNombrePersonal = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnEliminarPersnonal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(661, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(621, 561);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(11, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 29);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(11, 125);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(84, 29);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.Click += new System.EventHandler(this.lblApellido_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.Location = new System.Drawing.Point(11, 182);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(89, 29);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Telefono:";
            this.lblTelefono.Click += new System.EventHandler(this.lblTelefono_Click);
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRFC.Location = new System.Drawing.Point(43, 242);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(52, 29);
            this.lblRFC.TabIndex = 4;
            this.lblRFC.Text = "RFC:";
            this.lblRFC.Click += new System.EventHandler(this.lblRFC_Click);
            // 
            // lblCurp
            // 
            this.lblCurp.AutoSize = true;
            this.lblCurp.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurp.Location = new System.Drawing.Point(30, 300);
            this.lblCurp.Name = "lblCurp";
            this.lblCurp.Size = new System.Drawing.Size(65, 29);
            this.lblCurp.TabIndex = 5;
            this.lblCurp.Text = "CURP:";
            this.lblCurp.Click += new System.EventHandler(this.lblCurp_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 27);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(95, 129);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(125, 27);
            this.txtApellido.TabIndex = 7;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApellido_KeyDown);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(95, 186);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(125, 27);
            this.txtTelefono.TabIndex = 8;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(95, 246);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(125, 27);
            this.txtRfc.TabIndex = 9;
            this.txtRfc.TextChanged += new System.EventHandler(this.txtRfc_TextChanged);
            this.txtRfc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRfc_KeyPress);
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(95, 304);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(125, 27);
            this.txtCurp.TabIndex = 10;
            this.txtCurp.TextChanged += new System.EventHandler(this.txtCurp_TextChanged);
            this.txtCurp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurp_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAgregar.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(96, 345);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 29);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // bntEliminar
            // 
            this.bntEliminar.BackColor = System.Drawing.Color.Red;
            this.bntEliminar.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bntEliminar.Location = new System.Drawing.Point(78, 380);
            this.bntEliminar.Name = "bntEliminar";
            this.bntEliminar.Size = new System.Drawing.Size(146, 49);
            this.bntEliminar.TabIndex = 12;
            this.bntEliminar.Text = "Eliminar Proovedores";
            this.bntEliminar.UseVisualStyleBackColor = false;
            this.bntEliminar.Click += new System.EventHandler(this.bntEliminar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 12);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnpersonal
            // 
            this.btnpersonal.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnpersonal.Location = new System.Drawing.Point(342, 7);
            this.btnpersonal.Name = "btnpersonal";
            this.btnpersonal.Size = new System.Drawing.Size(113, 29);
            this.btnpersonal.TabIndex = 15;
            this.btnpersonal.Text = "Personal";
            this.btnpersonal.UseVisualStyleBackColor = true;
            this.btnpersonal.Click += new System.EventHandler(this.btnpersonal_Click);
            // 
            // btnprovedor
            // 
            this.btnprovedor.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnprovedor.Location = new System.Drawing.Point(95, 7);
            this.btnprovedor.Name = "btnprovedor";
            this.btnprovedor.Size = new System.Drawing.Size(115, 29);
            this.btnprovedor.TabIndex = 16;
            this.btnprovedor.Text = "proovedores";
            this.btnprovedor.UseVisualStyleBackColor = true;
            this.btnprovedor.Click += new System.EventHandler(this.btnprovedor_Click);
            // 
            // lblTrabajadores
            // 
            this.lblTrabajadores.AutoSize = true;
            this.lblTrabajadores.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrabajadores.Location = new System.Drawing.Point(71, 48);
            this.lblTrabajadores.Name = "lblTrabajadores";
            this.lblTrabajadores.Size = new System.Drawing.Size(153, 23);
            this.lblTrabajadores.TabIndex = 17;
            this.lblTrabajadores.Text = "Proovedores";
            this.lblTrabajadores.Click += new System.EventHandler(this.lblpersonal_Click);
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPersonal.Location = new System.Drawing.Point(342, 48);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(114, 23);
            this.lblPersonal.TabIndex = 18;
            this.lblPersonal.Text = "PERSONAL";
            // 
            // btnAgregarPersonal
            // 
            this.btnAgregarPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAgregarPersonal.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarPersonal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarPersonal.Location = new System.Drawing.Point(361, 380);
            this.btnAgregarPersonal.Name = "btnAgregarPersonal";
            this.btnAgregarPersonal.Size = new System.Drawing.Size(125, 29);
            this.btnAgregarPersonal.TabIndex = 29;
            this.btnAgregarPersonal.Text = "Agregar ";
            this.btnAgregarPersonal.UseVisualStyleBackColor = false;
            this.btnAgregarPersonal.Click += new System.EventHandler(this.btnAgregarPersonal_Click);
            // 
            // txtCurpPersonal
            // 
            this.txtCurpPersonal.Location = new System.Drawing.Point(360, 308);
            this.txtCurpPersonal.Name = "txtCurpPersonal";
            this.txtCurpPersonal.Size = new System.Drawing.Size(125, 27);
            this.txtCurpPersonal.TabIndex = 28;
            this.txtCurpPersonal.TextChanged += new System.EventHandler(this.txtCurpPersonal_TextChanged);
            this.txtCurpPersonal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurpPersonal_KeyPress);
            // 
            // txtRfcPersonal
            // 
            this.txtRfcPersonal.Location = new System.Drawing.Point(360, 250);
            this.txtRfcPersonal.Name = "txtRfcPersonal";
            this.txtRfcPersonal.Size = new System.Drawing.Size(125, 27);
            this.txtRfcPersonal.TabIndex = 27;
            this.txtRfcPersonal.TextChanged += new System.EventHandler(this.txtRfcPersonal_TextChanged);
            this.txtRfcPersonal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRfcPersonal_KeyPress);
            // 
            // txtTelefonoPersonal
            // 
            this.txtTelefonoPersonal.Location = new System.Drawing.Point(360, 190);
            this.txtTelefonoPersonal.Name = "txtTelefonoPersonal";
            this.txtTelefonoPersonal.Size = new System.Drawing.Size(125, 27);
            this.txtTelefonoPersonal.TabIndex = 26;
            this.txtTelefonoPersonal.TextChanged += new System.EventHandler(this.txtTelefonoPersonal_TextChanged);
            this.txtTelefonoPersonal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoPersonal_KeyPress);
            // 
            // txtApellidoPersonal
            // 
            this.txtApellidoPersonal.Location = new System.Drawing.Point(360, 133);
            this.txtApellidoPersonal.Name = "txtApellidoPersonal";
            this.txtApellidoPersonal.Size = new System.Drawing.Size(125, 27);
            this.txtApellidoPersonal.TabIndex = 25;
            this.txtApellidoPersonal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoPersonal_KeyPress);
            // 
            // txtNombrePersonal
            // 
            this.txtNombrePersonal.Location = new System.Drawing.Point(361, 88);
            this.txtNombrePersonal.Name = "txtNombrePersonal";
            this.txtNombrePersonal.Size = new System.Drawing.Size(125, 27);
            this.txtNombrePersonal.TabIndex = 24;
            this.txtNombrePersonal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePersonal_KeyPress);
            // 
            // lblCurpPersonal
            // 
            this.lblCurpPersonal.AutoSize = true;
            this.lblCurpPersonal.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurpPersonal.Location = new System.Drawing.Point(295, 304);
            this.lblCurpPersonal.Name = "lblCurpPersonal";
            this.lblCurpPersonal.Size = new System.Drawing.Size(65, 29);
            this.lblCurpPersonal.TabIndex = 23;
            this.lblCurpPersonal.Text = "CURP:";
            // 
            // lblRFCPersonal
            // 
            this.lblRFCPersonal.AutoSize = true;
            this.lblRFCPersonal.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRFCPersonal.Location = new System.Drawing.Point(308, 246);
            this.lblRFCPersonal.Name = "lblRFCPersonal";
            this.lblRFCPersonal.Size = new System.Drawing.Size(52, 29);
            this.lblRFCPersonal.TabIndex = 22;
            this.lblRFCPersonal.Text = "RFC:";
            // 
            // lblTelefonoPersonal
            // 
            this.lblTelefonoPersonal.AutoSize = true;
            this.lblTelefonoPersonal.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefonoPersonal.Location = new System.Drawing.Point(276, 186);
            this.lblTelefonoPersonal.Name = "lblTelefonoPersonal";
            this.lblTelefonoPersonal.Size = new System.Drawing.Size(89, 29);
            this.lblTelefonoPersonal.TabIndex = 21;
            this.lblTelefonoPersonal.Text = "Telefono:";
            // 
            // lblApellidoPersonal
            // 
            this.lblApellidoPersonal.AutoSize = true;
            this.lblApellidoPersonal.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellidoPersonal.Location = new System.Drawing.Point(276, 129);
            this.lblApellidoPersonal.Name = "lblApellidoPersonal";
            this.lblApellidoPersonal.Size = new System.Drawing.Size(84, 29);
            this.lblApellidoPersonal.TabIndex = 20;
            this.lblApellidoPersonal.Text = "Apellido:";
            // 
            // lblNombrePersonal
            // 
            this.lblNombrePersonal.AutoSize = true;
            this.lblNombrePersonal.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombrePersonal.Location = new System.Drawing.Point(276, 84);
            this.lblNombrePersonal.Name = "lblNombrePersonal";
            this.lblNombrePersonal.Size = new System.Drawing.Size(85, 29);
            this.lblNombrePersonal.TabIndex = 19;
            this.lblNombrePersonal.Text = "Nombre:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(360, 346);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 28);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.Location = new System.Drawing.Point(235, 344);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(130, 29);
            this.lblTipo.TabIndex = 31;
            this.lblTipo.Text = "Tipo Personal:";
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsalir.Location = new System.Drawing.Point(0, 506);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(113, 55);
            this.btnsalir.TabIndex = 32;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnEliminarPersnonal
            // 
            this.btnEliminarPersnonal.BackColor = System.Drawing.Color.Red;
            this.btnEliminarPersnonal.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarPersnonal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminarPersnonal.Location = new System.Drawing.Point(342, 414);
            this.btnEliminarPersnonal.Name = "btnEliminarPersnonal";
            this.btnEliminarPersnonal.Size = new System.Drawing.Size(146, 49);
            this.btnEliminarPersnonal.TabIndex = 33;
            this.btnEliminarPersnonal.Text = "Eliminar Personal";
            this.btnEliminarPersnonal.UseVisualStyleBackColor = false;
            this.btnEliminarPersnonal.Click += new System.EventHandler(this.btnEliminarPersnonal_Click);
            // 
            // bntpersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 561);
            this.Controls.Add(this.btnEliminarPersnonal);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnAgregarPersonal);
            this.Controls.Add(this.txtCurpPersonal);
            this.Controls.Add(this.txtRfcPersonal);
            this.Controls.Add(this.txtTelefonoPersonal);
            this.Controls.Add(this.txtApellidoPersonal);
            this.Controls.Add(this.txtNombrePersonal);
            this.Controls.Add(this.lblCurpPersonal);
            this.Controls.Add(this.lblRFCPersonal);
            this.Controls.Add(this.lblTelefonoPersonal);
            this.Controls.Add(this.lblApellidoPersonal);
            this.Controls.Add(this.lblNombrePersonal);
            this.Controls.Add(this.lblPersonal);
            this.Controls.Add(this.lblTrabajadores);
            this.Controls.Add(this.btnprovedor);
            this.Controls.Add(this.btnpersonal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bntEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCurp);
            this.Controls.Add(this.txtRfc);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCurp);
            this.Controls.Add(this.lblRFC);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dataGridView1);
            this.Name = "bntpersonal";
            this.Text = "personal";
            this.Load += new System.EventHandler(this.bntpersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblTelefono;
        private Label lblRFC;
        private Label lblCurp;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private TextBox txtRfc;
        private TextBox txtCurp;
        private Button btnAgregar;
        private Button bntEliminar;
        private Button button2;
        private Button btnpersonal;
        private Button btnprovedor;
        private Label lblTrabajadores;
        private Label lblPersonal;
        private Button btnAgregarPersonal;
        private TextBox txtCurpPersonal;
        private TextBox txtRfcPersonal;
        private TextBox txtTelefonoPersonal;
        private TextBox txtApellidoPersonal;
        private TextBox txtNombrePersonal;
        private Label lblCurpPersonal;
        private Label lblRFCPersonal;
        private Label lblTelefonoPersonal;
        private Label lblApellidoPersonal;
        private Label lblNombrePersonal;
        private ComboBox comboBox1;
        private Label lblTipo;
        private Button btnsalir;
        private Button btnEliminarPersnonal;
    }
}