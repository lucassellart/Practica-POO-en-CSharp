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
                comando.CommandText = "Select Numero, Nombre, P.Descripcion, UrlImagen, P.IdTipo, P.IdDebilidad, E.Descripcion as Tipo, D.Descripcion as Debilidad, P.Id  from POKEMONS P, ELEMENTOS E, ELEMENTOS D where P.IdTipo = E.Id and P.IdDebilidad = D.Id and P.Activo = 1";   // Consulta de la base de datos
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon(); // Pokemon auxiliar para cargar los datos del registro (de la base de datos)
                    
                    aux.Id = (int)lector["Id"];                         // Cargo el Id del Pokemon
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
                    aux.Tipo.Id = (int)lector["IdTipo"]; // Cargo el Id del tipo
                    aux.Tipo.Descripcion = (string)lector["Tipo"];

                    // Voy a cargar las debilidades de los pokemon:
                    aux.Debilidad = new Elemento(); // Inicializo el objeto Debilidad
                    aux.Debilidad.Id = (int)lector["IdDebilidad"]; // Cargo el Id de la debilidad
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
                datos.setearConsulta("Insert into Pokemons (Numero, Nombre, Descripcion, Activo, IdTipo, IdDebilidad, UrlImagen) values (@num, @nombre, @descrip, 1, @idTipo, @idDebilidad, @img)");

                // Voy a setear los parámetros de IdTipo y IdDebilidad:
                datos.setearParametros("@num", nuevo.Numero);
                datos.setearParametros("@nombre", nuevo.Nombre);
                datos.setearParametros("@descrip", nuevo.Descripcion);
           
                datos.setearParametros("@idTipo", nuevo.Tipo.Id);
                datos.setearParametros("@idDebilidad", nuevo.Debilidad.Id);
                datos.setearParametros("@img", nuevo.UrlImagen);

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

        public void modificar(Pokemon modificado)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update POKEMONS set Numero = @numero, Nombre = @nombre, Descripcion = @desc, UrlImagen = @img, IdTipo = @idTipo, IdDebilidad = @idDebilidad Where Id = @id");

                datos.setearParametros("@numero", modificado.Numero);
                datos.setearParametros("@nombre", modificado.Nombre);
                datos.setearParametros("@desc", modificado.Descripcion);
                datos.setearParametros("@img", modificado.UrlImagen);
                datos.setearParametros("@idTipo", modificado.Tipo.Id);
                datos.setearParametros("@idDebilidad", modificado.Debilidad.Id);
                datos.setearParametros("@id", modificado.Id);

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

        public void eliminar(int id)            // Método para eliminar un registro de la base de datos
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from POKEMONS where Id = @id");
                datos.setearParametros("@id", id);

                datos.ejecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void eliminarLogico (int id)     // Método para "inactivar" un registro de la DB
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update pokemons set Activo = 0 where Id = @id");
                datos.setearParametros("@id", id);

                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Pokemon> filtrar(string campo, string criterio, string filtro)   // Método para filtro avanzado (va a la DB y trae registros específicos)
        {
            List<Pokemon> lista = new List<Pokemon>();
            AccesoDatos datos = new AccesoDatos();      // me conecto a la DB

            try
            {
                string consulta = "Select Numero, Nombre, P.Descripcion, UrlImagen, P.IdTipo, P.IdDebilidad, E.Descripcion as Tipo, D.Descripcion as Debilidad, P.Id  from POKEMONS P, ELEMENTOS E, ELEMENTOS D where P.IdTipo = E.Id and P.IdDebilidad = D.Id and P.Activo = 1 And ";

                if (campo == "Número")  // primero evalúo el campo que eligió el usuario (para completar la consulta a DB)
                {
                    switch (criterio)
                    {
                        case "Mayor a":     // primer criterio
                            consulta += "Numero > " + filtro;       // el 'filtro' es un número que elige el usuario 
                            break;

                        case "Menor a":
                            consulta += "Numero < " + filtro;
                            break;

                        default:
                            consulta += "Numero = " + filtro;
                            break;
                    }

                } else if (campo == "Nombre") 
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Nombre like '" + filtro + "%' ";
                            break;

                        case "Termina con":
                            consulta += "Nombre like '%" + filtro + "' ";
                            break;

                        default:    // Contiene 
                            consulta += "Nombre like '%" + filtro + "%' ";
                            break;
                    }
                }
                else    // campo = "Descripcion"
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "P.Descripcion like '" + filtro + " %'";
                            break;

                        case "Termina con":
                            consulta += "P.Descripcion like '%" + filtro + "' ";
                            break;

                        default:    // Contiene
                            consulta += "P.Descripcion like '%" + filtro + "%' ";
                            break;
                    }
                }

                // ahora, con la consulta armada llamo al método para setearla y ejecutar la lectura:

                datos.setearConsulta(consulta);

                datos.ejecutarLectura();

                while (datos.Lector.Read())     // Traigo esta parte del método "listar" porque necesito leer los registros que están en la base de datos
                {
                    Pokemon aux = new Pokemon(); // Pokemon auxiliar para cargar los datos del registro (de la base de datos)

                    aux.Id = (int)datos.Lector["Id"];                         // Cargo el Id del Pokemon
                    aux.Numero = (int)datos.Lector["Numero"];                 // Cargo el número del Pokemon
                    aux.Nombre = (string)datos.Lector["Nombre"];              // Cargo el nombre del Pokemon
                    aux.Descripcion = (string)datos.Lector["Descripcion"];    // Cargo la descripción del Pokemon

                    // Hago validación por si la UrlImagen es nula: 
                    if (!(datos.Lector["UrlImagen"] is DBNull))
                    {
                        aux.UrlImagen = (string)datos.Lector["UrlImagen"];        // Cargo la URL de la imagen del Pokemon
                    }

                    // Voy a cargar los tipos de pokemon:
                    aux.Tipo = new Elemento(); // Inicializo el objeto Tipo
                    aux.Tipo.Id = (int)datos.Lector["IdTipo"]; // Cargo el Id del tipo
                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];

                    // Voy a cargar las debilidades de los pokemon:
                    aux.Debilidad = new Elemento(); // Inicializo el objeto Debilidad
                    aux.Debilidad.Id = (int)datos.Lector["IdDebilidad"]; // Cargo el Id de la debilidad
                    aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];

                    lista.Add(aux); // Agrego el Pokemon a la lista
                }


                return lista;
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
    