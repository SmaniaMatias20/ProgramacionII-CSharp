using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_06;

namespace Entidades_06
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string domicilio;
        private string telefono;
        private Mascota mascota;

        public Cliente(string nombre, string apellido, string domicilio, string telefono, Mascota mascota) 
        { 
            this.nombre = nombre;   
            this.apellido = apellido;   
            this.domicilio = domicilio; 
            this.telefono = telefono;   
            this.mascota = mascota;
        }

        public void MostrarInformacion() 
        {
            Console.WriteLine("---Informacion del Cliente---");
            Console.WriteLine($"Nombre: {this.nombre} \nApellido: {this.apellido} \nDomicilio: {this.domicilio} \nTelefono: {this.telefono} \nMascota: {this.mascota.GetNombre()}");
        }
    }
}
