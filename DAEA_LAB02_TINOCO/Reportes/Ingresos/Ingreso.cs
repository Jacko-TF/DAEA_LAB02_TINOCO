using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAEA_LAB02_TINOCO.Reportes.Ingresos
{
    public class Ingreso
    {
        public string fecha {  get; set; }
        public string placa { get; set;}
        public string turno { get; set;}
        public string conductor { get; set;}
        public string producto { get; set;}
        public int peso { get; set; }
        public string transporte { get; set; }

        public Ingreso(string fecha, string placa, string turno, string conductor, string producto, int peso, string transporte)
        {
            this.fecha = fecha;
            this.placa = placa; 
            this.turno = turno;
            this.conductor = conductor;
            this.producto = producto;
            this.peso = peso;
            this.transporte = transporte;
        }
    }
}
