using System;

namespace CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            /*string[] aulas = new string[]
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };*/


            string[] aulas = new string[3];
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            Console.WriteLine(aulas);
            
            Imprimir(aulas);

           // Console.WriteLine("Tecle enter para fechar ...");
           // Console.ReadLine();
        }
        private static void Imprimir(string[] aulas)
        {
            for (int i = 0;i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }
    }
}
