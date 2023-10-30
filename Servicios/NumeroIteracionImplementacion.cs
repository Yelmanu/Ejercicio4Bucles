using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Bucles.Servicios
{
    internal class NumeroIteracionImplementacion : NumeroIteracionInterfaz
    {
        /// <summary>
        /// Método para pedir el número por consola al usuario
        /// 251023 - MDN
        /// </summary>
        /// <returns></returns>
        public int pedirNumero()
        {
            Console.WriteLine("Introduce un número entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }
        /// <summary>
        /// Método para controlar si se cierra la aplicación o continúa ejecutandose
        /// 251023 - MDN
        /// </summary>
        public string continuarAplicacion()
        {
            Console.WriteLine("¿Desea introducir otro número? (s=si cualquier otra tecla=no): ");
            string respuesta = Console.ReadLine();
            return respuesta;
           
        }
    }
}
