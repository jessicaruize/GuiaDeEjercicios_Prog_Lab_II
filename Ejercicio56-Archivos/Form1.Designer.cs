
namespace Ejercicio56_Archivos
{
    partial class NotePad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.msAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.msGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.msGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ssCantidadCaracteres = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbTexto
            // 
            this.rtbTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTexto.Location = new System.Drawing.Point(0, 24);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(514, 412);
            this.rtbTexto.TabIndex = 0;
            this.rtbTexto.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msArchivo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msArchivo
            // 
            this.msArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAbrir,
            this.msGuardar,
            this.msGuardarComo});
            this.msArchivo.Name = "msArchivo";
            this.msArchivo.Size = new System.Drawing.Size(60, 20);
            this.msArchivo.Text = "Archivo";
            // 
            // msAbrir
            // 
            this.msAbrir.Name = "msAbrir";
            this.msAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.msAbrir.Size = new System.Drawing.Size(269, 22);
            this.msAbrir.Text = "Abrir";
            this.msAbrir.Click += new System.EventHandler(this.msAbrir_Click);
            // 
            // msGuardar
            // 
            this.msGuardar.Name = "msGuardar";
            this.msGuardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.msGuardar.Size = new System.Drawing.Size(269, 22);
            this.msGuardar.Text = "Guardar";
            this.msGuardar.Click += new System.EventHandler(this.msGuardar_Click);
            // 
            // msGuardarComo
            // 
            this.msGuardarComo.Name = "msGuardarComo";
            this.msGuardarComo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.msGuardarComo.Size = new System.Drawing.Size(269, 22);
            this.msGuardarComo.Text = "Guardar como...";
            this.msGuardarComo.Click += new System.EventHandler(this.msGuardarComo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssCantidadCaracteres});
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(514, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ssCantidadCaracteres
            // 
            this.ssCantidadCaracteres.Name = "ssCantidadCaracteres";
            this.ssCantidadCaracteres.Size = new System.Drawing.Size(118, 17);
            this.ssCantidadCaracteres.Text = "toolStripStatusLabel1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NotePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 436);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rtbTexto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NotePad";
            this.Text = "Cuadernillo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msArchivo;
        private System.Windows.Forms.ToolStripMenuItem msAbrir;
        private System.Windows.Forms.ToolStripMenuItem msGuardar;
        private System.Windows.Forms.ToolStripMenuItem msGuardarComo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ssCantidadCaracteres;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

