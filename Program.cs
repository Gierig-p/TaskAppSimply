using System;
using System.Collections.Generic;


class program
{
    class tarefa
    {
        public string Descricao { get; set; }
        public bool foifeita { get; set; }

        public tarefa(string descricao)
        {
            Descricao = descricao;
            foifeita = false;
        }
        public override string ToString()
        {
            return $"{(foifeita ? "[Concluída]" : "[Pendente]")} {Descricao}";
        }
    }

static void Main(string[] args)
{
    List<tarefa> tarefas = new List<tarefa>();
    bool rodar = true;

    while (rodar)
    {
        Console.Clear();
        Console.WriteLine("=== Gerenciador de Tarefas ===\n");
        Console.WriteLine("1. Adicionar tarefa");
        Console.WriteLine("2. Listar tarefas");
        Console.WriteLine("3. Marcar tarefa como Concluída");
        Console.WriteLine("4. Remover tarefas Concluídas");
        Console.WriteLine("5. Sair");
        Console.Write("\nEscolha uma opção: ");
        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                Addtarefas(tarefas);
                break;
            case "2":
                ListTarefas(tarefas);
                break;
            case "3":
                CompletarTarefas(tarefas);
                break;
            case "4":
                RemoveTarefas(tarefas);
                break;
            case "5":
                rodar = false;
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }
}
static void Addtarefas(List<tarefa> tarefas)
{
    Console.Write("\nDigite a descrição da tarefa: ");
    string Descricao = Console.ReadLine();
    tarefas.Add(new tarefa(Descricao));
    Console.WriteLine("Tarefa adicionada com Sucesso.");
    Console.ReadKey();
}

static void ListTarefas(List<tarefa> tarefas)
{
    Console.WriteLine("\n=== Lista de tarefas ===");
    if(tarefas.Count == 0)
    {
        Console.WriteLine("Nenhuma tarefa na lista.");
    }
    else
    {
        for (int i = 0; i < tarefas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tarefas[i]}");
        }
    }
    Console.ReadKey();
}
static void CompletarTarefas(List<tarefa> tarefas)
{
    ListTarefas(tarefas);
    Console.Write("\nDigite o número da tarefa a ser concluída: ");
    if(int.TryParse(Console.ReadLine(), out int numeroTarefa) && numeroTarefa > 0 && numeroTarefa <= tarefas.Count)
    {
        tarefas[numeroTarefa - 1].foifeita =true;
        Console.WriteLine("Tarefa foi marcada como concluída");
    }
    else
    {
        Console.WriteLine("Número inválido. Tente novamente.");
    }
    Console.ReadKey();
}
static void RemoveTarefas(List<tarefa> tarefas)
{
    tarefas.RemoveAll(t => t.foifeita);
    Console.WriteLine("Tarefas concluídas removidsa com sucesso!");
    Console.ReadKey();
}
}








































// using System;
// using System.Data;
// using Microsoft.VisualBasic;

// public class tarefa
// {
//     public string Titulo { get; set; }
//     public string Descricao { get; set; }
//     public bool concluida { get; private set; }
//     public DateTime dataCriacao {get; private set;}

//     public tarefa(string Titulo, string descricao = "")
//     {
//         Titulo = Titulo;
//         Descricao = descricao;
//         concluida = false;
//         dataCriacao = DateTime.Now;
//     }

//     public void marcaComoConcluida()
//     {
//         concluida = true;
//     }

//     public string exibirDetalhes()
//     {
//         string status = concluida ? "Concluida" : "Pendente";
//         return $"Titulo: {Titulo} \nDescrição: \nStatus: \nData da criação: \nSem prazo";
//     }

// }

