using System;

namespace ApuntesPOODos{
    /* 1ra Division de la clase Coche*/
    partial class Coche{

        private int ruedas;
        private double largo;
        private double ancho;
        private bool clima;
        private string tapiceria;

        // Constructor. Lleva el mismo nombre de la clase y no lleva void ni regresa ningun valor.
        public Coche(){
            ruedas = 4;
            largo = 2300.5;
            ancho = 1000;
            tapiceria = "Tela";
        }

        // Sobrecarga de constructores.
        public Coche(double largo, double ancho){
            ruedas = 4;
            tapiceria = "Tela";
            this.largo = largo;
            this.ancho = ancho;
        }
    }

    /* 2da Division de la clase Coche*/
    partial class Coche {
        // Metodo de acceso. Getter.
        public string getInfoCoche(){
            return $"Informacion del coche:\n\nCantidad de ruedas: {ruedas}\nDimensiones del coche: {largo}x{ancho}";
        }

        public void setExtras(bool clima, string tapiceria){

            //this. se usa para diferenciar entre campos de clase y parametros con el mismo nombre.
            // Hace referencia a la clase en la que se encuentra.
            // Osea, al clima de esta clase asigna el valor del otro clima, en este caso el parametro.
            // al reves {clima = this.clima;}, seria, a la variable clima asigna el valor de clima de esta clase.
            this.clima = clima;
            this.tapiceria = tapiceria;
        }

        public string getExtras(){
            return $"Caracteristicas extras:\n\nClima: {clima}\nTapiceria: {tapiceria}";
        }

    }
}