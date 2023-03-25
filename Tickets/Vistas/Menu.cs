using System;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Menu : Syncfusion.Windows.Forms.Office2010Form
    {
        public Menu()
        {
            InitializeComponent();

        }

        //Metodo para boton de usuarios
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //instanciar un objeto de la clase usuarios
            UsuariosForm userForm = new UsuariosForm();
            userForm.MdiParent = this; //propiedad que dice que va a tener un padre
            userForm.Show(); //mostrar el formulario
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ClientesForm clientesForm = new ClientesForm();
            clientesForm.MdiParent = this;
            clientesForm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            TicketForm ticketForm = new TicketForm();
            ticketForm.MdiParent = this;
            ticketForm.Show();
        }

        private void backStageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
