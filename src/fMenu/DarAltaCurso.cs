using fMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
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
            cbProfesorCurso.DataSource = (Program.colPers.RecuperarProfesores());
            cbProfesorCurso.DisplayMember = "Datos"; // cree una propiedad que devuelva solamente el nombre con el apellido y el legajo para que se muestre correctamente en el combo box

            cbInstituto.DataSource = (Program.colIns.Tabla);
            cbInstituto.DisplayMember = "Nombre";
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
            Curso objCurso;

            int id = Convert.ToInt32(mtIdCurso.Text);
            string nombre = tNombreCurso.Text;

            if (rbUniversitario.Checked)
            {
                string horario = tHorarioCurso.Text;
                string aula = tAulaCurso.Text;
                Profesor p = (Profesor)cbProfesorCurso.SelectedItem;

                objCurso = new CursoUniversitario(id, nombre, aula, horario, p);
            }
            else
            {
                Instituto i = (Instituto)cbInstituto.SelectedItem;
                objCurso = new CursoExterno(id, nombre, i);
            }

            Program.colCursos.AgregarCurso(objCurso);
            LimpiarCampos();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Seguro que desea salir? \nSe perderan los datos no guardados", "Confimacion", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }


    }
}
