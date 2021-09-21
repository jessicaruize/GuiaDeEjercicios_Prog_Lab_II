using System;
using Geometria;
namespace PruebaGeometria
{
    class Program
    {
        /*Escribir una aplicación con estos dos espacios de nombres (namespaces): Geometría y  PruebaGeometria. 
         * Dentro del espacio de nombres Geometría se deberán escribir dos clases: Punto y Rectángulo.
         * a. La clase Punto ha de tener dos atributos privados con acceso de sólo lectura 
         * (sólo con  getters), que serán las coordenadas del punto. 
         * También un constructor que reciba los  parámetros x e y. 
         * b. La clase Rectángulo tiene los atributos de tipo Punto vertice1, vertice2, vertice3 y vertice4  
         * (que corresponden a los cuatro vértices del rectángulo). 
         * c. La base de todos los rectángulos de esta clase será siempre horizontal. 
         * Por lo tanto, debe  tener un constructor para construir el rectángulo por medio de los vértices 1 y 3 
         * (utilizar el  método Abs de la clase Math, dicho método retorna el valor absoluto de un número, para  obtener la distancia entre puntos). 
         * d. Realizar los métodos getters para los atributos privados área y perímetro. 
         * e. Los atributos área (base * altura) y perímetro ((base + altura)*2) se deberán calcular sólo  una vez, 
         * al llamar por primera vez a su correspondiente método getter (GetArea y GetPerimetro de la clase Rectángulo creados en el punto anterior). 
         * Luego, cada vez que se  invoque a los métodos Área y Perímetro, se deberá retornar siempre el valor calculado  anteriormente. 
         * En el espacio de nombres PruebaGeometria es donde se escribirá una clase con el método Main. 
         * f. Probar las funcionalidades de las clases Punto y Rectángulo. 
         * i. Generar un nuevo Rectángulo. ii. Imprimir por pantalla los valores de área y perímetro. 
         * g. Desarrollar un método de clase que muestre todos los datos del rectángulo que recibe como  parámetro. */
        static void Main(string[] args)
        {
            Punto punto1 = new Punto(3, 7);
            Punto punto2 = new Punto(10, 15);
            Rectangulo rectangulo = new Rectangulo(punto1, punto2);
            Console.WriteLine(Program.Mostrar(rectangulo));
        }
        public static string Mostrar(Rectangulo rectangulo)
        {
            string cadena;
            float area;
            float perimetro;
            area = rectangulo.Area();
            perimetro = rectangulo.Perimetro();
            cadena = "Area = " + area + "\nPerimetro =" + perimetro + ".";
            return cadena;
        }
    }
}
