using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Ejercicio_3
    {
        static void Main(string[] args)
        {
            #region Ejercicio #3: Escribir un programa que sea capaz de calcular el nuevo salario de un empleado si obtuvo un incremento del 40 % sobre su salario anterior.
            double salario = 0, newSalario = 0;
            Console.WriteLine("INCREMENTO DE SALARIO AL 40%\n");
            Console.Write("INGRECE SALARIO: ");
            salario = Convert.ToDouble(Console.ReadLine());

            newSalario = (salario * 0.40) + salario;
            Console.WriteLine("\n");
            Console.WriteLine("EL NUEVO SALARIO ES: {0}", newSalario);


            Console.ReadKey();
            #endregion
        }
    }
}
