using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_01
{
    public class Furgon : VehiculoTerrestre
    {
        // Atributos
        private short cantidadMarchas;
        private int pesoCarga;

        // Propiedades
        public short CantidadMarchas 
        {
            get { return cantidadMarchas; }
            set { cantidadMarchas = value; }
        }

        public int PesoCarga 
        {
            get { return pesoCarga; }
            set { pesoCarga = value; }
        }

        // Constructores
        public Furgon() 
        { 
        
        }

        public Furgon(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga) : base(cantidadRuedas, cantidadPuertas, color)
        { 
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }

        public string MostrarInformacion()
        {
            return $"{base.MostrarInformacion()} \nMarchas: {this.cantidadMarchas} \nPeso de Carga: {this.pesoCarga}";
        }
    }
}
