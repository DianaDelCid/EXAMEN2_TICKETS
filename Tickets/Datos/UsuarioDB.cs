using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;

namespace Datos
{
    public class UsuarioDB
    {
        //Cadena de conexion
        string cadena = "server=localhost; user=root; database=ticket; password=diana21;";

        //METODO PARA PERMITIR INGRESAR A USUARIO
        public Usuario Autenticar(Login login)
        {
            Usuario user = null; //objeto user inicializado vacio

            //Sentencia para capturar errores
            try
            {
                //CODIGO PARA TRAER USUARIO
                //Sentencia SQL
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM usuario WHERE CodigoUsuario = @CodigoUsuario AND Contrasena = @Contrasena;"); //devuelve los usuarios de la base de datos

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open(); //Abre la conexion con la base de datos
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text; //sentencia de texto
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = login.CodigoUsuario;
                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 50).Value = login.Contraseña;

                        //ejecutar sentencia
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            user = new Usuario(); //instanciando user ya con datos

                            user.CodigoUsuario = dr["CodigoUsuario"].ToString();
                            user.Nombre = dr["Nombre"].ToString();
                            user.Contraseña = dr["Contrasena"].ToString();
                            user.Correo = dr["Correo"].ToString();
                            user.Rol = dr["Rol"].ToString();
                            user.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]); //convertir en datatime
                            user.EstadoActivo = Convert.ToBoolean(dr["EstaActivo"]); //convertir en boolean

                            if (dr["Foto"].GetType() != typeof(DBNull)) //si tipo de dato es distinto de null
                            {
                                user.Foto = (byte[])dr["Foto"]; //este es un arreglo de byte
                            }
                        }
                    }
                } //al terminar la sentencia cierra la conexion
            }
            catch (System.Exception ex) //Devuelve el error si existe
            {

            }
            return user; //retorna el objeto
        }

    }
}
