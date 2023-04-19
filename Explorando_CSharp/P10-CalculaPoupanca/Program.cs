using System;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            double investimento = 1000;
            Console.WriteLine("Investimento inicial: " + investimento);

            investimento += investimento * 0.005;
            Console.WriteLine("Investimento 1 mes: " + investimento);
            Console.WriteLine("--------------------");

            int mes = 1;
            while (mes <= 12)
            {
                investimento += investimento * 0.005;
                Console.WriteLine("Investimento " + mes + " mes: " + investimento);
                mes++;   
            }

            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
