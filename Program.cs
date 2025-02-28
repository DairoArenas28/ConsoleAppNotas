using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNota
{
    class Program
    {
        static void Main(string[] args)
        {
            Asignatura asig = new Asignatura("Matematicas", 4);
            asig.CrearNota("Examen",4.5d,10);
        }
    }
}
