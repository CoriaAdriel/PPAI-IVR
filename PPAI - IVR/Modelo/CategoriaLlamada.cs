using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI___IVR.Modelo
{
    public class CategoriaLlamada
    {
        private string audioMensajeOpciones;
        private string mensajeOpciones;
        private string nombre;
        private int nroOrden;
        private string descripcion;
        private OpcionLlamada opcionLlamada;

        /// <summary>
        /// Constructor de la clase actual.
        /// </summary>
        /// <param name="audioMensajeOpciones"></param>
        /// <param name="mensajeOpciones"></param>
        /// <param name="nombre"></param>
        /// <param name="nroOrden"></param>
        public CategoriaLlamada(string audioMensajeOpciones, string mensajeOpciones, string nombre, int nroOrden)
        {
            this.AudioMensajeOpciones = audioMensajeOpciones;
            this.MensajeOpciones = mensajeOpciones;
            this.Nombre = nombre;
            this.NroOrden = nroOrden;
        }
        public CategoriaLlamada()
        {

        }
        
        // Métodos set y get de la clase.
        public string AudioMensajeOpciones { get => audioMensajeOpciones; set => audioMensajeOpciones = value; }
        public string MensajeOpciones { get => mensajeOpciones; set => mensajeOpciones = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NroOrden { get => nroOrden; set => nroOrden = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public string getDescripcionCategoriaYOrigen()
        {
            return descripcion;
        }
        public string getValidaciones()
        {
            return opcionLlamada.getValidacion();
        }
    }
}
