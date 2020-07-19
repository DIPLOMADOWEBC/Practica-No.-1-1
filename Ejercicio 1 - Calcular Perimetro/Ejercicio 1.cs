using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___Calcular_Perimetro
{
    class Ejercicio_1
    {
        static void Main(string[] args)
        {
            #region Ejercicio #1: Escribir un programa que pida por teclado el lado de un cuadrado, mostrar por pantalla el perímetro del mismo(El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro).
            //Formula: (El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro).

            int ladoC = 0, perimetro;

            Console.WriteLine("\nCALCULAR EL PERIMETRO DE UN CUADRADO");
            Console.WriteLine("");
            Console.Write("INGRECE LADO DEL CUADRADO: ");
            ladoC = Convert.ToInt32(Console.ReadLine());
            perimetro = ladoC * 4;
            Console.WriteLine("\n");
            Console.WriteLine("EL PERIMETRO DEL CUADRADO ES: {0}", perimetro);
            Console.ReadKey();
            #endregion
        }
    }
}
