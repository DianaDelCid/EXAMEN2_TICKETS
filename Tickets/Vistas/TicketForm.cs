using Datos;
using Entidades;
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

        //EVENTO KEYPRESS PARA BUSCAR EL CLIENTE CUANDO DAMOS ENTER
        private void IdentidadTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(IdentidadTextBox.Text)) //si keychar es enter Y a ingresado aldo va a buscar al objeto cliente
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


        }
    }
}
