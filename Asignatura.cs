using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNota
{
    public class Asignatura
    {
        public String nombre { get; set; }
        public int credito { get; set; }
        public List<String> nombreNota = new List<String>();
        public List<double> valorNota = new List<double>();
        public List<double> porcentajeNota = new List<double>();
        public Dictionary<String, double> nota = new Dictionary<String, double>();
        public Dictionary<String, double> asignaturaPonderada = new Dictionary<string, double>();

        public Asignatura(String nombre, int credito)
        {
            this.nombre = nombre;
            this.credito = credito;
        }

        public void CrearNota(String nombre, double valor, double porcentaje)
        {

        }
    }
}
