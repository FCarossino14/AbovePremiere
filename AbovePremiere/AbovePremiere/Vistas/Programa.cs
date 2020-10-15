using AbovePremiere.FFMPEG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AbovePremiere.Vistas
{
    public partial class Programa : Form
    {
        public Programa()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ventanaSeleccionarArchivo = new OpenFileDialog();

            ventanaSeleccionarArchivo.InitialDirectory = "C:\\";
            ventanaSeleccionarArchivo.Filter = "Database files (*.mp4, *.avi, *.mpeg, *.flv)|*.mp4;*.avi;*.mpeg;.*.flv";
            ventanaSeleccionarArchivo.FilterIndex = 0;
            ventanaSeleccionarArchivo.RestoreDirectory = true;

            if (ventanaSeleccionarArchivo.ShowDialog() == DialogResult.OK)
            {
                string archivoSeleccionado = ventanaSeleccionarArchivo.FileName;
                textBoxArchivo.Text = archivoSeleccionado;
                buttonCambiarFormato.Enabled = true;
                buttonCambiarResolucion.Enabled = true;
                buttonExtraerAudio.Enabled = true;
                buttonRemoverAudio.Enabled = true;
                buttonImagenes.Enabled = true;
            }
        }

        private void buttonExtraerAudio_Click(object sender, EventArgs e)
        {
            Video.extraerAudio(textBoxArchivo.Text);
        }

        private void buttonRemoverAudio_Click(object sender, EventArgs e)
        {
            Video.eliminarAudio(textBoxArchivo.Text);
        }

        private void buttonCambiarResolucion_Click(object sender, EventArgs e)
        {

        }

        private void buttonCambiarFormato_Click(object sender, EventArgs e)
        {

        }

        private void buttonImagenes_Click(object sender, EventArgs e)
        {
            Video.extraerImagenes(textBoxArchivo.Text, textBoxImagenes.Text);
        }
    }
}
