using Models;
using System;
using System.Windows.Forms;

namespace Views
{
    public partial class Inscripcion : Form
    {
        public Inscripcion()
        {
            InitializeComponent();
        }

        public void LimpiarCampos()
        {
            mtBusqueda.Clear();
            cbCurso.SelectedIndex = -1;
            lInfoPersonaSeleccionada.Text = "";
            bInscribir.Enabled = false; // Arranca en falso, no se puede inscribir sin buscar
        }

        private void Inscripcion_Load(object sender, EventArgs e)
        {
            // TODO: Cargar la lista de cursos desde MySQL en el ComboBox
            // Ejemplo futuro: 
            // cbCurso.DataSource = repositorioCursos.ObtenerTodos();
            // cbCurso.DisplayMember = "NombreCurso";
            // cbCurso.ValueMember = "IdCurso"; // Muy importante para guardar el ID en la BD

            LimpiarCampos();
        }

        private void Bbuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtBusqueda.Text))
            {
                MessageBox.Show("Debe introducir un dni para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int dni;
            if (!int.TryParse(mtBusqueda.Text, out dni))
            {
                MessageBox.Show("El DNI debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TODO: Buscar el alumno en MySQL usando el DNI
            // Ejemplo futuro: Alumno alumno = repositorioAlumnos.BuscarPorDni(dni);

            /* Lógica a implementar cuando esté la base de datos:
            if (alumno != null)
            {
                lInfoPersonaSeleccionada.Text = $"Alumno -- {alumno.Nombre} {alumno.Apellido} \nN° Libreta: {alumno.NroLibreta}";
                bInscribir.Enabled = true;
            }
            else
            {
                MessageBox.Show("El Dni ingresado no existe en los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void bInscribir_Click(object sender, EventArgs e)
        {
            if (cbCurso.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un curso.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int dni = Convert.ToInt32(mtBusqueda.Text);
            // int idCurso = (int)cbCurso.SelectedValue; // Así obtendremos el ID del curso seleccionado

            // TODO: Insertar el registro en la tabla Inscripciones de MySQL
            // Ejemplo futuro: repositorioInscripciones.Inscribir(dni, idCurso);

            MessageBox.Show("Alumno Anotado Correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}