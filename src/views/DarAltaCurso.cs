using Models;
using System;
using System.Windows.Forms;

namespace Views
{
    public partial class DarAltaCurso : Form
    {
        public DarAltaCurso()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            cbProfesorCurso.SelectedIndex = -1; // de esta forma no hay ninguno seleccionado por defecto
            cbInstituto.SelectedIndex = -1;
            mtIdCurso.Clear();
            tAulaCurso.Clear();
            tHorarioCurso.Clear();
            tNombreCurso.Clear();
            rbUniversitario.Checked = true;
            pCursoExterno.Visible = false;
        }

        private void DarAltaCurso_Load(object sender, EventArgs e)
        {
            // TODO: Cargar la lista de Profesores e Institutos desde MySQL en los ComboBox
            // Ejemplo futuro:
            // cbProfesorCurso.DataSource = repositorioProfesores.ObtenerTodos();
            // cbProfesorCurso.DisplayMember = "Datos"; 
            // cbProfesorCurso.ValueMember = "IdProfesor"; // Clave para la relación en la BD

            // cbInstituto.DataSource = repositorioInstitutos.ObtenerTodos();
            // cbInstituto.DisplayMember = "Nombre";
            // cbInstituto.ValueMember = "IdInstituto";

            LimpiarCampos();
        }

        private void rbUniversitario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUniversitario.Checked)
            {
                pCursoUniversitario.Visible = true;
                pCursoExterno.Visible = false;
            }
            else
            {
                pCursoUniversitario.Visible = false;
                pCursoExterno.Visible = true;
            }
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtIdCurso.Text) || string.IsNullOrWhiteSpace(tNombreCurso.Text))
            {
                MessageBox.Show("Por favor, complete al menos los campos obligatorios (ID y Nombre del curso).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = Convert.ToInt32(mtIdCurso.Text);
                string nombre = tNombreCurso.Text;

                if (rbUniversitario.Checked)
                {
                    if (cbProfesorCurso.SelectedIndex == -1)
                    {
                        MessageBox.Show("Debe seleccionar un profesor para el curso universitario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string horario = tHorarioCurso.Text;
                    string aula = tAulaCurso.Text;

                    // TODO: Insertar Curso Universitario en la base de datos
                    // int idProfesor = (int)cbProfesorCurso.SelectedValue;
                    // repositorioCursos.AgregarUniversitario(id, nombre, aula, horario, idProfesor);
                }
                else
                {
                    if (cbInstituto.SelectedIndex == -1)
                    {
                        MessageBox.Show("Debe seleccionar un instituto para el curso externo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // TODO: Insertar Curso Externo en la base de datos
                    // int idInstituto = (int)cbInstituto.SelectedValue;
                    // repositorioCursos.AgregarExterno(id, nombre, idInstituto);
                }

                MessageBox.Show("Curso dado de alta correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en los datos ingresados. Verifique que el ID del curso sea un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
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