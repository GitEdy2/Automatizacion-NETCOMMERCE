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
            trabajo.Descripcion1tipotrabajo = cbTipoTrabajo1.SelectedItem.ToString();
            trabajo.Descripcion2tipotrabajo = cbTipoTrabajo2.SelectedItem.ToString();

            trabajo.Fibraid = Convert.ToInt32(cbDetalleFibra.SelectedValue.ToString());
            trabajo.Postesid = Convert.ToInt32(cbDetallePostes.SelectedValue.ToString());
            trabajo.Retenidasid = Convert.ToInt32(cbDetalleRetenidas.SelectedValue.ToString());


            bool exito = dtstrabajo.IngresarDetalleTrabajo(trabajo);


            if (exito == true)
            {
                MessageBox.Show("Trabajo ingresado correctamente");

                //txtTipoFibra.Clear();
               // txtMetrosFibra.Clear();

                //txtTipoPostes.Clear();
                //txtNumeroPostes.Clear();

                //txtDetalleRetenidas.Clear();
                //txtNumeroRetenidas.Clear();
            }
            else
            {
                MessageBox.Show("Error, trabajo no ingresado");
            }
        }


        private void txtMetrosFibra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNumeroPostes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNumeroRetenidas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void cBoxFibra_CheckedChanged(object sender, EventArgs e)
        {
            if(cBoxFibra.Checked == true)
            {

                lblTipoFibra.Visible = true;

                cbDetalleFibra.Visible = true;

                btnIngresarDetallesFibra.Visible = true;
                
            }

            if(cBoxFibra.Checked == false)
            {
                lblTipoFibra.Visible = false;

                cbDetalleFibra.Visible = false;

                btnIngresarDetallesFibra.Visible = false;

            }
        }


        private void cBoxPostes_CheckedChanged(object sender, EventArgs e)
        {
            if(cBoxPostes.Checked == true)
            {
                lblTipoPostes.Visible = true;

                cbDetallePostes.Visible = true;
                btnIngresarDetallesPostes.Visible = true;
            }

            if(cBoxPostes.Checked == false)
            {
                lblTipoPostes.Visible = false;

                cbDetallePostes.Visible = false;
                btnIngresarDetallesPostes.Visible = false;
            }
        }


        private void cBoxRetenidas_CheckedChanged(object sender, EventArgs e)
        {
            if(cBoxRetenidas.Checked == true)
            {
                lblDetalleRetenidas.Visible = true;
                
                btnIngresarDetallesRetenidas.Visible = true;
                cbDetalleRetenidas.Visible = true;
            }
            
            if(cBoxRetenidas.Checked == false)
            {
                lblDetalleRetenidas.Visible = false;

                btnIngresarDetallesRetenidas.Visible = false;
                cbDetalleRetenidas.Visible = false;
            }
        }

        private void btnIngresarDetallesFibra_Click(object sender, EventArgs e)
        {
            IngresarDetalleFibra fibra = new IngresarDetalleFibra();
            fibra.Show();
        }

        private void btnIngresarDetallesPostes_Click(object sender, EventArgs e)
        {
            IngresarDetallePostes postes = new IngresarDetallePostes();
            postes.Show();
        }

        private void btnIngresarDetallesRetenidas_Click(object sender, EventArgs e)
        {
            IngresarDetalleRetenidas retenidas = new IngresarDetalleRetenidas();
            retenidas.Show();
        }
    }
}
