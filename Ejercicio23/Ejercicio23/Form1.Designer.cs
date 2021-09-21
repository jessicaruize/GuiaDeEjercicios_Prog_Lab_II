
namespace Ejercicio23
{
    partial class txtCotizacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(txtCotizacion));
            this.btnConvertEuro = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.btnConvertPeso = new System.Windows.Forms.Button();
            this.lblEuroFilas = new System.Windows.Forms.Label();
            this.lblDolarFilas = new System.Windows.Forms.Label();
            this.lblPesoFilas = new System.Windows.Forms.Label();
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.MaskedTextBox();
            this.txtPesoAEuro = new System.Windows.Forms.MaskedTextBox();
            this.txtDolarAEuro = new System.Windows.Forms.MaskedTextBox();
            this.txtDolarADolar = new System.Windows.Forms.MaskedTextBox();
            this.txtDolarAPeso = new System.Windows.Forms.MaskedTextBox();
            this.txtEuroAPeso = new System.Windows.Forms.MaskedTextBox();
            this.txtEuroADolar = new System.Windows.Forms.MaskedTextBox();
            this.txtEuroAEuro = new System.Windows.Forms.MaskedTextBox();
            this.txtCotizacionPeso = new System.Windows.Forms.MaskedTextBox();
            this.txtCotizacionDolar = new System.Windows.Forms.MaskedTextBox();
            this.txtCotizacionEuro = new System.Windows.Forms.MaskedTextBox();
            this.txtPeso = new System.Windows.Forms.MaskedTextBox();
            this.txtDolar = new System.Windows.Forms.MaskedTextBox();
            this.txtPesoADolar = new System.Windows.Forms.MaskedTextBox();
            this.txtPesoAPeso = new System.Windows.Forms.MaskedTextBox();
            this.btnCandado = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnConvertEuro
            // 
            this.btnConvertEuro.AccessibleName = "";
            this.btnConvertEuro.Location = new System.Drawing.Point(272, 96);
            this.btnConvertEuro.Name = "btnConvertEuro";
            this.btnConvertEuro.Size = new System.Drawing.Size(75, 23);
            this.btnConvertEuro.TabIndex = 0;
            this.btnConvertEuro.Text = "->";
            this.btnConvertEuro.UseVisualStyleBackColor = true;
            this.btnConvertEuro.Click += new System.EventHandler(this.btnConvertEuro_Click);
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.AccessibleName = "";
            this.btnConvertDolar.Location = new System.Drawing.Point(272, 146);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(75, 23);
            this.btnConvertDolar.TabIndex = 1;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.btnConvertDolar_Click);
            // 
            // btnConvertPeso
            // 
            this.btnConvertPeso.AccessibleName = "";
            this.btnConvertPeso.Location = new System.Drawing.Point(272, 192);
            this.btnConvertPeso.Name = "btnConvertPeso";
            this.btnConvertPeso.Size = new System.Drawing.Size(75, 23);
            this.btnConvertPeso.TabIndex = 2;
            this.btnConvertPeso.Text = "->";
            this.btnConvertPeso.UseVisualStyleBackColor = true;
            this.btnConvertPeso.Click += new System.EventHandler(this.btnConvertPeso_Click);
            // 
            // lblEuroFilas
            // 
            this.lblEuroFilas.AccessibleName = "lblEuro";
            this.lblEuroFilas.AutoSize = true;
            this.lblEuroFilas.Location = new System.Drawing.Point(12, 106);
            this.lblEuroFilas.Name = "lblEuroFilas";
            this.lblEuroFilas.Size = new System.Drawing.Size(31, 15);
            this.lblEuroFilas.TabIndex = 3;
            this.lblEuroFilas.Text = "Euro";
            // 
            // lblDolarFilas
            // 
            this.lblDolarFilas.AccessibleName = "lblDolar";
            this.lblDolarFilas.AutoSize = true;
            this.lblDolarFilas.Location = new System.Drawing.Point(12, 156);
            this.lblDolarFilas.Name = "lblDolarFilas";
            this.lblDolarFilas.Size = new System.Drawing.Size(35, 15);
            this.lblDolarFilas.TabIndex = 4;
            this.lblDolarFilas.Text = "Dolar";
            // 
            // lblPesoFilas
            // 
            this.lblPesoFilas.AccessibleName = "lblPeso";
            this.lblPesoFilas.AutoSize = true;
            this.lblPesoFilas.Location = new System.Drawing.Point(12, 201);
            this.lblPesoFilas.Name = "lblPesoFilas";
            this.lblPesoFilas.Size = new System.Drawing.Size(32, 15);
            this.lblPesoFilas.TabIndex = 5;
            this.lblPesoFilas.Text = "Peso";
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Location = new System.Drawing.Point(156, 27);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(66, 15);
            this.lblCotizacion.TabIndex = 6;
            this.lblCotizacion.Text = "Cotizaciòn ";
            // 
            // lblEuro
            // 
            this.lblEuro.AccessibleName = "lblEuroColumna";
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(409, 62);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(31, 15);
            this.lblEuro.TabIndex = 7;
            this.lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            this.lblDolar.AccessibleName = "lblDolarColumna";
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(544, 62);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(35, 15);
            this.lblDolar.TabIndex = 8;
            this.lblDolar.Text = "Dolar";
            // 
            // lblPeso
            // 
            this.lblPeso.AccessibleName = "lblPesoColumna";
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(663, 62);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(32, 15);
            this.lblPeso.TabIndex = 9;
            this.lblPeso.Text = "Peso";
            // 
            // txtEuro
            // 
            this.txtEuro.AccessibleName = "";
            this.txtEuro.Location = new System.Drawing.Point(111, 98);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(126, 23);
            this.txtEuro.TabIndex = 3;
            // 
            // txtPesoAEuro
            // 
            this.txtPesoAEuro.AccessibleName = "";
            this.txtPesoAEuro.Enabled = false;
            this.txtPesoAEuro.Location = new System.Drawing.Point(374, 194);
            this.txtPesoAEuro.Name = "txtPesoAEuro";
            this.txtPesoAEuro.Size = new System.Drawing.Size(100, 23);
            this.txtPesoAEuro.TabIndex = 11;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.AccessibleName = "";
            this.txtDolarAEuro.Enabled = false;
            this.txtDolarAEuro.Location = new System.Drawing.Point(374, 147);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(100, 23);
            this.txtDolarAEuro.TabIndex = 12;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.AccessibleName = "";
            this.txtDolarADolar.Enabled = false;
            this.txtDolarADolar.Location = new System.Drawing.Point(509, 148);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(100, 23);
            this.txtDolarADolar.TabIndex = 13;
            // 
            // txtDolarAPeso
            // 
            this.txtDolarAPeso.AccessibleName = "";
            this.txtDolarAPeso.Enabled = false;
            this.txtDolarAPeso.Location = new System.Drawing.Point(632, 148);
            this.txtDolarAPeso.Name = "txtDolarAPeso";
            this.txtDolarAPeso.Size = new System.Drawing.Size(100, 23);
            this.txtDolarAPeso.TabIndex = 14;
            // 
            // txtEuroAPeso
            // 
            this.txtEuroAPeso.AccessibleName = "";
            this.txtEuroAPeso.Enabled = false;
            this.txtEuroAPeso.Location = new System.Drawing.Point(632, 97);
            this.txtEuroAPeso.Name = "txtEuroAPeso";
            this.txtEuroAPeso.Size = new System.Drawing.Size(100, 23);
            this.txtEuroAPeso.TabIndex = 15;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.AccessibleName = "";
            this.txtEuroADolar.Enabled = false;
            this.txtEuroADolar.Location = new System.Drawing.Point(509, 97);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(100, 23);
            this.txtEuroADolar.TabIndex = 16;
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.AccessibleName = "";
            this.txtEuroAEuro.Enabled = false;
            this.txtEuroAEuro.Location = new System.Drawing.Point(374, 98);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(100, 23);
            this.txtEuroAEuro.TabIndex = 17;
            // 
            // txtCotizacionPeso
            // 
            this.txtCotizacionPeso.AccessibleName = "";
            this.txtCotizacionPeso.Location = new System.Drawing.Point(632, 24);
            this.txtCotizacionPeso.Name = "txtCotizacionPeso";
            this.txtCotizacionPeso.Size = new System.Drawing.Size(100, 23);
            this.txtCotizacionPeso.TabIndex = 1;
            // 
            // txtCotizacionDolar
            // 
            this.txtCotizacionDolar.AccessibleName = "";
            this.txtCotizacionDolar.Enabled = false;
            this.txtCotizacionDolar.Location = new System.Drawing.Point(509, 24);
            this.txtCotizacionDolar.Name = "txtCotizacionDolar";
            this.txtCotizacionDolar.Size = new System.Drawing.Size(100, 23);
            this.txtCotizacionDolar.TabIndex = 19;
            this.txtCotizacionDolar.Text = "1";
            // 
            // txtCotizacionEuro
            // 
            this.txtCotizacionEuro.AccessibleDescription = "";
            this.txtCotizacionEuro.AccessibleName = "";
            this.txtCotizacionEuro.Location = new System.Drawing.Point(374, 24);
            this.txtCotizacionEuro.Name = "txtCotizacionEuro";
            this.txtCotizacionEuro.Size = new System.Drawing.Size(100, 23);
            this.txtCotizacionEuro.TabIndex = 0;
            this.txtCotizacionEuro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCotizacionEuro_KeyPress);
            this.txtCotizacionEuro.Leave += new System.EventHandler(this.btnCandado_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.AccessibleName = "";
            this.txtPeso.Location = new System.Drawing.Point(111, 193);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(126, 23);
            this.txtPeso.TabIndex = 5;
            this.txtPeso.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox12_MaskInputRejected);
            // 
            // txtDolar
            // 
            this.txtDolar.AccessibleName = "";
            this.txtDolar.Location = new System.Drawing.Point(111, 147);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(126, 23);
            this.txtDolar.TabIndex = 4;
            // 
            // txtPesoADolar
            // 
            this.txtPesoADolar.AccessibleName = "";
            this.txtPesoADolar.Enabled = false;
            this.txtPesoADolar.Location = new System.Drawing.Point(509, 193);
            this.txtPesoADolar.Name = "txtPesoADolar";
            this.txtPesoADolar.Size = new System.Drawing.Size(100, 23);
            this.txtPesoADolar.TabIndex = 23;
            this.txtPesoADolar.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox14_MaskInputRejected);
            // 
            // txtPesoAPeso
            // 
            this.txtPesoAPeso.AccessibleName = "";
            this.txtPesoAPeso.Enabled = false;
            this.txtPesoAPeso.Location = new System.Drawing.Point(632, 193);
            this.txtPesoAPeso.Name = "txtPesoAPeso";
            this.txtPesoAPeso.Size = new System.Drawing.Size(100, 23);
            this.txtPesoAPeso.TabIndex = 24;
            // 
            // btnCandado
            // 
            this.btnCandado.AccessibleName = "btnCandado";
            this.btnCandado.ImageIndex = 0;
            this.btnCandado.ImageList = this.imageList1;
            this.btnCandado.Location = new System.Drawing.Point(283, 9);
            this.btnCandado.Name = "btnCandado";
            this.btnCandado.Size = new System.Drawing.Size(64, 64);
            this.btnCandado.TabIndex = 25;
            this.btnCandado.UseVisualStyleBackColor = true;
            this.btnCandado.Click += new System.EventHandler(this.btnCandado_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "3643754_available_open_padlock_unlock_unlocked_icon.png");
            this.imageList1.Images.SetKeyName(1, "3643755_hide_lock_locked_padlock_private_icon.png");
            // 
            // txtCotizacion
            // 
            this.AccessibleName = "FrmCotizador";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 275);
            this.Controls.Add(this.btnCandado);
            this.Controls.Add(this.txtPesoAPeso);
            this.Controls.Add(this.txtPesoADolar);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtCotizacionEuro);
            this.Controls.Add(this.txtCotizacionDolar);
            this.Controls.Add(this.txtCotizacionPeso);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtEuroAPeso);
            this.Controls.Add(this.txtDolarAPeso);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtPesoAEuro);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblCotizacion);
            this.Controls.Add(this.lblPesoFilas);
            this.Controls.Add(this.lblDolarFilas);
            this.Controls.Add(this.lblEuroFilas);
            this.Controls.Add(this.btnConvertPeso);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnConvertEuro);
            this.Name = "txtCotizacion";
            this.Text = "Cotizador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.txtCotizacion_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertEuro;
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.Button btnConvertPeso;
        private System.Windows.Forms.Label lblEuroFilas;
        private System.Windows.Forms.Label lblDolarFilas;
        private System.Windows.Forms.Label lblPesoFilas;
        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.MaskedTextBox txtEuro;
        private System.Windows.Forms.MaskedTextBox txtPesoAEuro;
        private System.Windows.Forms.MaskedTextBox txtDolarAEuro;
        private System.Windows.Forms.MaskedTextBox txtDolarADolar;
        private System.Windows.Forms.MaskedTextBox txtDolarAPeso;
        private System.Windows.Forms.MaskedTextBox txtEuroAPeso;
        private System.Windows.Forms.MaskedTextBox txtEuroADolar;
        private System.Windows.Forms.MaskedTextBox txtEuroAEuro;
        private System.Windows.Forms.MaskedTextBox txtCotizacionPeso;
        private System.Windows.Forms.MaskedTextBox txtCotizacionDolar;
        private System.Windows.Forms.MaskedTextBox txtCotizacionEuro;
        private System.Windows.Forms.MaskedTextBox txtPeso;
        private System.Windows.Forms.MaskedTextBox txtDolar;
        private System.Windows.Forms.MaskedTextBox txtPesoADolar;
        private System.Windows.Forms.MaskedTextBox txtPesoAPeso;
        private System.Windows.Forms.Button btnCandado;
        private System.Windows.Forms.ImageList imageList1;
    }
}

