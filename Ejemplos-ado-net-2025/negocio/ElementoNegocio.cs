using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ElementoNegocio
    {
        public List<Elemento> listar()      // Método para leer los elementos de la base de datos:
        {
            List<Elemento> lista = new List<Elemento>();

            AccesoDatos datos = new AccesoDatos(); // Instancio la clase AccesoDatos para poder acceder a la base de datos

            try
            {
                datos.setearConsulta("Select Id, Descripcion from ELEMENTOS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Elemento aux = new Elemento();          // Instancio un objeto Elemento para cargar los datos del registro (de la base de datos)

                    aux.Id = (int)datos.Lector["Id"];                           // Cargo el Id del elemento
                    aux.Descripcion = (string)datos.Lector["Descripcion"];      // Cargo la descripción del elemento

                    lista.Add(aux);      // Agrego el elemento a la lista
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();         // Cierro la conexión a la base de datos
            }
        }
    }
}
