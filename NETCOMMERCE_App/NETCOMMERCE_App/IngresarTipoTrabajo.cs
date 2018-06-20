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
    public partial class IngresarTipoTrabajo : Form
    {
        public IngresarTipoTrabajo()
        {
            InitializeComponent();
        }

        private void btnIngresarTipoTrabajo_Click(object sender, EventArgs e)
        {
            clsDatosDetalleTrabajo dttrabajo = new clsDatosDetalleTrabajo();
            clsDetalleTrabajo trabajo = new clsDetalleTrabajo();

            trabajo.Identificadortipotrabajo = txtIdentificadorTrabajo.Text;
            trabajo.Descripciontipotrabajo = txtDescripcionTrabajo.Text;

            bool exito = dttrabajo.IngresarTipoTrabajo(trabajo);

            if (exito == true)
            {
                MessageBox.Show("Tipo de trabajo ingresado correctamente");
            }
            else
            {
                MessageBox.Show("Error, Tipo de trabajo no ingresado");
                this.Hide();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
