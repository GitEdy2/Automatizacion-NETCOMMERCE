namespace NETCOMMERCE_App
{
    partial class IngresarAyudantesGrupo
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbNombreGrupoTrabajo = new System.Windows.Forms.ComboBox();
            this.cbAyudante = new System.Windows.Forms.ComboBox();
            this.btnIngresarAyudante = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreGrupoTrabajo
            // 
            this.lblNombreGrupoTrabajo.AutoSize = true;
            this.lblNombreGrupoTrabajo.Location = new System.Drawing.Point(28, 43);
            this.lblNombreGrupoTrabajo.Name = "lblNombreGrupoTrabajo";
            this.lblNombreGrupoTrabajo.Size = new System.Drawing.Size(169, 13);
            this.lblNombreGrupoTrabajo.TabIndex = 0;
            this.lblNombreGrupoTrabajo.Text = "NOMBRE GRUPO DE TRABAJO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "AYUDANTE:";
            // 
            // cbNombreGrupoTrabajo
            // 
            this.cbNombreGrupoTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNombreGrupoTrabajo.FormattingEnabled = true;
            this.cbNombreGrupoTrabajo.Location = new System.Drawing.Point(203, 40);
            this.cbNombreGrupoTrabajo.Name = "cbNombreGrupoTrabajo";
            this.cbNombreGrupoTrabajo.Size = new System.Drawing.Size(269, 21);
            this.cbNombreGrupoTrabajo.TabIndex = 3;
            // 
            // cbAyudante
            // 
            this.cbAyudante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAyudante.FormattingEnabled = true;
            this.cbAyudante.Location = new System.Drawing.Point(203, 115);
            this.cbAyudante.Name = "cbAyudante";
            this.cbAyudante.Size = new System.Drawing.Size(244, 21);
            this.cbAyudante.TabIndex = 5;
            // 
            // btnIngresarAyudante
            // 
            this.btnIngresarAyudante.Location = new System.Drawing.Point(113, 179);
            this.btnIngresarAyudante.Name = "btnIngresarAyudante";
            this.btnIngresarAyudante.Size = new System.Drawing.Size(139, 30);
            this.btnIngresarAyudante.TabIndex = 6;
            this.btnIngresarAyudante.Text = "INGRESAR AYUDANTE";
            this.btnIngresarAyudante.UseVisualStyleBackColor = true;
            this.btnIngresarAyudante.Click += new System.EventHandler(this.btnIngresarAyudante_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(269, 179);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 30);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // IngresarAyudantesGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 242);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresarAyudante);
            this.Controls.Add(this.cbAyudante);
            this.Controls.Add(this.cbNombreGrupoTrabajo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombreGrupoTrabajo);
            this.Name = "IngresarAyudantesGrupo";
            this.Text = "Ingresar Ayudantes Grupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreGrupoTrabajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNombreGrupoTrabajo;
        private System.Windows.Forms.ComboBox cbAyudante;
        private System.Windows.Forms.Button btnIngresarAyudante;
        private System.Windows.Forms.Button btnCancelar;
    }
}