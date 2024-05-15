using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_02;

namespace EjercicioLavadero
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();   
            Moto primerVehiculo = new Moto("111", 2, EMarcas.Ford, 20);
            Auto segundoVehiculo = new Auto("222", 4, EMarcas.Ford, 4);
            Camion tercerVehiculo = new Camion("111", 6, EMarcas.Iveco, 4);
            Auto cuartoVehiculo = new Auto("444", 4, EMarcas.Honda, 6);
            Camion quintoVehiculo = new Camion("555", 8, EMarcas.Scania, 6);
            Camion sextoVehiculo = new Camion("666", 8, EMarcas.Iveco, 8);
            Moto septimoVehiculo = new Moto("777", 2, EMarcas.Zanella, 15);

            listaVehiculos.Add(primerVehiculo);
            listaVehiculos.Add(segundoVehiculo);
            listaVehiculos.Add(tercerVehiculo);
            listaVehiculos.Add(cuartoVehiculo);
            listaVehiculos.Add(quintoVehiculo);

            Lavadero lavadero = new Lavadero(listaVehiculos, 1000, 2000, 500);

            double totalFacturado = lavadero.MostrarTotalFacturado();
            double totalFacturadoPorMarca = lavadero.MostrarTotalFacturado(EMarcas.Ford);
            Console.WriteLine($"Total facturado: {totalFacturado}");
            Console.WriteLine($"Total facturado por marca: {totalFacturadoPorMarca}");

            // Comparamos las marcas
            int resultadoMarca = lavadero.OrdenarVehiculosPorMarca(primerVehiculo, segundoVehiculo);
            Console.WriteLine(resultadoMarca); // Funciona bien

            // Comparamos las patentes
            int resultadoPatente = Lavadero.OrdenarVehiculosPorPatente(primerVehiculo, tercerVehiculo);
            Console.WriteLine(resultadoPatente); // Funciona bien

            // Agregamos un vehiculo si no se encuentra en el lavadero

            Console.WriteLine(lavadero + sextoVehiculo); // Funciona

            // Quitamos un vehiculo si se encuentra en el lavadero

            Console.WriteLine(lavadero - septimoVehiculo); // Funciona

            // Verificamos si el vehiculo se encuentra en el lavadero

            Console.WriteLine(lavadero == sextoVehiculo); // Funciona

            // Verificamos si el vehiculo NO se encuentra en el lavadero

            Console.WriteLine(lavadero != septimoVehiculo); // Funciona







        }
    }
}
