using System;
using System.Collections.Generic;

namespace GerenciadorDeTarefas
{
    class Program
    {
        static void Main (string[] args)
        {
            List<Tarefa> tarefas = new List<Tarefa>();
            int opcao = 0;

            while (opcao != 5)
            {
                Console.WriteLine("\n---GERENCIADOR DE TAREFAS---\n1. Adicionar tarefa\n2. Listar tarefas\n3. Concluir tarefa\n4. Remover tarefa\n5. Sair");

                Console.WriteLine("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Título: ");
                        string titulo = Console.ReadLine();

                        Console.Write("Descrição: ");
                        string descricao = Console.ReadLine();

                        tarefas.Add(new Tarefa(titulo, descricao));

                        Console.WriteLine("Tarefa adicionada!");
                        break;

                    case 2:
                        if (tarefas.Count == 0)
                        {
                            Console.WriteLine("Nenhuma tarefa cadastrada.");
                        }
                        else
                        {
                            for (int i = 0; i < tarefas.Count; i++)
                            {
                                Console.WriteLine($"\nTarefa {i+1}");
                                Console.WriteLine(tarefas[i]);
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Digite o número da tarefa: ");
                        int concluir = int.Parse(Console.ReadLine());

                        if (concluir > 0 && concluir <= tarefas.Count)
                        {
                            tarefas[concluir - 1].Concluir();
                            Console.WriteLine("Tarefa concluída!");
                        }
                        else
                        {
                            Console.WriteLine("Tarefa inválida.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Digite o número da tarefa para remover: ");
                        int remover = int.Parse(Console.ReadLine());

                        if(remover > 0 && remover <= tarefas.Count)
                        {
                            tarefas.RemoveAt(remover - 1);
                            Console.WriteLine("Tarefa removida!");
                        }
                        else
                        {
                            Console.WriteLine("Tarefa inválida.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida, digite novamente.");
                        break;
                }
            }
        }
    }
}