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
    public partial class ListaTrabajadoresGrupo : Form
    {
        public ListaTrabajadoresGrupo()
        {
            InitializeComponent();

            cbNombreGrupoTrabajo.DataSource = dtsgrupotrabajo.ListaElementosGrupoTrabajo();
            cbNombreGrupoTrabajo.DisplayMember = "nombre_grupotrabajo";
            cbNombreGrupoTrabajo.ValueMember = "nombre_grupotrabajo";
        }

        clsDetalleGrupoTrabajo grupotrabajo = new clsDetalleGrupoTrabajo();
        clsDatosDetalleGrupoTrabajo dtsgrupotrabajo = new clsDatosDetalleGrupoTrabajo();

        private void btnListaTrabajadores_Click(object sender, EventArgs e)
        {
            VentanaGrupoTrabajo listagrupo = new VentanaGrupoTrabajo();
            listagrupo.nombre = cbNombreGrupoTrabajo.SelectedValue.ToString();
            listagrupo.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
