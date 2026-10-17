using Models;
using System;
using System.Windows.Forms;

namespace Views
{
    public partial class ConsultaCursos : Form
    {
        public ConsultaCursos()
        {
            InitializeComponent();
        }

        private void ActualizarPantalla()
        {
            lbAlumnos.Items.Clear();
        }

        private void ConsultaCursos_Load(object sender, EventArgs e)
        {
            // TODO: Cargar los cursos desde la base de datos MySQL
            // cbCurso.DataSource = repositorioCursos.ObtenerTodos();
            // cbCurso.DisplayMember = "NombreCurso";
            // cbCurso.ValueMember = "IdCurso"; // Importante para hacer la consulta de alumnos luego
            // cbCurso.SelectedIndex = -1;

            ActualizarPantalla();
        }

        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCurso.SelectedIndex != -1)
            {
                lbAlumnos.Items.Clear();

                // TODO: Obtener el ID del curso seleccionado y buscar sus alumnos en MySQL
                // int idCurso = (int)cbCurso.SelectedValue;
                // List<Alumno> alumnosDelCurso = repositorioInscripciones.ObtenerAlumnosPorCurso(idCurso);

                // foreach (Alumno al in alumnosDelCurso)
                // {
                //     lbAlumnos.Items.Add($"➤ {al.Nombre} {al.Apellido} - N° Libreta: {al.NroLibreta}");
                // }
            }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}