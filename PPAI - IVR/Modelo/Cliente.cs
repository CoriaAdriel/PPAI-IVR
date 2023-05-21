using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI___IVR.Modelo
{
    public class Cliente
    {
        private int dni;
        private string nombreCompleto;
        private int nroCelular;

        /// <summary>
        /// Constructor de la clase actual
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombreCompleto"></param>
        /// <param name="nroCelular"></param>
        public Cliente(int dni, string nombreCompleto, int nroCelular)
        {
            this.Dni = dni;
            this.NombreCompleto = nombreCompleto;
            this.NroCelular = nroCelular;
        }
        
        // Métodos set y get de la clase.
        public int Dni { get => dni; set => dni = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public int NroCelular { get => nroCelular; set => nroCelular = value; }
    }
}
