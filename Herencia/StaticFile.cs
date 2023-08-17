using System;

public class StaticFile : MultimediaFile
{

    public StaticFile(string fechaCreacion, string fechaModificacion, string nombre, string tipoElemento)
    //////: base(fechaCreacion, fechaModificacion, nombre, tipoElemento) Llamar constructor de la clase padre
    {
        this.fechaCreacion = fechaCreacion;
        this.fechaModificacion = fechaModificacion;
        this.nombre = nombre;
        this.tipoElemento = tipoElemento;
    }

    public override void DesplegarInfo() => Console.WriteLine("StaticFile detalles");

    public virtual void Editar() => Console.WriteLine("Editando");
}

