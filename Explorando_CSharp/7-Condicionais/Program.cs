using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
                if (quantidadePessoas > 1)
                {
                    Console.WriteLine("Pode entrar, pois etá acompanhado.");
                }
                else
                {
                    Console.WriteLine("Não pode entrar.");
                }
            }
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
