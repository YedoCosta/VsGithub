using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGitHub.AulaDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            string c = "git status";
            while(cont <= 30)
            {
                if (cont > 10 & cont < 20)
                {
                    c = "git init";
                }
                if (cont > 20 )
                {
                    c = "git add";
                }

                Console.WriteLine($"<{cont}> - {c}");
                cont++;
                
            }
            Console.ReadKey();
        }
    }
}
