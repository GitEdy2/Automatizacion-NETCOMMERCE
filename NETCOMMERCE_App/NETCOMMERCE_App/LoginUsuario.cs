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
using CapaDatos;
using CapaNegocios;


namespace NETCOMMERCE_App
{
    public partial class LoginUsuario : Form
    {
        clsConexionBD conDB = new clsConexionBD();

        public LoginUsuario()
        {
            InitializeComponent();

            cbRolEmpresa.SelectedIndex = 0;
        }


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


        private void btnIngresarLogin_Click(object sender, EventArgs e)
        {
            clsUsuarios usuario = new clsUsuarios();
            clsDatosUsuarios dtsusuario = new clsDatosUsuarios();

            

            string strusuario;

            int usuarioid;

            usuario.Nombreusuario = txtUsuario.Text;
            usuario.Passwordusuario = Helper.EncodePassword(txtPassword.Text);
            usuario.Rolempresa = cbRolEmpresa.SelectedItem.ToString();

            if(usuario.Nombreusuario == " " || usuario.Passwordusuario == " " || cbRolEmpresa.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Existen campos obligatorios en blanco");
                return;
            }
            
            if (dtsusuario.Autenticar(usuario.Nombreusuario, Helper.EncodePassword(txtPassword.Text), usuario.Rolempresa) > 0)
            {
                if (usuario.Rolempresa == "COORDINADOR")
                {
                    strusuario = txtUsuario.Text;
                    
                    usuarioid = Convert.ToInt32(dtsusuario.BuscarIdUsuario(strusuario));
                  
                    usuario.IdUsuario = usuarioid;

                    bool exito2 = dtsusuario.IngresarFechaLogin(usuario);

                    if (exito2 == true)
                    {
                        MessageBox.Show("Bienvenido");                      
                    }
                    else
                    {
                        MessageBox.Show("No se ingreso la fecha");
                    }

                    Principal principal = new Principal();
                    principal.Show();

                    this.Hide();
                }
                else
                    MessageBox.Show("Usuario o Contraseñas incorrectos");

            }
            else
                MessageBox.Show("Usuario o Contraseñas incorrectos");

        }


        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            IngresarUsuario nuevousuario = new IngresarUsuario();
            nuevousuario.Show();
        }
    }
}
