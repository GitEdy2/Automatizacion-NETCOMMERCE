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
    public partial class IngresarDetalleRetenidas : Form
    {
        public IngresarDetalleRetenidas()
        {
            InitializeComponent();
        }

        clsDetalleTrabajo trabajo = new clsDetalleTrabajo();
        clsDatosDetalleTrabajo dtstrabajo = new clsDatosDetalleTrabajo();

        Principal principal = new Principal();

        private void btnIngresarRetenidas_Click(object sender, EventArgs e)
        {           
            trabajo.Detalleretenidas = txtDetalleRetenidas.Text;
            trabajo.Numeroretenidas = Convert.ToInt32(numRetenidas.Value);

            bool exito = dtstrabajo.IngresarRetenidas(trabajo);

            if (exito == true)
            {
                MessageBox.Show("Datos de retenidas ingresados correctamente");
                this.Hide();
                Principal principal = new Principal();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Error, datos de retenidas no ingresados");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
