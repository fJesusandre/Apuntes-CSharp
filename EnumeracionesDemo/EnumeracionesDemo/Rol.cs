using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeracionesDemo
{
    enum Rol : short //Eligiendo el tipo de dato del enum
    {
        //Por defecto se inicia en 0
        Administrador, // = 3, se puede modificar el numero del indice de los elementos del enum
        Desarrollador,
        UsuarioFinal

    }
}
