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
    public partial class IngresarCargoTrabajador : Form
    {
        public IngresarCargoTrabajador()
        {
            InitializeComponent();
        }

        clsIntegranteGrupo tipointegrante = new clsIntegranteGrupo();
        clsDatosIntegranteGrupo dtstipointegrante = new clsDatosIntegranteGrupo();


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCrearCargo_Click(object sender, EventArgs e)
        {
            tipointegrante.Cargotipointegrante = txtNombreCargo.Text;
            tipointegrante.Descripciontipointegrante = txtDescripcionCargo.Text;

            bool exito = dtstipointegrante.IngresarTipoIntegrante(tipointegrante);

            if (exito == true)
            {
                MessageBox.Show("Cargo de trabajador ingresado correctamente");
                this.Hide();
                Principal principal = new Principal();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Error, cargo de trabajador no ingresado");
            }
        }
    }
}
