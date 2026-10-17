using Models;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Views
{
    public partial class DarAltaProfesor : Form
    {
        public DarAltaProfesor()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            tNombre.Clear();
            tApellido.Clear();
            tEmail.Clear();
            tTituloUniver.Clear();
            mtDocumento.Clear();
            mtLegajo.Clear();
            mtFechaNacimiento.Clear();
        }

        private void DarAltaProfesor_Load(object sender, EventArgs e)
        {
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tNombre.Text) || string.IsNullOrWhiteSpace(tApellido.Text) || string.IsNullOrWhiteSpace(mtDocumento.Text))
            {
                MessageBox.Show("Por favor, complete al menos los campos obligatorios (Nombre, Apellido y Documento).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string nombre = tNombre.Text;
                string apellido = tApellido.Text;
                string email = tEmail.Text;
                string titulo = tTituloUniver.Text;
                int doc = Convert.ToInt32(mtDocumento.Text);
                int legajo = Convert.ToInt32(mtLegajo.Text);
                DateTime fechaNac = Convert.ToDateTime(mtFechaNacimiento.Text);

                // TODO: Insertar el profesor en la base de datos MySQL
                // Ejemplo futuro:
                // Profesor nuevoProfesor = new Profesor(nombre, apellido, doc, fechaNac, email, legajo, titulo);
                // repositorioProfesores.Agregar(nuevoProfesor);

                MessageBox.Show("Profesor dado de alta correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en los datos ingresados. Verifique que el documento, legajo y fecha tengan el formato correcto.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
