using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class clsDetalleGrupoTrabajo
    {
        private int idgrupotrabajo;

        private int idintegrantegrupo;

        private string nombregrupotrabajo;
        private int numerogrupotrabajo;
        

        public int Idgrupotrabajo { get => idgrupotrabajo; set => idgrupotrabajo = value; }

        public int Idintegrantegrupo { get => idintegrantegrupo; set => idintegrantegrupo = value; }

        public string Nombregrupotrabajo { get => nombregrupotrabajo; set => nombregrupotrabajo = value; }
        public int Numerogrupotrabajo { get => numerogrupotrabajo; set => numerogrupotrabajo = value; }
    }
}
