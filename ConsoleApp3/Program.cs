using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static int x = 0;
        static void Main(string[] args)
        {
            Operaciones a = new Operaciones();
            a.Numero1 = 5;
            a.Numero5 = 1;
            Operaciones b = new Operaciones();
            b.Numero1 = 8;
            b.Numero5 = 4;
            int suma = a.Sumar();
            int sumab = a.Numero1 + a.Numero5;
            int sumac = SumarProgram(a.Numero1, a.Numero5);
            Console.WriteLine(x);
            sumarP(a.Numero1, a.Numero5);
            Console.WriteLine(x);
            Console.ReadKey();
        }

        private static int SumarProgram(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        private static void sumarP(int numero1, int numero2)
        {
            x = numero1 + numero2;
        }
    }
}
