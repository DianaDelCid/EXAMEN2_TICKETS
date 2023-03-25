using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;

namespace Datos
{
    public class ClientesDB
    {
        //Cadena de conexion, campos donde esta el servidor
        string cadena = "server=localhost; user=root; database=ticket; password=diana21;";

        //METODO PARA PERMITIR REGISTRAR CLIENTES
        public bool Insertar(Clientes cliente) //domo parametro el objeto de entidades
        {
            bool inserto = false; //variable boolena inicializada como falsa
            try //sentencia para capturar errores
            {
                //Sentencia SQL para insertar un registro
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO cliente VALUES"); //para insertar en la tabla usuarios
                sql.Append(" (@Identidad, @Nombre, @Telefono, @Correo, @Direccion, @FechaNacimiento, @EstaActivo, @Foto);");
                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //para cerrar la conexion a la base de datos
                {
                    _conexion.Open(); //abre la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text; //sentencia de los parametros 
                        comando.Parameters.Add("@Identidad", MySqlDbType.VarChar, 25).Value = cliente.Identidad;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 40).Value = cliente.Nombre;
                        comando.Parameters.Add("@Telefono", MySqlDbType.VarChar, 15).Value = cliente.Telefono;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = cliente.Correo;
                        comando.Parameters.Add("@Direccion", MySqlDbType.VarChar, 100).Value = cliente.Direccion;
                        comando.Parameters.Add("@FechaNacimiento", MySqlDbType.DateTime).Value = cliente.FechaNacimiento;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = cliente.EstaActivo;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = cliente.Foto;
                        comando.ExecuteNonQuery();
                        inserto = true; //inserto verdadero
                    }
                } //al terminar la sentencia cierra la conexion
            }
            catch (System.Exception ex) //aqui devuelve el error si existe
            {

            }
            return inserto;
        }

        //METODO PARA EDITAR O MODIFICAR CLIENTE
        public bool Editar(Clientes cliente)
        {
            bool edito = false; //variable booleana iniciada como falsa
            try //sentencia para capturar errores
            {
                //Sentencia SQL para iditar un registro
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE cliente SET "); //para iditar en la tabla usuarios
                sql.Append(" Nombre = @Nombre, Telefono = @Telefono, Correo = @Correo, Direccion = @Direccion, FechaNacimiento = @FechaNacimiento, EstaActivo = @EstaActivo, Foto = @Foto"); //campos a editar en sql
                sql.Append(" WHERE Identidad = @Identidad; "); //para ver que usuario se va a modificar

                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //para cerrar la conexion a la base de datos
                {
                    _conexion.Open(); //abre la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text; //sentencia de los parametros 
                        comando.Parameters.Add("@Identidad", MySqlDbType.VarChar, 25).Value = cliente.Identidad;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 40).Value = cliente.Nombre;
                        comando.Parameters.Add("@Telefono", MySqlDbType.VarChar, 15).Value = cliente.Telefono;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = cliente.Correo;
                        comando.Parameters.Add("@Direccion", MySqlDbType.VarChar, 100).Value = cliente.Direccion;
                        comando.Parameters.Add("@FechaNacimiento", MySqlDbType.DateTime).Value = cliente.FechaNacimiento;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = cliente.EstaActivo;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = cliente.Foto;
                        comando.ExecuteNonQuery(); //no devuelve ningun registro 
                        edito = true; //si inserta es true(verdadero)
                    }
                } //al terminar la sentencia cierra la conexion

            }
            catch (System.Exception ex) //aqui devuelve el error si existe
            {

            }
            return edito;

        }

        //METODO PARA ELIMINAR REGISTRO DE CLIENTE
        public bool Eliminar(string identidad)
        {
            bool elimino = false; //variable bool iniciada como falsa
            try //sentencia para capturar errores
            {
                //Sentencia SQL para eliminar un registro
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM cliente"); //para eliminar en la tabla usuarios
                sql.Append(" WHERE Identidad = @Identidad; "); //para ver que usuario se va a eliminar

                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //para cerrar la conexion a la base de datos
                {
                    _conexion.Open(); //abre la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text; //sentencia de los parametros 
                        comando.Parameters.Add("@Identidad", MySqlDbType.VarChar, 25).Value = identidad;
                        comando.ExecuteNonQuery(); //no devuelve ningun registro 
                        elimino = true; //si elimina es true(verdadero)
                    }
                } //al terminar la sentencia cierra la conexion
            }
            catch (System.Exception ex) //aqui devuelve el error si existe
            {

            }
            return elimino;

        }

        //METODO QUE PERMITE TRAER TODOS LOS CLIENTES EN DATAGRIP
        public DataTable DevolverClientes()
        {
            DataTable dt = new DataTable(); //instanciacion un DataTable
            try //sentencia para capturar errores
            {
                //Sentencia SQL para traer los registros
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT *FROM cliente"); //para traer todos los registros

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

        //METODO PARA TRAER LA IMAGEN DEL CLIENTE
        public byte[] DevolverFoto(string identidad)
        {
            byte[] foto = new byte[0];

            try //sentencia para capturar errores
            {
                //Sentencia SQL para traer los registros
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT Foto FROM cliente WHERE Identidad = @Identidad"); //para traer todos los registros

                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //para cerrar la conexion a la base de datos
                {
                    _conexion.Open(); //abre la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text; //sentencia de los parametros 
                        comando.Parameters.Add("@Identidad", MySqlDbType.VarChar, 25).Value = identidad;
                        MySqlDataReader dr = comando.ExecuteReader(); //DataRider

                        //validacion si hay algo
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

        //METODO PARA DEVOLVER CLIENTE QUE SIRVE PARA TICKET
        public Clientes DevolverClientePorIdentidad(string identidad)
        {
            Clientes cliente = null;
            try //sentencia para capturar errores
            {
                //Sentencia SQL para traer los registros
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT *FROM cliente WHERE Identidad = @Identidad;"); //para traer todos los registros

                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //para cerrar la conexion a la base de datos
                {
                    _conexion.Open(); //abre la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text; //sentencia de los parametros 
                        comando.Parameters.Add("@Identidad", MySqlDbType.VarChar, 25).Value = identidad;
                        MySqlDataReader dr = comando.ExecuteReader(); //DataRider

                        if (dr.Read())
                        {
                            cliente = new Clientes();

                            cliente.Identidad = identidad;
                            cliente.Nombre = dr["Nombre"].ToString();
                            cliente.Telefono = dr["Telefono"].ToString();
                            cliente.Correo = dr["Correo"].ToString();
                            cliente.Direccion = dr["Direccion"].ToString();
                            cliente.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
                            cliente.EstaActivo = Convert.ToBoolean(dr["Nombre"]);

                        }
                    }
                } //al terminar la sentencia cierra la conexion

            }
            catch (System.Exception ex) //aqui devuelve el error si existe
            {

            }
            return cliente; //retornamos cliente

        }

        //METODO PARA DEVOLVER CLIENTE POR NOMBRE
        public DataTable DevolverClientesPorNombre(string nombre)
        {
            DataTable dt = new DataTable(); //un DataTable
            try //sentencia para capturar errores
            {
                //Sentencia SQL para traer los registros
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT *FROM cliente WHERE Nombre LIKE  '%" + nombre + "%'"); //para traer el cliente LIKE es un filtro para traer los del mismo nombre

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


    }
}
