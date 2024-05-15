using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_01
{
    public class Sumador
    {
        // Atributos
        private int cantidadSumas;
        
        // Propiedades
        public int Cantidad 
        { 
            get 
            { 
                return cantidadSumas; 
            } 
            set 
            {  
                cantidadSumas = value; 
            }
        }

        // Constructores
        public Sumador() 
        { 
            this.cantidadSumas = 0;
        }

        public Sumador(int cantidadSumas) 
        { 
            this.cantidadSumas = cantidadSumas;  
        }

        // Metodos
        public long Sumar(long primerNumero, long segundoNumero)
        {
            this.cantidadSumas++;
            return primerNumero + segundoNumero;
        }

        public string Sumar(string primerCadena, string segundaCadena) 
        {
            this.cantidadSumas++;
            return primerCadena + segundaCadena;
        }

        // Conversión explícita desde int hacia Sumador
        public static explicit operator Sumador(int valor)
        {
            return new Sumador(valor);
        }

        // Sobrecarga de operadores
        public static long operator +(Sumador primerSumador, Sumador segundoSumador) 
        {
            return primerSumador.cantidadSumas + segundoSumador.cantidadSumas; 
        }

        public static bool operator /(Sumador primerSumador, Sumador segundoSumador)
        {
            if (primerSumador.cantidadSumas == segundoSumador.cantidadSumas)
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }



    }
}
