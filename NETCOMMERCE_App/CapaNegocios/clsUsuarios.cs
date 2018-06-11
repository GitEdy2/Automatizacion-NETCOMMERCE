using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class clsUsuarios
    {
        private int idUsuario;
        private string nombreusuario;
        private string passwordusuario;
        private string rolempresa;       
        private DateTime fechaingresoregistro;


        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombreusuario { get => nombreusuario; set => nombreusuario = value; }
        public string Passwordusuario { get => passwordusuario; set => passwordusuario = value; }
        public string Rolempresa { get => rolempresa; set => rolempresa = value; }
        public DateTime Fechaingresoregistro { get => fechaingresoregistro; set => fechaingresoregistro = value; }
    }
}
