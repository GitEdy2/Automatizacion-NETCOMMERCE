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
    public partial class VentanaGrupoTrabajo : Form
    {
        public string nombre;

        clsDatosDetalleGrupoTrabajo dtsgrupotrabajo = new clsDatosDetalleGrupoTrabajo();
        clsDetalleGrupoTrabajo grupotrabajo = new clsDetalleGrupoTrabajo();

        

        public VentanaGrupoTrabajo()
        {
            InitializeComponent();

            lblNombre.Text = nombre;
        }

        

        private void VentanaGrupoTrabajo_Load(object sender, EventArgs e)
        {
            lblNombre.Text = nombre;

            dataGridViewGrupo.DataSource = dtsgrupotrabajo.ListarGruposTrabajo(nombre);
            
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridViewGrupo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
