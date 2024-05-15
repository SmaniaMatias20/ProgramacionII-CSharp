using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades_03
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private Random random;

        public Estudiante(string nombre, string apellido, string legajo) 
        { 
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.random = new Random();
        }
        public int CalcularNotaFinal()
        {   
            int notaFinal = 0;

            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                notaFinal = this.random.Next(6, 10);

            }
            else 
            {
                notaFinal = -1;
            }

            return notaFinal;
        }

        private double CalcularPromedio()
        { 
            double promedio = (this.notaPrimerParcial + this.notaSegundoParcial) / 2.0;

            return promedio;
        
        }

        public void SetNotaPrimerParcial(int nota) 
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        public string Mostrar()
        { 
            double promedio = CalcularPromedio();
            int notaFinal = CalcularNotaFinal();

            StringBuilder cadena = new StringBuilder(
            $"Nombre: {this.nombre} \nApellido: {this.apellido} \nLegajo: {this.legajo} \nPrimer parcial: {this.notaPrimerParcial} \nSegundo parcial: {this.notaSegundoParcial} \nPromedio: {promedio}");

            if (notaFinal != -1)
            {
                cadena.Append($"\nNota final: {notaFinal}");
            }
            else 
            {
                cadena.Append($"\nNota final: Alumno desaprobado");
            }


            return cadena.ToString();   
        }

    }
}
