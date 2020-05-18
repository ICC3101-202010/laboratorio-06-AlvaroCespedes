
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.IO; //Agregadas Para la serializacion
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empresa> empresa = new List<Empresa>();
            bool exec = true;
            while (exec)
            {
                string chosen = ShowOptions(new List<string>() { "Si", "No", "Datos", "Salir" });
                switch (chosen)
                {
                    case "Si":
                        Console.Clear();
                        try
                        {
                            empresa = LoadEmpresa();
                            Console.WriteLine("Ya hay empresas guardadas, favor de probar 'Datos'\nPara ver informacion en el menu.");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("No hay empresas en el archivo. Favor de crear una.");
                            Console.WriteLine("Nombre de la empresa: ");
                            string nombre1 = Console.ReadLine();
                            Console.WriteLine("Rut de la empresa: ");
                            string rut1 = Console.ReadLine(); //VER MANEJO DE EXCEPCIONES CUANDO EL USUARIO SE EQUIVOQUE.
                            empresa.Add(new Empresa(nombre1, rut1));
                            SaveEmpresa(empresa);
                        }
                        break;

                    case "No":
                        Console.Clear();
                        Console.WriteLine("Tiene que rellenar los datos de la empresa.");
                        Console.WriteLine("Nombre de la empresa: ");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Rut de la empresa: ");
                        string rut = Console.ReadLine(); //VER MANEJO DE EXCEPCIONES CUANDO EL USUARIO SE EQUIVOQUE.
                        empresa.Add(new Empresa(nombre, rut));
                        SaveEmpresa(empresa);
                        break;

                    case "Datos":
                        Console.Clear();
                        ShowEmpresa(empresa);
                        break;

                    case "Salir":
                        Console.WriteLine("Has salido");
                        exec = false;
                        break;
                }
                
            }
        }

        private static string ShowOptions(List<string> options) // Menu de opciones.
        {
            int i = 0;
            Console.WriteLine("\n\nDeseas utilizar un archivo para cargar informacion ?");
            foreach (string option in options)
            {
                Console.WriteLine(Convert.ToString(i) + ". " + option);
                i += 1;
            }

            return options[Convert.ToInt16(Console.ReadLine())];
        }
        //SERIALIZACION EMPRESAS
        static private void SaveEmpresa(List<Empresa> empresa)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, empresa);
            stream.Close();
        }
        static private List<Empresa> LoadEmpresa()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Empresa> empresa = (List<Empresa>)formatter.Deserialize(stream);
            stream.Close();
            return empresa;
        }
        static public void ShowEmpresa(List<Empresa> empresa)
        {
            foreach (Empresa x in empresa)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
        }
        //Crear metodo para la excepcion
    }
}
