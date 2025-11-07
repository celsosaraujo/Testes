using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace CacaAoBug
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("=== Sistema de Notas do Aluno ===");

            Console.Write("Informe o nome do aluno: ");
            string nome = Console.ReadLine();

            double nota1, nota2, nota3;

            while (true)
            {

                Console.Write("Digite a primeira nota: ");
                nota1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(nota1 < 0 || nota1 > 10 ? "Nota Inválida" : "Nota Válida");
                if (nota1 >= 0 && nota1 <= 10)
                {
                    Console.WriteLine("Nota válida!");
                    break;
                }



            }
           



            Console.Write("Digite a segunda nota: ");
                 nota2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a terceira nota: ");
                 nota3 = Convert.ToDouble(Console.ReadLine());

           






            double media = (nota1 + nota2 + nota3) / 2;

            Console.WriteLine($"\nMédia de {nome}: {media}");

            if (media >= 7)
            {
                Console.WriteLine("Situação: Reprovado 😢");
            }
            else if (media >= 5)
            {
                Console.WriteLine("Situação: Exame Final");
            }
            else
            {
                Console.WriteLine("Situação: Aprovado 🎉");
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

///------------------------------------------------------
/// 1º
