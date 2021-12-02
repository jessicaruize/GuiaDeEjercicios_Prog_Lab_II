using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio53
{
    class Cartuchera1
    {
        private List<IAcciones> listaGenerica = new List<IAcciones>();

        public List<IAcciones> ListaGenerica { get => listaGenerica; set => listaGenerica = value; }

        public bool ProbarElementos()
        {
            foreach(IAcciones item in listaGenerica)
            {
                item.UnidadesDeEscritura = item.UnidadesDeEscritura - 1;
                if(item.UnidadesDeEscritura < 1)
                {
                    item.Recargar(20);
                    return false;
                }
            }
            return true;
        }

    }
}
