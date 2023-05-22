using PPAI___IVR.Controlador;
using PPAI___IVR.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI___IVR
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InterfazIVR());            
            Llamada llamada = new Llamada("", "", 0, "", "");
            Estado estado = new Estado("");
            CambioEstado cambioEstado = new CambioEstado(DateTime.Now);
            CategoriaLlamada categoriaLlamada = new CategoriaLlamada();
            cambioEstado.Estado = estado;
            llamada.addCambioEstado(cambioEstado);
            SubOpcionLlamada subOpcionLlamada = new SubOpcionLlamada();
            iniciarCU(llamada, subOpcionLlamada);
        }

        /// <summary>
        /// 
        /// </summary>
        static void iniciarCU(Llamada llamada, SubOpcionLlamada subOpcionLlamada)
        {                                    
            GestorOperador gestor = new GestorOperador();
            CategoriaLlamada categoriaLlamada = new CategoriaLlamada();
            gestor.nuevaRespuestaOperador(llamada, categoriaLlamada);            

        }        
    }
}
