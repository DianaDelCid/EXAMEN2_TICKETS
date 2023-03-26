using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Vistas
{
    public partial class TicketForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }
        Clientes miCliente = null; //declarado null
        ClientesDB clienteDB = new ClientesDB(); //instanciamos clientebd
        List<DetalleTicket> listaDetalles = new List<DetalleTicket>();
        TicketDB ticketDB = new TicketDB();

        //VARIABLES ACUMULADORAS
        decimal subTotal = 0;
        decimal isv = 0;
        decimal descuento = 0;
        decimal totalAPagar = 0;

        private void LimpiarControles()
        {
            miCliente = null;
            listaDetalles = null;
            FechaDateTimePicker.Value = DateTime.Now;
            IdentidadTextBox.Clear();
            NombreClienteTextBox.Clear();
            TipoSoporteComboBox = null;
            DescripcionSolicitudTextBox.Clear();
            DescripcionRespuestaTextBox.Clear();
            PrecioTextBox.Clear();
            DetalleDataGridView.DataSource = null;
            subTotal = 0;
            SubtotalTextBox.Clear();
            isv = 0;
            ISVTextBox.Clear();
            descuento = 0;
            DescuentoTextBox.Clear();
            totalAPagar = 0;
            TotalAPagarTextBox.Clear();
        }

        //EVENTO KEYPRESS PARA BUSCAR EL CLIENTE CUANDO DAMOS ENTER
        private void IdentidadTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(IdentidadTextBox.Text)) //si keychar es enter Y a ingresado algo va a buscar al objeto cliente
            {
                miCliente = new Clientes(); //instanciamos el objeto cliente
                miCliente = clienteDB.DevolverClientePorIdentidad(IdentidadTextBox.Text); //llamamos el metodo para buscar por identidad
                NombreClienteTextBox.Text = miCliente.Nombre; //devolvemos el nombre en el text box
            }
            else //sino no devuelve nada
            {
                miCliente = null; //mi cliente va hacer nulo
                NombreClienteTextBox.Clear(); //y limpiamos textbox 
            }

        }

        private void BuscarClienteButton_Click(object sender, System.EventArgs e)
        {
            BuscarClienteForm buscar = new BuscarClienteForm(); //instanciacion del fomulario
            buscar.ShowDialog(); //Mostrar el fomrulario

            miCliente = new Clientes(); //Instanciamos objeto
            miCliente = buscar.clientes;
            IdentidadTextBox.Text = miCliente.Identidad;
            NombreClienteTextBox.Text = miCliente.Nombre;

        }

        //PARA MOSTRAR EL USUARIO LOGUEADO
        private void TicketForm_Load(object sender, System.EventArgs e)
        {
            UsuarioTextBox.Text = System.Threading.Thread.CurrentPrincipal.Identity.Name; //accedemos al codigo de usuario
        }

        //EVENTO KEYPRESS DE PRECIO
        private void PrecioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validamos que no permita que ingrese letras solo numeros y que permita ingresar punto(.) para decimal
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && e.KeyChar != '\b') //si este caracter no es un numero (!)negando isdigtal para decimales
            {
                e.Handled = true; //handled lo cancela, no lo coloca en el textbox
            }

            //validar que solo deje ingresar dos numeros despues del punto
            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true; //handled lo cancela, no lo coloca en el textbox
            }


            //VALIDAMOS QUE DESPUES DE DAR ENTER MUESTRE EL DETALLE DEL TICKET
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(PrecioTextBox.Text) && !string.IsNullOrEmpty(TipoSoporteComboBox.Text) && !string.IsNullOrEmpty(DescripcionSolicitudTextBox.Text) && !string.IsNullOrEmpty(DescripcionRespuestaTextBox.Text))
                {
                    //AGREGAR SOPORTE
                    DetalleTicket detalle = new DetalleTicket(); //instancioms un objeto del detalle
                    detalle.TipoSoporte = TipoSoporteComboBox.Text;
                    detalle.DescripcionSolicitud = DescripcionSolicitudTextBox.Text;
                    detalle.DescripcionRespuesta = DescripcionRespuestaTextBox.Text;
                    detalle.Precio = Convert.ToDecimal(PrecioTextBox.Text);
                    detalle.Total = detalle.Precio;

                    //acumula cada vez que se ingresa productos
                    subTotal += detalle.Total;
                    isv = subTotal * 0.15M; //agregamos M para que sea decimal
                    totalAPagar = subTotal + isv;

                    listaDetalles.Add(detalle); //A la lista detalles le agregamos el objeto detalle

                    DetalleDataGridView.DataSource = null;
                    DetalleDataGridView.DataSource = listaDetalles;

                    //le pasamos a cada uno de los controles
                    SubtotalTextBox.Text = subTotal.ToString("N2"); //pasmos un formateador de tostring N2(para millares y decimales)
                    ISVTextBox.Text = isv.ToString("N2");
                    TotalAPagarTextBox.Text = totalAPagar.ToString("N2");

                    //Limpiamos los controles
                    TipoSoporteComboBox.Text = "";
                    DescripcionSolicitudTextBox.Clear();
                    DescripcionRespuestaTextBox.Clear();
                    PrecioTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Debe Ingresar todos los Datos de Detalle", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PrecioTextBox.Text) && !string.IsNullOrEmpty(TipoSoporteComboBox.Text) && !string.IsNullOrEmpty(DescripcionSolicitudTextBox.Text) && !string.IsNullOrEmpty(DescripcionRespuestaTextBox.Text))
            {
                //AGREGAR SOPORTE
                DetalleTicket detalle = new DetalleTicket(); //instancioms un objeto del detalle
                detalle.TipoSoporte = TipoSoporteComboBox.Text;
                detalle.DescripcionSolicitud = DescripcionSolicitudTextBox.Text;
                detalle.DescripcionRespuesta = DescripcionRespuestaTextBox.Text;
                detalle.Precio = Convert.ToDecimal(PrecioTextBox.Text);
                detalle.Total = detalle.Precio;

                //acumula cada vez que se ingresa productos
                subTotal += detalle.Total;
                isv = subTotal * 0.15M; //agregamos M para que sea decimal
                totalAPagar = subTotal + isv;

                listaDetalles.Add(detalle); //A la lista detalles le agregamos el objeto detalle

                DetalleDataGridView.DataSource = null;
                DetalleDataGridView.DataSource = listaDetalles;

                //le pasamos a cada uno de los controles
                SubtotalTextBox.Text = subTotal.ToString("N2"); //pasmos un formateador de tostring N2(para millares y decimales)
                ISVTextBox.Text = isv.ToString("N2");
                TotalAPagarTextBox.Text = totalAPagar.ToString("N2");

                //Limpiamos los controles
                TipoSoporteComboBox.Text = "";
                DescripcionSolicitudTextBox.Clear();
                DescripcionRespuestaTextBox.Clear();
                PrecioTextBox.Clear();

            }
            else
            {
                MessageBox.Show("Debe Ingresar todos los Datos de Detalle", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CrearTicketButton_Click(object sender, System.EventArgs e)
        {
            //REGISTRAR TICKET EN BASE DE DATOS
            Ticket miticket = new Ticket(); //instanciacion de objeto de la clase ticket
            miticket.Fecha = FechaDateTimePicker.Value;
            miticket.IdentidadCliente = miCliente.Identidad;
            miticket.CodigoUsuario = System.Threading.Thread.CurrentPrincipal.Identity.Name;
            miticket.Subtotal = subTotal;
            miticket.ISV = isv;
            miticket.Descuento = descuento;
            miticket.Total = totalAPagar;

            bool inserto = ticketDB.Crear(miticket, listaDetalles);
            if (inserto)
            {
                IdentidadTextBox.Focus();
                MessageBox.Show("TICKET REGISTRADO EXITOSAMENTE", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
                LimpiarControles();
            }
            else
            {
                MessageBox.Show("NO SE PUDO REGISTRAR EL TICKET", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DescuentoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validamos que no permita que ingrese letras solo numeros y que permita ingresar punto(.) para decimal
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && e.KeyChar != '\b') //si este caracter no es un numero (!)negando isdigtal para decimales
            {
                e.Handled = true; //handled lo cancela, no lo coloca en el textbox
            }

            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(DescuentoTextBox.Text))
            {
                descuento = Convert.ToDecimal(DescuentoTextBox.Text);
                totalAPagar = totalAPagar - descuento;
                TotalAPagarTextBox.Text = totalAPagar.ToString();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                string linea = "--------------------------------------------------------------------------------------------------------------------------------------------";
                Bitmap bitmap = Properties.Resources.logo;
                Image image = bitmap;
                e.Graphics.DrawImage(image, 230, 40);
                int ydetalles = 370;

                e.Graphics.DrawString("EMPRESA TECHNOLOGY", new Font("Cambria", 14, FontStyle.Bold), Brushes.Blue, new Point(305, 250));

                e.Graphics.DrawString("Cliente: ", new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new Point(50, 310));
                e.Graphics.DrawString(miCliente.Nombre, new Font("Calibri", 14, FontStyle.Regular), Brushes.Black, new Point(135, 310));

                e.Graphics.DrawString("Fecha: ", new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new Point(510, 310));
                e.Graphics.DrawString(FechaDateTimePicker.Value.ToString(), new Font("Calibri", 14, FontStyle.Regular), Brushes.Black, new Point(575, 310));

                e.Graphics.DrawString(linea, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(50, 340));

                e.Graphics.DrawString("Tipo de Soporte", new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new Point(50, ydetalles));
                e.Graphics.DrawString("Descripción Solicitud", new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new Point(50, ydetalles + 30));
                e.Graphics.DrawString("Descripción Respuesta", new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new Point(50, ydetalles + 60));
                e.Graphics.DrawString("Precio", new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new Point(50, ydetalles + 90));
                e.Graphics.DrawString("Total", new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new Point(50, ydetalles + 120));

                foreach (DetalleTicket item in listaDetalles)
                {
                    //ydetalles = ydetalles + 30;
                    e.Graphics.DrawString(item.TipoSoporte, new Font("Calibri", 14, FontStyle.Regular), Brushes.Black, new Point(260, ydetalles));
                    e.Graphics.DrawString(item.DescripcionSolicitud.ToString(), new Font("Calibri", 14, FontStyle.Regular), Brushes.Black, new Point(260, ydetalles + 30));
                    e.Graphics.DrawString(item.DescripcionRespuesta.ToString(), new Font("Calibri", 14, FontStyle.Regular), Brushes.Black, new Point(260, ydetalles + 60));
                    e.Graphics.DrawString(item.Precio.ToString("N2"), new Font("Calibri", 14, FontStyle.Regular), Brushes.Black, new Point(260, ydetalles + 90));
                    e.Graphics.DrawString(item.Total.ToString("N2"), new Font("Calibri", 14, FontStyle.Regular), Brushes.Black, new Point(260, ydetalles + 120));
                }
                e.Graphics.DrawString(linea, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(30, ydetalles + 150));

                e.Graphics.DrawString("Sub Total: ", new Font("Calibri", 12, FontStyle.Bold), Brushes.Black, new Point(600, ydetalles + 175));
                e.Graphics.DrawString(subTotal.ToString("N2"), new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(700, ydetalles + 175));
                e.Graphics.DrawString("ISV: ", new Font("Calibri", 12, FontStyle.Bold), Brushes.Black, new Point(648, ydetalles + 200));
                e.Graphics.DrawString(isv.ToString("N2"), new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(700, ydetalles + 200));
                e.Graphics.DrawString("Descuento: ", new Font("Calibri", 12, FontStyle.Bold), Brushes.Black, new Point(589, ydetalles + 225));
                e.Graphics.DrawString(descuento.ToString("N2"), new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(700, ydetalles + 225));
                e.Graphics.DrawString("Total: ", new Font("Calibri", 12, FontStyle.Bold), Brushes.Black, new Point(637, ydetalles + 250));
                e.Graphics.DrawString(totalAPagar.ToString("N2"), new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(700, ydetalles + 250));

                e.Graphics.DrawString("¡GRACIAS POR SU VISITA! ", new Font("Lucida Fax", 12, FontStyle.Bold), Brushes.Black, new Point(310, ydetalles + 280)); ; ;
            }
            catch (Exception)
            {

            }
        }

    }
}
