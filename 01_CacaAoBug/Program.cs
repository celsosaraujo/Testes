using System;
using System.Linq;

namespace CacaAoBug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Notas do Aluno ===");

            string nome;

            // Validação do nome
            while (true)
            {
                Console.Write("Informe o nome do aluno: ");
                nome = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nome))
                {
                    Console.WriteLine("Erro: O nome não pode estar vazio!");
                }
                else if (nome.Length < 3)
                {
                    Console.WriteLine("Erro: O nome deve ter pelo menos 3 letras!");
                }
                else if (!NomeValido(nome))
                {
                    Console.WriteLine("Erro: Nome inválido! São permitidas apenas letras.");
                }
                else
                {
                    break;
                }
            }

            // Validação das notas
            double nota1 = LerNota("Digite a primeira nota: ");
            double nota2 = LerNota("Digite a segunda nota: ");
            double nota3 = LerNota("Digite a terceira nota: ");

            // Cálculo correto da média
            double media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"\nMédia de {nome}: {media:F2}");

            // Lógica correta para situação
            if (media >= 7)
            {
                Console.WriteLine("Situação: Aprovado 🎉");
            }
            else if (media >= 5)
            {
                Console.WriteLine("Situação: Exame Final");
            }
            else
            {
                Console.WriteLine("Situação: Reprovado 😢");
            }

            Console.WriteLine("\n=== Estatísticas da Turma ===");

            int totalAlunos = 5;
            int aprovados = 0;

            for (int i = 1; i <= totalAlunos; i++)
            {
                if (i % 2 == 0)
                    aprovados++;
            }

            double percAprov = ((double)aprovados / totalAlunos) * 100;
            Console.WriteLine($"Taxa de aprovação: {percAprov}%");

            Console.WriteLine("\nFim do programa!");
            Console.ReadKey();
        }

        static bool NomeValido(string nome)
        {
            return nome.All(c => char.IsLetter(c) || c == ' ');
        }

        static double LerNota(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                string entrada = Console.ReadLine();

                if (!double.TryParse(entrada, out double nota))
                {
                    Console.WriteLine("Erro: Digite um número válido!");
                    continue;
                }

                if (TemMuitosDigitosIguais(entrada))
                {
                    Console.WriteLine("Muitos números iguais! O permitido são apenas dois.");
                    continue;
                }

                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("Erro: A nota deve estar entre 0 e 10.");
                    continue;
                }

                return nota;
            }
        }

        static bool TemMuitosDigitosIguais(string entrada)
        {
            int contador = 1;
            for (int i = 1; i < entrada.Length; i++)
            {
                if (entrada[i] == entrada[i - 1])
                {
                    contador++;
                    if (contador > 2) return true;
                }
                else
                {
                    contador = 1;
                }
            }
            return false;
        }
    }
}
