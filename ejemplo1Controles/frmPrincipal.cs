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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            // Arquitectura padre-hijo
            foreach (var item in Application.OpenForms)   // Validación para que no se pueda abrir el formulario si ya está abierto:
            {
                if (item.GetType() == typeof(Form1))    // Pregunto si el objeto vivo en memoria es del tipo Form1
                {
                    MessageBox.Show("El formulario ya está abierto");
                    return; // Salgo del ciclo y no abro el formulario
                }
            }

            Form1 ventana = new Form1();    // Estoy haciendo una nueva instancia de la clase donde tengo el formulario para que se vinculen
            ventana.MdiParent = this;       // Le estoy diciendo que el formulario secundario es hijo del formulario principal
            ventana.Show();                 // Con el ShowDialog() estoy haciendo que se muestre el formulario y no se pueda interactuar con el formulario principal hasta que cierre el secundario

        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)   
            {
                if (item.GetType() == typeof(Form1))    
                {
                    MessageBox.Show("El formulario ya está abierto");
                    return; 
                }
            }

            Form1 ventana = new Form1();    // Estoy haciendo una nueva instancia de la clase donde tengo el formulario para que se vinculen
            ventana.MdiParent = this;
            ventana.Show();           // Con el ShowDialog() estoy haciendo que se muestre el formulario y no se pueda interactuar con el formulario principal hasta que cierre el secundario
        }

        
    }
}
