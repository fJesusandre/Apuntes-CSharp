﻿using System.Runtime.CompilerServices;

namespace Metodos
{
    internal class Program
    {
        //Si una variable o constante es declarada dentro de una clase pero fuera de un metodo se dice que tiene "Ambito de clase". Ambito local dentro de un metodo.

        //A estas variables o constantes son denominadas "Campos de clase".
        int numeroClase1 = 5;
        int numeroClase2 = 7;


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

        // => (Expression-bodied) 
        static int divideNumeros(int num1, int num2) => num1 / num2; // Manera de escribir o SIMPLIFICAR metodos con una linea de codigo como los anteriores.
        
        void primerMetodo()
        {
            Console.WriteLine(numeroClase2 + numeroClase1);// Cualquier metodo puede acceder a los campos de clase si se encuentre dentro de la misma clase.
            // No importa si los campos de clase son declaradas al principio o al final. Son como variable globales.
        }
        
        // Sobrecarga de metodos: Cuando dos o mas metodos tienen el mismo nombre dentro de una clase.

        // Para realizar una sobrecarga de metodos es necesario que uno de ellos tenga diferente tipo o cantidad de parametros.
        static int Suma(int operador1, int operador2) => operador1 + operador2;

        static int Suma(int numero1, double numero2) => numero1;

        //Parametros opcionales. Esto es fuera del tema de sobrecarga.
        static int Suma(int numero1, int numero2, int numero3 = 0) => numero1 + numero2 + numero3; // numero3 es un parametro opcional, le estoy asignando un valor por defecto.
        // Si al momento de llamar a este metodo no se le da el valor al tercer parametro, no pasara nada ya que tiene como valor predeterminado el cero.
        //Los parametros opcionales deben ir siempre al final.

        // El metodo que se ejecute dependera de los parametros que se den al programa. 
    }
}