using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using _01_CacaAoBug;

namespace CacaAoBug
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double aprovados = 0;
            double totalAlunos = 0;

            Console.WriteLine("=== Sistema de Notas do Aluno ===");

            while (true)
            {
                Console.Write("Informe o nome do aluno: ");
                nome = Console.ReadLine();
                if (Regex.IsMatch(nome, @"^[A-Za-zÀ-ÿ\s]+$"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Digite um nome válido\n");
                }
            }

            double nota1 = ValidaNota.Validacao("Digite a 1° Nota: ");
            
            double nota2 = ValidaNota.Validacao("Digite a 2° Nota: ");

            double nota3 = ValidaNota.Validacao("Digite a 3° Nota: ");




            double media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"\nMédia de {nome}: {media}");

            if (media >= 7)
            {
                Console.WriteLine("Situação: Aprovado ");
                aprovados++;
                totalAlunos++;
            }
            else if (media >= 5)
            {
                Console.WriteLine("Situação: Exame Final");
                totalAlunos++;
            }
            else
            {
                Console.WriteLine("Situação: Reprovado");
                totalAlunos++;
            }


            Console.WriteLine("\n=== Estatísticas da Turma ===");

            

            //for (int i = 1; i <= totalAlunos; i++)
            //{
            //    if (i % 2 == 0)
            //        aprovados++;
            //}

            double percAprov = (aprovados / totalAlunos) * 100;
            Console.WriteLine($"Taxa de aprovação: {percAprov}%");

            Console.WriteLine("\nFim do programa!");
            Console.ReadKey();
        }
    }
}
