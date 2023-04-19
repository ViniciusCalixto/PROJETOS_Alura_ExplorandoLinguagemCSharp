using System;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
             double investimento = 1000;
             Console.WriteLine("Investimento inicial: " + investimento);
            /*
             investimento += investimento * 0.005;
             Console.WriteLine("Investimento 1 mes: " + investimento);
             Console.WriteLine("--------------------");

             int mes = 1;
             while (mes <= 12)
             {
                 investimento += investimento * 0.005;
                 Console.WriteLine("Investimento " + mes + " mes: " + investimento);
                 mes++;
             }*/
           
            for(int mes = 1; mes <= 12; mes++)
            {
                investimento += investimento * 0.005;
                Console.WriteLine("Investimento " + mes + " mes: " + investimento);
            }

            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
