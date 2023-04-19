using System;

namespace P12_InvestimentoALongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {

            double fatorRendimento = 1.005;
            double investimento = 1000;

            for (int anos = 1; anos <= 5; anos++)
            {
                for (int mes = 1; mes <= 12; mes++)
                {
                    investimento *= fatorRendimento;                    
                }
                fatorRendimento += 0.001;               
            }
            Console.WriteLine("Fator Rendimento: " + fatorRendimento);
            Console.WriteLine("Investimento: " + investimento);

            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
