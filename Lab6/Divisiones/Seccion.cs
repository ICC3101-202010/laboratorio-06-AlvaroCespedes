﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    [Serializable]
    class Seccion : Division
    {
        public Seccion(string nombre, Persona encargado)
        {
            this.Nombre = nombre;
            this.Encargado = encargado;
        }
    }
}
