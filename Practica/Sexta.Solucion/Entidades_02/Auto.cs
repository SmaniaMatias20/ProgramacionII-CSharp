using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_02
{
    public class Auto : Vehiculo
    {
        // Atributos
        private int cantidadAsientos;

        // Propiedades
        public int CantidadAsientos 
        { 
            get { return cantidadAsientos; } 
            set { cantidadAsientos = value; }
        }

        // Constructores
        public Auto() 
        { 
        }
        public Auto(string patente, byte cantidadRuedas, EMarcas marca, int cantidadAsientos) : base(patente, cantidadRuedas, marca)
        {
            this.cantidadAsientos = cantidadAsientos;
        }

        // Metodos
        public string MostrarAuto()
        {
            return $"{base.Mostrar()} \nAsientos: {CantidadAsientos}";
        }
    }
}
