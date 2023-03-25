using System;

namespace Entidades
{
    public class Ticket
    {
        //Propiedades
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string IdentidadCliente { get; set; }
        public string CodigoUsuario { get; set; }
        public decimal Precio { get; set; }
        public decimal Subtotal { get; set; }
        public decimal ISV { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }

        //Constructor vacio
        public Ticket()
        {

        }

        //Constructor con parametros
        public Ticket(int id, DateTime fecha, string identidadCliente, string codigoUsuario, decimal precio, decimal subtotal, decimal iSV, decimal descuento, decimal total)
        {
            Id = id;
            Fecha = fecha;
            IdentidadCliente = identidadCliente;
            CodigoUsuario = codigoUsuario;
            Precio = precio;
            Subtotal = subtotal;
            ISV = iSV;
            Descuento = descuento;
            Total = total;
        }
    }
}
