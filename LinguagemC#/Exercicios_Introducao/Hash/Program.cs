using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a cidade: ");
            string cidade = Console.ReadLine();

            Console.Write("Digite o ano de nascimento: ");
            string ano = Console.ReadLine();

            string dados = nome + " | " + cidade + " | " + ano;

            string dadosHash = GerarHash(dados);

            File.WriteAllText("usuario.txt", dadosHash);

            Console.WriteLine("\nDados armazenados com sucesso!");
            Console.WriteLine("Arquivo criado: usuario.txt");
        }

        static string GerarHash(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder resultado = new StringBuilder();

                foreach (byte b in hash)
                {
                    resultado.Append(b.ToString("x2"));
                }

                return resultado.ToString();
            }
        }
    }
}
