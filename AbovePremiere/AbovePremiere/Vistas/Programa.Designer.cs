namespace AbovePremiere.Vistas
{
    partial class Programa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCambiarFormato = new System.Windows.Forms.Button();
            this.buttonRemoverAudio = new System.Windows.Forms.Button();
            this.buttonExtraerAudio = new System.Windows.Forms.Button();
            this.buttonSeleccionarArchivo = new System.Windows.Forms.Button();
            this.textBoxArchivo = new System.Windows.Forms.TextBox();
            this.textBoxResolucionOriginal = new System.Windows.Forms.TextBox();
            this.buttonCambiarResolucion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFormatoOriginal = new System.Windows.Forms.TextBox();
            this.textBoxFormatoNuevo = new System.Windows.Forms.TextBox();
            this.textBoxResolucionNueva = new System.Windows.Forms.TextBox();
            this.buttonImagenes = new System.Windows.Forms.Button();
            this.textBoxImagenes = new System.Windows.Forms.TextBox();
            this.labelFrames = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCambiarFormato
            // 
            this.buttonCambiarFormato.Enabled = false;
            this.buttonCambiarFormato.Location = new System.Drawing.Point(170, 152);
            this.buttonCambiarFormato.Name = "buttonCambiarFormato";
            this.buttonCambiarFormato.Size = new System.Drawing.Size(112, 23);
            this.buttonCambiarFormato.TabIndex = 0;
            this.buttonCambiarFormato.Text = "Cambiar formato";
            this.buttonCambiarFormato.UseVisualStyleBackColor = true;
            this.buttonCambiarFormato.Click += new System.EventHandler(this.buttonCambiarFormato_Click);
            // 
            // buttonRemoverAudio
            // 
            this.buttonRemoverAudio.Enabled = false;
            this.buttonRemoverAudio.Location = new System.Drawing.Point(513, 152);
            this.buttonRemoverAudio.Name = "buttonRemoverAudio";
            this.buttonRemoverAudio.Size = new System.Drawing.Size(117, 23);
            this.buttonRemoverAudio.TabIndex = 1;
            this.buttonRemoverAudio.Text = "Remover audio";
            this.buttonRemoverAudio.UseVisualStyleBackColor = true;
            this.buttonRemoverAudio.Click += new System.EventHandler(this.buttonRemoverAudio_Click);
            // 
            // buttonExtraerAudio
            // 
            this.buttonExtraerAudio.Enabled = false;
            this.buttonExtraerAudio.Location = new System.Drawing.Point(650, 152);
            this.buttonExtraerAudio.Name = "buttonExtraerAudio";
            this.buttonExtraerAudio.Size = new System.Drawing.Size(99, 23);
            this.buttonExtraerAudio.TabIndex = 3;
            this.buttonExtraerAudio.Text = "Extraer audio";
            this.buttonExtraerAudio.UseVisualStyleBackColor = true;
            this.buttonExtraerAudio.Click += new System.EventHandler(this.buttonExtraerAudio_Click);
            // 
            // buttonSeleccionarArchivo
            // 
            this.buttonSeleccionarArchivo.Location = new System.Drawing.Point(659, 12);
            this.buttonSeleccionarArchivo.Name = "buttonSeleccionarArchivo";
            this.buttonSeleccionarArchivo.Size = new System.Drawing.Size(129, 23);
            this.buttonSeleccionarArchivo.TabIndex = 4;
            this.buttonSeleccionarArchivo.Text = "Seleccionar Archivo...";
            this.buttonSeleccionarArchivo.UseVisualStyleBackColor = true;
            this.buttonSeleccionarArchivo.Click += new System.EventHandler(this.buttonSeleccionarArchivo_Click);
            // 
            // textBoxArchivo
            // 
            this.textBoxArchivo.Location = new System.Drawing.Point(438, 12);
            this.textBoxArchivo.Name = "textBoxArchivo";
            this.textBoxArchivo.Size = new System.Drawing.Size(215, 23);
            this.textBoxArchivo.TabIndex = 5;
            this.textBoxArchivo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxResolucionOriginal
            // 
            this.textBoxResolucionOriginal.Location = new System.Drawing.Point(90, 57);
            this.textBoxResolucionOriginal.Name = "textBoxResolucionOriginal";
            this.textBoxResolucionOriginal.ReadOnly = true;
            this.textBoxResolucionOriginal.Size = new System.Drawing.Size(67, 23);
            this.textBoxResolucionOriginal.TabIndex = 6;
            // 
            // buttonCambiarResolucion
            // 
            this.buttonCambiarResolucion.Enabled = false;
            this.buttonCambiarResolucion.Location = new System.Drawing.Point(12, 152);
            this.buttonCambiarResolucion.Name = "buttonCambiarResolucion";
            this.buttonCambiarResolucion.Size = new System.Drawing.Size(133, 23);
            this.buttonCambiarResolucion.TabIndex = 7;
            this.buttonCambiarResolucion.Text = "Cambiar resolucion";
            this.buttonCambiarResolucion.UseVisualStyleBackColor = true;
            this.buttonCambiarResolucion.Click += new System.EventHandler(this.buttonCambiarResolucion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Resolucion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Formato";
            // 
            // textBoxFormatoOriginal
            // 
            this.textBoxFormatoOriginal.Location = new System.Drawing.Point(90, 101);
            this.textBoxFormatoOriginal.Name = "textBoxFormatoOriginal";
            this.textBoxFormatoOriginal.ReadOnly = true;
            this.textBoxFormatoOriginal.Size = new System.Drawing.Size(67, 23);
            this.textBoxFormatoOriginal.TabIndex = 6;
            // 
            // textBoxFormatoNuevo
            // 
            this.textBoxFormatoNuevo.Location = new System.Drawing.Point(170, 101);
            this.textBoxFormatoNuevo.Name = "textBoxFormatoNuevo";
            this.textBoxFormatoNuevo.Size = new System.Drawing.Size(67, 23);
            this.textBoxFormatoNuevo.TabIndex = 6;
            // 
            // textBoxResolucionNueva
            // 
            this.textBoxResolucionNueva.Location = new System.Drawing.Point(170, 57);
            this.textBoxResolucionNueva.Name = "textBoxResolucionNueva";
            this.textBoxResolucionNueva.Size = new System.Drawing.Size(67, 23);
            this.textBoxResolucionNueva.TabIndex = 6;
            // 
            // buttonImagenes
            // 
            this.buttonImagenes.Enabled = false;
            this.buttonImagenes.Location = new System.Drawing.Point(304, 152);
            this.buttonImagenes.Name = "buttonImagenes";
            this.buttonImagenes.Size = new System.Drawing.Size(155, 23);
            this.buttonImagenes.TabIndex = 9;
            this.buttonImagenes.Text = "Convertir a imagenes";
            this.buttonImagenes.UseVisualStyleBackColor = true;
            this.buttonImagenes.Click += new System.EventHandler(this.buttonImagenes_Click);
            // 
            // textBoxImagenes
            // 
            this.textBoxImagenes.Location = new System.Drawing.Point(428, 113);
            this.textBoxImagenes.Name = "textBoxImagenes";
            this.textBoxImagenes.Size = new System.Drawing.Size(31, 23);
            this.textBoxImagenes.TabIndex = 10;
            this.textBoxImagenes.Text = "0";
            // 
            // labelFrames
            // 
            this.labelFrames.AutoSize = true;
            this.labelFrames.Location = new System.Drawing.Point(304, 116);
            this.labelFrames.Name = "labelFrames";
            this.labelFrames.Size = new System.Drawing.Size(118, 15);
            this.labelFrames.TabIndex = 11;
            this.labelFrames.Text = "Saltear cuadros (1-5):";
            // 
            // Programa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 273);
            this.Controls.Add(this.labelFrames);
            this.Controls.Add(this.textBoxImagenes);
            this.Controls.Add(this.buttonImagenes);
            this.Controls.Add(this.textBoxResolucionNueva);
            this.Controls.Add(this.textBoxFormatoNuevo);
            this.Controls.Add(this.textBoxFormatoOriginal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCambiarResolucion);
            this.Controls.Add(this.textBoxResolucionOriginal);
            this.Controls.Add(this.textBoxArchivo);
            this.Controls.Add(this.buttonSeleccionarArchivo);
            this.Controls.Add(this.buttonExtraerAudio);
            this.Controls.Add(this.buttonRemoverAudio);
            this.Controls.Add(this.buttonCambiarFormato);
            this.Name = "Programa";
            this.Text = "Programa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCambiarFormato;
        private System.Windows.Forms.Button buttonRemoverAudio;
        private System.Windows.Forms.Button buttonExtraerAudio;
        private System.Windows.Forms.Button buttonSeleccionarArchivo;
        private System.Windows.Forms.TextBox textBoxArchivo;
        private System.Windows.Forms.TextBox textBoxResolucionOriginal;
        private System.Windows.Forms.Button buttonCambiarResolucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFormatoOriginal;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBoxFormatoNuevo;
        private System.Windows.Forms.TextBox textBoxResolucionNueva;
        private System.Windows.Forms.Button buttonImagenes;
        private System.Windows.Forms.TextBox textBoxImagenes;
        private System.Windows.Forms.Label labelFrames;
    }
}