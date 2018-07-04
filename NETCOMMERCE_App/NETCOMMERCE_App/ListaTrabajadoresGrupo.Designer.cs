namespace NETCOMMERCE_App
{
    partial class ListaTrabajadoresGrupo
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbNombreGrupoTrabajo = new System.Windows.Forms.ComboBox();
            this.btnListaTrabajadores = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE GRUPO DE TRABAJO:";
            // 
            // cbNombreGrupoTrabajo
            // 
            this.cbNombreGrupoTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNombreGrupoTrabajo.FormattingEnabled = true;
            this.cbNombreGrupoTrabajo.Location = new System.Drawing.Point(189, 32);
            this.cbNombreGrupoTrabajo.Name = "cbNombreGrupoTrabajo";
            this.cbNombreGrupoTrabajo.Size = new System.Drawing.Size(272, 21);
            this.cbNombreGrupoTrabajo.TabIndex = 1;
            // 
            // btnListaTrabajadores
            // 
            this.btnListaTrabajadores.Location = new System.Drawing.Point(82, 104);
            this.btnListaTrabajadores.Name = "btnListaTrabajadores";
            this.btnListaTrabajadores.Size = new System.Drawing.Size(127, 44);
            this.btnListaTrabajadores.TabIndex = 2;
            this.btnListaTrabajadores.Text = "VER TRABAJADORES DEL GRUPO";
            this.btnListaTrabajadores.UseVisualStyleBackColor = true;
            this.btnListaTrabajadores.Click += new System.EventHandler(this.btnListaTrabajadores_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(243, 104);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 44);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ListaTrabajadoresGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 193);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnListaTrabajadores);
            this.Controls.Add(this.cbNombreGrupoTrabajo);
            this.Controls.Add(this.label1);
            this.Name = "ListaTrabajadoresGrupo";
            this.Text = "ListaTrabajadoresGrupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNombreGrupoTrabajo;
        private System.Windows.Forms.Button btnListaTrabajadores;
        private System.Windows.Forms.Button btnCancelar;
    }
}