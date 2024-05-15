using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    public class Validador
    {
        public static bool ValidarRespuesta(string ingreso) {
            bool respuesta;

            if (ingreso.ToUpper() == "S")
            {
                respuesta = true;
            }
            else 
            { 
                respuesta= false;
            }


            return respuesta;
        }
    }
}
