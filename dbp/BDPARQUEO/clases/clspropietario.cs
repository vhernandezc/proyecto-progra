using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BDPARQUEO.clases
{
    public class clspropietario
    {
        public string matricula { get; set; }
        public string propietario { get; set; }
        public string fecha_ingreso { get; set; }
        public int DPI { get; set; }
        public int telefono { get; set; }
        public string color { get; set; }


        public clspropietario() { }
        public clspropietario(string pmatricula, string ppropietario, string Pfecha_ingreo, int PDPI, int ptelefono, string pcolor)
        {
            this.matricula = matricula;
            this.propietario = propietario;
            this.fecha_ingreso = fecha_ingreso;
            this.DPI = DPI;
            this.telefono = telefono;
            this.color = color;


        }
    }
}