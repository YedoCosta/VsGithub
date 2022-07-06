using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGitHub.AulaUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int dia;
            Console.WriteLine("Aula 1 - GitHub");
            Console.WriteLine("Qual a sua idade?");
            idade = int.Parse(Console.ReadLine());
            if (idade <= 15)
            {
                Console.WriteLine("GitHub Sesi");

            }
            else
            {

                Console.WriteLine("===========  GitHub Senai   ==== \r\n");
                Console.WriteLine("Qual o melhor dia para uma aula presencial?\r\n");
                Console.WriteLine("1 - segunda, 2 - Terça, 3 - Quarta, 4 - Quinta, 5 - Sexta, 6 - Sábado\r\n");
                dia = int.Parse(Console.ReadLine());

                switch (dia)
                {

                    case 1: Console.WriteLine("Segunda-Feira".ToUpper()); break;
                    case 2: Console.WriteLine("Terça-Feira".ToUpper()); break;
                    case 3: Console.WriteLine("Quarta-Feira".ToUpper()); break;
                    case 4: Console.WriteLine("Quinta-feira".ToUpper()); break;
                    case 5: Console.WriteLine("Sexta-feira".ToUpper()); break;
                    case 6: Console.WriteLine("Sabado".ToUpper()); break;
                    default: Console.WriteLine("Dado inserido fora do padrão"); break;


                }

            }

            Console.WriteLine("\r\nQual o seu nome completo?");
            string nome = Console.ReadLine();
            Console.WriteLine($"\r\nTudo minusculo:{nome.ToLower()} \r\n");
            Console.WriteLine($"Tamanho do string: {nome.Length} \r\n");
            Console.WriteLine($"Tem Y no seu nome? {nome.Contains("Y")} \r\n");
            Console.WriteLine($"Suprima pedaços do seu nome: {nome.Substring(7)} \r\n");

            Console.ReadKey();
        }
    }
}
