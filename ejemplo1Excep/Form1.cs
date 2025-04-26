namespace ejemplo1
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Manejo de excepciones:

            try
            {
                int num1 = int.Parse(txtNumUno.Text);   // Convierto string a entero
                int num2 = int.Parse(txtNumDos.Text);   // Convierto string a entero

                int r = num1 / num2;

                lblResultado.Text = "= " + r;
            }
            catch (FormatException format)
            {
                MessageBox.Show("Error, ingrese solamente números por favor");   
            }
            catch (DivideByZeroException zero)
            {
                MessageBox.Show("No es posible dividir por cero, intente nuevamente por favor...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no reconocido, contacte al delicuente del developer...");
            }
        }
    }
}
