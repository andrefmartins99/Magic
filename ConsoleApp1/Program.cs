using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Terreno carta = new Terreno(0, 2, 1, 0);
            //Feitico carta = new Feitico(1, 3, 2);
            //MagicaInstantanea carta = new MagicaInstantanea(3, 1, 0);
            //Encantamento carta = new Encantamento(1, 4, 2, 1);
            //Elfo carta = new Elfo(0, 3, 2, 1, 1, 3, 4);
            //Humano carta = new Humano(0, 3, 1, 1, 1, 3, 4);
            //Orc carta = new Orc(0, 3, 0, 1, 1, 3, 4);
            Anao carta = new Anao(0, 3, 2, 1, 1, 3, 4);

            Console.WriteLine(carta);

            Console.ReadKey();
        }
    }
}
