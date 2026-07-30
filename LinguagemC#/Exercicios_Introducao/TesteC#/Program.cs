using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;

            Console.Write("Digite o nome do primeiro integrante: ");
            nome1 = Console.ReadLine();

            Console.Write("Digite o nome do segundo integrante: ");
            nome2 = Console.ReadLine();

            Console.WriteLine("\n" + nome1 + " e " + nome2);
            Console.WriteLine("Turma 34DS - 2024");
        }
    }
}
