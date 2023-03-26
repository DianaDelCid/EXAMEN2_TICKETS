using Datos;
using Entidades;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Vistas
{
    public partial class ClientesForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }
        string operacion; //Variable global para tipo de operacion
        Clientes clientes;
        ClientesDB clietesDB = new ClientesDB();


        //Metodo para habilitar Controles
        private void HabilitarControles()
        {
            IdentidadTextBox.Enabled = true;
            NombreTextBox.Enabled = true;
            TelefonoTextBox.Enabled = true;
            CorreoTextBox.Enabled = true;
            DireccionTextBox.Enabled = true;
            FechaNacimientoDateTimePicker.Enabled = true;
            EstaActivoCheckBox.Enabled = true;
            AgregarFotoButton.Enabled = true;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            NuevoButton.Enabled = false;
        }

        //Metodo para deshabilitar Controles
        private void DeshabilitarControles()
        {
            IdentidadTextBox.Enabled = false;
            NombreTextBox.Enabled = false;
            TelefonoTextBox.Enabled = false;
            CorreoTextBox.Enabled = false;
            DireccionTextBox.Enabled = false;
            FechaNacimientoDateTimePicker.Enabled = false;
            EstaActivoCheckBox.Enabled = false;
            AgregarFotoButton.Enabled = false;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
            NuevoButton.Enabled = true;
        }

        //Metodo para limpiar Controles
        private void LimpiarControles()
        {
            IdentidadTextBox.Clear();
            NombreTextBox.Clear();
            TelefonoTextBox.Clear();
            CorreoTextBox.Clear();
            DireccionTextBox.Clear();
            FechaNacimientoDateTimePicker.Text = "";
            EstaActivoCheckBox.Checked = false;
            FotoClientePictureBox.Image = null;
            //cliente = null; //declaramos el objeto nulo para la imagen no se repita
        }


        private void NuevoButton_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
        }

        //METODO PARA MODIFICAR
        private void ModificarButton_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";

            //Validar que selecciono un registro
            if (ClientesDataGridView.SelectedRows.Count > 0)
            {
                IdentidadTextBox.Text = ClientesDataGridView.CurrentRow.Cells["Identidad"].Value.ToString();
                NombreTextBox.Text = ClientesDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                TelefonoTextBox.Text = ClientesDataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
                CorreoTextBox.Text = ClientesDataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                DireccionTextBox.Text = ClientesDataGridView.CurrentRow.Cells["Direccion"].Value.ToString();
                FechaNacimientoDateTimePicker.Value = Convert.ToDateTime(ClientesDataGridView.CurrentRow.Cells["FechaNacimiento"].Value);
                EstaActivoCheckBox.Checked = Convert.ToBoolean(ClientesDataGridView.CurrentRow.Cells["EstaActivo"].Value);

                byte[] img = clietesDB.DevolverFoto(ClientesDataGridView.CurrentRow.Cells["Identidad"].Value.ToString());

                if (img.Length > 0) //si el arreglo es mayor de 0 byte
                {
                    MemoryStream ms = new MemoryStream(img);
                    FotoClientePictureBox.Image = System.Drawing.Bitmap.FromStream(ms); //pasamos la imagen al picturebox
                }
                HabilitarControles(); //y habilitamos los controles
                IdentidadTextBox.ReadOnly = true; //para no permitir que usuario modifique este campo, ya que es una llave primaria

            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro", " Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void GuardarButton_Click(object sender, EventArgs e)
        {
            clientes = new Clientes(); // aqui si ya lo instanciamos 
            //Ponerlo al inicio para no duplicar 
            clientes.Identidad = IdentidadTextBox.Text;
            clientes.Nombre = NombreTextBox.Text;
            clientes.Telefono = TelefonoTextBox.Text;
            clientes.Correo = CorreoTextBox.Text;
            clientes.Direccion = DireccionTextBox.Text;
            clientes.FechaNacimiento = FechaNacimientoDateTimePicker.Value;
            clientes.EstaActivo = EstaActivoCheckBox.Checked;

            if (FotoClientePictureBox.Image != null) //si es distinto a null si tiene imagen
            {
                //la propiedad de foto es un arreglo de byte asi que hay que convertirla la imagen a arreglo de byte
                System.IO.MemoryStream ms = new System.IO.MemoryStream(); //instanciamos un nuevo obejto de memory

                //al ms le pasamos la foto que tiene el picureBox
                FotoClientePictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                //Y para pasarlo a la propiedad
                clientes.Foto = ms.GetBuffer();
            }

            if (operacion == "Nuevo") //Vamos a guardar el nuevo producto
            {
                if (string.IsNullOrEmpty(IdentidadTextBox.Text))
                {
                    errorProvider1.SetError(IdentidadTextBox, "Ingrese Identidad");
                    IdentidadTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(NombreTextBox.Text))
                {
                    errorProvider1.SetError(NombreTextBox, "Ingrese Nombre");
                    NombreTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                bool inserto = clietesDB.Insertar(clientes); //variable que trae el metodo de insertar
                if (inserto)
                {
                    DeshabilitarControles();
                    LimpiarControles();
                    TraerClientes();
                    MessageBox.Show("Registro Guardado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (operacion == "Modificar") //Si no operacion es Modifico
            {
                bool modifico = clietesDB.Editar(clientes); //variable para traer el metodo editar
                if (modifico)
                {
                    IdentidadTextBox.ReadOnly = false; //lo ponemos false porque si no nos permite poner codigo
                    DeshabilitarControles();
                    LimpiarControles();
                    TraerClientes();
                    MessageBox.Show("Registro actualizado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            TraerClientes(); //llamamos el metodo traer clientes
        }

        private void TraerClientes()
        {
            ClientesDataGridView.DataSource = clietesDB.DevolverClientes(); //el data va a ser igual a la productodb.metodo
        }

        //METODO PARA ELIMINAR CLIENTE
        private void EliminarButton_Click(object sender, EventArgs e)
        {
            //Validar que usuario seleccione un registro
            if (ClientesDataGridView.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("Esta seguro de eliminar el registro", "Continúa ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //ventana para verificar

                if (resultado == DialogResult.Yes) //si es un si
                {
                    bool elimino = clietesDB.Eliminar(ClientesDataGridView.CurrentRow.Cells["Identidad"].Value.ToString());

                    if (elimino)
                    {
                        LimpiarControles();
                        DeshabilitarControles();
                        TraerClientes();
                        MessageBox.Show("Registro Eliminado", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar registro", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //Si no, no hace nada
            }
        }

        //PAR AGREGAR FOTO
        private void AgregarFotoButton_Click(object sender, EventArgs e)
        {
            //Abre una ventana para abjuntar openFileDialog es una clase 
            OpenFileDialog dialog = new OpenFileDialog();

            //Mostrar la ventana y capturar lo que el usuario selecciono
            DialogResult resultado = dialog.ShowDialog();

            //Condicion para evaluar si usuario selecciono imagen
            if (resultado == DialogResult.OK) //Si resultado fue sactifactorio
            {
                //a la clase Image asignamos el metodo FromFile convierte el tipo de imagen y le pasamos dialog el archivo quqe trae el dialog y se lo pasa al pictubox
                FotoClientePictureBox.Image = Image.FromFile(dialog.FileName);//file name para capturar nombre del archivo
            }
        }

    }
}
