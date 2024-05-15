using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_02
{
    public class Camion : Vehiculo
    {
        // Atributos
        private float tara;

        // Propiedades
        public float Tara 
        { 
            get { return tara; } 
            set { tara = value; }
        }

        // Constructores
        public Camion() 
        { 
        }
        public Camion(string patente, byte cantidadRuedas, EMarcas marca, float tara) : base(patente, cantidadRuedas, marca)
        { 
            this.tara = tara;
        }

        // Metodos
        public string MostrarCamion() 
        {
            return $"{base.Mostrar()} \nTara: {Tara}";
        }
    }
}
