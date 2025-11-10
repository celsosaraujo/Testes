using System;

namespace CacaAoBug
{
    class Program
    {
        static void Main(string[] args)
        {

            int qtdAlunos = 0;
            double totalAlunos = 5;
            double aprovados = 0;

            while (qtdAlunos != totalAlunos)
            {
                Console.WriteLine("=== Sistema de Notas do Aluno ===");

                Console.Write("Informe o nome do aluno: ");
                string nome = Console.ReadLine();

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
                    Console.WriteLine("Situação: Aprovado 🎉\n");
                    aprovados++;
                }
                else if (media >= 5)
                {
                    Console.WriteLine("Situação: Exame Final\n");
                }
                else
                {
                    Console.WriteLine("Situação: Reprovado 😢\n");
                    
                }
                
                qtdAlunos++;
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
