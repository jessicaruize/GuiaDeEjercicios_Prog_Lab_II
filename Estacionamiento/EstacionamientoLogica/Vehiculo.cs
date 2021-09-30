using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoLogica
{
    public abstract class Vehiculo
    {
        private DateTime horaEgreso;
        private DateTime horaIngreso;
        private string patente;
        public enum EVehiculos
        {
            Automovil,
            Moto
        }
        public Vehiculo(string patente, DateTime horaIngreso)
        {
            this.Patente = patente;
            this.horaIngreso = horaIngreso;
        }
        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if (this.ValidarPatente(value))
                {
                    this.patente = value;
                }
            }
        }
        public DateTime HoraEgreso
        { 
            get
            {
                return this.horaEgreso;
            }
            set
            {
                if(value > this.horaIngreso)
                {
                    this.horaEgreso = value;
                }
            }
        }
        public DateTime HoraIngreso
        {
            get
            {
                return this.horaIngreso;
            }
        }
        public abstract string Descripcion { get; }
        public abstract  double CostoEstadia { get; }
        protected virtual double CargoDeEstacionamiento()
        {
            double horasAcumuladas = 0;
            if(this.HoraEgreso > this.HoraIngreso)
            {
                horasAcumuladas = (this.HoraEgreso - this.HoraIngreso).TotalHours;
            }
            return horasAcumuladas;
        }
        protected virtual string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine($"Patente : {this.Patente}");
            cadena.AppendLine($"Hora de ingreso : {this.HoraIngreso}");
            return cadena.ToString();
        }
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.Patente == v2.Patente;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        private bool ValidarPatente(string patente)
        {
            return (patente.Length > 5 && patente.Length < 8);
        }
        
    }
}
