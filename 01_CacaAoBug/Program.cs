using System;

namespace CacaAoBug
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            do
            {
                Console.WriteLine("=== Sistema de Notas do Aluno ===");

                Console.Write("Informe o nome do aluno: ");
                string nome = Console.ReadLine();
               
                
                nome = Console.ReadLine().Trim();

                if (nome == "")
                {
                    Console.WriteLine("Nome inválido! Digite novamente.\n");
                }



                double nota1, nota2, nota3;

                
                while (true)
                {
                    Console.Write("Digite a primeira nota: ");
                    nota1 = Convert.ToDouble(Console.ReadLine());

                    if (nota1 < 0 || nota1 > 10)
                        Console.WriteLine("Nota inválida!");
                    else
                    {
                        Console.WriteLine("Nota válida!");
                        break;
                    }
                }

                
                while (true)
                {
                    Console.Write("Digite a segunda nota: ");
                    nota2 = Convert.ToDouble(Console.ReadLine());

                    if (nota2 < 0 || nota2 > 10)
                        Console.WriteLine("Nota inválida!");
                    else
                    {
                        Console.WriteLine("Nota válida!");
                        break;
                    }
                }

                
                while (true)
                {
                    Console.Write("Digite a terceira nota: ");
                    nota3 = Convert.ToDouble(Console.ReadLine());

                    if (nota3 < 0 || nota3 > 10)
                        Console.WriteLine("Nota inválida!");
                    else
                    {
                        Console.WriteLine("Nota válida!");
                        break;
                    }
                }

                
                double media = (nota1 + nota2 + nota3) / 3;

                Console.WriteLine($"\nMédia de {nome}: {media:F1}");

                if (media >= 7)
                {
                    Console.WriteLine("Situação: Aprovado 😁");
                }
                else if (media >= 5 && media < 7)
                {
                    Console.WriteLine("Situação: Exame Final");
                }
                else
                {
                    Console.WriteLine("Situação: Reprovado 😞");
                }

               
                Console.WriteLine("\n=== Estatísticas da Turma ===");

                int totalAlunos = 5;
                int aprovados = 0;

                for (int i = 1; i <= totalAlunos; i++)
                {
                    if (i % 2 == 0)
                        aprovados++;
                }

                double percAprov = (double)aprovados / totalAlunos * 100;
                Console.WriteLine($"Taxa de aprovação: {percAprov}%");

               
                Console.Write("\nDeseja cadastrar outro aluno? (S/N): ");
                opcao = Console.ReadLine().ToLower();

                Console.Clear();

            } while (opcao == "s");

            Console.WriteLine("Programa encerrado. Obrigado!");
            Console.ReadKey();
        }
    }
}
