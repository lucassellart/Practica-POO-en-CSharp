using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form   // Herencia
    {
        public Form1()                  // Constructor de la clase
        {
            InitializeComponent();      // Método
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("WELCOME PEOPLE!");
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola Mundo!");

            string texto = txtNombre.Text;
            lblSaludar.Text = "Hola " + texto;
            

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("WISH YOU THE BEST BYE BYE!");
        }
    }
}
