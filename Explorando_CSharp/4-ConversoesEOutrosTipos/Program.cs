using System;

namespace _4_ConversoesEOutrosTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            salario = 3000.15;
            
            int salarioInteiro;
            salarioInteiro = (int)salario;

            Console.WriteLine("salario: " + salarioInteiro);

            int x = 2000000000;
            long j = 2000000000000000000;
            short y = 15000;

            float altura = 1.62f;

            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
