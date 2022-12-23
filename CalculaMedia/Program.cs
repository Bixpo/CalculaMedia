using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeAuluno;
            string pergunta = "s";
            float nota1, nota2, nota3, nota4, media;
            while (pergunta == "s")
            {

                Console.Clear();
                Console.WriteLine("Informe o nome do aluno: ");
                nomeAuluno = Console.ReadLine();
                Console.WriteLine("Informe a nota1: ");
                nota1 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Informe a nota2: ");
                nota2 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Informe a nota3: ");
                nota3 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Informe a nota4: ");
                nota4 = Convert.ToSingle(Console.ReadLine());


                media = (nota1 + nota2 + nota3 + nota4) / 4;
                Console.WriteLine("A média do aluno {0} é {1}", nomeAuluno, media);

                //if (media >= 5)
                //    Console.WriteLine("Aluno aprovado!");
                //else if (media >= 4 && media < 5)
                //    Console.WriteLine("Aluno de recuperação");
                //else
                //Console.WriteLine("aluno reprovado.");

                switch (media)
                {
                    case float n when n >= 5:
                        Console.WriteLine("Aluno aprovado!");
                        break;
                    case float n when (n >= 4 && n < 5):
                        Console.WriteLine("Aluno de recuperação.");
                        break;
                    default:
                        Console.WriteLine("Aluno reprovado");
                        break;
                }

                //while (true)
                //{
                //    if (pergunta != "s" && pergunta != "n")
                //        Console.WriteLine("Digite apenas n ou s.");
                //    else
                //        break;
                //}

                do
                {
                   Console.Write("Deseja calcular outra média? (s/n): ");
                   pergunta = Console.ReadLine().ToLower();
                } while (pergunta != "s" && pergunta != "n");
              
            }
            Console.WriteLine("Programa terminado.");
            Console.ReadKey();
        }
       
    }
}
