using System;

namespace A2._2_JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Falília flintstones";
            //"Falília Simpsons";
            //"Falília Dona Florinda";

            //jagged array = array denteado, array serrilhado

            string[][] familias = new string[3][];
            //{
            //    {"Fred","wilma","Pedrita" },
            //    {"Homer","Marge","Lsa","Bart","Maggie" },
            //    {"Florinda","Kiko" }
            //};
            
            familias[0] = new string[] { "Fred", "wilma", "Pedrita" };
            familias[1] = new string[] { "Homer", "Marge", "Lsa", "Bart", "Maggie" };
            familias[2] = new string[] { "Florinda","Kiko" };

            foreach (var familia in familias)
            {
                Console.WriteLine(string.Join(",",familia));
            }
        }
    }
}
