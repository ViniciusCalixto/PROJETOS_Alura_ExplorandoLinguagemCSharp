﻿using System;
using System.Collections.Generic;

namespace A1._1_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();

            alunos.Add("VT", new Aluno("vanessa", 34672));
            alunos.Add("AL", new Aluno("ana", 5617));
            alunos.Add("RN", new Aluno("rafael", 17645));
            alunos.Add("WM", new Aluno("Wanderson", 11287));

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            alunos.Remove("AL");

            alunos.Add("MO", new Aluno("Marcelo", 12345));

            Console.WriteLine();

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine();
            IDictionary<string, Aluno> sorted = new SortedList<string, Aluno>();
            sorted.Add("VT", new Aluno("vanessa", 34672));
            sorted.Add("AL", new Aluno("ana", 5617));
            sorted.Add("RN", new Aluno("rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }


        }
    }
}
