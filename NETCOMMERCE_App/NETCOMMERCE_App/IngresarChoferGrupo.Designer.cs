namespace NETCOMMERCE_App
{
    partial class IngresarChoferGrupo
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
            this.lblNombreGrupoTrabajo = new System.Windows.Forms.Label();
            this.cbNombreGrupoTrabajo = new System.Windows.Forms.ComboBox();
            this.lblChofer = new System.Windows.Forms.Label();
            this.cbChofer = new System.Windows.Forms.ComboBox();
            this.btnIngresarChofer = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreGrupoTrabajo
            // 
            this.lblNombreGrupoTrabajo.AutoSize = true;
            this.lblNombreGrupoTrabajo.Location = new System.Drawing.Point(23, 41);
            this.lblNombreGrupoTrabajo.Name = "lblNombreGrupoTrabajo";
            this.lblNombreGrupoTrabajo.Size = new System.Drawing.Size(169, 13);
            this.lblNombreGrupoTrabajo.TabIndex = 0;
            this.lblNombreGrupoTrabajo.Text = "NOMBRE GRUPO DE TRABAJO:";
            // 
            // cbNombreGrupoTrabajo
            // 
            this.cbNombreGrupoTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNombreGrupoTrabajo.FormattingEnabled = true;
            this.cbNombreGrupoTrabajo.Location = new System.Drawing.Point(199, 41);
            this.cbNombreGrupoTrabajo.Name = "cbNombreGrupoTrabajo";
            this.cbNombreGrupoTrabajo.Size = new System.Drawing.Size(300, 21);
            this.cbNombreGrupoTrabajo.TabIndex = 2;
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Location = new System.Drawing.Point(139, 113);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(54, 13);
            this.lblChofer.TabIndex = 4;
            this.lblChofer.Text = "CHOFER:";
            // 
            // cbChofer
            // 
            this.cbChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChofer.FormattingEnabled = true;
            this.cbChofer.Location = new System.Drawing.Point(199, 110);
            this.cbChofer.Name = "cbChofer";
            this.cbChofer.Size = new System.Drawing.Size(239, 21);
            this.cbChofer.TabIndex = 5;
            // 
            // btnIngresarChofer
            // 
            this.btnIngresarChofer.Location = new System.Drawing.Point(127, 177);
            this.btnIngresarChofer.Name = "btnIngresarChofer";
            this.btnIngresarChofer.Size = new System.Drawing.Size(129, 33);
            this.btnIngresarChofer.TabIndex = 6;
            this.btnIngresarChofer.Text = "INGRESAR CHOFER";
            this.btnIngresarChofer.UseVisualStyleBackColor = true;
            this.btnIngresarChofer.Click += new System.EventHandler(this.btnIngresarChofer_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(287, 177);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 33);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // IngresarChoferGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 247);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresarChofer);
            this.Controls.Add(this.cbChofer);
            this.Controls.Add(this.lblChofer);
            this.Controls.Add(this.cbNombreGrupoTrabajo);
            this.Controls.Add(this.lblNombreGrupoTrabajo);
            this.Name = "IngresarChoferGrupo";
            this.Text = "Ingresar Chofer Grupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreGrupoTrabajo;
        private System.Windows.Forms.ComboBox cbNombreGrupoTrabajo;
        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.ComboBox cbChofer;
        private System.Windows.Forms.Button btnIngresarChofer;
        private System.Windows.Forms.Button btnCancelar;
    }
}