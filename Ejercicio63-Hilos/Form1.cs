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

namespace Ejercicio63_Hilos
{
    public partial class FormHora : Form
    {
        Task tarea;
        public FormHora()
        {
            tarea = new Task(ActualizarHora);
            InitializeComponent();
        }

        private void FormHora_Load(object sender, EventArgs e)
        {
            //this.timer1.Enabled = true;
            //timer1.Interval = 1000;
            tarea.Start();
        }
        public void ActualizarHora()
        {
            while(true)
            {
                AsignarHora();
                Thread.Sleep(1000);
            }
        }
        public void AsignarHora()
        {
            if(lblHora.InvokeRequired)
            {
                Action delegado = AsignarHora; // delegado guarda la direccion de memoria de "AsignarHora" para luego usarla en el hilo principal
                this.Invoke(delegado); //invoca desde el hilo principal
            }
            else
            {
                lblHora.Text = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss");
            }
            //lblHora.Text = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.AsignarHora();
        }
    }
}
