using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_03;


namespace EstadisticaDeportiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(11, "Racing");

            Jugador jugador = new Jugador(40910931, "Matias", 30, 20);

            


            Console.WriteLine(jugador.MostrarDatos());
            

        }
    }
}
