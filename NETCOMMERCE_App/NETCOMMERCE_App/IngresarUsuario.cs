using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using CapaNegocios;
using CapaDatos;

namespace NETCOMMERCE_App
{
    public partial class IngresarUsuario : Form
    {
        public IngresarUsuario()
        {
            InitializeComponent();
        }

        clsUsuarios usuario = new clsUsuarios();
        clsDatosUsuarios dtsUsuario = new clsDatosUsuarios();


        internal class Helper
        {
            public static string EncodePassword(string originalPassword)
            {
                SHA1 sha1 = new SHA1CryptoServiceProvider();

                byte[] inputBytes = (new UnicodeEncoding()).GetBytes(originalPassword);

                byte[] hash = sha1.ComputeHash(inputBytes);

                return Convert.ToBase64String(hash);
            }
        }



        private void btnIngresoUsuario_Click(object sender, EventArgs e)
        {
  
            usuario.Nombreusuario = txtNombreUsuario.Text;
            usuario.Passwordusuario = Helper.EncodePassword(txtPassword.Text);
            usuario.Rolempresa = cbRolEmpresa.SelectedItem.ToString();

            bool exito = dtsUsuario.IngresarUsuario(usuario);

            if (exito == true)
            {
                MessageBox.Show("Usuario Ingresado Exitosamente");
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Error,Usuario no Ingresado");
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
