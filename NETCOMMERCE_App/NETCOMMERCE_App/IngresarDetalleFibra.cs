﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using CapaNegocios;
using CapaDatos;



namespace NETCOMMERCE_App
{
    public partial class IngresarDetalleFibra : Form
    {
        public IngresarDetalleFibra()
        {
            InitializeComponent();
        }

        private void btnIngresarFibra_Click(object sender, EventArgs e)
        {
            clsDetalleTrabajo trabajo = new clsDetalleTrabajo();
            clsDatosDetalleTrabajo dtstrabajo = new clsDatosDetalleTrabajo();
          
            trabajo.Detallefibra = txtDetalleFibra.Text;
            trabajo.Metrosfibra = Convert.ToInt32(numMetrosFibra.Value);

            bool exito = dtstrabajo.IngresarFibra(trabajo);

            if (exito == true)
            {
                MessageBox.Show("Datos de fibra ingresados correctamente");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error, datos de fibra no ingresados");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
