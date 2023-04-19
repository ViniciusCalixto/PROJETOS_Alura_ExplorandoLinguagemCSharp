using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "João";
            int idadeJoao = 16;
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas > 1;
            string textoAdicional;

            if (acompanhado)
            {
                textoAdicional = nome + " " + "Está acompanhado";
            }
            else
            {
                textoAdicional = nome + " " + "Não está acompanhado";
            }
            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("Pode entrar."+ textoAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar."+textoAdicional);
            }
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
