using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entidades_01;


namespace Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador primerSumador = new Sumador();
            primerSumador.Cantidad = 5;

            Sumador segundoSumador = new Sumador();
            segundoSumador.Cantidad = 5;

            Console.WriteLine((primerSumador + segundoSumador));
            Console.WriteLine((primerSumador / segundoSumador));


            // Conversion de Int a Sumador
            int valor = 6;
            Sumador tercerSumador = (Sumador)valor;

            Console.WriteLine((primerSumador + tercerSumador));
            Console.WriteLine((primerSumador / tercerSumador));

        }

    }
}
