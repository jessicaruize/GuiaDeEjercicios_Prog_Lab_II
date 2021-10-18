using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;
        /// <summary>
        /// Constructor privado que inicializa la lista y crea un puesto de atencion "caja1".
        /// </summary>
        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }
        /// <summary>
        /// Constructor que le asigna nombre e inicializa indirectamente el resto de los atributos.
        /// </summary>
        /// <param name="nombre"></param> nombre del negocio.
        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }
        /// <summary>
        /// Propiedad que retorna el proximo cliente en la cola de atenciòn. Tambien agrega un cliente si este no se encuentra en la cola.
        /// </summary>
        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                bool agrego = this + value;
            }
        }
        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count();
            }
        }
        /// <summary>
        /// corrobora si el cliente se encuentra en la cola.
        /// </summary>
        /// <param name="n"></param> negocio a ser inspeccionado.
        /// <param name="c"></param>cliente a buscar en el negocio pasado por parametro.
        /// <returns></returns> True si se encuentra, false si no se encuentra el cliente en la lista.
        public static bool operator ==(Negocio n, Cliente c)
        {
            if (n is not null && c is not null)
            {
                foreach (Cliente item in n.clientes)
                {
                    if (item == c)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Corrobora si un cliente no se encuentra en un negocio.
        /// </summary>
        /// <param name="n"></param> Negocio a ser inspeccionado.
        /// <param name="c"></param> Cliente a buscar en el negocio.
        /// <returns></returns> true si no se encuentra el cliente en la lista, false si no se encuentra en la lista.
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        /// <summary>
        /// Suma un cliente a la cola de clientes en el negocio en caso de no encontrarse en ella.
        /// </summary>
        /// <param name="n"></param> Negocio a agregar un cliente.
        /// <param name="c"></param> Cliente a ser agregado.
        /// <returns></returns>
        public static bool operator +(Negocio n, Cliente c)
        {
            if (n is not null && c is not null)
            {
                if (n != c)
                {
                    n.clientes.Enqueue(c);
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Atiende al cliente que sigue en la cola.
        /// </summary>
        /// <param name="n"></param>negocio en el que se va a atender el cliente.
        /// <returns></returns> true si se pudo atender, false en caso contrario.
        public static bool operator ~(Negocio n)
        {
            bool atendido = false;
            if (n is not null)
            {
                atendido = n.caja.Atender(n.Cliente);
            }
            return atendido;
        }
    }
}