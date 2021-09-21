using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string nombre;
        public string  apellido;
        public int legajo;

        public Alumno(string nombre, string apellido, int legajo)
        {
            if (!(nombre is null) && !(apellido is null) && legajo > 0)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.legajo = legajo;
            }
        }
        public void Estudiar (byte notaUno, byte notaDos)
        {
            if (notaUno > 0 && notaDos > 0)
            {
                this.nota1 = notaUno;
                this.nota2 = notaDos;
            }
        }

        public void calcularFinal()
        {
            Random rng = new Random();
            if(this.nota1 > 3 && this.nota2 > 3)
            {
                this.notaFinal = rng.Next(1, 10); 
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public string Mostrar()
        {
            string mensaje;
            mensaje = "Alumno " + this.nombre + this.apellido + " con legajo nùmero " +
                       this.legajo + ". \nPrimer nota: " + this.nota1 + "\nSegunda nota: " +
                       nota2 + "\nNota final: ";
            if(notaFinal != -1)
            {
                mensaje += this.notaFinal + "\n\n";
            }
            else
            {
                mensaje += "Alumno desaprobado.\n\n";
            }
            return mensaje;
        }

    }
}
