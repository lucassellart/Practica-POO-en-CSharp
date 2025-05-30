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
        public frmAltaPokemons()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Al hacer click sobre este botón se cierra el formulario

            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            Pokemon aux = new Pokemon();            // Creo un objeto Pokemon auxiliar para guardar los datos del nuevo Pokemon

            PokemonNegocio poke = new PokemonNegocio();     // Creo este objeto para poder acceder al método 'agregar'

            try
            {
                // Capturar los datos y transformarlos en un objeto tipo Pokemon

                aux.Numero = int.Parse(txtNumero.Text);     // Capturo el número del Pokemon
                aux.Nombre = txtNombre.Text;                // Capturo el nombre del Pokemon
                aux.Descripcion = txtDescripcion.Text;      // Capturo la descripción del Pokemon
                aux.UrlImagen = txtUrlImagen.Text;          // Capturo la URL de la imagen del Pokemon

                // Voy a sumar los tipos y debilidades de los Pokemons:

                aux.Tipo = (Elemento)cbxTipo.SelectedItem;
                aux.Debilidad = (Elemento)cbxDebilidad.SelectedItem;

                // Ahora necesito llevar ese nuevo Pokemon a la DB, eso lo hago con 'pokemonNegocio'
                poke.agregar(aux);
                MessageBox.Show("Pokemon agregado exitosamente!");

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
                cbxDebilidad.DataSource = elementoNegocio.listar();
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
                //System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

                pbxUrlImagen.Load(imagen);    // Cargar la imagen del pokemon seleccionado
            }
            catch (Exception)
            {

                pbxUrlImagen.Load("https://i0.wp.com/port2flavors.com/wp-content/uploads/2022/07/placeholder-614.png?fit=1200%2C800&ssl=1");
            }
        }
    }
}
