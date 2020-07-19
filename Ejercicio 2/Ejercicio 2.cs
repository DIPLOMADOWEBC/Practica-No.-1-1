using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Ejercicio_2
    {
        static void Main(string[] args)
        {
            #region Ejercicio #2: Escribir un programa que calcule la “Masa” de aire, pidiendo por teclado la presión, el volumen y la temperatura; teniendo en cuenta que la fórmula es: masa = (presión * volumen) / (0.37 * (temperatura + 460))
            //fórmula es: masa = (presión * volumen) / (0.37 * (temperatura + 460))
            double presion = 0, volumen = 0, temperatura = 0, masa = 0;
            Console.WriteLine("CALCULAR LA MASA DEL AIRE\n");
            Console.Write("INGRECE LA PRESION: ");
            presion = Convert.ToDouble(Console.ReadLine());
            Console.Write("INGRECE EL VOLUMEN: ");
            volumen = Convert.ToDouble(Console.ReadLine());
            Console.Write("INGRECE LA TEMPERATURA: ");
            temperatura = Convert.ToDouble(Console.ReadLine());
            masa = (presion * volumen) / (0.37 * (temperatura + 460));
            Console.WriteLine("\n");
            Console.WriteLine("LA MASA ES IGUAL A: {0}", masa);


            Console.ReadKey();
            #endregion
        }
    }
}
