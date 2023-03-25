namespace Entidades
{
    public class Login
    {
        //Propiedades para Usuario
        public string CodigoUsuario { get; set; }
        public string Contraseña { get; set; }

        //Constructor vacio
        public Login()
        {

        }

        //Constructor con las propiedades
        public Login(string codigoUsuario, string contraseña)
        {
            CodigoUsuario = codigoUsuario;
            Contraseña = contraseña;
        }
    }
}
