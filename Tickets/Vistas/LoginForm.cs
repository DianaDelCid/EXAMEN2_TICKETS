using Datos;
using Entidades;
using System.Windows.Forms;

namespace Vistas
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, System.EventArgs e)
        {
            //Validar que ingrese los datos
            if (string.IsNullOrEmpty(UsuarioTextBox.Text))
            {
                errorProvider1.SetError(UsuarioTextBox, "Ingrese usuario");
                UsuarioTextBox.Focus();
                return;
            }
            errorProvider1.Clear(); //borra el error
            if (string.IsNullOrEmpty(ContraseñaTextBox.Text))
            {
                errorProvider1.SetError(ContraseñaTextBox, "Ingrese Contraseña");
                ContraseñaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            //VALIDAR EN LA BASE DE DATOS
            //Instanciacion de objetos
            Login login = new Login(UsuarioTextBox.Text, ContraseñaTextBox.Text); //objeto con los parametros
            Usuario usuario = new Usuario();
            UsuarioDB usuarioDB = new UsuarioDB();

            usuario = usuarioDB.Autenticar(login); //metodo con parametro de la clase login

            //Validar 
            if (usuario != null) //si es distinto de null
            {
                if (usuario.EstadoActivo) //validar si usuario esta activo
                {
                    //PARA AUTENTICACION es decir la seccion o aurorizaciones de ese usuario
                    System.Security.Principal.GenericIdentity identidad = new System.Security.Principal.GenericIdentity(usuario.CodigoUsuario);
                    System.Security.Principal.GenericPrincipal principal = new System.Security.Principal.GenericPrincipal(identidad, new string[] { usuario.Rol });
                    System.Threading.Thread.CurrentPrincipal = principal;

                    //Mostrar el Menu
                    Menu menuForm = new Menu(); //Instanciamos el fomulario Menu
                    Hide(); //hide (ocultar) Para ocultar el formulario login
                    menuForm.Show(); //accedemos a ese objeto con el metodo show que muestra el form
                }
                else
                {
                    MessageBox.Show("El usuario no esta activo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Datos de usuario incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CancelarButton_Click(object sender, System.EventArgs e)
        {
            Close(); //metodo para cerrar el formulario
        }

        //METODO PARA MOSTRAR Y OCULTAR CONTRASEÑA
        private void VisualizarContraseñaButton_Click(object sender, System.EventArgs e)
        {
            //Validar las propiedades de passwordchar
            if (ContraseñaTextBox.PasswordChar == '*')
            {
                ContraseñaTextBox.PasswordChar = '\0'; //pasamos la propiedad en null para que muestre la contraseña
            }
            else
            {
                ContraseñaTextBox.PasswordChar = '*'; //oculta contraseña de nuevo
            }
        }

    }
}
