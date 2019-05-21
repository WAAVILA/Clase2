using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Persona
    {
        public string nombre;
        public string apellido;
        public string documento;
        public string direccion;

        /// <summary>
        /// Metodo para mostrar los datos de la persona
        /// creado por andres avila
        /// creado el 2019/05/20
        /// </summary>
        /// <param name="Personita"></param>
        public void VisualizarPersona(Persona Personita)
        {
            Console.WriteLine($" Nombre: {Personita.nombre}\n Apellido:{Personita.apellido}\n Documento:{Personita.documento}\n Dirección:{Personita.direccion}\n");
        }
        /// <summary>
        /// Metodo para crear persona
        /// Creado el 08/05/2019
        /// autor:Diego Gamboa
        /// </summary>
        /// <param name="personita"></param>
        public void IngresarPersona(Persona personita)
        {

            Console.WriteLine("Ingrese el nombre de la persona");
            personita.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido de la persona");
            personita.apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el documento de la persona");
            personita.documento = Console.ReadLine();
            Console.WriteLine("Ingrese el dirección de la persona");
            personita.direccion = Console.ReadLine();
        }

        }
}
