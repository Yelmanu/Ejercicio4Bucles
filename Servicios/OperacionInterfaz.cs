using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Bucles.Servicios
{
    /// <summary>
    /// Interfaz que se encarga de realizar la operación
    /// 251023 - MDN
    /// </summary>
    internal interface OperacionInterfaz
    {
        /// <summary>
        /// Método para hacer la operación con el número introducido por el usuario
        /// 251023 - MDN
        /// </summary>
        /// <returns></returns>
        public long factorialNumero(long numero);
    }
}
