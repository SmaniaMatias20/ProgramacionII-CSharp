using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_01;

namespace ElViajeEsUnPlacer
{
    public class Program
    {
        static void Main(string[] args)
        {
            VehiculoTerrestre vehiculo = new VehiculoTerrestre(4, 2, VehiculoTerrestre.Colores.Negro);

            Console.WriteLine("---Informacion del Vehiculo---");
            Console.WriteLine(vehiculo.MostrarInformacion());

            Console.WriteLine("\n---Informacion del Furgon---");
            Furgon furgon = new Furgon(4, 6, VehiculoTerrestre.Colores.Negro, 2, 80);
            Console.WriteLine(furgon.MostrarInformacion());

            Console.WriteLine("\n---Informacion del Automovil---");
            Automovil automovil = new Automovil(4, 4, VehiculoTerrestre.Colores.Rojo, 5, 4);
            Console.WriteLine(automovil.MostrarInformacion());


            Console.WriteLine("\n---Informacion del Ciclomotor---");
            Ciclomotor ciclomotor = new Ciclomotor(2, 0, VehiculoTerrestre.Colores.Azul, 250);
            Console.WriteLine(ciclomotor.MostrarInformacion());


        }
    }
}
