using Models;
using System;
using System.Windows.Forms;

namespace Views
{
    public partial class ConsultaGeneral : Form
    {
        public ConsultaGeneral()
        {
            InitializeComponent();
        }

        public void ActualizarCampos()
        {
            lCantAlumnos.Text = "";
            lbInformacion.Items.Clear();

            if (rbFiltroAlumno.Checked)
            {
                // TODO: Obtener lista de Alumnos desde MySQL (SELECT * FROM Alumnos)
                // foreach (Alumno al in repositorioAlumnos.ObtenerTodos())
                // {
                //     lbInformacion.Items.Add($"➤ {al.Nombre} {al.Apellido}, Carrera {al.Carrera}, N° lib: {al.NroLibreta}");
                // }
            }
            else if (rbFiltroProfesor.Checked)
            {
                // TODO: Obtener lista de Profesores desde MySQL (SELECT * FROM Profesores)
                // foreach (Profesor prof in repositorioProfesores.ObtenerTodos())
                // {
                //     lbInformacion.Items.Add($"➤ {prof.Nombre} {prof.Apellido}, Titulo {prof.Titulo}, N° Legajo: {prof.Legajo}");
                // }
            }
            else if (rbFiltroCurso.Checked)
            {
                // TODO: Obtener lista de Cursos desde MySQL
                // foreach (Curso cur in repositorioCursos.ObtenerTodos())
                // {
                //     if (cur is CursoUniversitario curUni)
                //     {
                //         lbInformacion.Items.Add($"➤ Tipo: C. Universitario, ID: {curUni.Id}, {curUni.NombreCurso}, Aula y Horario: {curUni.Aula} - {curUni.Horario}");
                //     }
                //     else if (cur is CursoExterno cursoExterno)
                //     {
                //         lbInformacion.Items.Add($"➤ Tipo: C. Externo,  ID: {cursoExterno.Id}, {cursoExterno.NombreCurso}, Instituto: {cursoExterno.Inst.Nombre}");
                //     }
                // }
            }
            else
            {
                // TODO: Obtener lista de Institutos desde MySQL
                // foreach (Instituto ins in repositorioInstitutos.ObtenerTodos())
                // {
                //     lbInformacion.Items.Add($"➤ {ins.ToString()}");
                // }
            }
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void rbFiltroAlumno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFiltroAlumno.Checked) ActualizarCampos();
        }

        private void rbFiltroProfesor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFiltroProfesor.Checked) ActualizarCampos();
        }

        private void rbFiltroCurso_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFiltroCurso.Checked) ActualizarCampos();
        }

        private void rbFiltroInstituto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFiltroInstituto.Checked) ActualizarCampos();
        }

        private void lbInformacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbInformacion.SelectedItem != null && rbFiltroCurso.Checked)
            {
                // TODO: Extraer el ID del curso seleccionado (lo ideal será usar DataBinding en lugar de parsear el string)
                // y luego ejecutar: SELECT COUNT(*) FROM Inscripciones WHERE IdCurso = @id

                // int cantidadAlumnos = repositorioInscripciones.ContarAlumnosPorCurso(idCursoSeleccionado);
                // lCantAlumnos.Text = $"Cantidad de Alumnos: {cantidadAlumnos}";
            }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}