using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            int operacao = random.Next(1, 7);

            Console.WriteLine();

            switch (operacao)
            {
                case 1:
                    Console.WriteLine($"Operação sorteada: Soma");
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;

                case 2:
                    Console.WriteLine($"Operação sorteada: Subtração");
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;

                case 3:
                    Console.WriteLine($"Operação sorteada: Multiplicação");
                    Console.WriteLine($"{num1} × {num2} = {num1 * num2}");
                    break;

                case 4:
                    Console.WriteLine($"Operação sorteada: Divisão");

                    if (num2 != 0)
                        Console.WriteLine($"{num1} ÷ {num2} = {num1 / num2}");
                    else
                        Console.WriteLine("Não é possível dividir por zero.");
                    break;

                case 5:
                    Console.WriteLine($"Operação sorteada: Potência");
                    Console.WriteLine($"{num1}^{num2} = {Math.Pow(num1, num2)}");
                    break;

                case 6:
                    Console.WriteLine($"Operação sorteada: Raiz");

                    if (num1 >= 0)
                        Console.WriteLine($"√{num1} = {Math.Sqrt(num1)}");
                    else
                        Console.WriteLine("Não existe raiz quadrada real de número negativo.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
