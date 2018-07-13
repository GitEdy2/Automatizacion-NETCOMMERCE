using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class clsDetalleTrabajo
    {
        private int detalletrabajoid;

        private string codigotrabajo;

        private int tipotrabajoid;
        private string identificadortipotrabajo;
        private string descripciontipotrabajo;

        private int postesid;
        private string detallepostes;
        private int numeropostes;

        private int retenidasid;
        private string detalleretenidas;
        private int numeroretenidas;

        private int fibraid;
        private string detallefibra;
        private int metrosfibra;



        public int Detalletrabajoid { get => detalletrabajoid; set => detalletrabajoid = value; }

        public string Codigotrabajo { get => codigotrabajo; set => codigotrabajo = value; }

        public int Tipotrabajoid { get => tipotrabajoid; set => tipotrabajoid = value; }
        public string Identificadortipotrabajo { get => identificadortipotrabajo; set => identificadortipotrabajo = value; }
        public string Descripciontipotrabajo { get => descripciontipotrabajo; set => descripciontipotrabajo = value; }

        public int Postesid { get => postesid; set => postesid = value; }
        public string Detallepostes { get => detallepostes; set => detallepostes = value; }
        public int Numeropostes { get => numeropostes; set => numeropostes = value; }

        public int Retenidasid { get => retenidasid; set => retenidasid = value; }
        public string Detalleretenidas { get => detalleretenidas; set => detalleretenidas = value; }
        public int Numeroretenidas { get => numeroretenidas; set => numeroretenidas = value; }

        public int Fibraid { get => fibraid; set => fibraid = value; }
        public string Detallefibra { get => detallefibra; set => detallefibra = value; }
        public int Metrosfibra { get => metrosfibra; set => metrosfibra = value; }
      
    }
}
