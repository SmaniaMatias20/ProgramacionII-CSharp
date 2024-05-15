using Billetes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar = new Dolar(1.17);
            Dolar dolarDos = new Dolar(1);
            Euro euro = new Euro(1);
            Euro euroDos = new Euro(1);
            Peso peso = new Peso(102.65);
            Peso pesoDos = new Peso(102.65);


            Console.WriteLine("---------------DOLAR---------------");

            Console.WriteLine($"U${dolar.GetCantidad()} + UE{euro.GetCantidad()} = U${(dolar + euro).GetCantidad()}");
            Console.WriteLine($"U${dolar.GetCantidad()} - UE{euro.GetCantidad()} = U${(dolar - euro).GetCantidad()}");
            Console.WriteLine($"U${dolar.GetCantidad()} es equivalente a UE{euro.GetCantidad()}: {(dolar == euro)}");
            Console.WriteLine($"U${dolar.GetCantidad()} NO es equivalente a UE{euro.GetCantidad()}: {(dolar != euro)}");

            Console.WriteLine("-----------------------------------");

            Console.WriteLine($"U${dolar.GetCantidad()} + ${peso.GetCantidad()} = U${(dolar + peso).GetCantidad()}");
            Console.WriteLine($"U${dolar.GetCantidad()} - ${peso.GetCantidad()} = U${(dolar - peso).GetCantidad()}");
            Console.WriteLine($"U${dolar.GetCantidad()} es equivalente a ${peso.GetCantidad()}: {(dolar == peso)}");
            Console.WriteLine($"U${dolar.GetCantidad()} NO es equivalente a ${peso.GetCantidad()}: {(dolar != peso)}");

            Console.WriteLine("-----------------------------------");

            Console.WriteLine($"U${dolar.GetCantidad()} es igual a U${dolarDos.GetCantidad()}: {(dolar == dolarDos)}");
            Console.WriteLine($"U${dolar.GetCantidad()} NO es igual a U${dolarDos.GetCantidad()}: {(dolar != dolarDos)}");

            Console.WriteLine("-----------------------------------");

            Console.WriteLine("---------------EURO----------------");

            Console.WriteLine($"UE{euro.GetCantidad()} + U${dolar.GetCantidad()} = UE{(euro + dolar).GetCantidad()}");
            Console.WriteLine($"UE{euro.GetCantidad()} - U${dolar.GetCantidad()} = UE{(euro - dolar).GetCantidad()}");
            Console.WriteLine($"UE{euro.GetCantidad()} es equivalente a U${dolar.GetCantidad()}: {(euro == dolar)}");
            Console.WriteLine($"UE{euro.GetCantidad()} NO es equivalente a U${dolar.GetCantidad()}: {(euro != dolar)}");


            Console.WriteLine("-----------------------------------");

            Console.WriteLine($"UE{euro.GetCantidad()} + ${peso.GetCantidad()} = UE{(euro + peso).GetCantidad()}");
            Console.WriteLine($"UE{euro.GetCantidad()} - ${peso.GetCantidad()} = UE{(euro - peso).GetCantidad()}");
            Console.WriteLine($"UE{euro.GetCantidad()} es equivalente a UE{euro.GetCantidad()}: {(euro == peso)}");
            Console.WriteLine($"UE{euro.GetCantidad()} NO es equivalente a UE{euro.GetCantidad()}: {(euro != peso)}");


            Console.WriteLine("-----------------------------------");

            Console.WriteLine($"UE{euro.GetCantidad()} es igual a UE{euroDos.GetCantidad()}: {(euro == euroDos)}");
            Console.WriteLine($"UE{euro.GetCantidad()} NO es igual a UE{euroDos.GetCantidad()}: {(euro != euroDos)}");

            Console.WriteLine("-----------------------------------");

            Console.WriteLine("---------------PESO----------------");

            Console.WriteLine($"${peso.GetCantidad()} + U${dolar.GetCantidad()} = ${(peso + dolar).GetCantidad().ToString("0.00")}");
            Console.WriteLine($"${peso.GetCantidad()} - U${dolar.GetCantidad()} = ${(peso - dolar).GetCantidad().ToString("0.00")}");
            Console.WriteLine($"${peso.GetCantidad()} es equivalente a U${dolar.GetCantidad()}: {(peso == dolar)}");
            Console.WriteLine($"${peso.GetCantidad()} NO es equivalente a U${dolar.GetCantidad()}: {(peso != dolar)}");

            Console.WriteLine("-----------------------------------");

            Console.WriteLine($"${peso.GetCantidad()} + UE{euro.GetCantidad()} = ${(peso + euro).GetCantidad()}");
            Console.WriteLine($"${peso.GetCantidad()} - UE{euro.GetCantidad()} = ${(peso - euro).GetCantidad()}");
            Console.WriteLine($"${peso.GetCantidad()} es equivalente a UE{euro.GetCantidad()}: {(peso == euro)}");
            Console.WriteLine($"${peso.GetCantidad()} NO es equivalente a UE{euro.GetCantidad()}: {(peso != euro)}");

            Console.WriteLine("-----------------------------------");

            Console.WriteLine($"${peso.GetCantidad()} es igual a ${pesoDos.GetCantidad()}: {(peso == pesoDos)}");
            Console.WriteLine($"${peso.GetCantidad()} NO es igual a ${pesoDos.GetCantidad()}: {(peso != pesoDos)}");







        }
    }
}
