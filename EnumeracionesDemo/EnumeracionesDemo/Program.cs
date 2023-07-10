namespace EnumeracionesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rol tipoUsuario = Rol.Administrador;

            if(tipoUsuario == Rol.Administrador)
            {
                tipoUsuario++;
            }

            //Rol? UsuarioNulo = null;

            string valorTUsuarioGuardado = tipoUsuario.ToString();

            switch (tipoUsuario)
            {
                case Rol.Administrador:
                    Console.WriteLine(tipoUsuario);
                    break;
                case Rol.Desarrollador:
                    Console.WriteLine(tipoUsuario);
                    break;
                case Rol.UsuarioFinal:
                    Console.WriteLine(tipoUsuario);
                    break;
            }
        }
    }
}