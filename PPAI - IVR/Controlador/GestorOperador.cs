using PPAI___IVR.Interfaz;
using PPAI___IVR.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        private DateTime fechaHoraInicio;

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

            fechaHoraInicio = DateTime.Now;
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

        public void tomarRespuesta() {
            interfazOperador.solicitarConfirmacion();
        }

        public void tomarConfirmacion() {

            CasoDeUso28 Caso28 = new CasoDeUso28();
            Caso28.iniciarCU28();
            DateTime fechaHoraActual= obtenerFechaYHoraActual();

            TimeSpan duracion = calcularDuracion();
            llamada.Duracion = duracion;
            llamada.finalizar();

            finCU();
        
        }

        private TimeSpan calcularDuracion() {
            DateTime fechaHoraActual= obtenerFechaYHoraActual();
            return fechaHoraActual - fechaHoraInicio;
          
        }

        private void finCU() {}
    }
}
