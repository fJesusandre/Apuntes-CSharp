using System.Runtime.CompilerServices;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sumarNumeros(10, 13);// Nota: No se puede llamar un metodo en un main estatico si el metodo no es estatico tambien.
            Console.WriteLine(sumarNumerosR(6, 3));
            Console.WriteLine(divideNumeros(6, 3));
            Console.ReadKey();
        }

        // Se hizo estatico el metodo para poder llamarlo en el main.
        static void sumarNumeros(int num1, int num2)
        {
            Console.WriteLine($"La suma de los numeros es: {num1 + num2}.");
        }

        // Siempre poner atencion al tipo de dato que se devolvera y a los tipos de datos que se reciben.
        // Tambien al tipo de operacion que realizara el metodo y al el tipo de dato que crea esta operacion, ejemplo en una division.
        static int sumarNumerosR(int num1, int num2) // Double + int = double, dara error el codigo. No es posible hacer conversiones implicitas ya que ya fueron hechas realizadas conversiones explicitas. 
        {                                            // int + int = int, si el metodo devuelve un double pero los parametros son enteros, devolvera un entero.
            return num1 + num2;
        }

        static int divideNumeros(int num1, int num2) => num1 / num2; // Manera de escribir o SIMPLIFICAR metodos con una linea de codigo como los anteriores.
    }
}