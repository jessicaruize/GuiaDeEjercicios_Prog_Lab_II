using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio56_Archivos
{

    public partial class NotePad : Form
    {
        OpenFileDialog openFileDialog; //encontrar ruta del archivo que deseammos abrir.
        SaveFileDialog saveFileDialog; //encontrar ruta del archivo que queremos salvar
        string archivo;
        public NotePad()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ssCantidadCaracteres.Text = "0 Caracteres";
        }

        private void msAbrir_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    archivo = openFileDialog.FileName;
                    using (StreamReader streamReader = new StreamReader(archivo))
                    {
                        rtbTexto.Text = streamReader.ReadToEnd();
                    }
                }
                catch(Exception ex)
                {
                    this.MostrarMEnsajeError(ex);
                }
            }
        }
        private void MostrarMEnsajeError(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Error: {ex.Message}");
            sb.AppendLine(ex.StackTrace);
            MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void msGuardar_Click(object sender, EventArgs e)
        {
            if(!File.Exists(archivo))
            {
                GuardarArchivoFileDialog();
            }
            else
            {
                GuardarArchivo(archivo);
            }
        }

        private void msGuardarComo_Click(object sender, EventArgs e)
        {
            GuardarArchivoFileDialog();
        }
        private void GuardarArchivoFileDialog()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                archivo = saveFileDialog.FileName;
                GuardarArchivo(archivo);
            }
        }
        private void GuardarArchivo(string ruta)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {
                    streamWriter.Write(rtbTexto.Text);
                }
            }
            catch (Exception ex)
            {
                this.MostrarMEnsajeError(ex);
            }
        }
    }
}
