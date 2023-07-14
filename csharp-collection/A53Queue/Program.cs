using System;
using System.Collections.Generic;
using System.Linq;

namespace A53Queue
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();
        static void Main(string[] args)
        {

            Enfileirar("van");
            Enfileirar("kombi");
            Enfileirar("guincho");
            Enfileirar("pichup");
            
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();            
            Desenfileirar();
            Desenfileirar();

            Console.ReadLine();
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                if (pedagio.Peek() == "guincho")
                {
                    Console.WriteLine("guincho está fazendo o pagamento");
                }
                string veiculo = pedagio.Dequeue();
                Console.WriteLine($"saiu da fila: {veiculo}");
                imprimirFila();
            }
           
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"entoru na fila: {veiculo}");

            pedagio.Enqueue(veiculo);
            imprimirFila();
        }

        private static void imprimirFila()
        {
            Console.WriteLine("FILA:");

            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }
    }
}
