namespace NETCOMMERCE_App
{
    partial class IngresarDetallePostes
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
            this.lblDetallePostes = new System.Windows.Forms.Label();
            this.txtDetallePostes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numPostes = new System.Windows.Forms.NumericUpDown();
            this.btnIngresarPostes = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPostes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetallePostes
            // 
            this.lblDetallePostes.AutoSize = true;
            this.lblDetallePostes.Location = new System.Drawing.Point(25, 39);
            this.lblDetallePostes.Name = "lblDetallePostes";
            this.lblDetallePostes.Size = new System.Drawing.Size(122, 13);
            this.lblDetallePostes.TabIndex = 0;
            this.lblDetallePostes.Text = "DETALLE DE POSTES:";
            // 
            // txtDetallePostes
            // 
            this.txtDetallePostes.Location = new System.Drawing.Point(153, 36);
            this.txtDetallePostes.Multiline = true;
            this.txtDetallePostes.Name = "txtDetallePostes";
            this.txtDetallePostes.Size = new System.Drawing.Size(247, 70);
            this.txtDetallePostes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NUMERO DE POSTES:";
            // 
            // numPostes
            // 
            this.numPostes.Location = new System.Drawing.Point(153, 134);
            this.numPostes.Name = "numPostes";
            this.numPostes.Size = new System.Drawing.Size(102, 20);
            this.numPostes.TabIndex = 3;
            // 
            // btnIngresarPostes
            // 
            this.btnIngresarPostes.Location = new System.Drawing.Point(75, 184);
            this.btnIngresarPostes.Name = "btnIngresarPostes";
            this.btnIngresarPostes.Size = new System.Drawing.Size(141, 35);
            this.btnIngresarPostes.TabIndex = 4;
            this.btnIngresarPostes.Text = "INGRESAR POSTES";
            this.btnIngresarPostes.UseVisualStyleBackColor = true;
            this.btnIngresarPostes.Click += new System.EventHandler(this.btnIngresarPostes_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(222, 184);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 35);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // IngresarDetallePostes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 246);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresarPostes);
            this.Controls.Add(this.numPostes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDetallePostes);
            this.Controls.Add(this.lblDetallePostes);
            this.Name = "IngresarDetallePostes";
            this.Text = "IngresarDetallePostes";
            ((System.ComponentModel.ISupportInitialize)(this.numPostes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetallePostes;
        private System.Windows.Forms.TextBox txtDetallePostes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numPostes;
        private System.Windows.Forms.Button btnIngresarPostes;
        private System.Windows.Forms.Button btnCancelar;
    }
}