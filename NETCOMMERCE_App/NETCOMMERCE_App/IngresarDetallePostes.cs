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
    public partial class IngresarDetallePostes : Form
    {
        public IngresarDetallePostes()
        {
            InitializeComponent();
        }

        clsDatosDetalleTrabajo dtstrabajo = new clsDatosDetalleTrabajo();
        clsDetalleTrabajo trabajo = new clsDetalleTrabajo();

        Principal principal = new Principal();

        private void btnIngresarPostes_Click(object sender, EventArgs e)
        {
            trabajo.Detallepostes = txtDetallePostes.Text;
            trabajo.Numeropostes = Convert.ToInt32(numPostes.Value);

            bool exito = dtstrabajo.IngresarPostes(trabajo);

            if (exito == true)
            {
                MessageBox.Show("Datos de postes ingresados correctamente");
                this.Hide();
                Principal principal = new Principal();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Error, datos de postes no ingresados");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal.Refresh();
        }
    }
}
