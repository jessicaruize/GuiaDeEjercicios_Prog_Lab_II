using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        private float perimetro;
        private float area;
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());
        }
        public float Area()
        {
            int ancho;
            int alto;
            ancho = Math.Abs(vertice1.GetX() - vertice3.GetX());
            alto = Math.Abs(vertice1.GetY() - vertice3.GetY());
            this.area = ancho * alto;
            return this.area;
        }

        public float Perimetro()
        {
            int ancho;
            int alto;
            ancho = Math.Abs(vertice1.GetX() - vertice3.GetX());
            alto = Math.Abs(vertice1.GetY() - vertice3.GetY());
            this.perimetro = (ancho + alto) * 2;
            return this.perimetro;
        }
    }    
}
