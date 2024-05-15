using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_03;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string datosEstudiante;

            Estudiante estudiante = new Estudiante("Matias", "Smania", "115559");

            estudiante.SetNotaPrimerParcial(5);
            estudiante.SetNotaSegundoParcial(6);
            datosEstudiante = estudiante.Mostrar();


            Console.WriteLine(datosEstudiante);

        }
    }
}
