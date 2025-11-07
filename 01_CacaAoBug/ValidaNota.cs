using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CacaAoBug
{
    public class ValidaNota
    {
        public static double Validacao(string mensagem)
        {
            double nota;
            double media;

            while (true)
            {
                Console.Write(mensagem);
                string valor = Console.ReadLine();

                if (double.TryParse(valor, out nota))
                {
                    if (nota >= 0 && nota <= 10)
                        return nota;
                    else
                        Console.WriteLine("Digite numeros entre 0 e 10!");
                }

                else
                {
                    Console.WriteLine("Digite um numero válido");
                }

                
            }
        }
    }
}
