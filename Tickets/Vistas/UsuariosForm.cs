namespace Vistas
{
    public partial class UsuariosForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        //Metodo para habilitar los controles
        private void HabilitarControles()
        {
            CodigoTextBox.Enabled = true;
            NombreTextBox.Enabled = true;
            ContraseñaTextBox.Enabled = true;
            CorreoTextBox.Enabled = true;
            RolComboBox.Enabled = true;
            EstaActivoCheckBox.Enabled = true;
            AgregarFotoButton.Enabled = true;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            ModificarButton.Enabled = false;
        }

        //Metodo para Deshabilitar los controles
        private void DeshabilitarControles()
        {
            CodigoTextBox.Enabled = false; //solo ponemos la propiedad en falso 
            NombreTextBox.Enabled = false;
            ContraseñaTextBox.Enabled = false;
            CorreoTextBox.Enabled = false;
            RolComboBox.Enabled = false;
            EstaActivoCheckBox.Enabled = false;
            AgregarFotoButton.Enabled = false;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
            ModificarButton.Enabled = true;
        }

        //Metodo para limpiar controles
        private void LimpiarControles()
        {
            CodigoTextBox.Clear();
            NombreTextBox.Clear();
            ContraseñaTextBox.Clear();
            CorreoTextBox.Clear();
            RolComboBox.Text = "";
            EstaActivoCheckBox.Checked = false;
            FotoPictureBox.Image = null; //para borra la foto
        }


        private void NuevoButton_Click(object sender, System.EventArgs e)
        {
            CodigoTextBox.Focus();
            HabilitarControles();

        }
    }
}
