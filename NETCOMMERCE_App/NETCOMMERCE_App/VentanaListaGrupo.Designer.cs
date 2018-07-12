namespace NETCOMMERCE_App
{
    partial class VentanaListaGrupo
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
            this.dataGridViewGrupo = new System.Windows.Forms.DataGridView();
            this.lblNombreGrupoTrabajo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGrupo
            // 
            this.dataGridViewGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrupo.Location = new System.Drawing.Point(33, 109);
            this.dataGridViewGrupo.Name = "dataGridViewGrupo";
            this.dataGridViewGrupo.Size = new System.Drawing.Size(446, 225);
            this.dataGridViewGrupo.TabIndex = 0;
            // 
            // lblNombreGrupoTrabajo
            // 
            this.lblNombreGrupoTrabajo.AutoSize = true;
            this.lblNombreGrupoTrabajo.Location = new System.Drawing.Point(30, 56);
            this.lblNombreGrupoTrabajo.Name = "lblNombreGrupoTrabajo";
            this.lblNombreGrupoTrabajo.Size = new System.Drawing.Size(169, 13);
            this.lblNombreGrupoTrabajo.TabIndex = 1;
            this.lblNombreGrupoTrabajo.Text = "NOMBRE GRUPO DE TRABAJO:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(206, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNombre.TabIndex = 3;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(206, 72);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(0, 13);
            this.lblNumero.TabIndex = 4;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(189, 357);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(107, 29);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // VentanaListaGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 410);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNombreGrupoTrabajo);
            this.Controls.Add(this.dataGridViewGrupo);
            this.Name = "VentanaListaGrupo";
            this.Text = "VentanaListaGrupo";
            this.Load += new System.EventHandler(this.VentanaListaGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGrupo;
        private System.Windows.Forms.Label lblNombreGrupoTrabajo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnCerrar;
    }
}