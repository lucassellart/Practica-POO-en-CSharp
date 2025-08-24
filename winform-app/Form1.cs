using dominio;
using Microsoft.IdentityModel.Tokens;
using negocio;

namespace winform_app
{
    public partial class frmPokemons : Form
    {
        // Atributo privado para poder manipular los pokemons antes de pasarlos al DataGridView
        private List<Pokemon> listaPokemons;    // Tambi�n la voy a usar para filtrar Pokemons
        public frmPokemons()
        {
            InitializeComponent();
        }

        private void frmPokemons_Load(object sender, EventArgs e)       // A este evento le agrego un 'try-catch' para manejar excepciones (UrlImagen null)
        {
            try
            {
                cargar();

                // Voy a cargar los Combobox con datos para filtro Avanzado (contra DB):
                cboCampo.Items.Add("N�mero");
                cboCampo.Items.Add("Nombre");
                cboCampo.Items.Add("Descripci�n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPokemon.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;    // Selecciono el pokemon de la grilla, fila actual, elemento enlazado
                cargarImagen(seleccionado.UrlImagen);    // Cargar la imagen del pokemon seleccionado
            }
        }

        // M�todo privado para manejar la excepci�n de imagen vac�a:

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

        private void cargar()       // M�todo para cargar la lista de Pokemons
        {
            PokemonNegocio negocio = new PokemonNegocio();      // Voy a invocar la lectura a la base de datos

            listaPokemons = negocio.listar();

            dgvPokemon.DataSource = listaPokemons;
            ocultarColumna();
            cargarImagen(listaPokemons[0].UrlImagen);           // Cargo la imagen del primer pokemon cuando se carga el formulario


            // negocio.listar(); Va a la base de datos y me devuelve una lista de datos (lista de Pokemons)
            // dgvPokemon.DataSource -> DataSource recibe esos datos y los modela en la tabla (dgvPokemons)
        }

        private void ocultarColumna()       // Lo voy a usar para ocultar columnas en el filtro y siempre que necesite cargar la lista de Pokemons
        {
            dgvPokemon.Columns["UrlImagen"].Visible = false;    // Al cargar el formulario, oculto la columna de la URL de la imagen en el DataGridView
            dgvPokemon.Columns["Id"].Visible = false;           // Oculto la columna del Id del Pokemon en el DataGridView
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Al clickear el bot�n 'Agregar', voy a abrir el formulario de cargar un nuevo Pokemon:

            frmAltaPokemons nuevo = new frmAltaPokemons();
            nuevo.ShowDialog();

            // Ac� voy a actualizar la carga del nuevo pokemon
            // Una vez que el usuario clickea 'Aceptar' se muestra el nuevo Pokemon en el DataGridView

            cargar();       // Con este m�todo deber�a aparecer el Pokemon que el usuario carga en el DataGridView
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado;
            seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;    // El Pokemon que selecciono de la grilla 

            frmAltaPokemons pokeModificado = new frmAltaPokemons(seleccionado);     // A este formulario le voy a pasar por par�metro el objeto Pokemon que quiero modificar  
            pokeModificado.ShowDialog();
            cargar();       // Con este m�todo deber�a aparecer el Pokemon que el usuario carga en el DataGridView

        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void eliminar(bool logico = false)      // El valor es opcional. Si no lo pongo par�metros, el valor es 'falso' por defecto
        {
            // Desde ac� voy a llamar a la funcionalidad de 'eliminar', que va a estar en la clase 'PokemonNegocio'

            PokemonNegocio negocio = new PokemonNegocio();
            Pokemon seleccionado;

            try
            {
                DialogResult resultado = MessageBox.Show("�Seguro que quer�s eliminar el Pokemon seleccionado?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;

                    if (logico)     // Si el registro es 'falso' es porque est� inactivo, entonces es eliminaci�n l�gica
                    {
                        negocio.eliminarLogico(seleccionado.Id);

                    }
                    else          // Ac� es eliminaci�n f�sica
                    {
                        negocio.eliminar(seleccionado.Id);
                    }

                    cargar();       // Actualizo la grilla de datos
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarFiltro()       // M�todo para validar que los 3 campos est�n cargados y el num�rico acepte solamente n�meros
        {
            if(cboCampo.SelectedIndex < 0)              // si el SelectedIndex es < 0 es porque no hay nada seleccionado en Campo
            {
                MessageBox.Show("Por favor seleccione el campo para filtrar.");
                return true;
            }

            if(cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione el criterio para filtrar.");
                return true;
            }

            if(cboCampo.SelectedItem.ToString() == "N�mero")        // Ojo con las t�ldes!!
            {
                if (txtFiltroAvanzado.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("Por favor, ingrese un n�mero para filtrar.");
                    return true;
                }

                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Por favor, ingrese �nicamente n�meros para filtrar.");
                    return true;
                }

            }

            return false;
        }

        private bool soloNumeros(string cadena)      // M�todo para validar que, al elegir el campo 'Numero' el usuario escriba solamente numeros
        {
            foreach (char caracter in cadena)        // Bucle para recorrer la caja de texto caracter por caracter, verificar los que NO sean numeros
            {

                if (!(char.IsNumber(caracter)))     //  El caracter evaluado NO es n�mero
                {
                    return false;                   //  Devuelvo false
                }
            }

            return true;
        }

        private void btnFiltro_Click(object sender, EventArgs e)        // Evento para filtrar (base de datos)
        {
            // Necesito una instancia de pokemonNegocio para conectarme a la DB

            PokemonNegocio negocio = new PokemonNegocio();


            try     // Capturar los 3 filtros (campo, criterio y filtro)
            {
                if (validarFiltro())
                {
                    return;         // Este 'return' no devuelve nada, cancela la ejecuci�n del evento
                }


                string campo = cboCampo.SelectedItem.ToString();    // Lo tengo que pasar a string porque cboCampo.SelectedItem me devuelve un objeto
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;

                dgvPokemon.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)      // Evento para filtrar r�pido
        {
            // Ac� lo que hago es tomar lo que el usuario escribe en la caja de texto y filtrar seg�n criterio (Nombre / N�mero / Descripci�n)

            List<Pokemon> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaPokemons.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                // El m�todo 'FindAll' me devuelve todos los objetos que cumplen con un criterio de b�squeda
            }
            else
            {
                listaFiltrada = listaPokemons;  // Si el usuario no filtra nada, en la grilla aparecer�n todos los pokemons
            }

            // Ya con la lista filtrada, le paso los objetos encontrados al datasource:

            dgvPokemon.DataSource = null;  // Primero pongo el DataSource en nulo para que no se repita la lista
            dgvPokemon.DataSource = listaFiltrada;

            ocultarColumna();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();       // En base a lo seleccionado en 'Campo' voy a cargar las opciones posibles en 'Criterio'
                                                                    // Filtro avanzado contra DB
            
            if (opcion == "N�mero")
            {
                cboCriterio.Items.Clear();    // Limpio los items del ComboBox Criterio
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            } else
            {
                cboCriterio.Items.Clear();    
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }
    }
}
