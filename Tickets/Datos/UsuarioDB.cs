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

        //METODO PARA PERMITIR INGRESAR UN NUEVO USUARIO
        public bool Insertar(Usuario user)
        {
            bool inserto = false; //variable bool iniciada como falsa
            try //sentencia para capturar errores
            {
                //Sentencia SQL para intsertar un registro
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO usuario VALUES"); //para insertar en la tabla usuarios
                sql.Append(" (@CodigoUsuario, @Nombre, @Contrasena, @Correo, @Rol, @Foto, @FechaCreacion, @EstaActivo);"); //colocarlos en orden como en la tabla de sql

                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //para cerrar la conexion a la base de datos
                {
                    _conexion.Open(); //abre la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text; //sentencia de los parametros 
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = user.CodigoUsuario;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = user.Nombre;
                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 60).Value = user.Contraseña;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 40).Value = user.Correo;
                        comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 20).Value = user.Rol;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = user.Foto;
                        comando.Parameters.Add("@FechaCreacion", MySqlDbType.DateTime).Value = user.FechaCreacion;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = user.EstadoActivo;

                        comando.ExecuteNonQuery(); //no vamos a ejecutar, no devuelve ningun registro 
                        inserto = true; //si inserta es true(verdadero)
                    }
                } //al terminar la sentencia cierra la conexion

            }
            catch (System.Exception ex) //aqui devuelve el error si existe
            {

            }
            return inserto;
        }

        //METODO PARA EDITAR USUARIO
        public bool Editar(Usuario user)
        {
            bool idito = false; //variable bool iniciada como falsa
            try //sentencia para capturar errores
            {
                //Sentencia SQL para iditar un registro
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE usuario SET "); //para iditar en la tabla usuarios
                sql.Append(" Nombre = @Nombre, Contrasena = @Contrasena, Correo = @Correo, Rol = @Rol, Foto = @Foto, EstaActivo = @EstaActivo"); //campos a editar en sql
                sql.Append(" WHERE CodigoUsuario = @CodigoUsuario; "); //para ver que usuario se va a modificar

                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //para cerrar la conexion a la base de datos
                {
                    _conexion.Open(); //abre la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text; //sentencia de los parametros 
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = user.CodigoUsuario;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = user.Nombre;
                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 60).Value = user.Contraseña;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 40).Value = user.Correo;
                        comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 20).Value = user.Rol;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = user.Foto;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = user.EstadoActivo;

                        comando.ExecuteNonQuery(); //no vamos a ejecutar, no devuelve ningun registro 
                        idito = true; //si inserta es true(verdadero)
                    }
                } //al terminar la sentencia cierra la conexion

            }
            catch (System.Exception ex) //aqui devuelve el error si existe
            {

            }
            return idito;

        }

        //METODO PARA ELIMINAR RESGISTRO
        public bool Eliminar(string codigoUsuario)
        {
            bool elimino = false; //variable bool iniciada como falsa
            try //sentencia para capturar errores
            {
                //Sentencia SQL para eliminar un registro
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM usuario"); //para eliminar en la tabla usuarios
                sql.Append(" WHERE CodigoUsuario = @CodigoUsuario; "); //para saber que usuario va a eliminar

                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //para cerrar la conexion a la base de datos
                {
                    _conexion.Open(); //abre la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text; //sentencia de los parametros 
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = codigoUsuario;
                        comando.ExecuteNonQuery(); //no vamos a ejecutar, no devuelve ningun registro 
                        elimino = true; //si elimina es true(verdadero)
                    }
                } //al terminar la sentencia cierra la conexion

            }
            catch (System.Exception ex) //aqui devuelve el error si existe
            {

            }
            return elimino;

        }

        //METODO QUE PERMITE TRAERTODOS LOS REGISTROS DE LOS USUARIOS
        public DataTable DevolverUsuarios()
        {
            DataTable dt = new DataTable(); //Instanciacion un DataTable
            try //sentencia para capturar errores
            {
                //Sentencia SQL para traer los registros
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT *FROM usuario"); //para traer todos los registros

                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //para cerrar la conexion a la base de datos
                {
                    _conexion.Open(); //abre la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text; //sentencia de los parametros 
                        MySqlDataReader dr = comando.ExecuteReader(); //DataRider
                        dt.Load(dr); //se lo pasamos al datatable
                    }
                } //al terminar la sentencia cierra la conexion

            }
            catch (System.Exception ex) //aqui devuelve el error si existe
            {

            }
            return dt;

        }

        //METODO QUE PERMITE TRAER LA FOTO DEL USUARIO
        public byte[] DevolverFoto(string codigoUsuario)
        {
            byte[] foto = new byte[0];

            try //sentencia para capturar errores
            {
                //Sentencia SQL para traer los registros
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT Foto FROM usuario WHERE CodigoUsuario = @CodigoUsuario"); //para traer todos los registros

                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //para cerrar la conexion a la base de datos
                {
                    _conexion.Open(); //abre la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text; //sentencia de los parametros 
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = codigoUsuario;
                        MySqlDataReader dr = comando.ExecuteReader(); //DataRider

                        //validacion si hay foto
                        if (dr.Read())
                        {
                            foto = (byte[])dr["Foto"]; //le pasamos la foto
                        }
                    }
                } //al terminar la sentencia cierra la conexion

            }
            catch (System.Exception ex) //aqui devuelve el error si existe
            {

            }
            return foto;
        }

    }
}
