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
    public partial class IngresarAyudantesGrupo : Form
    {
        public IngresarAyudantesGrupo()
        {
            InitializeComponent();

            cbNombreGrupoTrabajo.DataSource = dtsGrupoTrabajo.ListaElementosGrupoTrabajo();
            cbNombreGrupoTrabajo.DisplayMember = "nombre_grupotrabajo";
            cbNombreGrupoTrabajo.ValueMember = "nombre_grupotrabajo";

            cbNumeroGrupoTrabajo.DataSource = dtsGrupoTrabajo.ListaElementosGrupoTrabajo();
            cbNumeroGrupoTrabajo.DisplayMember = "numero_grupotrabajo";
            cbNumeroGrupoTrabajo.ValueMember = "numero_grupotrabajo";

            cbAyudante.DataSource = dtsGrupoTrabajo.ListaAyudantes();
            cbAyudante.DisplayMember = "nombre_integrantegrupo";
            cbAyudante.ValueMember = "idtbl_IntegranteGrupo";
        }

        clsDatosDetalleGrupoTrabajo dtsGrupoTrabajo = new clsDatosDetalleGrupoTrabajo();
        clsDetalleGrupoTrabajo grupotrabajo = new clsDetalleGrupoTrabajo();

        private void btnIngresarAyudante_Click(object sender, EventArgs e)
        {
            grupotrabajo.Nombregrupotrabajo = cbNombreGrupoTrabajo.SelectedValue.ToString();
            grupotrabajo.Numerogrupotrabajo = Convert.ToInt32(cbNumeroGrupoTrabajo.SelectedValue);

            grupotrabajo.Idintegrantegrupo = Convert.ToInt32(cbAyudante.SelectedValue.ToString());

            bool exito = dtsGrupoTrabajo.IngresarAyudanteGrupoTrabajo(grupotrabajo);

            if (exito == true)
            {
                MessageBox.Show("Ayudante ingresado correctamente");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error, ayudante no ingresado");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
