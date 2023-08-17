using System;

public class DinamicFile : MultimediaFile
{
	string duracion;
    public DinamicFile(string fechaCreacion, string fechaModificacion, string nombre, string tipoElemento)
    ////: base(fechaCreacion, fechaModificacion, nombre, tipoElemento) Llamar constructor de la clase padre
    {
        this.fechaCreacion = fechaCreacion;
        this.fechaModificacion = fechaModificacion;
        this.nombre = nombre;
        this.tipoElemento = tipoElemento;
    }
    public virtual void Reproducir()
	{
        Console.WriteLine("Reproduciendo");
    }

    public virtual void Pausar()
    {
        Console.WriteLine("Pausado");
    }

    public virtual void Detener()
    {
        Console.WriteLine("Detenido");
    }

    public override void DesplegarInfo()
    {
        Console.WriteLine( "DinamicFile detalles");
    }

}
