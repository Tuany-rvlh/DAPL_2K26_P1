using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Login Simples");
            Console.WriteLine(new string('=', 45));

            string usuario_correto = "admin";
            string senha_correta = "1234";
            string senha, usuario;
            sbyte c = 0;

            while (true)
            {
                Console.Write("Digite o usuário: ");
                usuario = Console.ReadLine();
                Console.Write("Digite a senha: ");
                senha = Console.ReadLine();

                c++;

                if (senha == senha_correta && usuario == usuario_correto)
                {
                    Console.WriteLine("Sucesso! Seu acesso está desbloquado...");
                    break;
                }
                if (c == 3)
                {
                    Console.WriteLine("Número excedito de tentativas! Seu acesso foi bloqueado!");
                    break;
                }


            }
        }
    }
}
