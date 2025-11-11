using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CacaAoBug
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> nomes = new List<string>();
            List<double> medias = new List<double>();

            Console.WriteLine("=== Sistema de Notas do Aluno ===");

            int totalAlunos = 5;

            for (int i = 0; i < totalAlunos; i++)
            {

                string nome = LerNome($"Informe o nome do {i + 1}º aluno: ");

                double nota1 = LerNota("Digite a primeira nota: ");
                double nota2 = LerNota("Digite a segunda nota: ");
                double nota3 = LerNota("Digite a terceira nota: ");

                //Criar lista para informar dados, permitindo mais de um aluno.

                double media = (nota1 + nota2 + nota3) / 3;
                //Corrigir a divisão do calculo.
                nomes.Add(nome);
                medias.Add(media);

                Console.WriteLine($"\nMédia de {nome}: {media:F2}");

                if (media >= 7)
                {
                    Console.WriteLine("Situação: Aprovado");
                }
                else if (media >= 5)
                {
                    Console.WriteLine("Situação: Exame Final");
                }
                else
                {
                    Console.WriteLine("Situação: Reprovado");
                }

                    Console.WriteLine();
                }
            //Corrigir mensagemns exibidas na situação. 

            Console.WriteLine("\n=== Estatísticas da Turma ===");

            int aprovados = 0;

            for (int i = 0; i < medias.Count; i++)
            {
                if (medias[i] >=7)
                    aprovados++;
            }

            double percAprov = ((double)aprovados / totalAlunos) * 100;

            Console.WriteLine($"Total de alunos: {totalAlunos}");
            Console.WriteLine($"Aprovados: {aprovados}");
            Console.WriteLine($"Taxa de aprovação: {percAprov:F1}%");

            Console.WriteLine("\nFim do programa!");
            Console.ReadKey();
        }

        static string LerNome(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                string input = Console.ReadLine();
                if (input == null) input = "";

                string nome = input.Trim();

                // Regex: permite letras (inclui acentos) e espaços. Pelo menos 1 caractere.
                if (Regex.IsMatch(nome, @"^[A-Za-zÀ-ÖØ-öø-ÿ\s]+$"))
                    return nome;

                Console.WriteLine("(Nome inválido! Digite apenas letras e espaços (sem números ou símbolos.)");
            }
        }

        // Lê nota (aceita 0 a 10). Usa TryParse com CultureInfo para prevenir erro de vírgula/ponto.
        static double LerNota(string mensagem)
        {
            double nota;
            while (true)
            {
                Console.Write(mensagem);
                string text = Console.ReadLine();
                if (text == null) text = "";

                // Tenta com a cultura atual e com InvariantCulture (aceita tanto vírgula quanto ponto).
                if (double.TryParse(text, NumberStyles.Any, CultureInfo.CurrentCulture, out nota) ||
                    double.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out nota))
                {
                    if (nota >= 0 && nota <= 10)
                        return nota;
                }

                Console.WriteLine("(Nota inválida! Digite um número entre 0 e 10).");
            }
        }
    }
}
