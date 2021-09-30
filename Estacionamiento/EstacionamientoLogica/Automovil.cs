﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoLogica
{
    public class Automovil : Vehiculo
    {
        private string marca;
        private static double valorHora;

        static Automovil() //Constructor de clase
        {
            valorHora = 120;
        }
        public Automovil(string patente, DateTime horaIngreso, string marca) //Constructor de instancia
            : base(patente, horaIngreso)
        {
            this.marca = marca;
        }
        public override double CostoEstadia
        {
            get
            {
                return this.CargoDeEstacionamiento();
            }
        }
        public override string Descripcion
        {
            get
            {
                return this.marca;
            }
        }
        public static double ValorHora
        {
            set
            {
                if (value > 0)
                {
                    Automovil.valorHora = value;
                }
            }
        }
        protected override double CargoDeEstacionamiento()
        {
            return Automovil.valorHora * base.CargoDeEstacionamiento();
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("****AUTOMOVIL****");
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Marca: {this.Descripcion}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }

    }
}
