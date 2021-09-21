using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Validacion
    {
        static public bool Validar(int valor, int max, int min)
        {
            return (valor >= min && valor <= max);
        }

    }
}
