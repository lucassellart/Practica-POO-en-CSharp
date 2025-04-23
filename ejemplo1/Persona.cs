using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        // Persona: Edad, Sueldo, Nombre

        // ATRIBUTOS o MIEMBROS:
        private int edad;
        private float sueldo;
        private string nombre;

       /* public void setEdad(int e)      // Función para leer el valor
        {
            edad = e;
        }

        public int getEdad()            // Función para obtener el valor y mostrarlo
        {
            return edad;
        }
       */

        // PROPIEDAD:

        public int Edad
        {
            set { edad = value; }
            get { return edad; }
        }

        // Constructor para nombre: (Uso constructor porque la idea es no cambiar el nombre de la persona)

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        // MÉTODOS:

        public string saludar()
        {
            return "Hola! Mi nombre es: " + nombre;
        }

        // SOBRECARGA Método Saludar:
        public string saludar(string personaje)     // Cambia el argumento y la definición
        {
            return "Hola " + personaje + ". Mi nombre es: " + nombre;
        }
    }
}
