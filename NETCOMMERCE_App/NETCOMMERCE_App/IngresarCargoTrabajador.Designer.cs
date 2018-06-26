namespace NETCOMMERCE_App
{
    partial class IngresarCargoTrabajador
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
            this.lblDescripcionCargo = new System.Windows.Forms.Label();
            this.lblNombreCargo = new System.Windows.Forms.Label();
            this.txtNombreCargo = new System.Windows.Forms.TextBox();
            this.txtDescripcionCargo = new System.Windows.Forms.TextBox();
            this.btnCrearCargo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescripcionCargo
            // 
            this.lblDescripcionCargo.AutoSize = true;
            this.lblDescripcionCargo.Location = new System.Drawing.Point(42, 110);
            this.lblDescripcionCargo.Name = "lblDescripcionCargo";
            this.lblDescripcionCargo.Size = new System.Drawing.Size(124, 13);
            this.lblDescripcionCargo.TabIndex = 0;
            this.lblDescripcionCargo.Text = "DESCRIPCION CARGO:";
            // 
            // lblNombreCargo
            // 
            this.lblNombreCargo.AutoSize = true;
            this.lblNombreCargo.Location = new System.Drawing.Point(50, 49);
            this.lblNombreCargo.Name = "lblNombreCargo";
            this.lblNombreCargo.Size = new System.Drawing.Size(116, 13);
            this.lblNombreCargo.TabIndex = 1;
            this.lblNombreCargo.Text = "NOMBRE DE CARGO:";
            // 
            // txtNombreCargo
            // 
            this.txtNombreCargo.Location = new System.Drawing.Point(172, 46);
            this.txtNombreCargo.Name = "txtNombreCargo";
            this.txtNombreCargo.Size = new System.Drawing.Size(204, 20);
            this.txtNombreCargo.TabIndex = 2;
            // 
            // txtDescripcionCargo
            // 
            this.txtDescripcionCargo.Location = new System.Drawing.Point(173, 110);
            this.txtDescripcionCargo.Multiline = true;
            this.txtDescripcionCargo.Name = "txtDescripcionCargo";
            this.txtDescripcionCargo.Size = new System.Drawing.Size(203, 80);
            this.txtDescripcionCargo.TabIndex = 3;
            // 
            // btnCrearCargo
            // 
            this.btnCrearCargo.Location = new System.Drawing.Point(85, 225);
            this.btnCrearCargo.Name = "btnCrearCargo";
            this.btnCrearCargo.Size = new System.Drawing.Size(121, 32);
            this.btnCrearCargo.TabIndex = 4;
            this.btnCrearCargo.Text = "CREAR CARGO";
            this.btnCrearCargo.UseVisualStyleBackColor = true;
            this.btnCrearCargo.Click += new System.EventHandler(this.btnCrearCargo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(223, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 32);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // IngresarCargoTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 299);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrearCargo);
            this.Controls.Add(this.txtDescripcionCargo);
            this.Controls.Add(this.txtNombreCargo);
            this.Controls.Add(this.lblNombreCargo);
            this.Controls.Add(this.lblDescripcionCargo);
            this.Name = "IngresarCargoTrabajador";
            this.Text = "IngresarCargoTrabajador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcionCargo;
        private System.Windows.Forms.Label lblNombreCargo;
        private System.Windows.Forms.TextBox txtNombreCargo;
        private System.Windows.Forms.TextBox txtDescripcionCargo;
        private System.Windows.Forms.Button btnCrearCargo;
        private System.Windows.Forms.Button btnCancelar;
    }
}