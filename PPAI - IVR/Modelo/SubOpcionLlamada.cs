﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI___IVR.Modelo
{
    public class SubOpcionLlamada
    {
        private string nombre;
        private int nroOrden;
        private Validacion validacion;

        /// <summary>
        /// Constructor de la clase actual.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="nroOrden"></param>
        public SubOpcionLlamada(string nombre, int nroOrden)
        {
            this.Nombre = nombre;
            this.NroOrden = nroOrden;
        }
        public SubOpcionLlamada()
        {

        }
        // Métodos set y get de la clase.
        public string Nombre { get => nombre; set => nombre = value; }
        public int NroOrden { get => nroOrden; set => nroOrden = value; }

        public bool esNro()
        {
            return false;
        }
        public string getValidacion()
        {
            return validacion.Nombre;
        }
    }
}
