using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_03
{
    public class Jugador
    {
        private int _dni;
        private string _nombre;
        private int _partidosJugados;
        private float _promedioGoles;
        private int _totalGoles;

        private Jugador() 
        { 
            this._dni = 0;
            this._partidosJugados = 0;
            this._totalGoles = 0;
            this._promedioGoles = 0;
        }

        public Jugador(int dni, string nombre)
        { 
            this._dni = dni;
            this._nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        { 
            this._totalGoles = totalGoles;
            this._partidosJugados = totalPartidos;
        }

        public float GetPromedioGoles() 
        { 
            this._promedioGoles = this._totalGoles / this._partidosJugados;
            return this._promedioGoles;
        }

        // Get de DNI
        public int Dni 
        { 
            get { 
                return this._dni; 
            }
        }

        public static bool operator !=(Jugador primerJugador, Jugador segundoJugador) 
        {
            if (primerJugador._dni == segundoJugador._dni)
            {
                return false;
            }
            else 
            { 
                return true;
            }

        }

        public static bool operator ==(Jugador primerJugador, Jugador segundoJugador)
        {
            if (!(primerJugador._dni != segundoJugador._dni))
            {
                return true;
            }
            else
            {
                return true;
            }

        }

        public string MostrarDatos() 
        {
            return $"DNI: {this._dni} \nNombre: {this._nombre} \nPartidos: {this._partidosJugados} \nGoles: {this._totalGoles} \nPromedio: {this._promedioGoles}";
        }


    }
}
