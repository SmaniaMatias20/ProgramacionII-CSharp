using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        private double _cantidad;
        private static double _cotzRespectoDolar;

        static Peso() 
        {
            _cotzRespectoDolar = 102.65;
        }

        public Peso(double cantidad)
        { 
            this._cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        { 
            _cotzRespectoDolar += cantidad;
        }

        public static explicit operator Dolar(Peso peso)
        {
            return new Dolar(peso.GetCantidad() / Peso.GetCotizacion());
        }

        public static explicit operator Euro(Peso peso)
        {
            Dolar dolar = (Dolar)peso;
            return new Euro(dolar.GetCantidad() / Euro.GetCotizacion());
        }

        public double GetCantidad()
        {
            return this._cantidad;
        }

        public static double GetCotizacion()
        {
            return _cotzRespectoDolar;
        }

        public static implicit operator Peso(double cantidad)
        {
            return new Peso(cantidad);
        }

        public static bool operator !=(Peso peso, Euro euro)
        {
            Peso nuevoPeso = (Peso)euro;

            if (nuevoPeso.GetCantidad() != peso.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Peso peso, Dolar dolar)
        {
            Peso nuevoPeso = (Peso)dolar;

            if (nuevoPeso.GetCantidad() != peso.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Peso peso, Peso pesoDos)
        {
            if (peso.GetCantidad() != pesoDos.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Peso peso, Euro euro)
        {
            if (!(peso != euro))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Peso peso, Dolar dolar)
        {
            if (!(peso != dolar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Peso peso, Peso pesoDos)
        {
            if (!(peso != pesoDos))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Peso operator -(Peso peso, Euro euro)
        {
            Peso nuevoPeso = (Peso)euro;

            return new Peso(peso.GetCantidad() - nuevoPeso.GetCantidad());
        }

        public static Peso operator -(Peso peso, Dolar dolar)
        {
            Peso nuevoPeso = (Peso)dolar;

            return new Peso(peso.GetCantidad() - nuevoPeso.GetCantidad());
        }

        public static Peso operator +(Peso peso, Euro euro)
        {
            Peso nuevoPeso = (Peso)euro;

            return new Peso(peso.GetCantidad() + nuevoPeso.GetCantidad());
        }

        public static Peso operator +(Peso peso, Dolar dolar)
        {
            Peso nuevoPeso = (Peso)dolar;

            return new Peso(peso.GetCantidad() + nuevoPeso.GetCantidad());
        }
    }
}
