using System;
using System.Collections.Generic;
using System.Linq;

namespace A5._1_Covariancia
{
    class Program
    {
        static void Main(string[] args)
        {
            string titulo = "meses";
            object obj = titulo;
            Console.WriteLine(obj);

            IList<string> listaMeses = new List<string>
            {
                "Janeiro",
                "Fevereiro",
                "Março",
                "Abril",
                "Maio",
                "Junho",
                "Julho",
                "Agosto",
                "Setembro",
                "Outubro",
                "Novembro",
                "Dezembro"
            };

            //IList<object> listaObj = listaMeses;
            Console.WriteLine();

            string[] arrayMeses = new string[]
            {
                 "Janeiro",
                "Fevereiro",
                "Março",
                "Abril",
                "Maio",
                "Junho",
                "Julho",
                "Agosto",
                "Setembro",
                "Outubro",
                "Novembro",
                "Dezembro"
            };


            object[] arrayObj = arrayMeses;

            Console.WriteLine(arrayObj);

            foreach (var item in arrayObj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            arrayObj[0] = "primeiro mEs";

            Console.WriteLine(arrayObj[0]);

            foreach (var item in arrayObj)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();
            IEnumerable<object> enumobj = listaMeses;
            foreach (var item in enumobj)
            {
                Console.WriteLine(item);
            }

        }
    }
}
