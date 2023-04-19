using System;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra = 'A';
            Console.WriteLine("Letra: " + letra);
            
            letra = (char)65;
            Console.WriteLine("Letra: " + letra);

            letra = (char)(65 + 2);
            Console.WriteLine("Letra: " + letra);

            string primeiraFrase = "Alura - Cursos de tech.";

            Console.WriteLine(primeiraFrase +" "+ 2022);

            string cursos = "Cursos disponiveis: \n- Go \n- C# \n- python \n- Java";
            Console.WriteLine(cursos + " " + 2022);

            cursos = @"Cursos disponiveis: 
- Go 
- C# 
- python 
- Java";
            Console.WriteLine(cursos + " " + 2022);


            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
