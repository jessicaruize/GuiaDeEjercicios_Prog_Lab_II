using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ValidarRespuesta
    {
        /// <summary>
        /// Valida si el char ingresado es "s" 
        /// </summary>
        /// <param name="c"></param> letra a validar
        /// <returns></returns>verdadero si es "s", falso si no lo es.
        static public bool ValidaS_N(char c)
        {
            return (c.ToString().ToLower() == "s");
        }
    }
}
