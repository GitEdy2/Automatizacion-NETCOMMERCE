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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        clsRuta ruta = new clsRuta();
        clsDatosRuta dtsRuta = new clsDatosRuta();

        clsDetalleTrabajo trabajo = new clsDetalleTrabajo();
        clsDatosDetalleTrabajo dtstrabajo = new clsDatosDetalleTrabajo();

        

        private void btnCrearRuta_Click(object sender, EventArgs e)
        {
            ruta.Nombreruta = txtNombreRuta.Text;
            ruta.Clienteruta = txtClienteRuta.Text;
            ruta.Provinciaruta = cbProvincia.SelectedItem.ToString();
            ruta.Parroquiaruta = txtParroquia.Text;
            ruta.Cantonruta = txtCanton.Text;
            ruta.Referenciaruta = txtReferencia.Text;

            bool exito = dtsRuta.IngresarRuta(ruta);

            if (exito == true)
            {
                MessageBox.Show("Ruta ingresada correctamente");

                txtNombreRuta.Clear();
                txtClienteRuta.Clear();
                txtParroquia.Clear();
                txtCanton.Clear();
                txtReferencia.Clear();
            }
            else
            {
                MessageBox.Show("Error, ruta no ingresada");
            }

        }


        private void btnCrearTrabajo_Click(object sender, EventArgs e)
        {
            trabajo.Descripcion1tipotrabajo = cbTipoTrabajo1.SelectedValue.ToString();
            trabajo.Descripcion2tipotrabajo = cbTipoTrabajo2.SelectedValue.ToString();

            trabajo.Detallefibra = cbTipodeFibra.SelectedText.ToString();
            trabajo.Metrosfibra = Convert.ToInt32(txtMetrosFibra.Text);

            trabajo.Detallepostes = cbTipoPostes1.SelectedValue.ToString();
            trabajo.Detalle2postes = cbTipoPostes2.SelectedValue.ToString();
            trabajo.Numeropostes = Convert.ToInt32(txtNumeroPostes.Text);

            trabajo.Detalleretenidas = txtDetalleRetenidas.Text;
            trabajo.Numeroretenidas = Convert.ToInt32(txtNumeroRetenidas.Text);

            bool exito = dtstrabajo.IngresarFibra(trabajo);
            bool exito2 = dtstrabajo.IngresarPostes(trabajo);
            bool exito3 = dtstrabajo.IngresarRetenidas(trabajo);

            bool exito4 = dtstrabajo.IngresarDetalleTrabajo(trabajo);
        }
    }
}
