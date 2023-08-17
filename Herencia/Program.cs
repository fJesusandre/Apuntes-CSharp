namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MultimediaFile mFile = new MultimediaFile(/*"17/08/2023", "17/08/2023", "Archivo", "Video"*/);

            DinamicFile dFile = new DinamicFile("17/08/2023", "17/08/2023", "Archivo", "Video");
            StaticFile sFile = new StaticFile("17/08/2023", "17/08/2023", "Foto", "Imagen");

            sFile.Editar();

            mFile.DesplegarInfo();
            sFile.DesplegarInfo();
            dFile.DesplegarInfo();

        }
    }
}