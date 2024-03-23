using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAEA_LAB02_TINOCO.Mantenimiento.Conductores
{
    public class Conductor
    {
        public string nombre { get; set; }
        public string licencia { get; set; }
        public string transporte { get; set; }

        public Conductor(string nombre, string licencia, string transporte) { 
            this.nombre = nombre;
            this.licencia = licencia;
            this.transporte = transporte;
        }
    }
}
