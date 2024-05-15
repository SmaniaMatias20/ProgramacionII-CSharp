using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_02
{
    public class Lavadero
    {
        // Atributos
        private List<Vehiculo> vehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;

        // Propiedades
        public string Detalle
        {
            // Listado de vehiculos
            get { return $"Precio Auto: {precioAuto} \nPrecio Moto: {precioMoto} \nPrecio Camion: {precioCamion}"; }
        }
        public List<Vehiculo> Vehiculos
        {
            // Recorrer la lista de vehiculos
            get { return vehiculos; }
        }

        // Constructores
        private Lavadero()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Lavadero(List<Vehiculo> vehiculos, float precioAuto, float precioCamion, float precioMoto)
        {
            this.vehiculos = vehiculos;
            this.precioAuto = precioAuto;
            this.precioMoto = precioMoto;
            this.precioCamion = precioCamion;
        }

        // Metodos
        public double MostrarTotalFacturado()
        {
            // Retorna la ganancia total del lavadero
            double ganancia = 0;

            foreach (Vehiculo vehiculo in vehiculos)
            {
                if (vehiculo.GetType() == typeof(Auto))
                {
                    ganancia += precioAuto;
                }
                else if (vehiculo.GetType() == typeof(Camion))
                {
                    ganancia += precioCamion;
                }
                else 
                {
                    ganancia += precioMoto;
                }
            }
            return ganancia;
        }
        public double MostrarTotalFacturado(EMarcas marca)
        {
            // Retorna la ganancia total del lavadero por tipo vehiculo
            double ganancia = 0;

            foreach (Vehiculo vehiculo in vehiculos)
            {
                if (vehiculo.Marca == marca)
                {
                    if (vehiculo.GetType() == typeof(Auto))
                    {
                        ganancia += precioAuto;
                    }
                    else if (vehiculo.GetType() == typeof(Camion))
                    {
                        ganancia += precioCamion;
                    }
                    else
                    {
                        ganancia += precioMoto;
                    }
                }
            }
            return ganancia;
        }

        // Sobrecarga de operadores
        public static bool operator ==(Lavadero lavadero, Vehiculo nuevoVehiculo) 
        {
            // Retorna True si el vehiculo se encuentra en el lavadero
            bool validacion = false;
            foreach (var vehiculo in lavadero.vehiculos)
            {
                if (vehiculo == nuevoVehiculo) 
                { 
                    validacion = true;
                } 
            }
            return validacion;
        }

        public static bool operator !=(Lavadero lavadero, Vehiculo nuevoVehiculo)
        {
            // Retorna True si el vehiculo no se encuentra en el lavadero
            bool validacion = true;

            foreach (var vehiculo in lavadero.vehiculos)
            {
                if (vehiculo == nuevoVehiculo)
                {
                    validacion = false;
                }
            }
            return validacion;
        }
        public static bool operator +(Lavadero lavadero, Vehiculo vehiculo)
        {
            // Agregara un vehiculo si no se encuentra en el lavadero
            if (lavadero != vehiculo)
            {
                lavadero.vehiculos.Add(vehiculo);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator -(Lavadero lavadero, Vehiculo vehiculo)
        {
            // Quitara un vehiculo si se encuentra en el lavadero
            if (lavadero == vehiculo)
            {
                lavadero.vehiculos.Remove(vehiculo);
                return true;
            }
            else
            {
                return false;
            }
        }

        // Metodos
        public static int OrdenarVehiculosPorPatente(Vehiculo primerVehiculo, Vehiculo segundoVehiculo) 
        {
            // Retorna 0 (cero) si ambas patentes son iguales
            // Si la primera patente es mayor que la segunda retorna 1 (uno)
            // Si la segunda patente es mayor que la primera retorna -1 (menos uno)
            if (primerVehiculo.Patente.Equals(segundoVehiculo.Patente))
            {
                return 0;
            }
            else 
            {
                return 1;
            }
        }
        public int OrdenarVehiculosPorMarca(Vehiculo primerVehiculo, Vehiculo segundoVehiculo) 
        {
            // Retorna 0 (cero) si ambas marcas son iguales
            // Si la primera marca es mayor que la segunda retorna 1 (uno)
            // Si la segunda marca es mayor que la primera retorna -1 (menos uno)
            if (primerVehiculo.Marca == segundoVehiculo.Marca)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

    }
}
