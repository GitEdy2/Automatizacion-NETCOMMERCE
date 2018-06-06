using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class clsPlantillaTrabajo
    {
        private int plantillatrabajoid;
        private string fechatrabajo;
        private string empresatrabajo;
        private string archivotrabajo;

        private int detallerutaid;
        private int detallegrupotrabajoid;
        private int usuariosid;
        private int detalletrabajoid;



        public int Plantillatrabajoid { get => plantillatrabajoid; set => plantillatrabajoid = value; }
        public string Fechatrabajo { get => fechatrabajo; set => fechatrabajo = value; }
        public string Empresatrabajo { get => empresatrabajo; set => empresatrabajo = value; }
        public string Archivotrabajo { get => archivotrabajo; set => archivotrabajo = value; }


        public int Detallerutaid { get => detallerutaid; set => detallerutaid = value; }
        public int Detallegrupotrabajoid { get => detallegrupotrabajoid; set => detallegrupotrabajoid = value; }
        public int Usuariosid { get => usuariosid; set => usuariosid = value; }
        public int Detalletrabajoid { get => detalletrabajoid; set => detalletrabajoid = value; }
    }
}
