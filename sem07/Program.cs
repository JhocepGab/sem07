using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem07
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroPerfectoDoWhile();
        }
            //engloba codigo (llaves). Static: modulador de acceso (quien puede acceder o no).
            //Void; retorno (vacio). Main: nombre.(string[] args): parametro
            static void NumeroPerfecto()
            {
                int n, suma = 0;
                Console.WriteLine("Su nùmero es: ");
                n = int.Parse(Console.ReadLine());
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        suma = suma + i;
                    }

                }
                if (suma == n)
                {
                    Console.WriteLine("El numero es perfecto");
                }
                else
                {
                    Console.WriteLine("el numero no es perfecto");
                }
            }
        static void NumeroPerfectoWhile()
        {
            int num, suma = 0, div;
            Console.WriteLine("ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            div = num-1;

            while (div>0)
            {
                if (num%div==0)
                {
                    suma = suma + div;
                }
                div--;
            }
            Console.WriteLine("suma: " + suma);
        }
        static void NumeroPerfectoDoWhile()
        {
            int num, suma = 0, div;
            Console.WriteLine("ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            div = num - 1;
            do
            {

                if (num % div == 0)
                {
                    suma = suma + div;
                }
                div--;
            }
            while (div>0);
            if (suma == num)
            {
                Console.WriteLine("El numero es perfecto");
            }
            else
            {
                Console.WriteLine("el numero no es perfecto");
            }
        }
    }
}
