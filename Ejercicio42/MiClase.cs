using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class MiClase
    {
        private int numero1;
        private int numero2;
        public MiClase()
        {
            try
            {
                MiMetodo();
            }
            catch(DivideByZeroException ex)
            {
                throw ex;
            }
        }
        public MiClase(int numero)
        {
            this.numero1 = numero;
            try
            {
                MiClase m = new MiClase();
            }
            catch(DivideByZeroException ex)
            {
                throw new UnaExcepcion("Una excepciòn", ex);
            }
        }
        public static float MiMetodo()
        {
            int numero1 = 5;
            int numero2 = 0;
            float resultado;
            try
            {
                resultado =  numero1 / numero2;
            }
            catch(DivideByZeroException)
            {
                throw;
            }
            return resultado;
        }
    }
}
