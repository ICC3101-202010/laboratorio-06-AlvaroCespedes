using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    [Serializable]
    class Bloque : Division //Personal general. Extra a persona persona encargada.
    {
        public Bloque(string nombre, Persona encargado)
        {
            this.Nombre = nombre;
            this.Encargado = encargado;
        }
    }
}
