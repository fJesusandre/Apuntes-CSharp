using System;

namespace ApuntesPOODos{

    internal class Program{
        static void Main(string[] args){
            Coche autoOne = new Coche(); //instanciacion. Se dio un estado inicial al autoOne. Se hace uso del constructor.

            Console.WriteLine(autoOne.getInfoCoche());

            Coche autoTwo = new Coche(4000.5, 1500.3);

            Console.WriteLine(autoTwo.getInfoCoche());
        }
    }

    class Coche{

        // Constructor. Lleva el mismo nombre de la clase y no lleva void ni regresa ningun valor.
        public Coche(){
            ruedas = 4;

            largo = 2300.5;

            ancho = 1000;
        }

        // Sobrecarga de constructores.
        public Coche(double largoEsp, double anchoEsp){
            ruedas = 4;
            largo = largoEsp;
            ancho = anchoEsp;
        }

        // Metodo de acceso. Getter.
        public string getInfoCoche(){
            return $"Informacion del coche:\n\nCantidad de ruedas: {ruedas}\nDimensiones del coche: {largo}x{ancho}";
        }

        private int ruedas;
        private double largo;
        private double ancho;
        private bool clima;
        private string tapiceria;
    }
}