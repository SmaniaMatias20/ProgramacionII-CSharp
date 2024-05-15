using Entidades_06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mascota mascota = new Mascota("Perro", "Musa", new DateTime(2023, 5, 25), "Sin vacunar");
            Cliente cliente = new Cliente("Matias", "Smania", "Pichincha", "1111111111", mascota);
            cliente.MostrarInformacion();
            mascota.MostrarInformacion();

            Console.WriteLine("--------------------------------");

            Mascota mascota2 = new Mascota("Gato", "Charly", new DateTime(2020, 5, 25), "Triple Felina");
            Cliente cliente2 = new Cliente("Lujan", "Palopolo", "Pichincha", "2222222222", mascota2);
            cliente2.MostrarInformacion();
            mascota2.MostrarInformacion();

            Console.WriteLine("--------------------------------");

            Mascota mascota3 = new Mascota("Gato", "Rodo", new DateTime(2019, 5, 25), "Sin vacunas");
            Cliente cliente3 = new Cliente("Lujan", "Palopolo", "Pichincha", "3333333333", mascota3);
            cliente3.MostrarInformacion();
            mascota3.MostrarInformacion();

            Console.WriteLine("--------------------------------");

            Mascota mascota4 = new Mascota("Perro", "Pillud", new DateTime(2015, 5, 25), "La Rabia");
            mascota4.MostrarInformacion();



        }

        
    }
}
