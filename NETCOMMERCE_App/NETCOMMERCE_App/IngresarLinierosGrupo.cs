using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocios;

namespace NETCOMMERCE_App
{
    public partial class IngresarLinierosGrupo : Form
    {
        public IngresarLinierosGrupo()
        {
            InitializeComponent();

            cbNombreGrupoTrabajo.DataSource = dtsGrupoTrabajo.ListaElementosGrupoTrabajo();
            cbNombreGrupoTrabajo.DisplayMember = "nombre_grupotrabajo";
            cbNombreGrupoTrabajo.ValueMember = "idtbl_GrupoTrabajo";


            cbLiniero.DataSource = dtsGrupoTrabajo.ListaLinieros();
            cbLiniero.DisplayMember = "nombre_integrantegrupo";
            cbLiniero.ValueMember = "idtbl_IntegranteGrupo";
        }

        clsDatosDetalleGrupoTrabajo dtsGrupoTrabajo = new clsDatosDetalleGrupoTrabajo();
        clsDetalleGrupoTrabajo grupotrabajo = new clsDetalleGrupoTrabajo();

        private void btnIngresarLiniero_Click(object sender, EventArgs e)
        {
            grupotrabajo.Nombregrupotrabajo = cbNombreGrupoTrabajo.SelectedValue.ToString();
           
            grupotrabajo.Idintegrantegrupo = Convert.ToInt32(cbLiniero.SelectedValue.ToString());

            bool exito = dtsGrupoTrabajo.IngresarLinieroGrupoTrabajo(grupotrabajo);

            if (exito == true)
            {
                MessageBox.Show("Liniero ingresado correctamente");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error, liniero no ingresado");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
