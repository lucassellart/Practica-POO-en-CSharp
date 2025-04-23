namespace ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDTPfecha_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = dtpFecha.Value;

            MessageBox.Show("La fecha seleccionada es: " + fecha1.ToShortDateString());
        }

        private void btnCALfecha_Click(object sender, EventArgs e)
        {
            DateTime fecha2 = calFecha.SelectionStart;

            MessageBox.Show("La fecha seleccionada es: " + fecha2.ToShortDateString());
        }
    }
}
