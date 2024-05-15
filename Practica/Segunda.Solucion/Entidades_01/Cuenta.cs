using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_01
{
    public class Cuenta
    {
        private string titular;
        private float cantidad;



        public Cuenta(string titular, float cantidad)
        { 
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        { 
            return this.titular;    
        }

        public float GetCantidad()
        {
            return this.cantidad;
        }

        public void Mostrar()
        {
            Console.WriteLine($"El titular de la cuenta es {this.titular} y la cantidad es {this.cantidad}");
        }

        public void Ingresar(float importe)
        {
            if (importe > 0)
            {
                this.cantidad += importe;

                Console.WriteLine($"El importe ({importe}) fue acreditado en su cuenta");
            }
            else
            {
                Console.WriteLine("Ingrese un importe mayor a 0 (cero)");
            }
        }

        public void Retirar(float importe)
        {
            if (importe > 0)
            {
                this.cantidad -= importe;

                Console.WriteLine($"El importe ({importe}) fue debitado de su cuenta");
            }
            else
            {
                Console.WriteLine("Ingrese un importe mayor a 0 (cero)");
            }
            
        }
    }
}
