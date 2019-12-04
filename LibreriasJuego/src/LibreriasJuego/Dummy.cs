using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego.src
{
    class Dummy
    {
        public static void Main()
        {
            //esta linea ejecuta cuadrado (2) y pasa el valor a pintarEvaluacion
            //pintarEvaluacion(cuadrado (2), 5);
            // las dos siguientes lineas hacen los mismo
            //Esta linea pintarEvaluacion llama a la funcion cuadrado
            pintarEvaluacion(cuadrado, 5);
            pintarEvaluacion((x)=> x*x, 5);
            // las dos siguientes lineas hacen los mismo
            pintarEvaluacion(tercio, 5);
            pintarEvaluacion((j) => j / 3, 5);
 
        }

        public static int cuadrado(int x)
        {
            return x * x;
        }

        public static void pintarEvaluacion (Func <int, int> funcion, int x)
        {
            int resultado = funcion(x);
            Console.WriteLine("El resultado es " + resultado);
        }

        public static int tercio(int j)
        {
            return j / 3;
        }
    }
}
