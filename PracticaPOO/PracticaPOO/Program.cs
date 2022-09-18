using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RealizarTarea();
            Console.ReadKey();
        }

        static void RealizarTarea()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(345,67);

            double distancia = origen.Distancia(destino);
            Console.WriteLine($"La distancia recorrida es de {distancia}");
        }
    }
}
