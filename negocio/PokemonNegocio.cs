using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient; // Librería para hacer la conexión a la base de datos
using dominio;

namespace negocio
{
    public class PokemonNegocio
    {
        // Métodos de acceso a datos para los Pokemon:

        public List<Pokemon> listar()   // Método que lea registros de la base de datos:
        {
            List<Pokemon> lista = new List<Pokemon>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector; // Objeto para leer los registros de la base de datos

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS05; database=POKEDEX_DB; integrated security=true; trustServerCertificate=true;";    // Dirección de mi motor de base de datos local

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion as Tipo, D.Descripcion as Debilidad  from POKEMONS P, ELEMENTOS E, ELEMENTOS D where P.IdTipo = E.Id and P.IdDebilidad = D.Id";   // Consulta de la base de datos
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon(); // Pokemon auxiliar para cargar los datos del registro (de la base de datos)
                    aux.Numero = (int)lector["Numero"];                 // Cargo el número del Pokemon
                    aux.Nombre = (string)lector["Nombre"];              // Cargo el nombre del Pokemon
                    aux.Descripcion = (string)lector["Descripcion"];    // Cargo la descripción del Pokemon
                    
                    // Hago validación por si la UrlImagen es nula: 
                    if (! (lector["UrlImagen"] is DBNull))
                    {
                        aux.UrlImagen = (string)lector["UrlImagen"];        // Cargo la URL de la imagen del Pokemon
                    }
                    
                    // Voy a cargar los tipos de pokemon:
                    aux.Tipo = new Elemento(); // Inicializo el objeto Tipo
                    aux.Tipo.Descripcion = (string)lector["Tipo"];

                    // Voy a cargar las debilidades de los pokemon:
                    aux.Debilidad = new Elemento(); // Inicializo el objeto Debilidad
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];

                    lista.Add(aux); // Agrego el Pokemon a la lista
                }

                conexion.Close(); // Cierro la conexión a la base de datos

                return lista;       // Retorno la lista de Pokemons
            }
            catch (SqlException)
            {
                throw;           // En caso de haber un error al mostrar la lista, muestro un mensaje de excepción
            }
        }

        public void agregar(Pokemon nuevo)         // Método para agregar nuevos Pokemons a la DB
        {
            AccesoDatos datos = new AccesoDatos();          // Objeto para conectarme a la DB

            try
            {
                // Acá voy a construir la lógica para conectarme a la DB
                datos.setearConsulta("Insert into Pokemons (Numero, Nombre, Descripcion, Activo, IdTipo, IdDebilidad, UrlImagen) values (" + nuevo.Numero + ", "  + nuevo.Nombre + "', '" + nuevo.Descripcion + "', 1, " + nuevo.Tipo.Id + ",  " + nuevo.Debilidad.Id + ", @UrlImagen)");

                // Voy a setear los parámetros de IdTipo y IdDebilidad:
                datos.setearParametros("@IdTipo", nuevo.Tipo.Id);
                datos.setearParametros("@IdDebilidad", nuevo.Debilidad.Id);
                datos.setearParametros("@UrlImagen", nuevo.UrlImagen);

                // Ahora tengo que insertar ese registro en la DB con un método que viene de 'AccesoDatos'
                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();  // Cierro la conexión a la DB
            }
        }
    }
}
