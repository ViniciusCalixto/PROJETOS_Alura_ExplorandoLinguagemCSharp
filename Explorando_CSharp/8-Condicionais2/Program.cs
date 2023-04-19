using System;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeJoao = 16;
            int quantidadePessoas = 2;
            
            bool acompanhado = quantidadePessoas > 1;

            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
