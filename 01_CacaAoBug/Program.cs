

using System;
using System.Text.RegularExpressions; // usado para validar o nome do aluno

namespace SistemaDeNotas
{
    class Program
    {
        // -----------------------------------------------------------------------------
        // 6º Criada função LerNota() com try/catch para impedir entrada inválida
        //     (texto, símbolo, etc.)
        // -----------------------------------------------------------------------------
        static double LerNota(string mensagem)
        {
            double nota = 0;
            bool notaValida = false;

            while (!notaValida)
            {
                try
                {
                    Console.Write(mensagem);
                    nota = Convert.ToDouble(Console.ReadLine());

                    // 1º Implementado laço para impedir notas negativas ou maiores que 10
                    if (nota < 0 || nota > 10)
                    {
                        Console.WriteLine("A nota deve estar entre 0 e 10.");
                    }
                    else
                    {
                        notaValida = true;
                    }
                }
                catch
                {
                    Console.WriteLine("Erro: digite apenas números!");
                }
            }
            return nota;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE NOTAS DO ALUNO ===");

            // 7º Adicionado laço (for) para repetir o processo de leitura e cálculo para cada aluno
            int totalAlunos = 3;
            int aprovados = 0;

            for (int i = 1; i <= totalAlunos; i++)
            {
                Console.WriteLine();
                Console.WriteLine("--- ALUNO " + i + " ---");

                // 5º Adicionado filtro com Regex para permitir apenas letras e espaços
                Console.Write("Informe o nome do aluno: ");
                string nome = Console.ReadLine();

                while (!Regex.IsMatch(nome, @"^[A-Za-zÀ-ÿ\s]+$"))
                {
                    Console.Write("Nome inválido! Digite apenas letras: ");
                    nome = Console.ReadLine();
                }

                // Entrada das 3 notas com verificação
                double nota1 = LerNota("Digite a 1ª nota: ");
                double nota2 = LerNota("Digite a 2ª nota: ");
                double nota3 = LerNota("Digite a 3ª nota: ");

                // 2º Foi alterado a divisão de 2 → 3
                double media = (nota1 + nota2 + nota3) / 3;

                Console.WriteLine("Média de " + nome + ": " + media.ToString("F2"));

                // 3º Foi trocada a lógica: agora média >=7 é “Aprovado”, <5 é “Reprovado”.
                // 4º Os emojis (ícones) foram retirados para evitar erro de exibição no console.
                if (media >= 7)
                {
                    Console.WriteLine("Situação: Aprovado");
                    // 8º Agora a contagem é feita de acordo com a média (media >= 7)
                    aprovados++;
                }
                else if (media >= 5)
                {
                    Console.WriteLine("Situação: Exame Final");
                }
                else
                {
                    Console.WriteLine("Situação: Reprovado");
                }
            }

            // Exibe a taxa de aprovação
            double porcentagem = ((double)aprovados / totalAlunos) * 100;
            Console.WriteLine();
            Console.WriteLine("Total de alunos aprovados: " + aprovados);
            Console.WriteLine("Taxa de aprovação: " + porcentagem.ToString("F2") + "%");
            Console.WriteLine("Fim do programa!");
        }
    }
}
