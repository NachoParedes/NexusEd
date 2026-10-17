using Models;
using System;
using System.Windows.Forms;

namespace Views
{
    public partial class DarAltaAlumno : Form
    {
        public DarAltaAlumno()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            tNombreAlumno.Clear();
            tApellidoAlumno.Clear();
            tEmailAlumno.Clear();
            tCarreraAlumno.Clear();
            mtDocumentoAlumno.Clear();
            mtFechaInscripcionAlumno.Clear();
            mtFechaNacimientoAlumno.Clear();
            mtNroLibretaAlumno.Clear();
        }

        private void DarAltaAlumno_Load(object sender, EventArgs e)
        {
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tNombreAlumno.Text) ||
                string.IsNullOrWhiteSpace(tApellidoAlumno.Text) ||
                string.IsNullOrWhiteSpace(mtDocumentoAlumno.Text) ||
                string.IsNullOrWhiteSpace(mtNroLibretaAlumno.Text))
            {
                MessageBox.Show("Por favor, complete al menos los campos obligatorios (Nombre, Apellido, Documento y N° de Libreta).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string nombre = tNombreAlumno.Text;
                string apellido = tApellidoAlumno.Text;
                string email = tEmailAlumno.Text;
                int doc = Convert.ToInt32(mtDocumentoAlumno.Text);
                DateTime fechaNac = Convert.ToDateTime(mtFechaNacimientoAlumno.Text);

                int nroLibreta = Convert.ToInt32(mtNroLibretaAlumno.Text);
                string carrera = tCarreraAlumno.Text;
                DateTime fechaInscripcion = Convert.ToDateTime(mtFechaInscripcionAlumno.Text);

                // TODO: Insertar el alumno en la base de datos MySQL
                // Ejemplo futuro:
                // Alumno nuevoAlumno = new Alumno(nombre, apellido, doc, fechaNac, email, nroLibreta, fechaInscripcion, carrera);
                // repositorioAlumnos.Agregar(nuevoAlumno);

                MessageBox.Show("Alumno dado de alta correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en los datos ingresados. Verifique que el documento, número de libreta y las fechas tengan el formato correcto.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
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