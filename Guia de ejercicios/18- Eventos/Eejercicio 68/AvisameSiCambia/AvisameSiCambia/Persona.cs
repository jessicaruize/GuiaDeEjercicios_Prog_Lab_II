using System;

namespace Biblioteca
{
    public delegate void DelegadoString(string msg);
    public class Persona
    {
        private string nombre;
        private string apellido;
        public event DelegadoString EventoString;

        public string Nombre { get => nombre; set
            {
                this.nombre = value;
                EventoString.Invoke(this.nombre);
            }
        }
        public string Apellido { get => apellido; set
            {
                this.apellido = value;
                EventoString.Invoke(this.apellido);
            }
        }
        public Persona()
        {
        }
        public string Mostrar()
        {
            return $"{this.Nombre} {this.Apellido}";
        }

    }
}
