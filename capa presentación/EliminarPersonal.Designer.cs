namespace Cooperativa_Julian_vega_felix.capa_presentación
{
    partial class EliminarPersonal
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
            this.bntEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTrabajador
            // 
            this.lblTrabajador.AutoSize = true;
            this.lblTrabajador.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrabajador.Location = new System.Drawing.Point(246, 57);
            this.lblTrabajador.Name = "lblTrabajador";
            this.lblTrabajador.Size = new System.Drawing.Size(288, 18);
            this.lblTrabajador.TabIndex = 1;
            this.lblTrabajador.Text = "Ingresa el ID del trabajador";
            // 
            // txtIdPersonal
            // 
            this.txtIdPersonal.Location = new System.Drawing.Point(260, 90);
            this.txtIdPersonal.Name = "txtIdPersonal";
            this.txtIdPersonal.Size = new System.Drawing.Size(249, 27);
            this.txtIdPersonal.TabIndex = 2;
            this.txtIdPersonal.TextChanged += new System.EventHandler(this.txtIdPersonal_TextChanged);
            // 
            // bntEliminar
            // 
            this.bntEliminar.BackColor = System.Drawing.Color.Red;
            this.bntEliminar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bntEliminar.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bntEliminar.Location = new System.Drawing.Point(0, 182);
            this.bntEliminar.Name = "bntEliminar";
            this.bntEliminar.Size = new System.Drawing.Size(800, 49);
            this.bntEliminar.TabIndex = 14;
            this.bntEliminar.Text = "Eliminar";
            this.bntEliminar.UseVisualStyleBackColor = false;
            this.bntEliminar.Click += new System.EventHandler(this.bntEliminar_Click);
            // 
            // EliminarPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 231);
            this.Controls.Add(this.bntEliminar);
            this.Controls.Add(this.txtIdPersonal);
            this.Controls.Add(this.lblTrabajador);
            this.Name = "EliminarPersonal";
            this.Text = "EliminarProovedor";
            this.Load += new System.EventHandler(this.EliminarPersonal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTrabajador;
        private TextBox txtIdPersonal;
        private Button bntEliminar;
    }
}