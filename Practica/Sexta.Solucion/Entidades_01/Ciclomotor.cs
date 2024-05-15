using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_01
{
    public class Ciclomotor : VehiculoTerrestre
    {
        // Atributos
        private int cilindradas;

        // Propiedades
        public int Cilindradas 
        {
            get { return cilindradas; }
            set { cilindradas = value; }
        }

        // Constructores 
        public Ciclomotor() 
        { 
        }
        public Ciclomotor(short cantidadRuedas, short cantidadPuertas, Colores color, int cilindradas) : base(cantidadRuedas, cantidadPuertas, color) 
        { 
            this.cilindradas = cilindradas;
        }

        public string MostrarInformacion()
        {
            return $"{base.MostrarInformacion()} \nCilindradas: {this.cilindradas}";
        }
    }
}
