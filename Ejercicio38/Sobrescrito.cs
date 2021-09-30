using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
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
            return "¡Este es mi metodo ToString sobrescrito!";
        }
        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }
        public override int GetHashCode()
        {
            return 1142510187;
        }

    }
}
