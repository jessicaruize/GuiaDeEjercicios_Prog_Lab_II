using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relojero
{
    public partial class Form1 : Form
    {
        Temporizador temporizador;
        public Form1()
        {
            InitializeComponent();
            this.temporizador = new Temporizador();
            this.temporizador.EventoTiempo += ActualizarHora;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void ActualizarHora()
        {
            if(this.InvokeRequired)
            {
                EncargadoTiempo calback = new EncargadoTiempo(ActualizarHora);
                this.Invoke(calback);
            }
            else
            {
                this.lblHora.Text = DateTime.Now.ToString("HH:MM:ss");
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(!this.temporizador.EstaActivo)
            {
                temporizador.EstaActivo = true;
                this.btnIniciar.Text = "Detener";
            }
            else
            {
                this.temporizador.EstaActivo = false;
                this.btnIniciar.Text = "Iniciar";
            }
        }

        private void nudIntervalo_ValueChanged(object sender, EventArgs e)
        {
            this.temporizador.Intervalo = ((int)this.nudIntervalo.Value * 1000);
        }
    }
}
