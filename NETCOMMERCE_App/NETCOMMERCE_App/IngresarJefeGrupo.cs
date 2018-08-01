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
    public partial class IngresarJefeGrupo : Form
    {
        public IngresarJefeGrupo()
        {
            InitializeComponent();

            cbNombreGrupoTrabajo.DataSource = dtsGrupoTrabajo.ListaElementosGrupoTrabajo();
            cbNombreGrupoTrabajo.DisplayMember = "nombre_grupotrabajo";
            cbNombreGrupoTrabajo.ValueMember = "idtbl_GrupoTrabajo";

            cbJefeGrupo.DataSource = dtsGrupoTrabajo.ListaJefeGrupo();
            cbJefeGrupo.DisplayMember = "nombre_integrantegrupo";
            cbJefeGrupo.ValueMember = "idtbl_IntegranteGrupo";

        }

        clsDatosDetalleGrupoTrabajo dtsGrupoTrabajo = new clsDatosDetalleGrupoTrabajo();
        clsDetalleGrupoTrabajo grupotrabajo = new clsDetalleGrupoTrabajo();

        private void btnIngresarJefeGrupo_Click(object sender, EventArgs e)
        {
            grupotrabajo.Nombregrupotrabajo = cbNombreGrupoTrabajo.SelectedValue.ToString();
            grupotrabajo.Idintegrantegrupo = Convert.ToInt32(cbJefeGrupo.SelectedValue.ToString());



            bool exito = dtsGrupoTrabajo.IngresarJefeGrupoTrabajo(grupotrabajo);

            if (exito == true)
            {
                MessageBox.Show("Jefe de Grupo ingresado correctamente");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error, Jefe de Grupo no ingresado");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
