using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Bucles.Servicios
{
    /// <summary>
    /// Interfaz que se encarga de pedir el número y controlar la iteración
    /// 251023 - MDN
    /// </summary>
    internal interface NumeroIteracionInterfaz
    {
        /// <summary>
        /// Método para pedir número al usuario por consola
        /// 251023 - MDN
        /// </summary>
        /// <returns></returns>
        public int pedirNumero();

        /// <summary>
        /// Método para controlar si se cierra la aplicación o continúa ejecutandose
        /// 251023 - MDN
        /// </summary>
        public string continuarAplicacion();
    }
}
