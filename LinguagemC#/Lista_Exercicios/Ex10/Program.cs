using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, c, multi;
            c = 1;

            Console.WriteLine("Gerador de Tabuada");
            Console.WriteLine(new string('=', 45));

            Console.Write("Digite um número inteiro para sua tabuada:");
            num = Convert.ToInt32(Console.ReadLine());

            while (c <= 10)
            {
                multi = num * c;
                Console.WriteLine(num + " x " + c + " = " + multi);
                c++;
            }
        }
    }
}
