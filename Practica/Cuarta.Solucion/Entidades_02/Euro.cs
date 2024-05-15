using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double _cantidad;
        private static double _cotzRespectoDolar;

        static Euro()
        {
            _cotzRespectoDolar = 1.17;
        }

        public Euro(double cantidad) 
        { 
            this._cantidad = cantidad;  
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            _cotzRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Euro euro)
        {
            return new Dolar(euro.GetCantidad() * Euro.GetCotizacion());
        }

        public static explicit operator Peso(Euro euro)
        {
            Dolar dolar = (Dolar)euro;
            return new Peso(dolar.GetCantidad() * Peso.GetCotizacion());
        }

        public double GetCantidad()
        {
            return this._cantidad;
        }

        public static double GetCotizacion()
        {
            return _cotzRespectoDolar;
        }

        public static implicit operator Euro(double cantidad)
        {
            return new Euro(cantidad);
        }


        public static bool operator !=(Euro euro, Peso peso)
        {
            Euro nuevoEuro = (Euro)peso;

            if (nuevoEuro.GetCantidad() != euro.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Euro euro, Dolar dolar)
        {
            Euro nuevoEuro = (Euro)dolar;

            if (nuevoEuro.GetCantidad() != euro.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Euro euro, Euro euroDos)
        {
            if (euro.GetCantidad() != euroDos.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Euro euro, Peso peso)
        {
            if (!(euro != peso))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Euro euro, Dolar dolar)
        {
            if (!(euro != dolar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Euro euro, Euro euroDos)
        {
            if (!(euro != euroDos))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Euro operator -(Euro euro, Peso peso)
        {
            Euro nuevoEuro = (Euro)peso;

            return new Euro(euro.GetCantidad() - nuevoEuro.GetCantidad());
        }

        public static Euro operator -(Euro euro, Dolar dolar)
        {
            Euro nuevoEuro = (Euro)dolar;

            return new Euro(euro.GetCantidad() - nuevoEuro.GetCantidad());
        }

        public static Euro operator +(Euro euro, Peso peso)
        {
            Euro nuevoEuro = (Euro)peso;

            return new Euro(euro.GetCantidad() + nuevoEuro.GetCantidad());
        }

        public static Euro operator +(Euro euro, Dolar dolar)
        {
            Euro nuevoEuro = (Euro)dolar;

            return new Euro(euro.GetCantidad() + nuevoEuro.GetCantidad());
        }
    }










}
