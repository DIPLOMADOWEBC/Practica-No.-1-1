using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Ejercicio_4
    {
        static void Main(string[] args)
        {
            #region Ejercicio #4: -Escribir un programa que solicite por teclado una cantidad en pesos, obtener la equivalencia en dólares, tomando en cuenta que la unidad cambiaria es un valor variable.
            double pesos = 0, dolares = 0, tasa = 0;
            Console.WriteLine("CONVERTIR PESOS A DOLARES\n");
            Console.Write("INGRECE PESOS: ");
            pesos = Convert.ToDouble(Console.ReadLine());
            Console.Write("INGRECE TASA DE CONVERSION: ");
            tasa = Convert.ToDouble(Console.ReadLine());

            dolares = (pesos / tasa);
            Console.WriteLine("\n");
            Console.WriteLine("{0} PESOS A UNA TASA CAMBIARA DE {1} = {2} DOLARES", pesos, tasa, dolares);


            Console.ReadKey();
            #endregion
        }
    }
}
