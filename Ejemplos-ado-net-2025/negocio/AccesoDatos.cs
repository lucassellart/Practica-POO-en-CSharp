using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using Microsoft.Data.SqlClient;

namespace negocio
{
    public class AccesoDatos
    {
        // Atributos: (son los objetos que necesito para establecer la conexión a la DB)

        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        // Voy a crear la propiedad para poder leer el atributo 'lector' desde el exterior:
        public SqlDataReader Lector
        {
            get { return lector; }  // Retorno el lector
        }

        // Constructor: (inicializo los atributos)

        public AccesoDatos()   // Cuando se crea el Constructor de la clase, le paso por parámetros la cadena de conexión
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS05; database=POKEDEX_DB; integrated security=true; trustServerCertificate=true;");
            comando = new SqlCommand();
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;     // La consulta es de tipo texto
            comando.CommandText = consulta;                         // Le paso la consulta al comando
        }

        public void setearParametros(string nombre, object valor)       // Método para setear los parámetros de IdTipo y IdDebilidad
        {
            comando.Parameters.AddWithValue(nombre, valor);         // Nombre de la variable y su valor (elegido por el usuario)     
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ejecutarAccion()        // Método para insertar un registro (nuevo Pokemon) en DB:
        {
            comando.Connection = conexion;  // Le paso la conexión al comando

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();  // Ejecuto la consulta de inserción´. Acá no hay que leer registros, solo insertar
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void cerrarConexion()
        {
            if (lector != null)
            {
                lector.Close();     // Cierro el lector
            }

            conexion.Close();
        }
    }
}
