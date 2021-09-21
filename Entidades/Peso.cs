using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotizRespectoDolar;
        static Peso()
        {
            Peso.cotizRespectoDolar = 66;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            Peso.cotizRespectoDolar = cotizacion;
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
                return Peso.cotizRespectoDolar;
            }

        }
        //sobrecarga explicita de Dolar y Euro
        public static explicit operator Dolar(Peso e)
        {
            return new Dolar(e.GetCantidad * Peso.GetCotizacion);
        }
        public static explicit operator Euro(Peso d)
        {
            return (Euro)((Dolar)d); //pasamos el peso a dolar y el dolar a peso.
        }
        //sobrecarga implicita de double
        public static implicit operator Peso(double p)
        {
            return new Peso(p);
        }
        //sobrecarga de operadores
        public static bool operator == (Peso p1, Peso p2)
        {
            return p1.GetCantidad == p2.GetCantidad;
        }
        public static bool operator != (Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }
        public static bool operator == (Peso p, Dolar d)
        {
            return p.GetCantidad == d.GetCantidad;
        }
        public static bool operator != (Peso p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator == (Peso p, Euro e)
        {
            return p.GetCantidad == e.GetCantidad;
        }
        public static bool operator != (Peso p, Euro e)
        {
            return !(p == e);
        }
        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad + ((Peso)d).GetCantidad);
        }
        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.GetCantidad + ((Peso)e).GetCantidad);
        }
        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad - ((Peso)d).GetCantidad);
        }
        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.GetCantidad - ((Peso)e).GetCantidad);
        }
    }
}