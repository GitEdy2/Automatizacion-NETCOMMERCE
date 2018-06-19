namespace NETCOMMERCE_App
{
    partial class IngresarFibra
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
            this.lblDetalleFibra = new System.Windows.Forms.Label();
            this.txtDetalleFibra = new System.Windows.Forms.TextBox();
            this.lblMetrosFibra = new System.Windows.Forms.Label();
            this.numMetrosFibra = new System.Windows.Forms.NumericUpDown();
            this.btnIngresarFibra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMetrosFibra)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetalleFibra
            // 
            this.lblDetalleFibra.AutoSize = true;
            this.lblDetalleFibra.Location = new System.Drawing.Point(44, 50);
            this.lblDetalleFibra.Name = "lblDetalleFibra";
            this.lblDetalleFibra.Size = new System.Drawing.Size(110, 13);
            this.lblDetalleFibra.TabIndex = 0;
            this.lblDetalleFibra.Text = "DETALLE DE FIBRA:";
            // 
            // txtDetalleFibra
            // 
            this.txtDetalleFibra.Location = new System.Drawing.Point(160, 47);
            this.txtDetalleFibra.Multiline = true;
            this.txtDetalleFibra.Name = "txtDetalleFibra";
            this.txtDetalleFibra.Size = new System.Drawing.Size(202, 45);
            this.txtDetalleFibra.TabIndex = 1;
            // 
            // lblMetrosFibra
            // 
            this.lblMetrosFibra.AutoSize = true;
            this.lblMetrosFibra.Location = new System.Drawing.Point(26, 114);
            this.lblMetrosFibra.Name = "lblMetrosFibra";
            this.lblMetrosFibra.Size = new System.Drawing.Size(128, 13);
            this.lblMetrosFibra.TabIndex = 2;
            this.lblMetrosFibra.Text = "METROS DE FIBRA (m) :";
            // 
            // numMetrosFibra
            // 
            this.numMetrosFibra.Location = new System.Drawing.Point(160, 112);
            this.numMetrosFibra.Name = "numMetrosFibra";
            this.numMetrosFibra.Size = new System.Drawing.Size(75, 20);
            this.numMetrosFibra.TabIndex = 3;
            // 
            // btnIngresarFibra
            // 
            this.btnIngresarFibra.Location = new System.Drawing.Point(160, 170);
            this.btnIngresarFibra.Name = "btnIngresarFibra";
            this.btnIngresarFibra.Size = new System.Drawing.Size(132, 33);
            this.btnIngresarFibra.TabIndex = 4;
            this.btnIngresarFibra.Text = "INGRESAR FIBRA";
            this.btnIngresarFibra.UseVisualStyleBackColor = true;
            this.btnIngresarFibra.Click += new System.EventHandler(this.btnIngresarFibra_Click);
            // 
            // IngresarFibra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 253);
            this.Controls.Add(this.btnIngresarFibra);
            this.Controls.Add(this.numMetrosFibra);
            this.Controls.Add(this.lblMetrosFibra);
            this.Controls.Add(this.txtDetalleFibra);
            this.Controls.Add(this.lblDetalleFibra);
            this.Name = "IngresarFibra";
            this.Text = "IngresarFibra";
            ((System.ComponentModel.ISupportInitialize)(this.numMetrosFibra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetalleFibra;
        private System.Windows.Forms.TextBox txtDetalleFibra;
        private System.Windows.Forms.Label lblMetrosFibra;
        private System.Windows.Forms.NumericUpDown numMetrosFibra;
        private System.Windows.Forms.Button btnIngresarFibra;
    }
}