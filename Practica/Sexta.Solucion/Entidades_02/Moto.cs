using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_02
{
    public class Moto : Vehiculo
    {
        // Atributos
        private float cilindrada;

        // Propiedades
        public float Cilindrada 
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }

        // Constructores
        public Moto() { }
        public Moto(string patente, byte cantidadRuedas, EMarcas marca, float cilindrada) : base(patente, cantidadRuedas, marca)
        { 
            this.cilindrada = cilindrada;
        }

        // Metodos
        public string MostrarMoto()
        {
            return $"{base.Mostrar()} \nCilindrada: {Cilindrada}";
        }
    }
}
