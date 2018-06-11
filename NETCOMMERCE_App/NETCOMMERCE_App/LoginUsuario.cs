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
using System.Text;
using CapaDatos;
using CapaNegocios;
using System.Data;


namespace NETCOMMERCE_App
{
    public partial class LoginUsuario : Form
    {
        public LoginUsuario()
        {
            InitializeComponent();
        }


        string strusuario;
        public DataRow fila;
        public int strusuarioID;


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

            usuario.Nombreusuario = txtUsuario.Text;
            usuario.Passwordusuario = Helper.EncodePassword(txtPassword.Text);
            usuario.Rolempresa = cbRolEmpresa.SelectedValue.ToString();

            strusuario = txtUsuario.Text;


            if (dtsusuario.Autenticar(usuario.Nombreusuario, Helper.EncodePassword(txtPassword.Text), usuario.Rolempresa) > 0)
            {
                if (usuario.Rolempresa == "Coordinador")
                {
                    Se
                }



            }


        }
    }
}
