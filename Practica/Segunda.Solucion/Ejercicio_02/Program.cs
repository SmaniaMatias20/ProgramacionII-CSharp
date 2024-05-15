using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_02;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Matias", new DateTime(1998, 1, 26), "40910931");
            Persona persona2 = new Persona("Julio", new DateTime(2010, 1, 26), "40910931");
            Persona persona3 = new Persona("Lujan", new DateTime(1995, 1, 09), "40910931");


            persona.EsMayorDeEdad();
            persona2.EsMayorDeEdad();   
            persona3.EsMayorDeEdad();

            persona.Mostrar();
            persona2.Mostrar();
            persona3.Mostrar();

            
        }
    }
}
