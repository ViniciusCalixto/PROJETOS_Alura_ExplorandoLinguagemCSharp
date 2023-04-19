using System;

namespace P13_EncadeandoFor
{
    class Program
    {
        static void Main(string[] args)
        {


            /* for (int linhas = 1; linhas <= 10; linhas++)
             {
                 for (int colunas = 1; colunas <= linhas; colunas++)
                 {                    
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }*/
            for (int linhas = 1; linhas <= 10; linhas++)
            {
                for (int colunas = 1; colunas <= 10; colunas++)
                {
                    Console.Write("*");
                    if (colunas >= linhas)
                        break;
                }
                Console.WriteLine();
            }
            for (int linhas = 1; linhas <= 10; linhas++)
            {
                for (int colunas = 10; colunas >= linhas; colunas--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
