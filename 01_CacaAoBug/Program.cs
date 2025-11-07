using System;

namespace CacaAoBug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Notas do Aluno ===");

            string nome;
            while (true)
            {
                Console.Write("Informe o nome do aluno: ");
                nome = Console.ReadLine();

                bool valido = true;

                // Verifica se o nome tem apenas letras e espaços
                foreach (char c in nome)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        valido = false;
                        break;
                    }
                }

                if (string.IsNullOrWhiteSpace(nome))
                {
                    valido = false;
                }

                if (valido)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("❌ Nome inválido! Digite apenas letras e espaços.\n");
                }
            }

            Console.Write("Digite a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"\nMédia de {nome}: {media}");

            if (media >= 7)
            {
                Console.WriteLine("Situação: Aprovado");
            }
            else if (media >= 5 )
            {
                Console.WriteLine("Situação: Exame Final");
            }
            else
            {
                Console.WriteLine("Situação: Reprovado");
            }

            Console.WriteLine("\n=== Estatísticas da Turma ===");

            int totalAlunos = 5;
            int aprovados = 0;

           
            for (int i = 1; i <= totalAlunos; i++)
            {
                Console.Write($"O aluno {i} foi aprovado? (s/n): ");
                string resp = Console.ReadLine().ToLower();

                if (resp == "s")
                {
                    aprovados++;
                }
            }

            double percAprov = ((double)aprovados / totalAlunos) * 100.0;

            Console.WriteLine($"\nTotal de alunos: {totalAlunos}");
            Console.WriteLine($"Aprovados: {aprovados}");
            Console.WriteLine($"Taxa de aprovação: {percAprov:F2}%");

            Console.WriteLine("\n=== Fim do programa ===");
            Console.ReadKey();

        }
    }
}
