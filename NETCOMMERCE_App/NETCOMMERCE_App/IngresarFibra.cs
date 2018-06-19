using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using CapaDatos;
using CapaNegocios;

namespace NETCOMMERCE_App
{
    public partial class IngresarFibra : Form
    {
        public IngresarFibra()
        {
            InitializeComponent();
        }

        clsDetalleTrabajo trabajo = new clsDetalleTrabajo();
        clsDatosDetalleTrabajo dtstrabajo = new clsDatosDetalleTrabajo();

        private void btnIngresarFibra_Click(object sender, EventArgs e)
        {
            trabajo.Detallefibra = txtDetalleFibra.Text;
            trabajo.Metrosfibra = Convert.ToInt32(numMetrosFibra.ToString());

            bool exito = dtstrabajo.IngresarFibra(trabajo);

            if(exito == true)
            {
                MessageBox.Show("Datos de fibra ingresados correctamente");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error, datos de fibra no ingresados");
            }

        }
    }
}
