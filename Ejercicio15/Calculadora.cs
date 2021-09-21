using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Calculadora
    {
        /// <summary>
        /// Calcula dos numero y retorna el resultado
        /// </summary>
        /// <param name="numero"></param> primer numero a calcular
        /// <param name="numeroDos"></param> segundo numero a calcular
        /// <param name="operador"></param> operador que se va a calcular entre los numeros.
        /// <returns></returns> resultado de operaciòn
        public static float Calcular(float numero, float numeroDos, string operador)
        {
            float resultado = 0; //Lo inicializo por si el operador que viene por parametro no corresponde a ningun caso correcto.
            if (!(operador is null))
            {
                switch (operador)
                {
                    case "+":
                        resultado = numero + numeroDos;
                        break;
                    case "-":
                        resultado = numero - numeroDos;
                        break;
                    case "*":
                        resultado = numero * numeroDos;
                        break;
                    case "/":
                        if(validar(numeroDos))
                        {
                            resultado = numero / numeroDos;
                        }
                        break;
                }
            }
            return resultado;
        }
        /// <summary>
        /// valida que un nùmero no sea cero
        /// </summary>
        /// <param name="numero"></param> nùmero a validar
        /// <returns></returns>verdadero si no es cero y falso si es cero.
        private static bool validar(float numero)
        {
            return !(numero == 0);
        }
    }
}
