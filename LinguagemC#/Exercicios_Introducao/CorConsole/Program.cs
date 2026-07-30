using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma cor para o console:");
            Console.WriteLine("1 - Azul");
            Console.WriteLine("2 - Verde");
            Console.WriteLine("3 - Vermelho");

            Console.Write("Digite a opção desejada: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;

                case 2:
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;

                case 3:
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    return;
            }

            Console.Clear();
            Console.WriteLine("Cor do console alterada com sucesso!");
        }
    }
}
