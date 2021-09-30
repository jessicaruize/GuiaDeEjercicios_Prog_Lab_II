using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01CladeDeIntroduccion
{
    class Encapsulamiento
    {
        static void Main(string[] args)
        {
            //ENUMERADOS.
            DiasDeLaSemana dia = DiasDeLaSemana.Lunes;
            int i = (int)DiasDeLaSemana.Lunes;

            Console.WriteLine((int)dia); //1
            Console.WriteLine(i); //1
            Console.WriteLine(dia); //Lunes
            Console.WriteLine(DiasDeLaSemana.Lunes); //Lunes

            //INDEXADORES
            RegistoTemperaturas registro = new RegistoTemperaturas();
            int indice = 2;
            float temperatura = registro[indice];
            Console.WriteLine(temperatura);
            registro[indice] = 55.5F;
            Console.WriteLine(temperatura);
        }
    }
    //ENUMERADOS (Se declaran dentro de una clase(anidado) o dentro de un namespace)
    public enum DiasDeLaSemana
    {
        Domingo, //0 por defecto
        Lunes,   //1 por defecto
        Martes,     //3 por defecto, si lo cambio a 10
        Miercoles,   //por defecto este sera 11
        Jueves,
        Viernes,
        Sabado
    }

    public class RegistoTemperaturas
    {
        private float[] temperaturas = new float[10]
        {
            56.3F, 23.5F, 76.2F, 60.5F, 23.5F, 65.7F, 54.3F, 27.4F, 54.7F, 25.9F
        };
        //INDEXADOR
        public float this[int index]
        {
            get
            {
                return temperaturas[index];
            }
            set
            {
                temperaturas[index] = value;
            }
        }
    }
}
}
