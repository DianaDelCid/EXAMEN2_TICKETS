namespace Entidades
{
    public class DetalleTicket
    {
        //Propiedades
        public int Id { get; set; }
        public int IdFactura { get; set; }
        public string TipoSoporte { get; set; }
        public string DescripcionSolicitud { get; set; }
        public string DescripcionRespuesta { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }

        //Constructor vacio
        public DetalleTicket()
        {

        }

        //Constructor con parametros
        public DetalleTicket(int id, int idFactura, string tipoSoporte, string descripcionSolicitud, string descripcionRespuesta, decimal precio, decimal total)
        {
            Id = id;
            IdFactura = idFactura;
            TipoSoporte = tipoSoporte;
            DescripcionSolicitud = descripcionSolicitud;
            DescripcionRespuesta = descripcionRespuesta;
            Precio = precio;
            Total = total;
        }
    }
}
