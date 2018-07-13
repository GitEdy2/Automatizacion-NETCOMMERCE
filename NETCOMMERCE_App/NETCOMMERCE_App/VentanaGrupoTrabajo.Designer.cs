namespace NETCOMMERCE_App
{
    partial class VentanaGrupoTrabajo
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
            this.lblGrupoTrabajo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dataGridViewGrupo = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGrupoTrabajo
            // 
            this.lblGrupoTrabajo.AutoSize = true;
            this.lblGrupoTrabajo.Location = new System.Drawing.Point(24, 29);
            this.lblGrupoTrabajo.Name = "lblGrupoTrabajo";
            this.lblGrupoTrabajo.Size = new System.Drawing.Size(170, 13);
            this.lblGrupoTrabajo.TabIndex = 0;
            this.lblGrupoTrabajo.Text = "NUMERO GRUPO DE TRABAJO:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(200, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNombre.TabIndex = 1;
            // 
            // dataGridViewGrupo
            // 
            this.dataGridViewGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrupo.Location = new System.Drawing.Point(27, 63);
            this.dataGridViewGrupo.Name = "dataGridViewGrupo";
            this.dataGridViewGrupo.Size = new System.Drawing.Size(472, 252);
            this.dataGridViewGrupo.TabIndex = 2;
            this.dataGridViewGrupo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGrupo_CellContentClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(194, 333);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(123, 32);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // VentanaGrupoTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 388);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dataGridViewGrupo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblGrupoTrabajo);
            this.Name = "VentanaGrupoTrabajo";
            this.Text = "LISTA DE INTEGRANTES DE GRUPO DE TRABAJO";
            this.Load += new System.EventHandler(this.VentanaGrupoTrabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrupoTrabajo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dataGridViewGrupo;
        private System.Windows.Forms.Button btnCerrar;
    }
}