namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbxColorFav.Items.Add("Azul");
            cbxColorFav.Items.Add("Rojo");
            cbxColorFav.Items.Add("Amarillo");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string texto = txtNombre.Text;
            string fecha = dtpFechaNac.Value.ToString();

            // Operador ternario:
            string chocolate = cbxChocolate.Checked == true ? "Le gusta el chocolate brodi!" : "No le simpatiza mi rey";

            string tipo;
            if (rbnWizard.Checked)
            {
                tipo = "Wizard";
            }
            else if (rbnMuggle.Checked)
            {
                tipo = "Muggle";
            }
            else
            {
                tipo = "Squib";
            }

            string colorFavorito = cbxColorFav.SelectedItem.ToString();
            string numFavorito = numNumeroFavorito.Value.ToString();

            // Agrego cada elemento a la lista: 
            lwElementos.Items.Add(texto);       // Estoy agregando cada nombre a la lista
            lwElementos.Items.Add(fecha);
            lwElementos.Items.Add(chocolate); // Agrego el texto de la variable chocolate
            lwElementos.Items.Add(tipo);
            lwElementos.Items.Add(colorFavorito);
            lwElementos.Items.Add(numFavorito);
           
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string texto = txtNombre.Text;
            DateTime fecha = dtpFechaNac.Value;

            // Operador ternario:
            string chocolate = cbxChocolate.Checked == true ? "Le gusta el chocolate brodi!" : "No le simpatiza mi rey";

            string tipo;
            if (rbnWizard.Checked)
            {
                tipo = "Wizard";
            }
            else if (rbnMuggle.Checked)
            {
                tipo = "Muggle";
            }
            else
            {
                tipo = "Squib";
            }

            string colorFavorito = cbxColorFav.SelectedItem.ToString();
            string numFavorito = numNumeroFavorito.Value.ToString();

            MessageBox.Show("Nombre: " + texto + "\nFecha: " + fecha + "\nChocolate: " + chocolate + "\nTipo: " + tipo + "\nColor Favorito: " + colorFavorito + "\nNumero Favorito: " + numFavorito);

        }

        
    }
}
