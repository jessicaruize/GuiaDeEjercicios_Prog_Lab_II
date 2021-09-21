using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;
        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
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
                return Dolar.cotizRespectoDolar;
            }

        }
        //sobrecarga explicita de Euro y Peso
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.GetCantidad * Euro.GetCotizacion);
        }
        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.GetCantidad * Peso.GetCotizacion);
        }
        //sobrecarga implicita de double
        public static implicit operator Dolar(double p)
        {
            return new Dolar(p);
        }
        //sobrecarga de operadores aritmèticos 
        public static bool operator == (Dolar d1, Dolar d2)
        {
            return d1.GetCantidad == d2.GetCantidad;
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1== d2);
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            return d.GetCantidad == e.GetCantidad;
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator ==(Dolar d, Peso p)
        {
            return d.GetCantidad == p.GetCantidad;
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad + ((Dolar)e).GetCantidad);
        }
        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.GetCantidad + (((Dolar)p).GetCantidad));
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad - ((Dolar)e).GetCantidad);
        }
        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d.GetCantidad - ((Dolar)p).GetCantidad);
        }
    }

}