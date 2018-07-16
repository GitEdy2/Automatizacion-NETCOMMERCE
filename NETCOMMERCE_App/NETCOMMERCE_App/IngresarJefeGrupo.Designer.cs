namespace NETCOMMERCE_App
{
    partial class IngresarJefeGrupo
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
            this.lblNombreGrupo = new System.Windows.Forms.Label();
            this.lblJefeGrupo = new System.Windows.Forms.Label();
            this.cbNombreGrupoTrabajo = new System.Windows.Forms.ComboBox();
            this.cbJefeGrupo = new System.Windows.Forms.ComboBox();
            this.btnIngresarJefeGrupo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreGrupo
            // 
            this.lblNombreGrupo.AutoSize = true;
            this.lblNombreGrupo.Location = new System.Drawing.Point(17, 50);
            this.lblNombreGrupo.Name = "lblNombreGrupo";
            this.lblNombreGrupo.Size = new System.Drawing.Size(169, 13);
            this.lblNombreGrupo.TabIndex = 0;
            this.lblNombreGrupo.Text = "NOMBRE GRUPO DE TRABAJO:";
            // 
            // lblJefeGrupo
            // 
            this.lblJefeGrupo.AutoSize = true;
            this.lblJefeGrupo.Location = new System.Drawing.Point(91, 112);
            this.lblJefeGrupo.Name = "lblJefeGrupo";
            this.lblJefeGrupo.Size = new System.Drawing.Size(95, 13);
            this.lblJefeGrupo.TabIndex = 1;
            this.lblJefeGrupo.Text = "JEFE DE GRUPO:";
            // 
            // cbNombreGrupoTrabajo
            // 
            this.cbNombreGrupoTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNombreGrupoTrabajo.FormattingEnabled = true;
            this.cbNombreGrupoTrabajo.Location = new System.Drawing.Point(193, 50);
            this.cbNombreGrupoTrabajo.Name = "cbNombreGrupoTrabajo";
            this.cbNombreGrupoTrabajo.Size = new System.Drawing.Size(265, 21);
            this.cbNombreGrupoTrabajo.TabIndex = 2;
            // 
            // cbJefeGrupo
            // 
            this.cbJefeGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJefeGrupo.FormattingEnabled = true;
            this.cbJefeGrupo.Location = new System.Drawing.Point(192, 112);
            this.cbJefeGrupo.Name = "cbJefeGrupo";
            this.cbJefeGrupo.Size = new System.Drawing.Size(166, 21);
            this.cbJefeGrupo.TabIndex = 3;
            // 
            // btnIngresarJefeGrupo
            // 
            this.btnIngresarJefeGrupo.Location = new System.Drawing.Point(94, 183);
            this.btnIngresarJefeGrupo.Name = "btnIngresarJefeGrupo";
            this.btnIngresarJefeGrupo.Size = new System.Drawing.Size(132, 45);
            this.btnIngresarJefeGrupo.TabIndex = 4;
            this.btnIngresarJefeGrupo.Text = "INGRESAR JEFE DE GRUPO";
            this.btnIngresarJefeGrupo.UseVisualStyleBackColor = true;
            this.btnIngresarJefeGrupo.Click += new System.EventHandler(this.btnIngresarJefeGrupo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(250, 183);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 45);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // IngresarJefeGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 259);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresarJefeGrupo);
            this.Controls.Add(this.cbJefeGrupo);
            this.Controls.Add(this.cbNombreGrupoTrabajo);
            this.Controls.Add(this.lblJefeGrupo);
            this.Controls.Add(this.lblNombreGrupo);
            this.Name = "IngresarJefeGrupo";
            this.Text = "IngresarJefeGrupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreGrupo;
        private System.Windows.Forms.Label lblJefeGrupo;
        private System.Windows.Forms.ComboBox cbNombreGrupoTrabajo;
        private System.Windows.Forms.ComboBox cbJefeGrupo;
        private System.Windows.Forms.Button btnIngresarJefeGrupo;
        private System.Windows.Forms.Button btnCancelar;
    }
}