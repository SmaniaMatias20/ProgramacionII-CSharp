using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_02
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, string dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        private int CalcularEdad()
        {
            int edad = 2024 - this.fechaDeNacimiento.Year;

            return edad;
        }

        public void Mostrar()
        {
            int edad = CalcularEdad();

            Console.WriteLine($"\nNombre: {this.nombre}.\nFecha de nacimiento: {this.fechaDeNacimiento}. \nEdad: {edad}. \nDNI: {this.dni}");
        }

        public void EsMayorDeEdad()
        {
            int edad = CalcularEdad();

            if (edad >= 18)
            {
                Console.WriteLine($"{this.nombre}... Es mayor de edad");
            }
            else 
            {
                Console.WriteLine($"{this.nombre}... NO es mayor de edad");
            }
        }

    }
}
