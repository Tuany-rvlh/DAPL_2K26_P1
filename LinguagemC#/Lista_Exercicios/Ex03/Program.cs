using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string par_impar;

            Console.WriteLine("Verificador de Número:");
            Console.Write("Digite um número inteiro");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                par_impar = "PAR";
            else
                par_impar = "ÍMPAR";

            if (num > 0)
                Console.WriteLine("O seu número é " + par_impar + " e ele é positivo!");
            else if ( num < 0)
                Console.WriteLine("O seu número é " + par_impar + " e ele é negativo!");
            else
                Console.WriteLine("O seu número é " + par_impar + " e ele é zero!");
        }
    }
}
