using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;

            Console.WriteLine("CALCULADORA DE IMC");
            Console.WriteLine(new string('=', 45));

            Console.Write("Digite seu peso em kg: ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite sua altura em m: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(new string('=', 45));

            imc = peso / (altura * altura);

            if (imc < 18.5)
                Console.WriteLine("Classificação: ABAIXO DO PESO");
            else if (imc < 25)
                Console.WriteLine("Classificação: PESO NORMAL");
            else if (imc < 30)
                Console.WriteLine("Classificação: SOBREPESO");
            else
                Console.WriteLine("Classificação: OBESIDADE");
        }
    }
}
