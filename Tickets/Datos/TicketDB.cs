using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public class TicketDB
    {
        //Cadena de conexion, campos donde esta el servidor
        string cadena = "server=localhost; user=root; database=ticket; password=diana21;";

        //METODO PARA CREAR TICKET
        public bool Crear(Ticket ticket, List<DetalleTicket> detalleTickets)
        {
            bool inserto = false;
            int idFactura = 0;

            try
            {
                //SENTENCIA SQL
                StringBuilder sqlTicket = new StringBuilder();
                sqlTicket.Append("INSERT INTO ticket (Fecha, IdentidadCliente, CodigoUsuario, SubTotal, ISV, Descuento, Total) VALUES (@Fecha, @IdentidadCliente, @CodigoUsuario, @SubTotal, @ISV, @Descuento, @Total);");
                sqlTicket.Append(" SELECT LAST_INSERT_ID();"); //sentencia que devuelve la ultima llave primaria de la tabla que se acaba de insertar

                //SENTENCIA PARA INSERTAR EL DETALLE DE TICKET
                StringBuilder sqlDetalle = new StringBuilder();
                sqlDetalle.Append(" INSERT INTO detalleticket (IdFactura, TipoSoporte, DescripcionSolicitud, DescripcionRespuesta, Precio, Total) VALUES (@IdFactura, @TipoSoporte, @DescripcionSolicitud, @DescripcionRespuesta, @Precio, @Total);");

                //OBJETO CADENA
                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open(); //Abre la conexion con la base de datos

                    //TRANSACCION
                    MySqlTransaction transaction = _conexion.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

                    try
                    {
                        using (MySqlCommand cmd1 = new MySqlCommand(sqlTicket.ToString(), _conexion, transaction))
                        {
                            cmd1.CommandType = System.Data.CommandType.Text;
                            //PARAMETROS DEL TICKET
                            cmd1.Parameters.Add("@Fecha", MySqlDbType.DateTime).Value = ticket.Fecha;
                            cmd1.Parameters.Add("@IdentidadCliente", MySqlDbType.VarChar, 25).Value = ticket.IdentidadCliente;
                            cmd1.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = ticket.CodigoUsuario;
                            cmd1.Parameters.Add("@SubTotal", MySqlDbType.Decimal).Value = ticket.Subtotal;
                            cmd1.Parameters.Add("@ISV", MySqlDbType.Decimal).Value = ticket.ISV;
                            cmd1.Parameters.Add("@Descuento", MySqlDbType.Decimal).Value = ticket.Descuento;
                            cmd1.Parameters.Add("@Total", MySqlDbType.Decimal).Value = ticket.Total;
                            idFactura = Convert.ToInt32(cmd1.ExecuteScalar()); //le asignamos al id para capturar el id

                        }

                        //ITERAMOS UNA LISTA DE DETALLE
                        foreach (DetalleTicket detalle in detalleTickets)
                        {
                            //PARA DETALLES SOPORTE
                            using (MySqlCommand cmd2 = new MySqlCommand(sqlDetalle.ToString(), _conexion, transaction))
                            {
                                cmd2.CommandType = System.Data.CommandType.Text;
                                //PARAMETROS DE DETALLE TICKET
                                cmd2.Parameters.Add("@IdFactura", MySqlDbType.Int32).Value = idFactura;
                                cmd2.Parameters.Add("@TipoSoporte", MySqlDbType.VarChar, 50).Value = detalle.TipoSoporte;
                                cmd2.Parameters.Add("@DescripcionSolicitud", MySqlDbType.VarChar, 100).Value = detalle.DescripcionSolicitud;
                                cmd2.Parameters.Add("@DescripcionRespuesta", MySqlDbType.VarChar, 100).Value = detalle.DescripcionRespuesta;
                                cmd2.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = detalle.Precio;
                                cmd2.Parameters.Add("@Total", MySqlDbType.Decimal).Value = detalle.Total;
                                cmd2.ExecuteNonQuery(); //No vamos a devolver solo a insertar

                            }
                        }
                        transaction.Commit(); //esto dice que ejecute la transaccion
                        inserto = true; //y si llego hasta aca va ser verdadero

                    }
                    catch (System.Exception ex)
                    {
                        inserto = false; //no inserto
                        transaction.Rollback(); //tendria un rollback (devuelve a la base de datos a donde quedo)
                        throw;
                    }

                }

            }
            catch (System.Exception ex)
            {

            }
            return inserto; //retorna el inserto
        }

    }
}
