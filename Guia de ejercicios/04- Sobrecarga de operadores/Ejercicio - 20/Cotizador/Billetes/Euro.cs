using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;
        static Euro()
        {
            Euro.cotizRespectoDolar = 1 / 1.08;    
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizaciòn):this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizaciòn;
        }
        public double GetCantidad
        {
            get
            {
                return this.cantidad;
            }
        }
        public static double GetCotizacion
        {
            get
            {
                return Euro.cotizRespectoDolar;
            }

        }
        //sobrecargas explicitas para Dolar y Peso
        public static explicit operator Dolar(Euro p)
        {
            return new Dolar((p.cantidad / Euro.GetCotizacion));
        }
        public static explicit operator Peso(Euro e)
        {

            return (Peso)((Dolar)e); //pasamos Euro a Dolar y Dolar a Peso (esta en la clase Dolar)
        }
        //sobrecarga implicita de Double 
        public static implicit operator Euro(double p)
        {
            return new Euro(p);
        }
        //comparadores y sobrecarga de operadores aritmèticos.
        public static bool operator == (Euro e1, Euro e2)
        {
            return e1.GetCantidad == e2.GetCantidad;
        }
        public static bool operator != (Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        public static bool operator == (Euro e, Peso p)
        {
            return e.GetCantidad == p.GetCantidad;
        }
        public static bool operator != (Euro e, Peso p)
        {
            return !(e == p);
        }
        public static bool operator == (Euro e, Dolar d)
        {
            return e.GetCantidad == d.GetCantidad;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad + ((Euro)d).GetCantidad);
        }
        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad + ((Euro)p).GetCantidad);
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad - ((Euro)d).GetCantidad);
        }
        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad - ((Euro)p).GetCantidad);
        }
    }
}
