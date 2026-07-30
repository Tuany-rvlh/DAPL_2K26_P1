using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static List<string> tarefas = new List<string>();

    static void Main()
    {
        int escolha = 0;

        while (escolha != 4)
        {
            Console.WriteLine(new string('=', 20) + " MENU " + new string('=', 20));
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Listar tarefas");
            Console.WriteLine("3 - Remover tarefa");
            Console.WriteLine("4 - Sair");
            Console.WriteLine(new string('=', 44)); 
            Console.Write("Escolha uma opção: ");

            escolha = Convert.ToInt32((Console.ReadLine()));

            if (escolha == 1)
            {
                Adicionar_tarefa();
            }
            else if (escolha == 2)
            {
                Listar_tarefas();
            }
            else if (escolha == 3)
            {
                Remover_tarefa();
            }
            else if (escolha == 4)
            {
                Console.WriteLine("Saindo...");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
        }
    }

    static void Adicionar_tarefa()
    {
        Console.WriteLine(new string('=', 44));
        Console.Write("Digite uma tarefa para adicionar: ");
        string tarefa = Console.ReadLine();
        tarefas.Add(tarefa);
        Console.WriteLine("Tarefa adicionada!");
    }

    static void Listar_tarefas()
    {
        if (tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa cadastrada.");
        }
        else
        {
            Console.WriteLine(new string('*', 20) + " TAREFAS " + new string('=', 20));

            for (int i = 0; i < tarefas.Count; i++)
            {
                Console.WriteLine((i + 1) + " - " + tarefas[i]);
            }
        }
    }

    static void Remover_tarefa()
    {
        Listar_tarefas();

        Console.Write("Digite o número da tarefa para remover: ");
        int numero = Convert.ToInt32((Console.ReadLine()));

        if (tarefas.Count == 0)
        {
            Console.WriteLine("Não há tarefas para remover!");
        }
        else { 

        if (numero > 0 && numero <= tarefas.Count)
        {
            tarefas.RemoveAt(numero - 1);
            Console.WriteLine("Tarefa removida!");
        }
        else
        {
            Console.WriteLine("Número inválido!");
        }

        }
    }
}