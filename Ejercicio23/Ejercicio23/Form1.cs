using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;
namespace Ejercicio23
{
    public partial class txtCotizacion : Form
    {
        Euro euro = new Euro(0);
        Dolar dolar= new Dolar(0);
        Peso peso = new Peso(0);
       
        public txtCotizacion()
        {
            InitializeComponent();
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            this.euro.Cantidad = Convert.ToDouble(txtEuro);
            this.txtEuroAEuro.Text = this.euro.Cantidad.ToString();
            this.txtEuroAPeso.Text = ((Peso)euro).Cantidad.ToString();
            this.txtEuroADolar.Text = ((Dolar)euro).Cantidad.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCandado_Click(object sender, EventArgs e)
        {
            int aux = 0;
            if(txtCotizacionEuro.Text == "")
            {
                aux = 3;
                txtCotizacionEuro.Focus();
            }
            else
            {
                Euro.Cotizacion = Convert.ToDouble(txtCotizacionEuro.Text);
                this.txtCotizacionEuro.Enabled = false;
            }
            if(txtCotizacionPeso.Text == "")
            {
                aux = 3;
                txtCotizacionPeso.Focus();
            }
            else
            {
                Peso.Cotizacion = Convert.ToDouble(txtCotizacionPeso.Text);
                this.txtCotizacionPeso.Enabled = false;
            }
            if(aux == 0)
            {
                this.btnCandado.ImageIndex = 1;  
            }
            else
            {
                if(aux == 1)
                {
                    this.btnCandado.ImageIndex = 0;
                }
            }
         }

        private void maskedTextBox12_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox14_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            dolar.Cantidad = Convert.ToDouble(txtCotizacionDolar);

        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            peso.Cantidad = Convert.ToDouble(txtCotizacionPeso);
        }

        private void txtCotizacionEuro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar))
            {

            }
        }

        private void txtCotizacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Esta seguro de salir?","Salir",MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
