using PPAI___IVR.Interfaz;
using PPAI___IVR.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI___IVR.Controlador
{
    public class GestorOperador
    {
        private string mensaje;
        private Llamada llamada;
        private Cliente cliente;
        private InterfazIVR interfazIVR;
        private InterfazOperador interfazOperador;

        public GestorOperador(InterfazIVR interfazIVR, InterfazOperador interfazOperador)
        {
            this.interfazIVR = interfazIVR;
            this.interfazOperador = interfazOperador;
            interfazIVR.GestorOperador = this;
            interfazOperador.GestorOperador = this;
        }

        public bool esEnCurso()
        {
            return false;
        }
        public void nuevaRespuestaOperador(Llamada llamada, CategoriaLlamada categoriaLlamada)
        {
            Estado estado = new Estado("En Curso");
            llamada.setEstado(estado);
            cliente = llamada.Cliente;
            categoriaLlamada.getValidaciones();
            
        }
        public DateTime obtenerFechaYHoraActual()
        {
            return DateTime.Now;
        }
        public void mensajeDeCambioEstado()
        {
            this.mensaje = "Se ha creado un cambio de estado nuevo";
        }
        private void buscarDatosLlamada()
        {

        }
        public void tomarOpcionValida()
        {
            llamada.validarInfoCliente();
        }
    }
}
