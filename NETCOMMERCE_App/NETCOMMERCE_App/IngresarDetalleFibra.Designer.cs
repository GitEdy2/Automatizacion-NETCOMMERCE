namespace NETCOMMERCE_App
{
    partial class IngresarDetalleFibra
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
            this.btnIngresarFibra = new System.Windows.Forms.Button();
            this.lblDetalleFibra = new System.Windows.Forms.Label();
            this.txtDetalleFibra = new System.Windows.Forms.TextBox();
            this.lblMetrosFibra = new System.Windows.Forms.Label();
            this.numMetrosFibra = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMetrosFibra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresarFibra
            // 
            this.btnIngresarFibra.Location = new System.Drawing.Point(95, 188);
            this.btnIngresarFibra.Name = "btnIngresarFibra";
            this.btnIngresarFibra.Size = new System.Drawing.Size(120, 30);
            this.btnIngresarFibra.TabIndex = 0;
            this.btnIngresarFibra.Text = "INGRESAR FIBRA";
            this.btnIngresarFibra.UseVisualStyleBackColor = true;
            this.btnIngresarFibra.Click += new System.EventHandler(this.btnIngresarFibra_Click);
            // 
            // lblDetalleFibra
            // 
            this.lblDetalleFibra.AutoSize = true;
            this.lblDetalleFibra.Location = new System.Drawing.Point(46, 42);
            this.lblDetalleFibra.Name = "lblDetalleFibra";
            this.lblDetalleFibra.Size = new System.Drawing.Size(110, 13);
            this.lblDetalleFibra.TabIndex = 1;
            this.lblDetalleFibra.Text = "DETALLE DE FIBRA:";
            // 
            // txtDetalleFibra
            // 
            this.txtDetalleFibra.Location = new System.Drawing.Point(162, 42);
            this.txtDetalleFibra.Multiline = true;
            this.txtDetalleFibra.Name = "txtDetalleFibra";
            this.txtDetalleFibra.Size = new System.Drawing.Size(224, 67);
            this.txtDetalleFibra.TabIndex = 2;
            // 
            // lblMetrosFibra
            // 
            this.lblMetrosFibra.AutoSize = true;
            this.lblMetrosFibra.Location = new System.Drawing.Point(31, 138);
            this.lblMetrosFibra.Name = "lblMetrosFibra";
            this.lblMetrosFibra.Size = new System.Drawing.Size(125, 13);
            this.lblMetrosFibra.TabIndex = 3;
            this.lblMetrosFibra.Text = "METROS DE FIBRA (m):";
            // 
            // numMetrosFibra
            // 
            this.numMetrosFibra.Location = new System.Drawing.Point(162, 136);
            this.numMetrosFibra.Name = "numMetrosFibra";
            this.numMetrosFibra.Size = new System.Drawing.Size(93, 20);
            this.numMetrosFibra.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(230, 188);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 30);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // IngresarDetalleFibra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 245);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.numMetrosFibra);
            this.Controls.Add(this.lblMetrosFibra);
            this.Controls.Add(this.txtDetalleFibra);
            this.Controls.Add(this.lblDetalleFibra);
            this.Controls.Add(this.btnIngresarFibra);
            this.Name = "IngresarDetalleFibra";
            this.Text = "IngresarDetalleFibra";
            ((System.ComponentModel.ISupportInitialize)(this.numMetrosFibra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarFibra;
        private System.Windows.Forms.Label lblDetalleFibra;
        private System.Windows.Forms.TextBox txtDetalleFibra;
        private System.Windows.Forms.Label lblMetrosFibra;
        private System.Windows.Forms.NumericUpDown numMetrosFibra;
        private System.Windows.Forms.Button btnCancelar;
    }
}