using System;
using System.Collections.Generic;

namespace AplicativoNotas
{
    class Program
    {
        static List<Nota> notas = new List<Nota>();

        static void Main(string[] args)
        {
            bool executando = true;

            while (executando)
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Adicionar nota");
                Console.WriteLine("2 - Visualizar notas");
                Console.WriteLine("3 - Editar nota");
                Console.WriteLine("4 - Excluir nota");
                Console.WriteLine("5 - Sair");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarNota();
                        break;
                    case 2:
                        VisualizarNotas();
                        break;
                    case 3:
                        EditarNota();
                        break;
                    case 4:
                        ExcluirNota();
                        break;
                    case 5:
                                            executando = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        static void AdicionarNota()
        {
            Console.WriteLine("Digite o título da nota: ");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite o conteúdo da nota: ");
            string conteudo = Console.ReadLine();

            Nota nota = new Nota(titulo, conteudo);
            notas.Add(nota);

            Console.WriteLine("Nota adicionada com sucesso.");
        }

        static void VisualizarNotas()
        {
            foreach (Nota nota in notas)
            {
                Console.WriteLine("Título: " + nota.Titulo);
                Console.WriteLine("Conteúdo: " + nota.Conteudo);
                Console.WriteLine("----------------------");
            }
        }

        static void EditarNota()
        {
            Console.WriteLine("Digite o título da nota que deseja editar: ");
            string titulo = Console.ReadLine();

            Nota nota = notas.Find(n => n.Titulo == titulo);

            if (nota != null)
            {
                Console.WriteLine("Digite o novo título da nota: ");
                string novoTitulo = Console.ReadLine();

                Console.WriteLine("Digite o novo conteúdo da nota: ");
                string novoConteudo = Console.ReadLine();

                nota.Titulo = novoTitulo;
                nota.Conteudo = novoConteudo;

                Console.WriteLine("Nota editada com sucesso.");
            }
            else
            {
                Console.WriteLine("Nota não encontrada.");
            }
        }

        static void ExcluirNota()
        {
            Console.WriteLine("Digite o título da nota que deseja excluir: ");
            string titulo = Console.ReadLine();

            Nota nota = notas.Find(n => n.Titulo == titulo);

            if (nota != null)
            {
                notas.Remove(nota);
                Console.WriteLine("Nota excluída com sucesso.");
            }
            else
            {
                Console.WriteLine("Nota não encontrada.");
            }
        }
    }

    class Nota
    {
        public string Titulo { get; set; }
        public string Conteudo { get; set; }

        public Nota(string titulo, string conteudo)
        {
            Titulo = titulo;
            Conteudo = conteudo;
        }
    }
}