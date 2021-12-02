using Biblioteca;
using System;

namespace NotasAlumno
{
    class Program
    {/*a. Se pide crear 3 instancias de la clase Alumno (3 objetos) en la función Main. 
         * Colocarle  nombre, apellido y legajo a cada uno de ellos.  
         * b. Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar. 
         * c. El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 
         * son mayores o iguales a 4, caso contrario la inicializará con -1. 
         * Para darle un valor a la nota final utilice el método de instancia Next de la clase Random. 
         * d. El método Mostrar, expondrá en la consola todos los datos de los alumnos. 
         * La nota final se  mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno  desaprobado". 
*/
        static void Main(string[] args)
        {
            Alumno alumnoUno = new Alumno("Antonia", "Gomez", 1);
            Alumno alumnoDos = new Alumno("Gabriel", "Diaz", 2);
            Alumno alumnoTres = new Alumno("Pablo", "Bianchet", 3);
            alumnoUno.Estudiar(1, 6);
            alumnoDos.Estudiar(4, 9);
            alumnoTres.Estudiar(8, 3);
            alumnoUno.calcularFinal();
            alumnoDos.calcularFinal();
            alumnoTres.calcularFinal();

            Console.WriteLine(alumnoUno.Mostrar());
            Console.WriteLine(alumnoDos.Mostrar());
            Console.WriteLine(alumnoTres.Mostrar());
        }
    }
}
