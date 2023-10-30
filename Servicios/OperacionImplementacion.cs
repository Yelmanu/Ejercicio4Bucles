using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Bucles.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public long factorialNumero(long numero)
        {
            long factorial = 1;
            for (int i = 2; i <= numero; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("La multiplicación de todos los números hasta {0} es: {1}", numero, factorial);
            
            return factorial;
        }
    }
}
