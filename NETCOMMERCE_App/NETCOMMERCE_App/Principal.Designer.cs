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
            this.txtNombreRuta = new System.Windows.Forms.TextBox();
            this.lblNombreRuta = new System.Windows.Forms.Label();
            this.lblClienteRuta = new System.Windows.Forms.Label();
            this.txtClienteRuta = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.lblCanton = new System.Windows.Forms.Label();
            this.lblParroquia = new System.Windows.Forms.Label();
            this.txtCanton = new System.Windows.Forms.TextBox();
            this.txtParroquia = new System.Windows.Forms.TextBox();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.pbNETCOMMERCE = new System.Windows.Forms.PictureBox();
            this.pbQR = new System.Windows.Forms.PictureBox();
            this.btnCrearRuta = new System.Windows.Forms.Button();
            this.tcRuta.SuspendLayout();
            this.Ruta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNETCOMMERCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
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
            this.Ruta.Controls.Add(this.btnCrearRuta);
            this.Ruta.Controls.Add(this.pbQR);
            this.Ruta.Controls.Add(this.pbNETCOMMERCE);
            this.Ruta.Controls.Add(this.txtReferencia);
            this.Ruta.Controls.Add(this.lblReferencia);
            this.Ruta.Controls.Add(this.txtParroquia);
            this.Ruta.Controls.Add(this.txtCanton);
            this.Ruta.Controls.Add(this.lblParroquia);
            this.Ruta.Controls.Add(this.lblCanton);
            this.Ruta.Controls.Add(this.cbProvincia);
            this.Ruta.Controls.Add(this.lblProvincia);
            this.Ruta.Controls.Add(this.txtClienteRuta);
            this.Ruta.Controls.Add(this.lblClienteRuta);
            this.Ruta.Controls.Add(this.lblNombreRuta);
            this.Ruta.Controls.Add(this.txtNombreRuta);
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
            // txtNombreRuta
            // 
            this.txtNombreRuta.Location = new System.Drawing.Point(151, 31);
            this.txtNombreRuta.Name = "txtNombreRuta";
            this.txtNombreRuta.Size = new System.Drawing.Size(189, 20);
            this.txtNombreRuta.TabIndex = 0;
            // 
            // lblNombreRuta
            // 
            this.lblNombreRuta.AutoSize = true;
            this.lblNombreRuta.Location = new System.Drawing.Point(62, 34);
            this.lblNombreRuta.Name = "lblNombreRuta";
            this.lblNombreRuta.Size = new System.Drawing.Size(83, 13);
            this.lblNombreRuta.TabIndex = 1;
            this.lblNombreRuta.Text = "Nombre de ruta:";
            // 
            // lblClienteRuta
            // 
            this.lblClienteRuta.AutoSize = true;
            this.lblClienteRuta.Location = new System.Drawing.Point(62, 82);
            this.lblClienteRuta.Name = "lblClienteRuta";
            this.lblClienteRuta.Size = new System.Drawing.Size(78, 13);
            this.lblClienteRuta.TabIndex = 2;
            this.lblClienteRuta.Text = "Cliente de ruta:";
            // 
            // txtClienteRuta
            // 
            this.txtClienteRuta.Location = new System.Drawing.Point(151, 79);
            this.txtClienteRuta.Name = "txtClienteRuta";
            this.txtClienteRuta.Size = new System.Drawing.Size(155, 20);
            this.txtClienteRuta.TabIndex = 3;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(84, 127);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 4;
            this.lblProvincia.Text = "Provincia:";
            // 
            // cbProvincia
            // 
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Location = new System.Drawing.Point(151, 127);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(155, 21);
            this.cbProvincia.TabIndex = 5;
            // 
            // lblCanton
            // 
            this.lblCanton.AutoSize = true;
            this.lblCanton.Location = new System.Drawing.Point(94, 174);
            this.lblCanton.Name = "lblCanton";
            this.lblCanton.Size = new System.Drawing.Size(44, 13);
            this.lblCanton.TabIndex = 6;
            this.lblCanton.Text = "Cantón:";
            // 
            // lblParroquia
            // 
            this.lblParroquia.AutoSize = true;
            this.lblParroquia.Location = new System.Drawing.Point(83, 221);
            this.lblParroquia.Name = "lblParroquia";
            this.lblParroquia.Size = new System.Drawing.Size(55, 13);
            this.lblParroquia.TabIndex = 8;
            this.lblParroquia.Text = "Parroquia:";
            // 
            // txtCanton
            // 
            this.txtCanton.Location = new System.Drawing.Point(151, 174);
            this.txtCanton.Name = "txtCanton";
            this.txtCanton.Size = new System.Drawing.Size(155, 20);
            this.txtCanton.TabIndex = 9;
            // 
            // txtParroquia
            // 
            this.txtParroquia.Location = new System.Drawing.Point(151, 221);
            this.txtParroquia.Name = "txtParroquia";
            this.txtParroquia.Size = new System.Drawing.Size(155, 20);
            this.txtParroquia.TabIndex = 10;
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Location = new System.Drawing.Point(76, 272);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(62, 13);
            this.lblReferencia.TabIndex = 11;
            this.lblReferencia.Text = "Referencia:";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(151, 272);
            this.txtReferencia.Multiline = true;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(189, 66);
            this.txtReferencia.TabIndex = 12;
            // 
            // pbNETCOMMERCE
            // 
            this.pbNETCOMMERCE.Location = new System.Drawing.Point(453, 60);
            this.pbNETCOMMERCE.Name = "pbNETCOMMERCE";
            this.pbNETCOMMERCE.Size = new System.Drawing.Size(263, 121);
            this.pbNETCOMMERCE.TabIndex = 13;
            this.pbNETCOMMERCE.TabStop = false;
            // 
            // pbQR
            // 
            this.pbQR.Location = new System.Drawing.Point(453, 203);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(263, 135);
            this.pbQR.TabIndex = 14;
            this.pbQR.TabStop = false;
            // 
            // btnCrearRuta
            // 
            this.btnCrearRuta.Location = new System.Drawing.Point(151, 358);
            this.btnCrearRuta.Name = "btnCrearRuta";
            this.btnCrearRuta.Size = new System.Drawing.Size(189, 35);
            this.btnCrearRuta.TabIndex = 15;
            this.btnCrearRuta.Text = "CREAR RUTA";
            this.btnCrearRuta.UseVisualStyleBackColor = true;
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
            this.Ruta.ResumeLayout(false);
            this.Ruta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNETCOMMERCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcRuta;
        private System.Windows.Forms.TabPage Ruta;
        private System.Windows.Forms.TabPage dtTrabajo;
        private System.Windows.Forms.Button btnCrearRuta;
        private System.Windows.Forms.PictureBox pbQR;
        private System.Windows.Forms.PictureBox pbNETCOMMERCE;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.TextBox txtParroquia;
        private System.Windows.Forms.TextBox txtCanton;
        private System.Windows.Forms.Label lblParroquia;
        private System.Windows.Forms.Label lblCanton;
        private System.Windows.Forms.ComboBox cbProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtClienteRuta;
        private System.Windows.Forms.Label lblClienteRuta;
        private System.Windows.Forms.Label lblNombreRuta;
        private System.Windows.Forms.TextBox txtNombreRuta;
    }
}