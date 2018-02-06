using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharp_string_format
{
    class Program
    {
        static void Main(string[] args)
        {
            string aluno = "Claudio Roberto";
            decimal mediaAluno = 9.80m;
            string mediaStr = String.Format("Aluno {0}, você foi aprovado com a média {1}. Parabéns!!!", aluno, mediaAluno);
            Console.WriteLine(mediaStr);
            Console.WriteLine(String.Empty.PadRight(15, '-'));

            var exemplo1 = String.Format("Hoje é dia {0:dd/MM/yyyy}", System.DateTime.Today); // Hoje é dia 04/02/2018
            var exemplo2 = String.Format("Agora são {0:HH:mm:ss.fff} do dia {0:dd/MM/yyyy}", System.DateTime.Now); // Agora são 15:46:25.152 do dia 04/02/2018
            var exemplo3 = String.Format("Aquele carro custa {0:c2}", 65000.00); // Aquele carro custa R$ 65.000,00

            Console.WriteLine(exemplo1);
            Console.WriteLine(exemplo2);
            Console.WriteLine(exemplo3);
            Console.WriteLine(String.Empty.PadRight(15, '-'));

            Console.ReadKey();
        }
    }
}
