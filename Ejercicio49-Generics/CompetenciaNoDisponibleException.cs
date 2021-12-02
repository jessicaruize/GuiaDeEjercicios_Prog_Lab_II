using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio49_Generics
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;
        CompetenciaNoDisponibleException ex;

        public CompetenciaNoDisponibleException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public CompetenciaNoDisponibleException(string mensaje, string nombreClase, string nombreMetodo) : this(mensaje, nombreClase, nombreMetodo, null)
        {
            
        }
        public CompetenciaNoDisponibleException(string mensaje, string nombreClase, string nombreMetodo, Exception inner) : base(mensaje, inner)
        {
            this.nombreClase = nombreClase;
            this.nombreMetodo = nombreMetodo;
        }
        public string NombreClase { get => this.nombreClase; }
        public string NombreMetodo { get => this.nombreMetodo; }
        public override string ToString()
        {
            Exception e = this;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Excepciòn en el metodo {this.NombreMetodo} de la clase {this.NombreClase}.");
            sb.AppendLine($"{e.Message}");
            do
            {
                sb.Append($"{e.Message}\t");
                e = e.InnerException;
            } while (!object.ReferenceEquals(e, null));
            
            return sb.ToString();
        }
    }
}
