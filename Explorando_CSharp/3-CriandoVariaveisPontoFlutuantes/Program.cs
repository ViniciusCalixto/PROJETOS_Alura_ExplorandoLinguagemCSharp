using System;

namespace _3_CriandoVariaveisPontoFlutuantes
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            
            salario = 3000.10;

            double idade;
            idade = 7 / 5;
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Salario: " + salario);

            //*
            double peso = 4.0;
            int quantidade = 10;
            Console.WriteLine(peso * quantidade);

            //*
            int brindes = 15;
            int pessoas = 2;
            Console.WriteLine(brindes / pessoas);
            
            //*
            int dia = 4;
            int outroDia = 4 + dia;
            Console.WriteLine(outroDia);

            //*
            double preco = 5.0;
            double ingressos = 5.0;
            Console.WriteLine(preco * ingressos);

            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
