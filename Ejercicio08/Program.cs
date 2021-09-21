using System;

namespace Ejercicio08
{   /*Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y 
     * la cantidad de horas  trabajadas en el mes de N empleados de una fábrica 
     * Se pide calcular el importe a cobrar teniendo en cuenta que el total 
     * (que resulta de multiplicar el  valor hora por la cantidad de horas trabajadas), 
     * hay que sumarle la cantidad de años trabajados  multiplicados por $ 150, 
     * y al total de todas esas operaciones restarle el 13% en concepto de  descuentos. 
     * Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, 
     * el total a cobrar en  bruto, el total de descuentos y el valor neto a cobrar de 
     * todos los empleados ingresados. Nota: Utilizar estructuras repetitivas y selectivas. */
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "";
            float valorHora;
            string nombre;
            int antiguedad;
            int horasTrabajadas;
            string seguir;
            float totalBruto;
            float descuento;
            do
            {
                Console.WriteLine("Ingrese el valor hora: ");
                valorHora = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre: ");
                nombre = (Console.ReadLine());
                Console.WriteLine("Ingrese la antiguedad en años: ");
                antiguedad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese las horas trabajadas: ");
                horasTrabajadas = int.Parse(Console.ReadLine());
                totalBruto = horasTrabajadas * valorHora + (antiguedad * 150);
                descuento = totalBruto * (float)0.13;

                txt += "\n\nNombre: " + nombre + "\nAntiguedad: " + antiguedad + " años. \nValor de hora: " + valorHora + "\nTotal a cobrar en bruto: " + totalBruto + 
                        "\nTotal de descuento: " + descuento + "\nValor neto: " + (totalBruto - descuento);
                Console.WriteLine("¡Desea seguir? ");
                seguir = (Console.ReadLine());

            } while (seguir.ToLower() == "s");
            Console.WriteLine(txt);
            Console.ReadKey();
        }
    }
}
