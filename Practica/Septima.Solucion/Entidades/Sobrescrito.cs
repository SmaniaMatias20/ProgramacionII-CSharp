using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_01
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;

        public Sobrescrito() 
        { 
            this.miAtributo = "Probar abstractos";
        }

        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();

        public override string ToString()
        {
            return "Este es mi metodo ToString sobrescrito!";
        }

        public override bool Equals(object obj)
        {
            // Verifica si el objeto proporcionado no es nulo y es del mismo tipo
            if (obj != null && obj.GetType() == this.GetType())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode() 
        {
            return 1142510181;
        }
    }
}
