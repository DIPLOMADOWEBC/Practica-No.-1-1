using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Ejercicio_5
    {
        static void Main(string[] args)
        {
            #region Ejercicio #5: Escribir un programa que calcule el porcentaje de estudiantes hombres y el porcentaje de mujeres en el grupo de diplomado C#.
            int hombre = 0, mujeres = 0, totalPersonas;
            double porcientoHombre = 0, porcientoMujeres = 0;

            Console.WriteLine("PORCENTAJE DE HOMBRE & MUJERES DEL DIPLOMADO DE C#\n");
            Console.Write("INGRECE CANTIDAD DE HOMBRES: ");
            hombre = Convert.ToInt32(Console.ReadLine());
            Console.Write("INGRECE CANTIDAD DE MUJERES: ");
            mujeres = Convert.ToInt32(Console.ReadLine());

            totalPersonas = (hombre + mujeres);
            porcientoHombre = (hombre * 100) / totalPersonas;
            porcientoMujeres = (mujeres * 100) / totalPersonas;

            Console.WriteLine("\n");
            Console.WriteLine("PORCENTAJES");
            Console.WriteLine("HOMBRES: {0}%", porcientoHombre);
            Console.WriteLine("MUJERES: {0}%", porcientoMujeres);


            Console.ReadKey();
            #endregion
        }
    }
}
