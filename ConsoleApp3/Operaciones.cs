using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Operaciones
    {
        private int numero1;
        private int numero2;
        private int numero3;
        private int numero4;
        private int numero5;

        public int Numero1 { get { return numero1; } set { numero1 = value; } }
        public int Numero2 { get { return numero2; } set { numero2 = value; } }
        public int Numero3 { get { return numero3; } set { numero3 = value; } }
        public int Numero4 { get { return numero4; } set { numero4 = value; } }
        public int Numero5 { get { return numero5; } set { numero5 = value; } }
        
        public Operaciones()
        {
            numero1 = 0;
            numero2 = 0;
            numero3 = 0;
            numero4 = 0;
            numero5 = 0;
        }

        public Operaciones(int numero1, int numero2, int numero3, int numero4, int numero5)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
            this.numero3 = numero3;
            this.numero4 = numero4;
            this.numero5 = numero5;
        }

        public int Sumar()
        {
            return numero1 + numero2 + numero3 + numero4 + numero5;
        }

        public int Resta()
        {
            return numero1 - numero2 - numero3 - numero4 - numero5;
        }

        public  double Promedio()
        {
            return (numero1 + numero2 + numero3 + numero4 + numero5)*1.0 / 5;
        }


    }
}
