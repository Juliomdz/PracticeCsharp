using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajesEntidades
{
    public class Usuario
    {

        private int id;
        private string pass;
        private string user;
        private string nombre;

        public Usuario()
        {

        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
