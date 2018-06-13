namespace NETCOMMERCE_App
{
    partial class LoginUsuario
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.PBNetcommerce = new System.Windows.Forms.PictureBox();
            this.pbQR = new System.Windows.Forms.PictureBox();
            this.btnIngresarLogin = new System.Windows.Forms.Button();
            this.lblLoginUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRolEmpresa = new System.Windows.Forms.ComboBox();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBNetcommerce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(165, 192);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(165, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(165, 239);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(165, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(105, 195);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 13);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(94, 242);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(65, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // PBNetcommerce
            // 
            this.PBNetcommerce.Location = new System.Drawing.Point(441, 52);
            this.PBNetcommerce.Name = "PBNetcommerce";
            this.PBNetcommerce.Size = new System.Drawing.Size(298, 136);
            this.PBNetcommerce.TabIndex = 4;
            this.PBNetcommerce.TabStop = false;
            // 
            // pbQR
            // 
            this.pbQR.Location = new System.Drawing.Point(441, 239);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(298, 146);
            this.pbQR.TabIndex = 5;
            this.pbQR.TabStop = false;
            // 
            // btnIngresarLogin
            // 
            this.btnIngresarLogin.Location = new System.Drawing.Point(165, 294);
            this.btnIngresarLogin.Name = "btnIngresarLogin";
            this.btnIngresarLogin.Size = new System.Drawing.Size(137, 36);
            this.btnIngresarLogin.TabIndex = 6;
            this.btnIngresarLogin.Text = "Ingresar";
            this.btnIngresarLogin.UseVisualStyleBackColor = true;
            this.btnIngresarLogin.Click += new System.EventHandler(this.btnIngresarLogin_Click);
            // 
            // lblLoginUsuario
            // 
            this.lblLoginUsuario.AutoSize = true;
            this.lblLoginUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUsuario.Location = new System.Drawing.Point(50, 52);
            this.lblLoginUsuario.Name = "lblLoginUsuario";
            this.lblLoginUsuario.Size = new System.Drawing.Size(349, 46);
            this.lblLoginUsuario.TabIndex = 7;
            this.lblLoginUsuario.Text = "LOGIN USUARIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rol en empresa:";
            // 
            // cbRolEmpresa
            // 
            this.cbRolEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRolEmpresa.FormattingEnabled = true;
            this.cbRolEmpresa.Items.AddRange(new object[] {
            "COORDINADOR"});
            this.cbRolEmpresa.Location = new System.Drawing.Point(165, 145);
            this.cbRolEmpresa.Name = "cbRolEmpresa";
            this.cbRolEmpresa.Size = new System.Drawing.Size(165, 21);
            this.cbRolEmpresa.TabIndex = 9;
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Location = new System.Drawing.Point(165, 353);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(137, 41);
            this.btnNuevoUsuario.TabIndex = 10;
            this.btnNuevoUsuario.Text = "Ingresar Nuevo Usuario";
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // LoginUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Controls.Add(this.cbRolEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLoginUsuario);
            this.Controls.Add(this.btnIngresarLogin);
            this.Controls.Add(this.pbQR);
            this.Controls.Add(this.PBNetcommerce);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Name = "LoginUsuario";
            this.Text = "LoginUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.PBNetcommerce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox PBNetcommerce;
        private System.Windows.Forms.PictureBox pbQR;
        private System.Windows.Forms.Button btnIngresarLogin;
        private System.Windows.Forms.Label lblLoginUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRolEmpresa;
        private System.Windows.Forms.Button btnNuevoUsuario;
    }
}