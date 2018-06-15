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

            trabajo.Detallefibra = txtTipoFibra.Text;
            trabajo.Metrosfibra = Convert.ToInt32(txtMetrosFibra.Text);

            trabajo.Detallepostes = txtTipoPostes.Text;
            trabajo.Numeropostes = Convert.ToInt32(txtNumeroPostes.Text);

            trabajo.Detalleretenidas = txtDetalleRetenidas.Text;
            trabajo.Numeroretenidas = Convert.ToInt32(txtNumeroRetenidas.Text);

            bool exito = dtstrabajo.IngresarFibra(trabajo);
            bool exito2 = dtstrabajo.IngresarPostes(trabajo);
            bool exito3 = dtstrabajo.IngresarRetenidas(trabajo);           
            bool exito4 = dtstrabajo.IngresarDetalleTrabajo(trabajo);


            if ((exito || exito2 || exito3 || exito4) == true)
            {
                MessageBox.Show("Trabajo ingresado correctamente");

                txtTipoFibra.Clear();
                txtMetrosFibra.Clear();

                txtTipoPostes.Clear();
                txtNumeroPostes.Clear();

                txtDetalleRetenidas.Clear();
                txtNumeroRetenidas.Clear();
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
                lblMetrosFibra.Visible = true;

                txtTipoFibra.Visible = true;
                txtMetrosFibra.Visible = true;
            }

            if(cBoxFibra.Checked == false)
            {
                lblTipoFibra.Visible = false;
                lblMetrosFibra.Visible = false;

                txtTipoFibra.Visible = false;
                txtTipoFibra.Text = null;

                txtMetrosFibra.Visible = false;
                //txtMetrosFibra.Text = null;
            }
        }


        private void cBoxPostes_CheckedChanged(object sender, EventArgs e)
        {
            if(cBoxPostes.Checked == true)
            {
                lblTipoPostes.Visible = true;
                lblNumeroPostes.Visible = true;

                txtTipoPostes.Visible = true;
                txtNumeroPostes.Visible = true;
            }

            if(cBoxPostes.Checked == false)
            {
                lblTipoPostes.Visible = false;
                lblNumeroPostes.Visible = false;

                txtTipoPostes.Visible = false;
                txtTipoPostes.Text = null;

                txtNumeroPostes.Visible = false;
                //txtNumeroPostes.Text = null;
            }
        }


        private void cBoxRetenidas_CheckedChanged(object sender, EventArgs e)
        {
            if(cBoxRetenidas.Checked == true)
            {
                lblDetalleRetenidas.Visible = true;
                lblNumeroRetenidas.Visible = true;

                txtDetalleRetenidas.Visible = true;
                txtNumeroRetenidas.Visible = true;
            }
            
            if(cBoxRetenidas.Checked == false)
            {
                lblDetalleRetenidas.Visible = false;
                lblNumeroRetenidas.Visible = false;

                txtDetalleRetenidas.Visible = false;
                txtDetalleRetenidas.Text = null;

                txtNumeroRetenidas.Visible = false;
                //txtNumeroRetenidas.Text = null;
            }
        }
    }
}
