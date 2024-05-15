using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_02
{
    public class Vehiculo
    {
        // Atributos 
        protected string patente;
        protected byte cantidadRuedas;
        protected EMarcas marca;

        // Propiedades
        public string Patente 
        {
            get { return patente; }
        }
        public byte CantidadRuedas
        {
            get { return cantidadRuedas; }
            set { cantidadRuedas = value; }
        }
        public EMarcas Marca
        {
            get { return marca; }
        }

        // Constructores
        public Vehiculo() 
        { 
        }
        public Vehiculo(string patente, byte cantidadRuedas, EMarcas marca) 
        { 
            this.patente = patente;
            this.cantidadRuedas = cantidadRuedas;
            this.marca = marca;
        }

        // Metodos
        protected string Mostrar() 
        {
            return $"Patente: {Patente} \nRuedas: {CantidadRuedas} \nMarca: {Marca}";
        }
        //public void Vehiculo(string patente, byte cantidadRuedas, EMarcas marca) 
        //{ 

        //}

        // Sobrecarga de operadores
        public static bool operator ==(Vehiculo primerVehiculo, Vehiculo segundoVehiculo) 
        {
            return primerVehiculo.Patente == segundoVehiculo.Patente && primerVehiculo.Marca == segundoVehiculo.Marca;
        }

        public static bool operator !=(Vehiculo primerVehiculo, Vehiculo segundoVehiculo)
        {
            return primerVehiculo.Patente != segundoVehiculo.Patente && primerVehiculo.Marca != segundoVehiculo.Marca;
        }



    }
}
