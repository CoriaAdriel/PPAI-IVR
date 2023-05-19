using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI___IVR.Modelo
{
    public class Estado
    {
        private string nombre;

        /// <summary>
        /// Constructor de la clase Estado.
        /// </summary>
        /// <param name="nombre"></param>
        public Estado(string nombre)
        {
            this.nombre = nombre;
        }
        // Métodos set y get de la clase Estado.
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
