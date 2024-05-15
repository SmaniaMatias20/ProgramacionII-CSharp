using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_01;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta miCuenta = new Cuenta("Matias", 30000);

            miCuenta.Mostrar();
            miCuenta.Ingresar(100000);
            miCuenta.Mostrar();
            miCuenta.Retirar(25000);
            miCuenta.Mostrar();
        }
    }
}
