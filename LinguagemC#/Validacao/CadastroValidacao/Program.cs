using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroValidacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            if (nome.Length < 2 || nome.Length > 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nome inválido.");
                Console.ResetColor();
                return;
            }

            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade <= 0 || idade > 120)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Idade inválida.");
                Console.ResetColor();
                return;
            }

            Console.Write("Digite o CPF: ");
            string cpf = Console.ReadLine();

            if (cpf.Length != 11)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("CPF inválido.");
                Console.ResetColor();
                return;
            }

            int tentativas = 0;
            bool senhaValida = false;

            while (tentativas < 3)
            {
                Console.Write("Digite a senha: ");
                string senha = Console.ReadLine();

                Console.Write("Confirme a senha: ");
                string confirmacao = Console.ReadLine();

                if (senha == confirmacao)
                {
                    senhaValida = true;
                    break;
                }
                else
                {
                    tentativas++;
                    Console.WriteLine("As senhas não coincidem.");
                }
            }

            if (!senhaValida)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Cadastro inválido, tente novamente mais tarde");
                Console.ResetColor();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cadastro feito com sucesso");
            Console.ResetColor();
        }
    }
}
