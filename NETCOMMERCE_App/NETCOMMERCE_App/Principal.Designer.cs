namespace NETCOMMERCE_App
{
    partial class Principal
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
            this.tcRuta = new System.Windows.Forms.TabControl();
            this.Ruta = new System.Windows.Forms.TabPage();
            this.dtTrabajo = new System.Windows.Forms.TabPage();
            this.tcRuta.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcRuta
            // 
            this.tcRuta.Controls.Add(this.Ruta);
            this.tcRuta.Controls.Add(this.dtTrabajo);
            this.tcRuta.Location = new System.Drawing.Point(-1, 3);
            this.tcRuta.Name = "tcRuta";
            this.tcRuta.SelectedIndex = 0;
            this.tcRuta.Size = new System.Drawing.Size(800, 444);
            this.tcRuta.TabIndex = 0;
            this.tcRuta.Tag = "";
            // 
            // Ruta
            // 
            this.Ruta.Location = new System.Drawing.Point(4, 22);
            this.Ruta.Name = "Ruta";
            this.Ruta.Padding = new System.Windows.Forms.Padding(3);
            this.Ruta.Size = new System.Drawing.Size(792, 418);
            this.Ruta.TabIndex = 0;
            this.Ruta.Text = "Ruta";
            this.Ruta.UseVisualStyleBackColor = true;
            // 
            // dtTrabajo
            // 
            this.dtTrabajo.Location = new System.Drawing.Point(4, 22);
            this.dtTrabajo.Name = "dtTrabajo";
            this.dtTrabajo.Padding = new System.Windows.Forms.Padding(3);
            this.dtTrabajo.Size = new System.Drawing.Size(792, 418);
            this.dtTrabajo.TabIndex = 1;
            this.dtTrabajo.Text = "Detalles de Trabajo";
            this.dtTrabajo.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcRuta);
            this.Name = "Principal";
            this.Text = "Principal";
            this.tcRuta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcRuta;
        private System.Windows.Forms.TabPage Ruta;
        private System.Windows.Forms.TabPage dtTrabajo;
    }
}