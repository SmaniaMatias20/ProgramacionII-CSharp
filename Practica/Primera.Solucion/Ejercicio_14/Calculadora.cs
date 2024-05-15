using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    public class Calculadora
    {
        public static double Calcular(double primerNumero, double segundoNumero, string operador)
        { 
            double resultado = 0;

            switch (operador) 
            {
                case "+":
                    resultado = primerNumero + segundoNumero;
                    break;
                case "-":
                    resultado = primerNumero - segundoNumero;
                    break;
                case "*":   
                    resultado = primerNumero * segundoNumero;
                    break;
                case "/":

                    if (Validar(segundoNumero)) 
                    { 
                        resultado = primerNumero / segundoNumero;
                    }
                    else 
                    {
                        resultado = primerNumero;
                    }
                    break;

            }

            return resultado;
        }

        private static bool Validar(double segundoNumero)
        {
            bool validacion = false;

            if (segundoNumero != 0) { 
                validacion = true;
            }

            return validacion;
        }


    }
}
