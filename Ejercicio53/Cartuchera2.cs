using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio53
{
    class Cartuchera2
    {
        private List<Boligrafo> listaBoligrafo = new List<Boligrafo>();
        private List<Lapiz> listaLapiz = new List<Lapiz>();

        public List<Boligrafo> ListaBoligrafo { get => listaBoligrafo; set => listaBoligrafo = value; }
        public List<Lapiz> ListaLapiz { get => listaLapiz; set => listaLapiz = value; }

        public bool ProbarElementos()
        {
            bool aux = true;
            foreach(Boligrafo item in listaBoligrafo)
            {
                item.UnidadesDeEscritura = item.UnidadesDeEscritura - 1;
                if (item.UnidadesDeEscritura < 1)
                {
                    item.Recargar(20);
                    aux = false;
                }
            }
            foreach (Lapiz item in listaLapiz)
            {
                item.UnidadesDeEscritura = item.UnidadesDeEscritura - 1;
                if (item.UnidadesDeEscritura < 1)
                {
                    ((IAcciones)item).Recargar(20);
                    aux = false;
                }
            }
            return aux;
        }
    }
}
