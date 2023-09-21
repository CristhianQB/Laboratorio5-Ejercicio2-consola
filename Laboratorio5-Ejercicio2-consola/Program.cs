using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_Ejercicio2_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la base: ");
            int base1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el exponente: ");
            int expo = int.Parse(Console.ReadLine());
            int resul = 1;

            for (int i = 1; i <= expo; i++)
            {
                resul = resul * base1;
            }
            Console.WriteLine("El producto es " + resul);
            Console.ReadKey();

        }
    }
}
