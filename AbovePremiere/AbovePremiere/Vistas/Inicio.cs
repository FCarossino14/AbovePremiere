using AbovePremiere.DAOs;
using AbovePremiere.Modelo;
using AbovePremiere.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbovePremiere
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            var usuario = textBoxUsuario.Text;
            var password = textBoxPassword.Text;


            if (UsuariosDAO.existeUsuario(usuario, password))
            {
                var form = new Programa();
                form.Show();
                this.Hide();
            } else 
            {
                MessageBox.Show("Los datos son incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != "" && textBoxUsuario.Text != "") 
            {
                buttonLogin.Enabled = true;
            }else
            {
                buttonLogin.Enabled = false;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != "" && textBoxUsuario.Text != "")
            {
                buttonLogin.Enabled = true;
            }else {
                buttonLogin.Enabled = false;
            }

        }
    }
}
