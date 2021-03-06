﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using CapaDatos;
using CapaNegocios;

namespace NETCOMMERCE_App
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            cbProvincia.SelectedIndex = 0;
            cbTipoTrabajo.SelectedIndex = 0;
            cbDetalleFibra.SelectedIndex = 0;
            cbDetallePostes.SelectedIndex = 0;
            cbDetalleRetenidas.SelectedIndex = 0;
            cbEmpresa.SelectedIndex = 0;
            cbCargo.SelectedIndex = 0;
            cbEmpresaPrograma.SelectedIndex = 0;

            cbCargo.DataSource = dtsintegrante.ListaCargosIntegrante();
            cbCargo.DisplayMember = "cargo_tipointegrante";
            cbCargo.ValueMember = "idtbl_TipoIntegranteGrupo";

            cbTipoTrabajo.DataSource = dtstrabajo.ListaTipoTrabajos();
            cbTipoTrabajo.DisplayMember = "identificador_tipotrabajo";
            cbTipoTrabajo.ValueMember = "idtbl_TipoTrabajo";

            cbDetalleFibra.DataSource = dtstrabajo.ListaFibra();
            cbDetalleFibra.DisplayMember = "detalle_fibra";
            cbDetalleFibra.ValueMember = "idtbl_Fibra";

            cbDetallePostes.DataSource = dtstrabajo.ListaPostes();
            cbDetallePostes.DisplayMember = "detalle_postes";
            cbDetallePostes.ValueMember = "idtbl_Postes";

            cbDetalleRetenidas.DataSource = dtstrabajo.ListaRetenidas();
            cbDetalleRetenidas.DisplayMember = "detalle_retenidas";
            cbDetalleRetenidas.ValueMember = "idtbl_KitsRetenida";

            cbRutaPrograma.DataSource = dtsRuta.ListaRutas();
            cbRutaPrograma.DisplayMember = "nombre_ruta";
            cbRutaPrograma.ValueMember = "idtbl_DetalleRuta";

            cbGrupoTrabajoPrograma.DataSource = dtsgrupotrabajo.ListaGruposTrabajo();
            cbGrupoTrabajoPrograma.DisplayMember = "nombre_grupotrabajo";
            cbGrupoTrabajoPrograma.ValueMember = "idtbl_GrupoTrabajo";

            cbTrabajoRealizar.DataSource = dtstrabajo.ListaTrabajosporCodigo();
            cbTrabajoRealizar.DisplayMember = "codigo_trabajo";
            cbTrabajoRealizar.ValueMember = "idtbl_DetalleTrabajo";
                      
        }


        clsRuta ruta = new clsRuta();
        clsDatosRuta dtsRuta = new clsDatosRuta();

        clsDetalleTrabajo trabajo = new clsDetalleTrabajo();
        clsDatosDetalleTrabajo dtstrabajo = new clsDatosDetalleTrabajo();

        clsIntegranteGrupo integrante = new clsIntegranteGrupo();
        clsDatosIntegranteGrupo dtsintegrante = new clsDatosIntegranteGrupo();

        clsDetalleGrupoTrabajo grupotrabajo = new clsDetalleGrupoTrabajo();
        clsDatosDetalleGrupoTrabajo dtsgrupotrabajo = new clsDatosDetalleGrupoTrabajo();

        
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
            trabajo.Tipotrabajoid = Convert.ToInt32(cbTipoTrabajo.SelectedValue.ToString());
            trabajo.Codigotrabajo = txtCodigoTrabajo.Text;

            if(cBoxFibra.Checked == true)
            {
                trabajo.Tipotrabajoid = Convert.ToInt32(cbTipoTrabajo.SelectedValue.ToString());
                trabajo.Fibraid = Convert.ToInt32(cbDetalleFibra.SelectedValue.ToString());

                bool exito = dtstrabajo.IngresarDetalleTrabajoFibra(trabajo);

                if (exito == true)
                {
                    MessageBox.Show("Trabajo ingresado correctamente");
                    txtCodigoTrabajo.Clear();
                }
                else
                {
                    MessageBox.Show("Error, trabajo no ingresado");
                }
            }
            else
            {
                cbDetalleFibra.ValueMember = null;
            }

            if(cBoxPostes.Checked == true)
            {
                trabajo.Tipotrabajoid = Convert.ToInt32(cbTipoTrabajo.SelectedValue.ToString());
                trabajo.Postesid = Convert.ToInt32(cbDetallePostes.SelectedValue.ToString());

                bool exito = dtstrabajo.IngresarDetalleTrabajoPostes(trabajo);

                if (exito == true)
                {
                    MessageBox.Show("Trabajo ingresado correctamente");
                }
                else
                {
                    MessageBox.Show("Error, trabajo no ingresado");
                }
            }
            else
            {
                cbDetallePostes.ValueMember = null;
            }


            if(cBoxRetenidas.Checked == true)
            {
                trabajo.Tipotrabajoid = Convert.ToInt32(cbTipoTrabajo.SelectedValue.ToString());
                trabajo.Retenidasid = Convert.ToInt32(cbDetalleRetenidas.SelectedValue.ToString());

                bool exito = dtstrabajo.IngresarDetalleTrabajoKitsRetenidas(trabajo);

                if (exito == true)
                {
                    MessageBox.Show("Trabajo ingresado correctamente");
                }
                else
                {
                    MessageBox.Show("Error, trabajo no ingresado");
                }

            }
            else
            {
                cbDetalleRetenidas.ValueMember = null;
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

                cbDetalleFibra.Visible = true;

                btnIngresarDetallesFibra.Visible = true;
                
            }

            if(cBoxFibra.Checked == false)
            {
                lblTipoFibra.Visible = false;

                cbDetalleFibra.Visible = false;

                btnIngresarDetallesFibra.Visible = false;

            }
        }


        private void cBoxPostes_CheckedChanged(object sender, EventArgs e)
        {
            if(cBoxPostes.Checked == true)
            {
                lblTipoPostes.Visible = true;

                cbDetallePostes.Visible = true;
                btnIngresarDetallesPostes.Visible = true;
            }

            if(cBoxPostes.Checked == false)
            {
                lblTipoPostes.Visible = false;

                cbDetallePostes.Visible = false;
                btnIngresarDetallesPostes.Visible = false;
            }
        }


        private void cBoxRetenidas_CheckedChanged(object sender, EventArgs e)
        {
            if(cBoxRetenidas.Checked == true)
            {
                lblDetalleRetenidas.Visible = true;
                
                btnIngresarDetallesRetenidas.Visible = true;
                cbDetalleRetenidas.Visible = true;
            }
            
            if(cBoxRetenidas.Checked == false)
            {
                lblDetalleRetenidas.Visible = false;

                btnIngresarDetallesRetenidas.Visible = false;
                cbDetalleRetenidas.Visible = false;
            }
        }

        private void btnIngresarDetallesFibra_Click(object sender, EventArgs e)
        {
            IngresarDetalleFibra fibra = new IngresarDetalleFibra();
            Principal principal = new Principal();
            principal.Close();
            fibra.Show();
        }

        private void btnIngresarDetallesPostes_Click(object sender, EventArgs e)
        {
            IngresarDetallePostes postes = new IngresarDetallePostes();
            Principal principal = new Principal();
            postes.Show();
            principal.Hide();
        }

        private void btnIngresarDetallesRetenidas_Click(object sender, EventArgs e)
        {
            IngresarDetalleRetenidas retenidas = new IngresarDetalleRetenidas();
            Principal principal = new Principal();
            retenidas.Show();
            principal.Hide();
        }

        private void btnDetallesTipoTrabajo_Click(object sender, EventArgs e)
        {
            IngresarTipoTrabajo tipotrabajo = new IngresarTipoTrabajo();
            Principal principal = new Principal();
            principal.Close();
            tipotrabajo.Show();

        }



        private void btnCrearTrabajador_Click(object sender, EventArgs e)
        {
            integrante.Idtipointegrante = Convert.ToInt32(cbCargo.SelectedValue.ToString());
            integrante.Nombreintegrantegrupo = txtNombreTrabajador.Text;
            integrante.Empresaintegrantegrupo = cbEmpresa.SelectedItem.ToString();

            bool exito = dtsintegrante.IngresarIntegranteGrupo(integrante);

            if (exito == true)
            {
                MessageBox.Show("Trabajador ingresado correctamente");
                txtNombreTrabajador.Clear();
            }
            else
            {
                MessageBox.Show("Error, trabajador no ingresado");
            }

        }

        private void btnIngresarCargo_Click(object sender, EventArgs e)
        {
            IngresarCargoTrabajador cargo = new IngresarCargoTrabajador();
            Principal principal = new Principal();
            cargo.Show();
            principal.Hide();
        }

        private void btnAsignarLinieros_Click(object sender, EventArgs e)
        {
            IngresarLinierosGrupo linierosgrupo = new IngresarLinierosGrupo();
            Principal principal = new Principal();
            linierosgrupo.Show();
            principal.Hide();

        }

        private void btnCrearGrupoTrabajo_Click(object sender, EventArgs e)
        {
            grupotrabajo.Nombregrupotrabajo = txtNombreGrupo.Text;
            grupotrabajo.Numerogrupotrabajo = Convert.ToInt32(numGrupoTrabajo.Value);


            bool exito = dtsgrupotrabajo.IngresarGrupoTrabajo(grupotrabajo);

            if (exito == true)
            {
                MessageBox.Show("Grupo de trabajo creado correctamente");
            }
            else
            {
                MessageBox.Show("Error, grupo de trabajo no creado");
            }
        }

        private void btnAsignarAyudantes_Click(object sender, EventArgs e)
        {
            IngresarAyudantesGrupo ayudantesgrupo = new IngresarAyudantesGrupo();
            Principal principal = new Principal();
            ayudantesgrupo.Show();
            principal.Hide();
        }

        private void btnAsignarChofer_Click(object sender, EventArgs e)
        {
            IngresarChoferGrupo chofergrupo = new IngresarChoferGrupo();
            Principal principal = new Principal();
            chofergrupo.Show();
            principal.Hide();
        }

        private void btnVerListaTrabajadores_Click(object sender, EventArgs e)
        {
            ListaTrabajadoresGrupo trabajadoresgrupo = new ListaTrabajadoresGrupo();
            Principal principal = new Principal();
            trabajadoresgrupo.Show();
            principal.Close();
        }

        private void btnGenerarPrograma_Click(object sender, EventArgs e)
        {

        }

        private void btnAsignarJefeGrupo_Click(object sender, EventArgs e)
        {
            IngresarJefeGrupo jefegrupo = new IngresarJefeGrupo();
            Principal principal = new Principal();
            jefegrupo.Show();
            principal.Close();
        }
    }
}
