using Datos;
using Entidades;
using System;

namespace Vistas
{
    public partial class BuscarClienteForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public BuscarClienteForm()
        {
            InitializeComponent();
        }
        ClientesDB clientesDB = new ClientesDB(); //Instaciacion del objeto clientesdb
        public Clientes clientes = new Clientes();

        //EVENTO LOAD PARA DEVOLVER CLIENTE CUANDO SE ABRA ESTE FORMULARIO
        private void BuscarClienteForm_Load(object sender, System.EventArgs e)
        {
            ClientesDataGridView.DataSource = clientesDB.DevolverClientes(); //Devuelve todos los registros de clientes
        }

        private void AceptarButton_Click(object sender, System.EventArgs e)
        {
            //validar que usuario selecciono un registro
            if (ClientesDataGridView.SelectedRows.Count > 0)
            {
                clientes.Identidad = ClientesDataGridView.CurrentRow.Cells["Identidad"].Value.ToString();
                clientes.Nombre = ClientesDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                clientes.Telefono = ClientesDataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
                clientes.Correo = ClientesDataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                clientes.Direccion = ClientesDataGridView.CurrentRow.Cells["Direccion"].Value.ToString();
                clientes.FechaNacimiento = Convert.ToDateTime(ClientesDataGridView.CurrentRow.Cells["FechaNacimiento"].Value);
                clientes.EstaActivo = Convert.ToBoolean(ClientesDataGridView.CurrentRow.Cells["EstaActivo"].Value);
                this.Close(); //cierra
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close(); //cierra este formulario
        }

        private void NombreTextBox_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            ClientesDataGridView.DataSource = clientesDB.DevolverClientesPorNombre(NombreTextBox.Text);
        }
    }
}
