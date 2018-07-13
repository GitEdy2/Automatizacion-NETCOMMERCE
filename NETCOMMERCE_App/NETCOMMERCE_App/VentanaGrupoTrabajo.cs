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
        public int numero;

        clsDatosDetalleGrupoTrabajo dtsgrupotrabajo = new clsDatosDetalleGrupoTrabajo();
        clsDetalleGrupoTrabajo grupotrabajo = new clsDetalleGrupoTrabajo();

        
        public VentanaGrupoTrabajo()
        {
            InitializeComponent();

            lblNombre.Text = numero.ToString();
        }

        

        private void VentanaGrupoTrabajo_Load(object sender, EventArgs e)
        {
            lblNombre.Text = numero.ToString();

            dataGridViewGrupo.DataSource = dtsgrupotrabajo.ListaGruposTrabajo(numero);
                       
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
