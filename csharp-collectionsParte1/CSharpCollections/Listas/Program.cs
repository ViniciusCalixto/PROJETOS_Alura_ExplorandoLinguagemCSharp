using System;
using System.Collections.Generic;
using System.Linq;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            // List<string> aulas = new List<string>
            // {
            //aulaIntro,
            //aulaModelando,
            //aulaSets
            //
            //};
            List<string> aulas = new List<string>();

            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            
            Imprimir(aulas);

            Console.WriteLine("primeira: " + aulas.First());
            Console.WriteLine(aulas.Last());


            Console.WriteLine("busca primeira ocorrencia: " + aulas.First(aula =>  aula.Contains("Trabalhando")));

            Console.WriteLine("busca ultima ocorrencia: " + aulas.Last(aula => aula.Contains("Trabalhando")));

            Console.WriteLine("busca ultima ocorrencia: " + aulas.LastOrDefault(aula => aula.Contains("Conclusão")));

            aulas.Reverse();
            Imprimir(aulas);

            aulas.RemoveAt(aulas.Count - 1);
            Imprimir(aulas);

            aulas.Add("COnclusão");
            Imprimir(aulas);

            aulas.Sort();
            Imprimir(aulas);

            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
            Imprimir(copia);

            List<string> clone = new List<string>(aulas);
            Imprimir(clone);
            
            clone.RemoveRange(clone.Count - 2, 2);
            Imprimir(clone);

            


        }
        private static void Imprimir(List<string> aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
           
            for (int i = 0; i < aulas.Count; i++)
            {
                Console.WriteLine(aulas[i]);
                Console.WriteLine("teste com enter" + aulas[i] + Console.Eniroument.NewLine());
                
            }

            aulas.ForEach(aula => 
            {
                Console.WriteLine(aula);

            });
        }
    }
}
