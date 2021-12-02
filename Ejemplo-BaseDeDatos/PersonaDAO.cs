using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejemplo_BaseDeDatos
{
    public class PersonaDAO
    {
        private SqlConnection conn;
        private SqlCommand command;
        public PersonaDAO()
        {
            string connString = @"Data Source=DESKTOP-TGPB9LS\MSSQLSERVER01; Initial Catalog=Kiosco; Integrated Security=True";
            this.conn = new SqlConnection(connString);
            this.command = new SqlCommand();
            //this.command.CommandType = System.Data.CommandType.Text; // es por default, no hace falta.
            this.command.Connection = this.conn;
        }
        public void Guardar(Persona p)
        {
            command.Parameters.AddWithValue("@nombre", p.Nombre);
            command.Parameters.AddWithValue("@Apellido", p.Apellido);
            this.Ejecutar("INSERT INTO Personas (nombre,apellido) VALUE (@nombre, @apellido)");
        }
        public List<Persona> Leer()
        {
            this.Ejecutar("SELECT id, nombre, apellido FROM personas");
               
            SqlDataReader oDr = command.ExecuteReader();
            List<Persona> lista = new List<Persona>();
            while(oDr.Read())
            {
                int id;
                string nombre = oDr["nombre"].ToString();
                string apellido = oDr["apellido"].ToString();
                int.TryParse(oDr["id"].ToString(), out id);
                Persona persona = new Persona(id, nombre, apellido);
                lista.Add(persona);
            }
            return lista;
            
        }
        public void LeerPorId(Persona p)
        {
            this.command.CommandText = $"SELECT Personas.id, Personas.nombre, Personas.Apellido FROM Personas";
            this.command.Parameters.Add(new SqlParameter("ID", p.Id));
            //this.Ejecutar();
        }
        public void Modificar(Persona p)
        {
            this.Ejecutar($"UPDATE personas SET nombre = {p.Nombre}, apellido = {p.Apellido} WHERE id = {p.Id}");
        }
        public void Borrar(Persona p)
        {
            this.command.Parameters.AddWithValue("@id", p.Id);
            this.Ejecutar("Delete From persona where id = @ID");

        }
        private bool Ejecutar(string comando)
        {
            bool retorno = false;
            this.command.CommandText = comando;
            try
            {
                if(this.conn.State != System.Data.ConnectionState.Open && this.conn.State != System.Data.ConnectionState.Connecting)
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                this.conn.Close();
                this.command.Parameters.Clear();
                retorno =  true;
            }
            return retorno; ;
        }
    }
}
