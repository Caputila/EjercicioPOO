using System;

namespace EjercicioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            realiarTarea();
        }

        static void realiarTarea()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(130,40);
            double distancia = origen.CacularDistancia(destino);
            Console.WriteLine($"La distancia entre los puntos es: {distancia}"); 
        }
        
    }


}