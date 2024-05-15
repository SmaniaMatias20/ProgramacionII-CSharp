using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_04
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;



        public Boligrafo(short tinta, ConsoleColor color) 
        { 
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor() 
        { 
            return this.color;
        }

        public int GetTinta() 
        { 
            return this.tinta;  
        }

        public string Pintar(short gasto, out string dibujo)
        {
            dibujo = ""; 

            if (gasto > this.tinta) 
            {
                for (int i = 0; i < this.tinta; i++)
                {
                    dibujo += "*"; 

                }
                SetTinta(this.tinta *= 0);
                return dibujo; 
            }
            else if (gasto <= this.tinta) 
            {


                for (int i = 0; i < gasto; i++)
                {
                    dibujo += "*"; 

                }
                SetTinta(gasto *= -1); 

                return dibujo; 
            } 
            else 
            {
                return dibujo;
            }
        }

        public void Recargar() 
        { 
            this.tinta = Boligrafo.cantidadTintaMaxima;
        }

        public void SetTinta(short cantidad)
        {
            int cantidadTotal = this.tinta + cantidad;

            if (Boligrafo.cantidadTintaMaxima >= cantidadTotal && cantidadTotal >= 0)
            {
                this.tinta += cantidad;
            }

        }
    }
}
