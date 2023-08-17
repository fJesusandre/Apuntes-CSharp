using System;
using System.Collections.Specialized;

public class MultimediaFile
{
	protected string fechaCreacion;
    protected string fechaModificacion;
    protected string nombre;
    protected string tipoElemento;


	//public MultimediaFile(string fechaCreacion, string fechaModificacion, string nombre, string tipoElemento) { 
	//	this.fechaCreacion = fechaCreacion;
	//	this.fechaModificacion = fechaModificacion;
	//	this.nombre = nombre;
	//	this.tipoElemento = tipoElemento;
	//}

	public void DesplegarInfo()
	{
		string informacion = $"{fechaCreacion} {fechaModificacion} {nombre} {tipoElemento}";

        Console.WriteLine(informacion);

    }
}
