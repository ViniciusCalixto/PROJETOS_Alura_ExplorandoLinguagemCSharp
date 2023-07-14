using System;
using System.Collections.Generic;
using System.Linq;

namespace A52Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var navegador = new Navegador();

            navegador.NavegarPara("google.com");
            navegador.NavegarPara("youtube.com.br");
            navegador.NavegarPara("Alura.com.br");

            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();

            navegador.Proximo();
            navegador.Proximo();
            navegador.Anterior();

            Console.ReadLine();
        }
    }

    internal class Navegador
    {
        private string atual = "vazia";
        private readonly Stack<string> historicoAnterior = new Stack<string>();
        private readonly Stack<string> historicoProximo = new Stack<string>();

        public Navegador()
        {
            Console.WriteLine("Pagina atual: " + atual);
        }

        internal void Anterior()
        {
            if (historicoAnterior.Any())
            {
                historicoProximo.Push(atual);

                atual = historicoAnterior.Pop();
                Console.WriteLine("Pagina atual: " + atual);
            }
            
        }

        internal void NavegarPara(string url)
        {
            historicoAnterior.Push(atual);
            atual = url;
            Console.WriteLine("Pagina atual: " + atual);

        }

        internal void Proximo()
        {
            if (historicoProximo.Any())
            {
                historicoAnterior.Push(atual);

                atual = historicoProximo.Pop();
                Console.WriteLine("Pagina atual: " + atual);
            }
        }
    }
}
