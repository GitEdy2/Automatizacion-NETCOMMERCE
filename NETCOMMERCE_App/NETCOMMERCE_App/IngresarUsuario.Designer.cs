namespace NETCOMMERCE_App
{
    partial class IngresarUsuario
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
            this.lblIngresarUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRolEmpresa = new System.Windows.Forms.ComboBox();
            this.btnIngresoUsuario = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbNetcommerce = new System.Windows.Forms.PictureBox();
            this.pbQR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNetcommerce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIngresarUsuario
            // 
            this.lblIngresarUsuario.AutoSize = true;
            this.lblIngresarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarUsuario.Location = new System.Drawing.Point(34, 56);
            this.lblIngresarUsuario.Name = "lblIngresarUsuario";
            this.lblIngresarUsuario.Size = new System.Drawing.Size(329, 46);
            this.lblIngresarUsuario.TabIndex = 0;
            this.lblIngresarUsuario.Text = "Ingresar Usuario";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(72, 164);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(115, 13);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Nombre deUsuario:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(193, 161);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(179, 20);
            this.txtNombreUsuario.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(122, 217);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(65, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(193, 217);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(179, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rol de Empresa:";
            // 
            // cbRolEmpresa
            // 
            this.cbRolEmpresa.FormattingEnabled = true;
            this.cbRolEmpresa.Items.AddRange(new object[] {
            "COORDINADOR"});
            this.cbRolEmpresa.Location = new System.Drawing.Point(194, 272);
            this.cbRolEmpresa.Name = "cbRolEmpresa";
            this.cbRolEmpresa.Size = new System.Drawing.Size(142, 21);
            this.cbRolEmpresa.TabIndex = 6;
            // 
            // btnIngresoUsuario
            // 
            this.btnIngresoUsuario.Location = new System.Drawing.Point(75, 352);
            this.btnIngresoUsuario.Name = "btnIngresoUsuario";
            this.btnIngresoUsuario.Size = new System.Drawing.Size(152, 24);
            this.btnIngresoUsuario.TabIndex = 7;
            this.btnIngresoUsuario.Text = "Ingresar Usuario";
            this.btnIngresoUsuario.UseVisualStyleBackColor = true;
            this.btnIngresoUsuario.Click += new System.EventHandler(this.btnIngresoUsuario_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(255, 352);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 24);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbNetcommerce
            // 
            this.pbNetcommerce.Location = new System.Drawing.Point(461, 56);
            this.pbNetcommerce.Name = "pbNetcommerce";
            this.pbNetcommerce.Size = new System.Drawing.Size(287, 142);
            this.pbNetcommerce.TabIndex = 9;
            this.pbNetcommerce.TabStop = false;
            // 
            // pbQR
            // 
            this.pbQR.Location = new System.Drawing.Point(461, 222);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(287, 154);
            this.pbQR.TabIndex = 10;
            this.pbQR.TabStop = false;
            // 
            // IngresarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbQR);
            this.Controls.Add(this.pbNetcommerce);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresoUsuario);
            this.Controls.Add(this.cbRolEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblIngresarUsuario);
            this.Name = "IngresarUsuario";
            this.Text = "Ingresar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pbNetcommerce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresarUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRolEmpresa;
        private System.Windows.Forms.Button btnIngresoUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbNetcommerce;
        private System.Windows.Forms.PictureBox pbQR;
    }
}