using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_01
{
    public class VehiculoTerrestre
    {
        // Atributos 
        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected Colores color;

        // Propiedades
        public short CantidadRuedas 
        {
            get { return cantidadRuedas; }
            set { cantidadRuedas = value; }
        }

        public short CantidadPuertas 
        {
            get { return cantidadPuertas; }
            set { cantidadPuertas = value; }
        }

        public Colores Color 
        {
            get { return color; }
            set { color = value; }
        }

        // Constructores
        public VehiculoTerrestre() 
        { 
        
        }

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color) 
        { 
            this.cantidadRuedas = cantidadRuedas;   
            this.cantidadPuertas = cantidadPuertas;
            this.color = color; 
        }


        public enum Colores 
        { 
            Rojo,
            Blanco,
            Azul,
            Gris,
            Negro
        }

        public string MostrarInformacion() 
        {
            return $"Ruedas: {this.cantidadRuedas} \nPuertas: {this.cantidadPuertas} \nColor: {this.color}";
        }
    }
}
