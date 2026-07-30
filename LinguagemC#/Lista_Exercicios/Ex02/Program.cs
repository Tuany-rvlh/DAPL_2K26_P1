using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temp;
            byte op;
            Console.WriteLine("MENU DE CONVERSÃO:");
            Console.WriteLine(" 1 - Celsius para Fahrenheit");
            Console.WriteLine(" 2 - Fahrenheit para Celsius");
            Console.WriteLine(new string('=', 45));
            Console.Write("Digite o valor da temperatura correspondente:");
            temp = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite sua opção de conversão: ");
            op = Convert.ToByte(Console.ReadLine());
            Console.WriteLine(new string('=', 45));
            if (op == 1)
                Console.WriteLine("Essa quantia em Fahrenheits é " + ((temp * 1.8) + 32).ToString("F2"));
            else if (op == 2)
                Console.WriteLine("Essa quantia em Celsius é " + ((temp - 32) * 5 / 9).ToString("F2"));
            else
                Console.WriteLine("Não foi entrada essa opção no menu!");
        }
    }
}
