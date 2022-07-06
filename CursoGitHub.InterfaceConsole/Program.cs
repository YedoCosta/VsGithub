using System;

namespace CursoGitHub.InterfaceConsole
{ //Inicio do namespace
    internal class Program
    { // Inicio da classe
        static void Main(string[] args)
        { // inicio do método
            /*
             * Main - principal
             * O método inicia-se com a letra maiuscula
             *
             */
            //Variável
            /*
             * É um espaço reservado na memória
             */
            /*Tipos de dados:
             * Inteiro - int
             * Real - double
             * Texto - string
             */
            /*
             * Operadores aritiméticos:
             * + - adição
             * - - subtração
             * * - multiplicação
             * / - divisão
             * % - mod (modulo da divisão)
             */

            string comando;
            string resposta = "remote add origin";

            //=========== tratando com vetor =====================
            /*
            string[] campos = resposta.Split(' ');
            Console.WriteLine(resposta);
            Console.WriteLine(campos[0]);
            Console.WriteLine(campos[1]);
            Console.WriteLine(campos[2]);
            Console.WriteLine(campos[3]);
            Console.WriteLine(campos[4]);
            Console.WriteLine(campos[5]);
            Console.WriteLine(campos.Length);
            */
            //=================================================
            Console.WriteLine("Qual comando para iniciar o git");
            comando = Console.ReadLine();

            string[] subcomando = comando.Split(' ');
            foreach (string item in subcomando)
            {
                Console.WriteLine(item);
            }

            //==================================
            int ctc = 0;
            int med = 0;
            // Console.WriteLine($"antes o while ctc = {ctc}");
            // Console.WriteLine($"antes do while subcomando length = {subcomando.Length}");
            while (ctc < subcomando.Length)
                {
             //   Console.WriteLine($"após o while {ctc}");
             //   Console.WriteLine(subcomando[ctc]);
             //   Console.WriteLine("=========");
             
                if (subcomando[ctc].Equals("remote"))
                {
                    Console.WriteLine($"{subcomando[ctc]} => Cria o ambiente remoto no ambiente local");
                    med++;
                }
                if (subcomando[ctc].Equals("add"))
                {
                    Console.WriteLine($"{subcomando[ctc]} => Adiciona as alteraçoes no ambiente local");
                    med++;
                }
                if (subcomando[ctc].Equals("origin"))
                {
                    Console.WriteLine($"{subcomando[ctc]} => É o local onde será gravado a versão");
                    med++;
                }
                ctc++;

            }
            //===========================================================

            if (comando.Equals(resposta))
            {  

                Console.WriteLine("Parabens voce acertou 100%....");
            }
            else
            {
                if (med > 0)
                {

                    Console.WriteLine($"\r\nVoce acertou {(33*med)}%");
                }
                else
                {
                    Console.WriteLine("Voce errou");
                }
                
            }
           //=========================================================== 
            Console.WriteLine($"A resposta é {resposta}");
            Console.WriteLine("Alô Mundo!");

            Console.ReadKey();


        } // fin do método
    } // fim da classe
} // fim do namespace
