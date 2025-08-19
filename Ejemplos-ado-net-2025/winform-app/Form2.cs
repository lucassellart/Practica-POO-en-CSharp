using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace winform_app
{
    public partial class frmAltaPokemons : Form
    {
        private Pokemon pokemon = null;   

        public frmAltaPokemons()
        {
            InitializeComponent();
        }

        public frmAltaPokemons(Pokemon modificado)      // Hago este 2do constructor para tener la opción de pasar por parámetro un Pokemon a modificar
        {
            InitializeComponent();
            
            this.pokemon = modificado;

            Text = "Modificar Pokemon";    // Cambio el título del formulario al modificar un Pokemon
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Al hacer click sobre este botón se cierra el formulario

            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            PokemonNegocio poke = new PokemonNegocio();     // Creo este objeto para poder acceder al método 'agregar'

            try
            {
                if (pokemon == null)     // Si llegué hasta acá y estoy en nulo es porque voy a agregar un nuevo Pokemon
                {
                    pokemon = new Pokemon();    // Creo un nuevo objeto Pokemon
                }


                // Capturar los datos y transformarlos en un objeto tipo Pokemon
                // La variable 'pokemon' que uso viene del atributo privado creado al principio de la clase

                pokemon.Numero = int.Parse(txtNumero.Text);     // Capturo el número del Pokemon
                pokemon.Nombre = txtNombre.Text;                // Capturo el nombre del Pokemon
                pokemon.Descripcion = txtDescripcion.Text;      // Capturo la descripción del Pokemon
                pokemon.UrlImagen = txtUrlImagen.Text;          // Capturo la URL de la imagen del Pokemon

                // Voy a sumar los tipos y debilidades de los Pokemons:

                pokemon.Tipo = (Elemento)cbxTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cbxDebilidad.SelectedItem;


                if (pokemon.Id == 0)
                {
                    poke.agregar(pokemon);
                    MessageBox.Show("Pokemon agregado exitosamente!");
                
                } else
                {
                    poke.modificar(pokemon);
                    MessageBox.Show("Pokemon modificado exitosamente!");
                }  

                Close();  // Cierro el formulario para volver a la otra ventana
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void frmAltaPokemons_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();    // Creo un objeto de la clase ElementoNegocio para poder acceder a los tipos y debilidades de los Pokemons

            try
            {
                cbxTipo.DataSource = elementoNegocio.listar();      // 'DataSource' es para visualizar datos que vienen del exterior (lista, DB, etc)

                // Valores pre-seleccionados para Tipo:
                cbxTipo.ValueMember = "Id";
                cbxTipo.DisplayMember = "Descripcion";      // 'DisplayMember' es para mostrar el nombre del tipo en el ComboBox

                cbxDebilidad.DataSource = elementoNegocio.listar();

                // Valores pre-seleccionados para Debilidad:
                cbxDebilidad.ValueMember = "Id";            // Son los nombres de las propiedades de la clase 'Elemento'
                cbxDebilidad.DisplayMember = "Descripcion";  

                // Voy a precargar los datos del Pokemon que se va a modificar:

                if (pokemon != null)       // Si el Pokemon NO es nulo, es porque es una modificación
                {
                    txtNumero.Text = pokemon.Numero.ToString();    
                    txtNombre.Text = pokemon.Nombre;               
                    txtDescripcion.Text = pokemon.Descripcion;
                    txtUrlImagen.Text = pokemon.UrlImagen;

                    // Arreglar la imagen para cargarla de una:
                    cargarImagen(pokemon.UrlImagen);    // Cargar la imagen del Pokemon con la URL precargada

                    // Voy a pre-seleccionar los valores de los tipos y debilidades del Pokemon:
                    cbxTipo.SelectedValue = pokemon.Tipo.Id;        
                    cbxDebilidad.SelectedValue = pokemon.Debilidad.Id;    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);    // Al salir del campo de texto, se carga la imagen del Pokemon con la URL ingresada
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxUrlImagen.Load(imagen);    // Cargar la imagen del pokemon seleccionado
            }
            catch (Exception)
            {
                pbxUrlImagen.Load("https://i0.wp.com/port2flavors.com/wp-content/uploads/2022/07/placeholder-614.png?fit=1200%2C800&ssl=1");
            }
        }
    }
}
