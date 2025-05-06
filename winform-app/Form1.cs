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

        private void frmPokemons_Load(object sender, EventArgs e)
        {
            // Voy a invocar la lectura a la base de datos

            PokemonNegocio negocio = new PokemonNegocio();

            listaPokemons = negocio.listar();

            dgvPokemon.DataSource = listaPokemons;
            dgvPokemon.Columns["UrlImagen"].Visible = false;    // Al cargar el formulario, oculto la columna de la URL de la imagen en el DataGridView
            cargarImagen(listaPokemons[0].UrlImagen);           // Cargo la imagen del primer pokemon cuando se carga el formulario


            // negocio.listar(); Va a la base de datos y me devuelve una lista de datos (lista de Pokemons)
            // dgvPokemon.DataSource -> DataSource recibe esos datos y los modela en la tabla (dgvPokemons)
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
    }
}
