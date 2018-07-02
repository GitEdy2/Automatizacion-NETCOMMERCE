namespace NETCOMMERCE_App
{
    partial class IngresarLinierosGrupo
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
            this.lblNumeroGrupo = new System.Windows.Forms.Label();
            this.lblNombreGrupo = new System.Windows.Forms.Label();
            this.cbNombreGrupoTrabajo = new System.Windows.Forms.ComboBox();
            this.cbNumeroGrupoTrabajo = new System.Windows.Forms.ComboBox();
            this.lblLiniero = new System.Windows.Forms.Label();
            this.cbLiniero = new System.Windows.Forms.ComboBox();
            this.btnIngresarLiniero = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroGrupo
            // 
            this.lblNumeroGrupo.AutoSize = true;
            this.lblNumeroGrupo.Location = new System.Drawing.Point(32, 103);
            this.lblNumeroGrupo.Name = "lblNumeroGrupo";
            this.lblNumeroGrupo.Size = new System.Drawing.Size(170, 13);
            this.lblNumeroGrupo.TabIndex = 25;
            this.lblNumeroGrupo.Text = "NUMERO GRUPO DE TRABAJO:";
            // 
            // lblNombreGrupo
            // 
            this.lblNombreGrupo.AutoSize = true;
            this.lblNombreGrupo.Location = new System.Drawing.Point(32, 62);
            this.lblNombreGrupo.Name = "lblNombreGrupo";
            this.lblNombreGrupo.Size = new System.Drawing.Size(169, 13);
            this.lblNombreGrupo.TabIndex = 23;
            this.lblNombreGrupo.Text = "NOMBRE GRUPO DE TRABAJO:";
            // 
            // cbNombreGrupoTrabajo
            // 
            this.cbNombreGrupoTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNombreGrupoTrabajo.FormattingEnabled = true;
            this.cbNombreGrupoTrabajo.Location = new System.Drawing.Point(207, 59);
            this.cbNombreGrupoTrabajo.Name = "cbNombreGrupoTrabajo";
            this.cbNombreGrupoTrabajo.Size = new System.Drawing.Size(244, 21);
            this.cbNombreGrupoTrabajo.TabIndex = 26;
            // 
            // cbNumeroGrupoTrabajo
            // 
            this.cbNumeroGrupoTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumeroGrupoTrabajo.FormattingEnabled = true;
            this.cbNumeroGrupoTrabajo.Location = new System.Drawing.Point(207, 103);
            this.cbNumeroGrupoTrabajo.Name = "cbNumeroGrupoTrabajo";
            this.cbNumeroGrupoTrabajo.Size = new System.Drawing.Size(79, 21);
            this.cbNumeroGrupoTrabajo.TabIndex = 27;
            // 
            // lblLiniero
            // 
            this.lblLiniero.AutoSize = true;
            this.lblLiniero.Location = new System.Drawing.Point(149, 153);
            this.lblLiniero.Name = "lblLiniero";
            this.lblLiniero.Size = new System.Drawing.Size(53, 13);
            this.lblLiniero.TabIndex = 28;
            this.lblLiniero.Text = "LINIERO:";
            // 
            // cbLiniero
            // 
            this.cbLiniero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLiniero.FormattingEnabled = true;
            this.cbLiniero.Location = new System.Drawing.Point(208, 150);
            this.cbLiniero.Name = "cbLiniero";
            this.cbLiniero.Size = new System.Drawing.Size(209, 21);
            this.cbLiniero.TabIndex = 29;
            // 
            // btnIngresarLiniero
            // 
            this.btnIngresarLiniero.Location = new System.Drawing.Point(95, 240);
            this.btnIngresarLiniero.Name = "btnIngresarLiniero";
            this.btnIngresarLiniero.Size = new System.Drawing.Size(137, 27);
            this.btnIngresarLiniero.TabIndex = 30;
            this.btnIngresarLiniero.Text = "INGRESAR LINIERO";
            this.btnIngresarLiniero.UseVisualStyleBackColor = true;
            this.btnIngresarLiniero.Click += new System.EventHandler(this.btnIngresarLiniero_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(251, 240);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 27);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // IngresarLinierosGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 308);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresarLiniero);
            this.Controls.Add(this.cbLiniero);
            this.Controls.Add(this.lblLiniero);
            this.Controls.Add(this.cbNumeroGrupoTrabajo);
            this.Controls.Add(this.cbNombreGrupoTrabajo);
            this.Controls.Add(this.lblNumeroGrupo);
            this.Controls.Add(this.lblNombreGrupo);
            this.Name = "IngresarLinierosGrupo";
            this.Text = "IngresarLinierosGrupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumeroGrupo;
        private System.Windows.Forms.Label lblNombreGrupo;
        private System.Windows.Forms.ComboBox cbNombreGrupoTrabajo;
        private System.Windows.Forms.ComboBox cbNumeroGrupoTrabajo;
        private System.Windows.Forms.Label lblLiniero;
        private System.Windows.Forms.ComboBox cbLiniero;
        private System.Windows.Forms.Button btnIngresarLiniero;
        private System.Windows.Forms.Button btnCancelar;
    }
}