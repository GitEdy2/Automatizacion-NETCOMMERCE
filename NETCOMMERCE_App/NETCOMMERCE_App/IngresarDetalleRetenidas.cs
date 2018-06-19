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

        private void btnIngresarRetenidas_Click(object sender, EventArgs e)
        {
            clsDetalleTrabajo trabajo = new clsDetalleTrabajo();
            clsDatosDetalleTrabajo dtstrabajo = new clsDatosDetalleTrabajo();

            trabajo.Detalleretenidas = txtDetalleRetenidas.Text;
            trabajo.Numeroretenidas = Convert.ToInt32(numRetenidas.Value);

            bool exito = dtstrabajo.IngresarRetenidas(trabajo);

            if (exito == true)
            {
                MessageBox.Show("Datos de retenidas ingresados correctamente");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error, datos de retenidas no ingresados");
            }


        }
    }
}
