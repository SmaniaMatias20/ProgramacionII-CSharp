using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public class Conversor
    {

        /// <summary>
        /// Convierte un numero recibido por parametro a Binario.
        /// </summary>
        /// <param name="numeroEntero">Numero a convertir.</param>
        /// <returns>Numero convertido a Binario.</returns>
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            StringBuilder numeroBinario = new StringBuilder();
            int resto = 0;


            while (numeroEntero >= 1) {

                resto = numeroEntero % 2;
                numeroEntero = numeroEntero / 2;

                numeroBinario.Insert(0, resto.ToString());
            }

            return numeroBinario.ToString();
        }

        /// <summary>
        /// Convierte un numero recibido por parametro a Decimal.
        /// </summary>
        /// <param name="numeroBinario">Numero a convertir.</param>
        /// <returns>Numero convertido a Decimal.</returns>
        public static int ConvertirBinarioADecimal(int numeroBinario)
        {
            int resto = 0;
            double contador = 0;
            double numeroDecimal = 0;

            double multiplicador = 0;

            while (numeroBinario != 0) {
                resto = numeroBinario % 10;
                numeroBinario = numeroBinario / 10;

                multiplicador = Math.Pow(2, contador);
                contador++;

                numeroDecimal += resto * multiplicador;
            }


            return (int)numeroDecimal;
        }

    }
}
