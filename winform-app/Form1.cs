using dominio;
using negocio;

namespace winform_app
{
    public partial class frmPokemons : Form
    {
        // Atributo privado para poder manipular los pokemons antes de pasarlos al DataGridView
        private List<Pokemon> listaPokemons;
        public frmPokemons()
        {
            InitializeComponent();
        }

        private void frmPokemons_Load(object sender, EventArgs e)       // A este evento le agrego un 'try-catch' para manejar excepciones (UrlImagen null)
        {
            try
            {
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;    // Selecciono el pokemon de la grilla, fila actual, elemento enlazado
            cargarImagen(seleccionado.UrlImagen);    // Cargar la imagen del pokemon seleccionado
        }

        // Método privado para manejar la excepción de imagen vacía:

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxPokemon.Load(imagen);    // Cargar la imagen del pokemon seleccionado
            }
            catch (Exception)
            {

                pbxPokemon.Load("https://i0.wp.com/port2flavors.com/wp-content/uploads/2022/07/placeholder-614.png?fit=1200%2C800&ssl=1");
            }
        }

        private void cargar()       // Método para cargar la lista de Pokemons
        {
            PokemonNegocio negocio = new PokemonNegocio();      // Voy a invocar la lectura a la base de datos

            listaPokemons = negocio.listar();

            dgvPokemon.DataSource = listaPokemons;
            dgvPokemon.Columns["UrlImagen"].Visible = false;    // Al cargar el formulario, oculto la columna de la URL de la imagen en el DataGridView
            cargarImagen(listaPokemons[0].UrlImagen);           // Cargo la imagen del primer pokemon cuando se carga el formulario


            // negocio.listar(); Va a la base de datos y me devuelve una lista de datos (lista de Pokemons)
            // dgvPokemon.DataSource -> DataSource recibe esos datos y los modela en la tabla (dgvPokemons)
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Al clickear el botón 'Agregar', voy a abrir el formulario de cargar un nuevo Pokemon:

            frmAltaPokemons nuevo = new frmAltaPokemons();
            nuevo.ShowDialog();

            // Acá voy a actualizar la carga del nuevo pokemon
            // Una vez que el usuario clickea 'Aceptar' se muestra el nuevo Pokemon en el DataGridView

            cargar();       // Con este método debería aparecer el Pokemon que el usuario carga en el DataGridView
        }
    }
}
