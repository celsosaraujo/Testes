using System;

namespace CacaAoBug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Notas do Aluno ===\n");

            Console.Write("Quantos alunos deseja cadastrar? ");
            int totalAlunos = int.Parse(Console.ReadLine());

            int aprovados = 0;

            for (int i = 1; i <= totalAlunos; i++)
            {
                Console.WriteLine($"\n--- Cadastro da nota do {i}º aluno ---");

                Console.Write("Informe o nome do aluno: ");
                string nome = Console.ReadLine();

                double[] notas = new double[3];

       // aprendi que se usa J e não I porque é um índice dentro de outro índice, náo se usa a mesma variavel para duas coisas diferentes
                for (int j = 0; j < 3; j++)
                {
                    double nota;

                    while (true)
                    {
                        Console.Write($"Digite a {j + 1}ª nota (0 a 10): ");
                        string entrada = Console.ReadLine();

                        // Verifica se é número e se está entre 0 e 10
                        if (double.TryParse(entrada, out nota) && nota >= 0 && nota <= 10)
                        {
                            notas[j] = nota;
                            break; // sai do loop da nota se for válida
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido! Digite apenas números entre 0 e 10.");
                        }
                    }
                }

                double media = (notas[0] + notas[1] + notas[2]) / 3;
                Console.WriteLine($"\nMédia de {nome}: {media:F2}");

                if (media >= 7)
                {
                    Console.WriteLine("Situação: Aprovado 🎉");
                    aprovados++;//Essa linha incrementa o contador de aprovados
                }
                else if (media >= 5)
                {
                    Console.WriteLine("Situação: Exame Final");
                }
                else
                {
                    Console.WriteLine("Situação: Reprovado 😢");
                }
            }

            // Estatísticas finais da turma
            Console.WriteLine("\n=== Estatísticas da Turma ===");
            Console.WriteLine($"Total de alunos: {totalAlunos}");
            Console.WriteLine($"Total de aprovados: {aprovados}");

            double percAprov = ((double)aprovados / totalAlunos) * 100;
            Console.WriteLine($"Taxa de aprovação: {percAprov:F1}%");

            Console.WriteLine("\nFim do programa!");
            Console.ReadKey();
        }
    }
}
