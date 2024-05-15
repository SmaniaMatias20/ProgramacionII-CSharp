using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    public class Validador
    {
        /// <summary>
        /// Valida si el numero ingresado está dentro del rango.
        /// </summary>
        /// <param name="valor">Valor a validar.</param>
        /// <param name="min">Valor minimo.</param>
        /// <param name="max">Valor maximo.</param>
        /// <returns>Un valor booleano.</returns>
        public static bool Validar(int valor, int min, int max) { 
            return valor > min && valor < max;  
        }
    }
}
