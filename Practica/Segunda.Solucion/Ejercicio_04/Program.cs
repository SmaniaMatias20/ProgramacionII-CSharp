using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_04;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tinta = 0;
            ConsoleColor colorBoligrafo;

            Boligrafo boligrafo = new Boligrafo(100, ConsoleColor.Green);


            //boligrafo.SetTinta(-30);
            

            string dibujo = "";
            string pintar = boligrafo.Pintar(30, out dibujo);
            Console.ForegroundColor = boligrafo.GetColor();
            Console.WriteLine(pintar);







            tinta = boligrafo.GetTinta();
            colorBoligrafo = boligrafo.GetColor();

            Console.WriteLine($"Color: {colorBoligrafo} \nTinta: {tinta}");

        }
    }
}
