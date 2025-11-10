using System;
using System.Text.RegularExpressions;

namespace CacaAoBug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Notas do Aluno ===");

            Console.Write("Informe o nome do aluno: ");
            string nome = Console.ReadLine();


            // Validação do nome (5º Erro corrigido)
            // O nome não pode ser vazio ou conter só espaços
            // só pode conter letras e espaços
            if (string.IsNullOrWhiteSpace(nome) || !Regex.IsMatch(nome, @"^[A-Za-zÀ-ÿ\s]+$"))
            {
                Console.WriteLine("Erro. Por favor, informe um Nome válido!");
                return;
            }

            Console.Write("Digite a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());


            // Validação das notas (2º Erro corrigido)
            if (nota1 < 0 || nota2 < 0 || nota3 < 0) 
            {
                Console.WriteLine("Erro: Nenhuma nota pode ser negativa (menor que 0). Por favor, informe somente notas de 0 á 10!");
                return;
            }

            if (nota1 > 10 || nota2 > 10 || nota3 > 10)
            {
                Console.WriteLine("Erro: Nenhuma nota pode ser maior que 10!");
                return;
            }

            // Cálculo da média (3º e 4º Erro corrigido)
            double media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"\nMédia de {nome}: {media}");

            // Determinação da situação do aluno (1º Erro corrigido)
            if (media >= 7)
            {
                Console.WriteLine("Situação: Aprovado.");
            }
            else if (media >= 5 && media <7)
            {
                Console.WriteLine("Situação: Exame Final.");
            }
            else
            {
                Console.WriteLine("Situação: Reprovado.");
            }

            Console.WriteLine("\n=== Estatísticas da Turma ===");

            int totalAlunos = 5;
            int aprovados = 0;

            for (int i = 1; i <= totalAlunos; i++)
            {
                if (i % 2 == 0)
                    aprovados++;
            }

            double percAprov = (aprovados / totalAlunos) * 100;
            Console.WriteLine($"Taxa de aprovação: {percAprov}%");

            Console.WriteLine("\nFim do programa!");
            Console.ReadKey();
        }
    }
}
