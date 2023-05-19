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

        public CategoriaLlamada(string audioMensajeOpciones, string mensajeOpciones, string nombre, int nroOrden)
        {
            this.AudioMensajeOpciones = audioMensajeOpciones;
            this.MensajeOpciones = mensajeOpciones;
            this.Nombre = nombre;
            this.NroOrden = nroOrden;
        }

        public string AudioMensajeOpciones { get => audioMensajeOpciones; set => audioMensajeOpciones = value; }
        public string MensajeOpciones { get => mensajeOpciones; set => mensajeOpciones = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NroOrden { get => nroOrden; set => nroOrden = value; }
    }
}
