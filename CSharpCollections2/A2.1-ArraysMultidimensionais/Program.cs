using System;

namespace A2._1_ArraysMultidimensionais
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] resultados = new string[4, 3];
            //{
            //    {"alemanha","espanha","holanda" },
            //    {"argentina","holanda", "frança" },
            //    {"holanda","alemanha","alemanha" },
            //};

            resultados[0, 0] = "Alemanha";
            resultados[1, 0] = "Espanha";
            resultados[2, 0] = "Holanda";
            resultados[3, 0] = "Brasil";

            resultados[0, 1] = "Espanha";
            resultados[1, 1] = "Holanda";
            resultados[2, 1] = "Alemanha";
            resultados[3, 1] = "Uruguai";

            resultados[0, 2] = "Italia";
            resultados[1, 2] = "França";
            resultados[2, 2] = "Alemanha";
            resultados[3, 2] = "Portugal";

            //foreach (var selecao in resultados)
            //{
            //    Console.WriteLine(selecao);
            //}

            for (int i = 0; i <= resultados.GetUpperBound(1); i++)
            {
                int ano = 2014 - i * 4;

                Console.Write(ano.ToString().PadRight(12));
            }
            Console.WriteLine();

            for (int posicao = 0; posicao <= resultados.GetUpperBound(0); posicao++)
            {
                for (int copa = 0; copa <= resultados.GetUpperBound(1); copa++)
                {
                    Console.Write(resultados[posicao, copa].PadRight(12));
                }
                Console.WriteLine();
            }
            
            

        }
    }
}
