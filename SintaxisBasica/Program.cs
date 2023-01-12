using System;

namespace PrimerContactoConCSharp
{
    class Program
    { 
        static void Main(string[] args)
        {
            int edad = 12;
            edad += 9;
            Console.WriteLine($"Tengo {--edad} años de edad.");//Interpolacion de strings/ sufijo y prefijo de dobles signos

            float personaEdad1, personaEdad2, personaEdad3 = 28.3f;//Checar el resultado del valor de persona 1 y 2
            
            //Casting, conversion explicita
            int personaEdadEntera = (int)personaEdad3;
            Console.WriteLine(personaEdadEntera);

            //Conversion implicita, googlear tabla de conversiones numericas implicitas para mas informacion.
            long personaEdadLargota = personaEdadEntera;
            Console.WriteLine(personaEdadLargota);

            Console.WriteLine("Introduce el primer numero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo numero: ");
            int numero2 =  int.Parse(Console.ReadLine());

            Console.WriteLine($"El resultado de la multplicacion de los dos numeros anteriores es: {numero1 * numero2}");

            const int VALOR = 5; // Las constantes se deben declarar e iniciar en la misma linea de codigo, nombrarlas en mayusculas es una buena practica
            const int VALOR2 = 10;

            Console.WriteLine("El valor de la constante es : {1}", VALOR, VALOR2);

            const double PI = Math.PI;
            Console.WriteLine("Ingresa el radio del circulo a calcular su area: ");

            double radio = double.Parse(Console.ReadLine());

            double area = Math.Pow(radio, 2) * PI;

            Console.WriteLine($"El area del circulo es {area}");
            
            //Un metodo void nunca llevara return

        }
    } 
}
