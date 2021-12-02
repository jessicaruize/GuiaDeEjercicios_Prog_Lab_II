using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmAvisador
{
    public partial class FrmAvisador : Form
    {
        private Persona persona;
        public FrmAvisador()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        static void NotificarCambio(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(persona is null)
            {
                persona = new Persona();
                persona.EventoString += NotificarCambio;
                btnActualizar.Text = "Actualizar";
            }
            if(txtNombre.Text != persona.Nombre)
            {
                persona.Nombre = txtNombre.Text;
            }
            if(txtApellido.Text != persona.Apellido)
            {
                persona.Apellido = txtApellido.Text;
            }
            lblNombreCompleto.Text = persona.Mostrar();
        }
    }
}
