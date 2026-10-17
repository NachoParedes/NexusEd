using Models;
using System;
using System.Windows.Forms;

namespace Views
{
    public partial class DarAltaInstituto : Form
    {
        public DarAltaInstituto()
        {
            InitializeComponent();
        }

        public void LimpiarCampos()
        {
            mtIdInstituto.Clear();
            tNombreInstituto.Clear();
            tDireccionInstituto.Clear();
            mtTelefonoInstituto.Clear();
            tContactoInstituto.Clear();
        }

        private void DarAltaInstituto_Load(object sender, EventArgs e)
        {
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtIdInstituto.Text) || string.IsNullOrWhiteSpace(tNombreInstituto.Text))
            {
                MessageBox.Show("Por favor, complete al menos los campos obligatorios (ID y Nombre).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = Convert.ToInt32(mtIdInstituto.Text);
                string nombre = tNombreInstituto.Text;
                string direccion = tDireccionInstituto.Text;
                int telefono = Convert.ToInt32(mtTelefonoInstituto.Text);
                string contacto = tContactoInstituto.Text;

                // TODO: Insertar el instituto en la base de datos MySQL
                // Ejemplo futuro:
                // Instituto nuevoInstituto = new Instituto(id, nombre, direccion, telefono, contacto);
                // repositorioInstitutos.Agregar(nuevoInstituto);

                MessageBox.Show("Instituto dado de alta correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en los datos ingresados. Verifique que el ID y el teléfono sean números válidos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea salir? \nSe perderán los datos no guardados", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
