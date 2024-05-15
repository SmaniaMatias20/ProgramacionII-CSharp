using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double _cantidad;
        private static double _cotzRespectoDolar;

        static Dolar() 
        { 
        }

        public Dolar(double cantidad) 
        { 
            this._cantidad = cantidad;
        }

        public static explicit operator Euro(Dolar dolar)
        {
            return new Euro(dolar.GetCantidad() / Euro.GetCotizacion());
        }

        public static explicit operator Peso(Dolar dolar)
        {
            return new Peso(dolar.GetCantidad() / Peso.GetCotizacion());
        }

        public double GetCantidad() 
        { 
            return this._cantidad;
        }

        public static double GetCotizacion()
        {
            return _cotzRespectoDolar;
        }

        public static implicit operator Dolar(double cantidad)
        {
            return new Dolar(cantidad);
        }

        public static bool operator !=(Dolar dolar, Euro euro)
        {
            Dolar nuevoDolar = (Dolar)euro;

            if (nuevoDolar.GetCantidad() != dolar.GetCantidad())
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public static bool operator !=(Dolar dolar, Peso peso)
        {
            Dolar nuevoDolar = (Dolar)peso;

            if (nuevoDolar.GetCantidad() != dolar.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool operator !=(Dolar dolar, Dolar dolarDos)
        {
            if (dolar.GetCantidad() != dolarDos.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Dolar dolar, Euro euro)
        {
            if (!(dolar != euro))
            {
                return true;
            }
            else 
            {
                return false;
            }
            
        }

        public static bool operator ==(Dolar dolar, Peso peso)
        {
            if (!(dolar != peso))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Dolar dolar, Dolar dolarDos)
        {
            if (!(dolar != dolarDos))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Dolar operator -(Dolar dolar, Euro euro)
        {
            Dolar nuevoDolar = (Dolar)euro;

            return new Dolar(dolar.GetCantidad() - nuevoDolar.GetCantidad());
        }

        public static Dolar operator -(Dolar dolar, Peso peso)
        {
            Dolar nuevoDolar = (Dolar)peso;

            return new Dolar(dolar.GetCantidad() - nuevoDolar.GetCantidad());
        }

        public static Dolar operator +(Dolar dolar, Euro euro)
        {
            Dolar nuevoDolar = (Dolar)euro;

            return new Dolar(dolar.GetCantidad() + nuevoDolar.GetCantidad());
        }

        public static Dolar operator +(Dolar dolar, Peso peso)
        {
            Dolar nuevoDolar = (Dolar)peso;

            return new Dolar(dolar.GetCantidad() + nuevoDolar.GetCantidad());
        }


    }
}
