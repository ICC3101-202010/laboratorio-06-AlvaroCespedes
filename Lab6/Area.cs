using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class Area : Division
    {
        public Area(string nombre, Persona encargado)
        {
            this.Nombre = nombre;
            this.Encargado = encargado;
        }
    }
}
