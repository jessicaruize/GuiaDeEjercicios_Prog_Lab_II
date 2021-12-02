using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico47_Generics
{
    public class EquipoBasquet : Equipo
    {
        public EquipoBasquet(string nombre, DateTime fechaCreacion) : base(nombre, fechaCreacion)
        {
        }
        public override string Ficha()
        {
            return $"Equipo de BASQUET\n{base.Ficha()}";
        }
    }
}
