using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            bool primo = true;

            if (numero <= 1)
            {
                primo = false;
            }
            else
            {
                for (int i = 2; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        primo = false;
                        break;
                    }
                }
            }

            if (primo)
                Console.WriteLine("O número é primo.");
            else
                Console.WriteLine("O número não é primo.");
        }
    }
}
