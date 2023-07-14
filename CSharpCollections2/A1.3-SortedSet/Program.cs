using System;
using System.Collections.Generic;

namespace A1._3_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ISet<string> alunos = new SortedSet<string>(new ComparadorMinusculo())
            {
                "Vanessa tonini",
                "Ana losnak",
                "Rafael nercessian",
                "Prescila stuani"
            };

            alunos.Add("Vanessa tonini");
            alunos.Add("Ana losnak");
            alunos.Add("Rafael nercessian");
            alunos.Add("Prescila stuani");
            alunos.Add("Fabio A");
            alunos.Add("FABIO A");

            foreach (var item in alunos)
            {
                Console.WriteLine(item);
            }


            ISet<string> outroConjunto = new HashSet<string>();
            //este conjunto é subconjunto do outro ?
            alunos.IsSubsetOf(outroConjunto);
            
            //este conjunto é superconjunto do outro?
            alunos.IsSupersetOf(outroConjunto);
            
            // os consjuntos contem os mesms elementos?
            alunos.SetEquals(outroConjunto);

            //subtrai os elementos da outra colueção que também estão nesta colleção
            alunos.ExceptWith(outroConjunto);
            
            //intersecção dos conjuntos
            alunos.IntersectWith(outroConjunto);
            
            //somente em um ou outro conjunto 
            alunos.SymmetricExceptWith(outroConjunto);
            
            //uniao de conjuntos 
            alunos.UnionWith(outroConjunto);
        }
    }

    internal class ComparadorMinusculo : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
