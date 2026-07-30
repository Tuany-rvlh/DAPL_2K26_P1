using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha, c, sorteio;
            c = 0;
            Console.WriteLine("JOGO DE ADIVINHAÇÃO");
            Console.WriteLine(new string('=', 45));

            Random random = new Random();
            sorteio = random.Next(0, 1001);

            Console.WriteLine("Tente adivinhas o número que escolhi!");

            while (true)
            {
                Console.Write("Digite sua tentativa: ");
                escolha = Convert.ToInt32(Console.ReadLine());
                c++;

                if (escolha > sorteio)
                    Console.WriteLine("O número digitado é maior que o sorteado!");
                else if (escolha < sorteio)
                    Console.WriteLine("O número digitado é menor que o sorteado!");
                else
                {
                    Console.WriteLine("Você acertou! Era o número " + sorteio + " e ele foi descoberto em " + c + " tentativas!");
                    break;
                }
                Console.WriteLine(new string('=', 45));
            }

        }
    }
}
