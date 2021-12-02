﻿using System;
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
        Task tarea;
        public Form1()
        {
            InitializeComponent();
            tarea = new Task(ActualizarHora);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.timer1.Enabled = true;
            //timer1.Interval = 1000;
            tarea.Start();
        }
        public void ActualizarHora()
        {
            while (true)
            {
                AsignarHora();
                Thread.Sleep(1000);
            }
        }
        public void AsignarHora()
        {
            if (lblHora.InvokeRequired)
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
