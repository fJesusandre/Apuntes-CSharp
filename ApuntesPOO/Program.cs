using System;

namespace ParadigmaPOO{
    class Program{

        // los identificadores "public" deben de ir en notacion PascalCase y los "private" en camelCase.

        static void Main(string[] args){

            Circulo circulo1 = new Circulo(); //Declaracion, Creacion de objeto de tipo circulo e iniciacion del objeto o instanciar una clase. 
            Console.WriteLine( circulo1.CalculoArea(3));
            Console.WriteLine(circulo1.Color = "azul");// Esto es una mala practica, hay que usar metodos de acceso.
            circulo1.DeterminarCantidad(2);
            Console.WriteLine($"Cantidad de circulos creados: {circulo1.ConsultarCantidad()}");
        }
    }
    class Circulo{
        private const double pi = 3.1416; // Propiedad; Campo de clase. Esta encapsulada, es recomendable usar private. 
        public string Color = "Sin color";
        private int Cantidad = 1;
        public double CalculoArea(int radio){
            
            return pi*radio*radio;
        }

    // Metodos de acceso
        public void DeterminarCantidad(int cantidadNueva){
            if(cantidadNueva > 1) Cantidad = cantidadNueva;
        }

        public int ConsultarCantidad(){
            return Cantidad;
        }

    }
    
}


