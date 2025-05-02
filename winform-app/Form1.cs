namespace winform_app
{
    public partial class frmPokemons : Form
    {
        public frmPokemons()
        {
            InitializeComponent();
        }

        private void frmPokemons_Load(object sender, EventArgs e)
        {
            // Voy a invocar la lectura a la base de datos

            PokemonNegocio negocio = new PokemonNegocio();
            
            dgvPokemon.DataSource = negocio.listar();   

            // negocio.listar(); Va a la base de datos y me devuelve una lista de datos (lista de Pokemons)
            // dgvPokemon.DataSource -> DataSource recibe esos datos y los modela en la tabla (dgvPokemons)
        }
    }
}
