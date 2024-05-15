using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_03
{
    public class Equipo
    {
        private short _cantidadDeJugadores;
        private List<Jugador> _jugadores;
        private string _nombre;

        private Equipo() 
        {
            this._jugadores = new List<Jugador>();  
        }
        public Equipo(short cantidad, string nombre) : this()
        { 
            this._cantidadDeJugadores = cantidad;
            this._nombre = nombre;   
        }

        public static bool operator +(Equipo equipo, Jugador nuevoJugador) 
        {
            bool validacion = true;
            
            foreach (Jugador jugador in equipo._jugadores)
            {
                
                if ((jugador == nuevoJugador))
                {
                    validacion = false;
                    break;
                }
            }

            if (validacion)
            {
                equipo._jugadores.Add(nuevoJugador);
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
