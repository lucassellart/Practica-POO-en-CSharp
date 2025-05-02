using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient; // Librería para hacer la conexión a la base de datos

namespace winform_app
{
    internal class PokemonNegocio
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
                comando.CommandText = "Select Numero, Nombre, Descripcion from POKEMONS";   // Consulta de la base de datos
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();   

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon(); // Pokemon auxiliar para cargar los datos del registro (de la base de datos)
                    aux.Numero = (int)lector["Numero"];                 // Cargo el número del Pokemon
                    aux.Nombre = (string)lector["Nombre"];              // Cargo el nombre del Pokemon
                    aux.Descripcion = (string)lector["Descripcion"];    // Cargo la descripción del Pokemon

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
    }
}
