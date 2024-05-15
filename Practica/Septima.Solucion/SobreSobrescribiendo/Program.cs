using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_01;

namespace SobreSobrescribiendo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Title = " Ejercicio Nro 01: Sobre-Sobrescrito";
            //Sobrescrito objetoSobrescrito = new Sobrescrito();
            //Console.WriteLine(objetoSobrescrito.ToString());
            //string objeto = "¡Este es mi método ToString sobrescrito!";
            //Console.WriteLine("----------------------------------------------");
            //Console.Write("Comparación Sobrecargas con String: ");
            //Console.WriteLine(objetoSobrescrito.Equals(objeto));
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine(objetoSobrescrito.GetHashCode());
            //Console.ReadKey();


            Console.Title = " Ejercicio Nro 01: Sobre-Sobrescrito";
            SobreSobrescrito objetoSobrescrito = new SobreSobrescrito();
            Console.WriteLine(objetoSobrescrito.ToString());
            string objeto = "¡Este es mi método ToString sobrescrito!";
            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobrescrito.Equals(objeto));
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.GetHashCode());
            Console.ReadKey();

            Console.WriteLine(objetoSobrescrito.MiPropiedad);
            Console.WriteLine(objetoSobrescrito.MiMetodo());
            
            


        }
    }
}
