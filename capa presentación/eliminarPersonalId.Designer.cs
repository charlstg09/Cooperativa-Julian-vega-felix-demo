namespace Cooperativa_Julian_vega_felix.capa_presentación
{
    partial class eliminarPersonalId
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
            this.lblTrabajador = new System.Windows.Forms.Label();
            this.txtIdPersonal = new System.Windows.Forms.TextBox();
            this.btnEliminarPersonal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTrabajador
            // 
            this.lblTrabajador.AutoSize = true;
            this.lblTrabajador.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrabajador.Location = new System.Drawing.Point(256, 66);
            this.lblTrabajador.Name = "lblTrabajador";
            this.lblTrabajador.Size = new System.Drawing.Size(288, 18);
            this.lblTrabajador.TabIndex = 1;
            this.lblTrabajador.Text = "Ingresa el ID del trabajador";
            // 
            // txtIdPersonal
            // 
            this.txtIdPersonal.Location = new System.Drawing.Point(271, 97);
            this.txtIdPersonal.Name = "txtIdPersonal";
            this.txtIdPersonal.Size = new System.Drawing.Size(261, 27);
            this.txtIdPersonal.TabIndex = 2;
            this.txtIdPersonal.TextChanged += new System.EventHandler(this.txtIdPersonal_TextChanged);
            this.txtIdPersonal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdPersonal_KeyPress);
            // 
            // btnEliminarPersonal
            // 
            this.btnEliminarPersonal.BackColor = System.Drawing.Color.Red;
            this.btnEliminarPersonal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEliminarPersonal.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarPersonal.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPersonal.Location = new System.Drawing.Point(0, 161);
            this.btnEliminarPersonal.Name = "btnEliminarPersonal";
            this.btnEliminarPersonal.Size = new System.Drawing.Size(800, 51);
            this.btnEliminarPersonal.TabIndex = 3;
            this.btnEliminarPersonal.Text = "Eliminar Personal";
            this.btnEliminarPersonal.UseVisualStyleBackColor = false;
            this.btnEliminarPersonal.Click += new System.EventHandler(this.btnEliminarPersonal_Click);
            // 
            // eliminarPersonalId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 212);
            this.Controls.Add(this.btnEliminarPersonal);
            this.Controls.Add(this.txtIdPersonal);
            this.Controls.Add(this.lblTrabajador);
            this.Name = "eliminarPersonalId";
            this.Text = "eliminarPersonalId";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTrabajador;
        private TextBox txtIdPersonal;
        private Button btnEliminarPersonal;
    }
}