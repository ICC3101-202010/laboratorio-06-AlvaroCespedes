using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    [Serializable]
    class Empresa
    {
        private string nombre;
        private string rut;
        private List<Division> divisiones; //Parte 2, agregar a empresa una lista de divisiones.

        public string Nombre { get => nombre; set => nombre = value; }
        public string Rut { get => rut; set => rut = value; }
        internal List<Division> Divisiones { get => divisiones; set => divisiones = value; }

        public Empresa(string nombre, string rut)
        {
            this.Nombre = nombre;
            this.Rut = rut;
        }
        public override string ToString()
        {
            return Nombre + ": " + Rut;
        }
    }
}
