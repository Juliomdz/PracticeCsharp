using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajesEntidades
{
    public class Mensajeria
    {
        static List<Usuario> usuarios;



        public static bool BuscarUsuarios()
        {
            DB miBase = new DB("Data Source=190.210.161.90; Integrated Security=false;User ID=alumno;Password=alumno;Initial Catalog=UTN");
            Mensajeria.usuarios = miBase.RetornarUsuarios();
            return true;
        }
        public static bool InstertarUsuario(Usuario nuevoUsuario)

        {
            DB miBase = new DB("Data Source=190.210.161.90; Integrated Security=false;User ID=alumno;Password=alumno;Initial Catalog=UTN");
            Mensajeria.usuarios = miBase.RetornarUsuarios();
            return miBase.CrearUsuario(nuevoUsuario) ==1;
        }
    }
}
