using System;
using System.Collections.Generic;

namespace A1._2_SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            IDictionary<string, Aluno> sorted = new SortedDictionary<string, Aluno>();
            sorted.Add("VT", new Aluno("vanessa", 34672));
            sorted.Add("AL", new Aluno("ana", 5617));
            sorted.Add("RN", new Aluno("rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

        }
    }
}
