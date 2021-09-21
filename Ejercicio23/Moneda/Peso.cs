using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
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
                return Peso.cotizRespectoDolar;
            }
            set
            {
                Peso.cotizRespectoDolar = value;
            }

        }
        //sobrecarga explicita de Dolar y Euro
        public static explicit operator Dolar(Peso e)
        {
            return new Dolar(e.Cantidad * Peso.Cotizacion);
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
        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.Cantidad == p2.Cantidad;
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Peso p, Dolar d)
        {
            return p.Cantidad == d.Cantidad;
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator ==(Peso p, Euro e)
        {
            return p.Cantidad == e.Cantidad;
        }
        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }
        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.Cantidad + ((Peso)d).Cantidad);
        }
        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.Cantidad + ((Peso)e).Cantidad);
        }
        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.Cantidad - ((Peso)d).Cantidad);
        }
        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.Cantidad - ((Peso)e).Cantidad);
        }
    }
}
