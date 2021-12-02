using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Ejercicio57
{
    [Serializable]
    public class Persona
    {
        private Stream fs;
        private BinaryFormatter ser;
        private string nombre;
        private string apellido;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public Persona()
        {

        }
        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        public static void GuardarJson(Persona p, string path)
        {
            string jsonString = JsonSerializer.Serialize(p);
            try
            {
                using (StreamWriter streamWrite = new StreamWriter(path))
                {
                    streamWrite.WriteLine(jsonString);
                }
            }
            catch (ArgumentException)
            {
                throw;
            }
        }
        public static Persona LeerJson(string path)
        {
            string aux = string.Empty;
            try
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    while(!streamReader.EndOfStream)
                    {
                        aux += $"{streamReader.ReadLine()}\n";
                    }
                }
                return JsonSerializer.Deserialize<Persona>(aux);
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch(JsonException)
            {
                throw;
            }
        }
        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido;
        }

        public void GuardadBinario(Persona p, string path)
        {
            try
            {
                //Se indica la ubicación del archivo binario y el modo
                fs = new FileStream(path, FileMode.Create);
                //Se crea el objeto serializador
                ser = new BinaryFormatter();
                //Serializa el objeto p en el archivo contenido en fs
                ser.Serialize(fs, p);
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (SerializationException)
            {
                throw;
            }
            finally
            {
                //Se cierra el objeto fs
                fs.Close();
            }
        }
        public Persona LeerBinario(string path)
        {
            Persona p;
            //Se indica la ubicación del archivo binario y el modo
            fs = new FileStream(path, FileMode.Open);
            //Se crea el objeto serializador
            ser = new BinaryFormatter();
            //Serializa el objeto p en el archivo contenido en fs
            p = (Persona)ser.Deserialize(fs);
            //Se cierra el objeto fs
            fs.Close();
            return p;
        }

    }
}
