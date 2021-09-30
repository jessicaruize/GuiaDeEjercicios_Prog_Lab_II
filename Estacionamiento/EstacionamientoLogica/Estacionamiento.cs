using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoLogica
{
    public class Estacionamiento
    {
        private int capacidadEstacionamiento;
        private static Estacionamiento estacionamiento;
        private List<Vehiculo> listadoVehiculos;
        private string nombre;
        public List<Vehiculo> ListadoVehiculos
        {
            get
            {
                return this.listadoVehiculos;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        private Estacionamiento(string nombre, int capacidad)
        {
            List<Vehiculo> estacionamiento = new List<Vehiculo>(); //inicializa lista de vehiculos.
            this.nombre = nombre;
            this.capacidadEstacionamiento = capacidad;
        }
        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {
            if(Estacionamiento.estacionamiento is null)
            {
                Estacionamiento.estacionamiento = new Estacionamiento(nombre, capacidad);
            }
            else
            {
                Estacionamiento.estacionamiento.capacidadEstacionamiento = capacidad;
            }
            return Estacionamiento.estacionamiento;
        }
        public string InformarSalida(Vehiculo vehiculo)
        {
            string cadena = "Estacionamiento: " + this.Nombre + vehiculo.ToString()
                + "\nHora de salida: " + vehiculo.HoraEgreso + "\nTotal a pagar: " + vehiculo.CostoEstadia.ToString("00.0");
            return cadena;
        }
        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (Estacionamiento.estacionamiento.listadoVehiculos.Count > 0)
            {
                foreach (Vehiculo item in estacionamiento.ListadoVehiculos)
                {
                    if (item == vehiculo)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }
        public static bool operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento != vehiculo && estacionamiento.ListadoVehiculos.Count < estacionamiento.capacidadEstacionamiento)
            {
                Estacionamiento.estacionamiento.ListadoVehiculos.Add(vehiculo);
                return true;
            }
            return false;
        }
        public static bool operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento == vehiculo)
            {
                vehiculo.HoraEgreso = DateTime.Now;
                Estacionamiento.estacionamiento.ListadoVehiculos.Remove(vehiculo);
                return true;
            }
            return false;
        }
    }
}
