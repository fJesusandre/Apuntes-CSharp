using System;

class ParadigmaPOO{
    static void Main(string[] args){

        Circulo circulo1 = new Circulo(); //Declaracion, Creacion de objeto de tipo circulo e iniciacion del objeto o instanciar una clase. 
        Console.WriteLine( circulo1.calculoArea(3));

    }

    class Circulo{
        double pi = 3.1416; // Propiedad; Campo de clase.
        public double calculoArea(int radio){
            
            return pi*radio*radio;
        }

    }
}

