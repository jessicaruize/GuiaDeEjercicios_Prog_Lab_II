using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }
       public ConsoleColor getColor()
       {
            return this.color;
       }
        public short GetTinta()
        {
            return this.tinta;
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "";
            bool aux;
            if(this.tinta >= gasto)
            {
                for(int i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                }
            }
            else
            {
                for(int i = 0; i < this.tinta; i++)
                {
                    dibujo += "*";
                }
            }
            aux = this.tinta >= 0;
            SetTinta(gasto);
            return aux;
        }

        public void recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        private void SetTinta(short tinta)
        {
            this.tinta += tinta;
            if(this.tinta < 0)
            {
                this.tinta = 0;
            }
            if(this.tinta > cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
        }

    }
}
