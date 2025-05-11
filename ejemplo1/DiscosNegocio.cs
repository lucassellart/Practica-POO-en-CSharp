using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient; // Librería para hacer la conexión a la base de datos

namespace ejemplo1
{
    internal class DiscosNegocio
    {
        // Métodos de acceso a datos para los Discos:

        // Método que lea registros de la base de datos:

        public List<DISCOS> listar()      // El método es 'public' para poder ser accedido desde el exterior
        {
            List<DISCOS> lista = new List<DISCOS>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();  // Realizar acciones en la base de datos (lectura)
            SqlDataReader lector;       // Objeto que leé los registros de la base de datos



            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS05; database=DISCOS_DB; integrated security=true; trustServerCertificate=true; Connect Timeout=30;";     // Cadena de conexión al motor de la base de datos
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select D.Titulo,D.FechaLanzamiento,D.CantidadCanciones, D.CantidadCanciones, D.UrlImagenTapa, E.Descripcion as Estilo, T.Descripcion as TipoEdicion from  DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id";       // Consulta SQL
                comando.Connection = conexion;      // Asigno la conexión al comando

                conexion.Open();       // Abro la conexión a la base de datos

                lector = comando.ExecuteReader();      // Ejecuto el comando (lectura de la base de datos)

                while (lector.Read())                // lectura de registros de la base de datos
                {
                    DISCOS aux = new DISCOS();      // Voy a cargar este objeto con los datos que vienen de la DB (Titulo, CantidadCanciones, etc)
                    aux.Titulo = (string)lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)lector["CantidadCanciones"];
                    aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];

                    aux.Estilo = new Estilos();      // Inicializo el objeto 'Estilo' para poder cargarlo
                    aux.Estilo.Descripcion = (string)lector["Estilo"];

                    aux.TipoEdicion = new TiposEdicion();      // Inicializo el objeto 'TipoEdicion' para poder cargarlo
                    aux.TipoEdicion.Descripcion = (string)lector["TipoEdicion"];

                    lista.Add(aux);
                }

                conexion.Close();      // Cierro la conexión a la base de datos

                return lista;          // Retorno la lista de discos si sale todo bien
            }
            catch (SqlException)
            {
                throw;          // Lanzo una excepción si hubo algún error
            }

            
        }
    }
}
