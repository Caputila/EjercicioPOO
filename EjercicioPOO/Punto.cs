using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    internal class Punto
    {  
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y; 
            
            //Console.WriteLine($"Coordenada X: {x}; Coordenada Y: {y}");
        }
        public Punto()
        {
            this.x = 0;
            this.y = 0;

            //Console.WriteLine("Este es el constructor por defecto");
        }
        public double CacularDistancia(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;
            double distancia = Math.Sqrt(Math.Pow(xDif, 2)+Math.Pow(yDif, 2));
            return distancia;
        }

        private int x, y;


      
       
    }
}
