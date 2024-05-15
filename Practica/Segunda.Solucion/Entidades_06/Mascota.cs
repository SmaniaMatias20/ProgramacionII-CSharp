using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_06
{
    public class Mascota
    {
        private string especie;
        private string nombre;
        private DateTime fechaNacimiento;
        private string vacuna;

        public Mascota(string especie, string nombre, DateTime fechaNacimiento, string vacuna) 
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento; 
            this.vacuna = vacuna;   
        }

        public string GetNombre() 
        {
            return this.nombre;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("---Informacion de la Mascota---");
            Console.WriteLine($"Nombre: {this.nombre} \nEspecie: {this.especie} \nNacimiento: {this.fechaNacimiento.Year} \nVacuna: {this.vacuna}");
        }
    }
}
