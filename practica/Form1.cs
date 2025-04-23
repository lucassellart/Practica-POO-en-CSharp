namespace practica
{
    public partial class frmPractica1 : Form
    {
        public frmPractica1()
        {
            InitializeComponent();
        }

        private void frmPractica1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");

        }

        private void frmPractica1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Gracias por usar la aplicaci�n!");
        }

        private void btnBoton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se dispar� el evento click!", "Atenci�n!");
            //this.BackColor = Color.Blue;

            if (txtTexto.Text == "")
            {
                txtTexto.BackColor = Color.Red;
            }
            else
            {
                txtTexto.BackColor = System.Drawing.SystemColors.Window;
            }
        }
        
        
        private void frmPractica1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
            {
                MessageBox.Show("Se presion� el bot�n izquierdo del mouse", "Atenci�n!");
            }
            else if (click.Button == MouseButtons.Right)
            {
                MessageBox.Show("Se presion� el bot�n derecho del mouse", "Atenci�n!");
            }
            else
            {
                MessageBox.Show("Se presion� el bot�n del medio del mouse", "Atenci�n!");
            }
            
        }
        
        private void lblEtiqueta_MouseMove(object sender, MouseEventArgs e)
        {
            lblEtiqueta.BackColor = Color.Cyan;
            lblEtiqueta.Cursor = Cursors.Hand;
        }

        private void lblEtiqueta_MouseLeave(object sender, EventArgs e)
        {
            lblEtiqueta.BackColor = System.Drawing.SystemColors.Window;
            lblEtiqueta.Cursor = Cursors.Arrow;
        }

        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtCajaTexto2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene: " + txtCajaTexto2.Text.Length + " caracteres.");
        }
    }
}
