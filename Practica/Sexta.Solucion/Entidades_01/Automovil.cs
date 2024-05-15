using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_01
{
    public class Automovil : VehiculoTerrestre
    {
        // Atributos
        private short cantidadMarchas;
        private int cantidadPasajeros;

        // Propiedades
        public short CantidadMarchas 
        {
            get { return cantidadMarchas; }
            set { cantidadMarchas = value; }
        }

        public int CantidadPasajeros 
        {
            get { return cantidadPasajeros; }
            set { cantidadPasajeros = value; }
        }

        // Constructores
        public Automovil() 
        { 
        }

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public string MostrarInformacion()
        {
         
            return $"{base.MostrarInformacion()} \nMarchas: {this.cantidadMarchas} \nPasajeros: {this.cantidadPasajeros}";
        }
    }
}
