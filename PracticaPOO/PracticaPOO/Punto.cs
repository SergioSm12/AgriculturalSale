using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    internal class Punto
    {
        private int x, y;

        public Punto()
        {
            this.x = 0;
            this.y = 0;
        }

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double Distancia(Punto otroPunto)
        {
            int xdif= this.x-otroPunto.x;
            int ydif= this.y-otroPunto.y;

            double distanciaPuntos= Math.Sqrt(Math.Pow(xdif,2) + Math.Pow(ydif,2));
            return distanciaPuntos;

        }
    }
}
