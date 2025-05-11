using Microsoft.Data.SqlClient;     // Librería para hacer la conexión a la base de datos
using System.Net; 

namespace ejemplo1
{
    public partial class frmDiscos : Form
    {
        // Atributo privado para manipular una lista de Discos antes de pasarlos al DataGridView
        private List<DISCOS> listaDiscos;
        public frmDiscos()
        {
            InitializeComponent();
        }

        private void frmDiscos_Load(object sender, EventArgs e)
        {
            DiscosNegocio negocio = new DiscosNegocio();    // Creo una instancia de la clase 'DiscosNegocio' para conectarme a la base de datos
                                                            // y poder traer los datos de los discos
            listaDiscos = negocio.listar();

            dgvDiscos.DataSource = listaDiscos;
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;     // Oculto la columna de la URL de la imagen

            cargarImagen(listaDiscos[0].UrlImagenTapa);     // Acá estoy haciendo que se cargue la imagen del primer Disco cuando se carga el formulario

            // negocio.listar(); Va a la base de datos y me devuelve una lista de datos (lista de Discos)
            // dgvDiscos.DataSource -> DataSource recibe esos datos y los modela en la tabla (dgvDiscos)
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            DISCOS seleccionado = (DISCOS)dgvDiscos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagenTapa);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                if (!imagen.StartsWith("https://"))     // Intento validar que la URL empiece con 'https:// para que funcionen todas las URL
                {
                    imagen = "https://" + imagen;
                }
                pbxDiscos.Load(imagen);
            }
            catch (WebException)
            {
                pbxDiscos.Load("https://i0.wp.com/port2flavors.com/wp-content/uploads/2022/07/placeholder-614.png?fit=1200%2C800&ssl=1");
            }
            catch (IOException)
            {
                pbxDiscos.Load("https://i0.wp.com/port2flavors.com/wp-content/uploads/2022/07/placeholder-614.png?fit=1200%2C800&ssl=1");
            }
        }
    }
}
