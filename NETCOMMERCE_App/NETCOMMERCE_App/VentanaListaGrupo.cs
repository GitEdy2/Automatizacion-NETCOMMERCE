using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETCOMMERCE_App
{
    public partial class VentanaListaGrupo : Form
    {
        public string nombre;
        public int numero;

        public VentanaListaGrupo()
        {
            InitializeComponent();


        }

       

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
