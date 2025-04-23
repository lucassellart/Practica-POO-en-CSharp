namespace practica5
{
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool bandera = false;       // Utilizo una variable "true-false" para asegurarme de mostrar el texto una vez que pas� por la validaci�n requerida

            if (txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.Red;
            }
            else
            {
                txtApellido.BackColor = System.Drawing.SystemColors.Window;
                //txtResultado.Text += "Apellido: " + txtApellido.Text + "\n";
                bandera = true;
            }

            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
            }
            else
            {
                txtNombre.BackColor = System.Drawing.SystemColors.Window;
                //txtResultado.Text += "\nNombre: " + txtNombre.Text + "\n";
                bandera = true;
            }

            if (txtEdad.Text == "")
            {
                txtEdad.BackColor = Color.Red;
            }
            else
            {
                txtEdad.BackColor = System.Drawing.SystemColors.Window;
                //txtResultado.Text += "\nEdad: " + txtEdad.Text + "\n";
                bandera = true;
            }

            if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.Red;
            }
            else
            {
                txtDireccion.BackColor = System.Drawing.SystemColors.Window;
                //txtResultado.Text += "\nDirecci�n: " + txtDireccion.Text + "\n";
                bandera = true;
            }

            if (bandera == true)
            {
                txtResultado.Text = "Apellido y Nombre: " + txtApellido.Text + " " + txtNombre.Text + "\r\nEdad: " + txtEdad.Text + " a�os" + "\r\nDirecci�n: " + txtDireccion.Text;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
