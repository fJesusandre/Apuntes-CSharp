using System;

public class DinamicFile : MultimediaFile
{
	string duracion;
    public DinamicFile(string fechaCreacion, string fechaModificacion, string nombre, string tipoElemento)
    //: base(fechaCreacion, fechaModificacion, nombre, tipoElemento) Llamar constructor de la clase padre
    {
        this.fechaCreacion = fechaCreacion;
        this.fechaModificacion = fechaModificacion;
        this.nombre = nombre;
        this.tipoElemento = tipoElemento;
    }
    public void Reproducir()
	{
        Console.WriteLine("Reproduciendo");
    }

    public void Pausar()
    {
        Console.WriteLine("Pausado");
    }

    public void Detener()
    {
        Console.WriteLine("Detenido");
    }

}
