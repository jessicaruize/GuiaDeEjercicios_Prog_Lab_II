using System;
using System.Runtime.Serialization;
using System.Text.Json;

namespace Ejercicio57
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Pablo", "bianchet");
            Persona p2 = new Persona("Jessica", "Ruiz");
            try
            {
                Persona.GuardarJson(p1, "Prueba.json");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                p2 = Persona.LeerJson("Prueba.json");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (JsonException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("3");
            }

            try
            {
                p1.GuardadBinario(p1, "personaB");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SerializationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                 p2 = p2.LeerBinario("personaB");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SerializationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(p2.ToString());
        }
    }
}
