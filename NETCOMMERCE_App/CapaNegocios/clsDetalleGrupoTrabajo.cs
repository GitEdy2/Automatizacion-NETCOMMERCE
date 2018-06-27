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
        private int idtipointegrante;

        private string nombregrupotrabajo;
        private string numerogrupotrabajo;
        


        public int Idgrupotrabajo { get => idgrupotrabajo; set => idgrupotrabajo = value; }

        public int Idintegrantegrupo { get => idintegrantegrupo; set => idintegrantegrupo = value; }
        public int Idtipointegrante { get => idtipointegrante; set => idtipointegrante = value; }

        public string Nombregrupotrabajo { get => nombregrupotrabajo; set => nombregrupotrabajo = value; }
        public string Numerogrupotrabajo { get => numerogrupotrabajo; set => numerogrupotrabajo = value; }
    }
}
