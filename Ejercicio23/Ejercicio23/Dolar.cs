using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
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
        public double Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                if(value > 0)
                this.cantidad = value;
            }
        }
        public static double Cotizacion
        {
            get
            {
                return Dolar.cotizRespectoDolar;
            }

        }
        //sobrecarga explicita de Euro y Peso
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.Cantidad * Euro.Cotizacion);
        }
        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.Cantidad * Peso.Cotizacion);
        }
        //sobrecarga implicita de double
        public static implicit operator Dolar(double p)
        {
            return new Dolar(p);
        }
        //sobrecarga de operadores aritmèticos 
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.Cantidad == d2.Cantidad;
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            return d.Cantidad == e.Cantidad;
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator ==(Dolar d, Peso p)
        {
            return d.Cantidad == p.Cantidad;
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.Cantidad + ((Dolar)e).Cantidad);
        }
        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.Cantidad + (((Dolar)p).Cantidad));
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.Cantidad - ((Dolar)e).Cantidad);
        }
        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d.Cantidad - ((Dolar)p).Cantidad);
        }
    }

}
