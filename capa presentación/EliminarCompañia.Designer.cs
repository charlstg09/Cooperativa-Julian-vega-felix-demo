namespace Cooperativa_Julian_vega_felix.capa_presentación
{
    partial class EliminarCompañia
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
            this.txtIdCompañia = new System.Windows.Forms.TextBox();
            this.lblTrabajador = new System.Windows.Forms.Label();
            this.btnEliminarPersonal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIdCompañia
            // 
            this.txtIdCompañia.Location = new System.Drawing.Point(271, 77);
            this.txtIdCompañia.Name = "txtIdCompañia";
            this.txtIdCompañia.Size = new System.Drawing.Size(261, 27);
            this.txtIdCompañia.TabIndex = 4;
            this.txtIdCompañia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdPersonal_KeyPress);
            // 
            // lblTrabajador
            // 
            this.lblTrabajador.AutoSize = true;
            this.lblTrabajador.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrabajador.Location = new System.Drawing.Point(256, 46);
            this.lblTrabajador.Name = "lblTrabajador";
            this.lblTrabajador.Size = new System.Drawing.Size(288, 18);
            this.lblTrabajador.TabIndex = 3;
            this.lblTrabajador.Text = "Ingresa el ID de la Compañia";
            // 
            // btnEliminarPersonal
            // 
            this.btnEliminarPersonal.BackColor = System.Drawing.Color.Red;
            this.btnEliminarPersonal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEliminarPersonal.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarPersonal.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPersonal.Location = new System.Drawing.Point(0, 164);
            this.btnEliminarPersonal.Name = "btnEliminarPersonal";
            this.btnEliminarPersonal.Size = new System.Drawing.Size(800, 51);
            this.btnEliminarPersonal.TabIndex = 5;
            this.btnEliminarPersonal.Text = "Eliminar Compañia";
            this.btnEliminarPersonal.UseVisualStyleBackColor = false;
            this.btnEliminarPersonal.Click += new System.EventHandler(this.btnEliminarPersonal_Click);
            // 
            // EliminarCompañia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 215);
            this.Controls.Add(this.btnEliminarPersonal);
            this.Controls.Add(this.txtIdCompañia);
            this.Controls.Add(this.lblTrabajador);
            this.Name = "EliminarCompañia";
            this.Text = "EliminarCompañia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtIdCompañia;
        private Label lblTrabajador;
        private Button btnEliminarPersonal;
    }
}