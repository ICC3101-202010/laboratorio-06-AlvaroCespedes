using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    [Serializable] //Clase padre de las divisiones
    class Division //Para cada nivel de division existe una persona encargada
    {
        private string nombre;
        private Persona encargado;

        public string Nombre { get => nombre; set => nombre = value; }
        internal Persona Encargado { get => encargado; set => encargado = value; }

        public Division()
        {

        }
        
    }
}
