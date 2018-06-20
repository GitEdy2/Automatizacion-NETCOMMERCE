namespace NETCOMMERCE_App
{
    partial class IngresarDetalleRetenidas
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
            this.lblDetalleRetenidas = new System.Windows.Forms.Label();
            this.txtDetalleRetenidas = new System.Windows.Forms.TextBox();
            this.lblNumeroRetenidas = new System.Windows.Forms.Label();
            this.numRetenidas = new System.Windows.Forms.NumericUpDown();
            this.btnIngresarRetenidas = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRetenidas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetalleRetenidas
            // 
            this.lblDetalleRetenidas.AutoSize = true;
            this.lblDetalleRetenidas.Location = new System.Drawing.Point(24, 37);
            this.lblDetalleRetenidas.Name = "lblDetalleRetenidas";
            this.lblDetalleRetenidas.Size = new System.Drawing.Size(141, 13);
            this.lblDetalleRetenidas.TabIndex = 0;
            this.lblDetalleRetenidas.Text = "DETALLE DE RETENIDAS:";
            // 
            // txtDetalleRetenidas
            // 
            this.txtDetalleRetenidas.Location = new System.Drawing.Point(171, 34);
            this.txtDetalleRetenidas.Multiline = true;
            this.txtDetalleRetenidas.Name = "txtDetalleRetenidas";
            this.txtDetalleRetenidas.Size = new System.Drawing.Size(265, 90);
            this.txtDetalleRetenidas.TabIndex = 1;
            // 
            // lblNumeroRetenidas
            // 
            this.lblNumeroRetenidas.AutoSize = true;
            this.lblNumeroRetenidas.Location = new System.Drawing.Point(24, 147);
            this.lblNumeroRetenidas.Name = "lblNumeroRetenidas";
            this.lblNumeroRetenidas.Size = new System.Drawing.Size(141, 13);
            this.lblNumeroRetenidas.TabIndex = 2;
            this.lblNumeroRetenidas.Text = "NUMERO DE RETENIDAS:";
            // 
            // numRetenidas
            // 
            this.numRetenidas.Location = new System.Drawing.Point(171, 145);
            this.numRetenidas.Name = "numRetenidas";
            this.numRetenidas.Size = new System.Drawing.Size(105, 20);
            this.numRetenidas.TabIndex = 3;
            // 
            // btnIngresarRetenidas
            // 
            this.btnIngresarRetenidas.Location = new System.Drawing.Point(81, 195);
            this.btnIngresarRetenidas.Name = "btnIngresarRetenidas";
            this.btnIngresarRetenidas.Size = new System.Drawing.Size(138, 34);
            this.btnIngresarRetenidas.TabIndex = 4;
            this.btnIngresarRetenidas.Text = "INGRESAR RETENIDAS";
            this.btnIngresarRetenidas.UseVisualStyleBackColor = true;
            this.btnIngresarRetenidas.Click += new System.EventHandler(this.btnIngresarRetenidas_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(240, 195);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 34);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // IngresarDetalleRetenidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 256);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresarRetenidas);
            this.Controls.Add(this.numRetenidas);
            this.Controls.Add(this.lblNumeroRetenidas);
            this.Controls.Add(this.txtDetalleRetenidas);
            this.Controls.Add(this.lblDetalleRetenidas);
            this.Name = "IngresarDetalleRetenidas";
            this.Text = "IngresarDetalleRetenidas";
            ((System.ComponentModel.ISupportInitialize)(this.numRetenidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetalleRetenidas;
        private System.Windows.Forms.TextBox txtDetalleRetenidas;
        private System.Windows.Forms.Label lblNumeroRetenidas;
        private System.Windows.Forms.NumericUpDown numRetenidas;
        private System.Windows.Forms.Button btnIngresarRetenidas;
        private System.Windows.Forms.Button btnCancelar;
    }
}