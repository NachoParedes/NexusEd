using proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fMenu
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
                List<Alumno> colAlumnos = Program.colPers.RecuperarAlumnos(); // se recupera una coleccion con todos los alumnos existentes
                foreach (Alumno al in colAlumnos) // se recorre la coleccion
                {
                    lbInformacion.Items.Add($"➤ {al.Nombre} {al.Apellido}, Carrera {al.Carrera}, N° lib: {al.NroLibreta}");
                }
            }
            else if (rbFiltroProfesor.Checked)
            {
                List<Profesor> colProf = Program.colPers.RecuperarProfesores();
                foreach (Profesor prof in colProf)
                {
                    lbInformacion.Items.Add($"➤ {prof.Nombre} {prof.Apellido}, Titulo {prof.Titulo}, N° Legajo: {prof.Legajo}");
                }
            }
            else if (rbFiltroCurso.Checked)
            {
                List<Curso> colCurso = Program.colCursos.Tabla;
                foreach (Curso cur in colCurso)
                {
                    // dependiendo del tipo de Curso cambia lo que muestra
                    if (cur.GetType() == typeof(CursoUniversitario))
                    {
                        CursoUniversitario curUni = (CursoUniversitario)cur;
                        lbInformacion.Items.Add($"➤ Tipo: C. Univeristario, ID: {curUni.Id}, {curUni.NombreCurso}, Aula y Horario: {curUni.Aula} - {curUni.Horario}");
                    }
                    else if (cur.GetType() == typeof(CursoExterno))
                    {
                        CursoExterno cursoExterno = (CursoExterno)cur;
                        lbInformacion.Items.Add($"➤ Tipo: C. Externo,  ID: {cursoExterno.Id}, {cursoExterno.NombreCurso}, Instituto: {cursoExterno.Inst.Nombre}");
                    }
                }
            }
            else
            {
                List<Instituto> conInst = Program.colIns.Tabla;
                foreach (Instituto ins in conInst)
                {
                    lbInformacion.Items.Add($"➤ {ins.ToString()}");
                }
            }

        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            ActualizarCampos();
        }
        private void rbFiltroAlumno_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void rbFiltroProfesor_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void rbFiltroCurso_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void rbFiltroInstituto_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void lbInformacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbInformacion.SelectedItem != null && rbFiltroCurso.Checked) // solo entra si no hay ningun item seleccionado y si esta checkeado el radio button de curso
            {
                string textoSeleccionado = lbInformacion.SelectedItem.ToString();
                Curso cursoSeleccionado = null; // la inicializo sin valor para que no entre en los if

                foreach (Curso curso in Program.colCursos.Tabla)
                {
                    if (textoSeleccionado.Contains(curso.NombreCurso))
                    {
                        cursoSeleccionado = curso;
                        lCantAlumnos.Text = $"Cantidad de Alumnos: {cursoSeleccionado.CantAlumnos}";
                        break;  // Cambia el label y sale del bucle si encuentra el curso

                    }
                }
            }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
