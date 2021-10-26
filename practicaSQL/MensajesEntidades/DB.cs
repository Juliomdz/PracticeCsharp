using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajesEntidades
{
    class DB
    {
        private string connstr;

        public DB( string connstr)
        {
            this.connstr = connstr;
        }


        public List<Usuario> RetornarUsuarios()
        {
            string consulta = "select id, usuario, pass, nombre from usuarios";
            List<Usuario> usuarios = new List<Usuario>();
            SqlConnection cn = new SqlConnection(this.connstr);
            SqlCommand cm = new SqlCommand(consulta, cn);
            try
            {
                cn.Open();
                SqlDataReader sqlDataReader = cm.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Usuario user = new Usuario();
                    user.Id = (int)(decimal)sqlDataReader["id"];
                    user.User = sqlDataReader["Usuario"].ToString();
                    user.Pass = sqlDataReader["Pass"].ToString();
                    user.Nombre = sqlDataReader["Nombre"].ToString();

                    usuarios.Add(user);
                }
            }
            finally
            {
                cn.Close();
            }
            return usuarios;
        }

        public int CrearUsuario(Usuario usuario)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = this.connstr;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = $"Insert into usuarios (usuario, pass, nombre) values ('{usuario.User}', '{usuario.Pass}', '{usuario.Nombre}')";
            sqlCommand.Connection = sqlConnection;

            try
            {
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
            finally
            {

                sqlConnection.Close();
            }

        }
    }
}
