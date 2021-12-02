using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_BaseDeDatos
{
    public class Persona
    {
        private static SqlConnection conn;
        private static SqlCommand command;

        private int id;
        private string nombre;
        private string apellido;
        public Persona()
        {
            string connString = @"Data Source=DESKTOP-TGPB9LS\MSSQLSERVER01; Initial Catalog=Kiosco; Integrated Security=True";
            Persona.conn = new SqlConnection(connString);
            Persona.command = new SqlCommand();
            Persona.command.CommandType = System.Data.CommandType.Text;
            Persona.command.Connection = Persona.conn;
        }


        public Persona(int id, string nombre, string apellido) : this(nombre, apellido)
        {
            this.id = id;
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => Apellido; set => Apellido = value; }
        public virtual string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine($"ID Nº {this.Id} persona {this.Nombre} {this.Apellido}.");
            return cadena.ToString();
        }
        public static List<Persona> GetLista()
        {
            List<Persona> personas = new List<Persona>();
            Persona.command.CommandText = "Select nombre,edad,estadoDeVida From personas";
            try
            {
                Persona.conn.Open();
                SqlDataReader reader = Persona.command.ExecuteReader();
                while (reader.Read())
                {
                    Persona p = new Persona();
                    p.Nombre = reader["nombre"].ToString();
                    p.Edad = int.Parse(reader["edad"].ToString());
                    p.Vive = bool.Parse(reader["estadoDeVida"].ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Persona.conn.Close();
            }
            return personas;
        }
        public static void Delete(decimal id)
        {
            Persona.command.CommandText = "Delete From persona where id = " + id;

        }
        public static void Update(decimal id)
        {
            Persona.command.CommandText = "Update From persona where id = " + id;
        }
        private static void nomQuery(string sql)
        {
            Persona.command.CommandText = sql;
            try
            {
                Persona.conn.Open();
                Persona.command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Persona.conn.Close();
            }
        }
    }
}
