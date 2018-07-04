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
    public partial class IngresarChoferGrupo : Form
    {
        public IngresarChoferGrupo()
        {
            InitializeComponent();

            cbNombreGrupoTrabajo.DataSource = dtsGrupoTrabajo.ListaElementosGrupoTrabajo();
            cbNombreGrupoTrabajo.DisplayMember = "nombre_grupotrabajo";
            cbNombreGrupoTrabajo.ValueMember = "nombre_grupotrabajo";

            cbNumeroGrupoTrabajo.DataSource = dtsGrupoTrabajo.ListaElementosGrupoTrabajo();
            cbNumeroGrupoTrabajo.DisplayMember = "numero_grupotrabajo";
            cbNumeroGrupoTrabajo.ValueMember = "numero_grupotrabajo";

            cbChofer.DataSource = dtsGrupoTrabajo.ListaChofer();
            cbChofer.DisplayMember = "nombre_integrantegrupo";
            cbChofer.ValueMember = "idtbl_IntegranteGrupo";
        }

        clsDatosDetalleGrupoTrabajo dtsGrupoTrabajo = new clsDatosDetalleGrupoTrabajo();
        clsDetalleGrupoTrabajo grupotrabajo = new clsDetalleGrupoTrabajo();

        private void btnIngresarChofer_Click(object sender, EventArgs e)
        {
            grupotrabajo.Nombregrupotrabajo = cbNombreGrupoTrabajo.SelectedValue.ToString();
            grupotrabajo.Numerogrupotrabajo = Convert.ToInt32(cbNumeroGrupoTrabajo.SelectedValue);

            grupotrabajo.Idintegrantegrupo = Convert.ToInt32(cbChofer.SelectedValue.ToString());

            bool exito = dtsGrupoTrabajo.IngresarChoferGrupoTrabajo(grupotrabajo);

            if (exito == true)
            {
                MessageBox.Show("Chofer ingresado correctamente");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error, chofer no ingresado");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
