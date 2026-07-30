using System;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            string op;
            Console.WriteLine("Calculadora Simples");
            Console.WriteLine(new string('=', 45));
            Console.Write("Digite um número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite outro número: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(new string('=', 45));
            Console.WriteLine("MENU:");
            Console.WriteLine("... + para SOMA");
            Console.WriteLine("...  - para SUBTRAÇÃO");
            Console.WriteLine("... * para MULTIPLICAÇÃO");
            Console.WriteLine("... / para DIVISÃO");
            Console.WriteLine(new string('=', 45));
            Console.Write("Escolha uma das opções para calcular:");
            op = Console.ReadLine();
            Console.WriteLine(new string('=', 45));

            if (op == "+")
                Console.WriteLine("A soma entre " + n1 + " e " + n2 + " é " + (n1 + n2) + ".");
            else if (op == "-")
                Console.WriteLine("A subtração entre " + n1 + " e " + n2 + " é " + (n1 - n2) + ".");
            else if (op == "*")
                Console.WriteLine("A multiplicação entre " + n1 + " e " + n2 + " é " + (n1 * n2) + ".");
            else if (op == "/" && n2 != 0)
                Console.WriteLine("A divisão entre " + n1 + " e " + n2 + " é " + (n1 / n2).ToString("F2") + ".");
            else
                Console.WriteLine("Não foi possível realizar tal cálculo!");

        }
    }
}

