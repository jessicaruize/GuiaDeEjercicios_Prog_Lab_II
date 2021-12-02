using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class OtraClase
    {
        public OtraClase()
        {
            try
            {
                MiClase mi = new MiClase(0);
            }
            catch(UnaExcepcion e)
            {
                throw new MiExcepcion("Otra clase", e);
            }
        }
    }
}
