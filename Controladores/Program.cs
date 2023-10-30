using Ejercicio4Bucles.Servicios;

namespace Ejercicio4Bucles.Controladores
{
    class Program
    {
        static public void Main(string[] args)
        {
            //Declaramos las variables
            long numero, factorial;
            string continuar;

            //Instanciamos las clases donde se encuentran los métodos 
            NumeroIteracionInterfaz nii = new NumeroIteracionImplementacion();
            OperacionInterfaz oi = new OperacionImplementacion();

            //Realizamos la operacion
            do
            {
                numero = nii.pedirNumero();
                factorial = oi.factorialNumero(numero);
                continuar = nii.continuarAplicacion();
            } while (continuar.ToLower() == "s");

        }
    }
}
