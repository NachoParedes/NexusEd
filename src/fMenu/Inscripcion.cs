using proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fMenu
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
            bInscribir.Enabled = false; // arranca en falso, no se puede inscirbir un alumno si antes no lo encuentra
        }
        private void Inscripcion_Load(object sender, EventArgs e)
        {
            cbCurso.DataSource = (Program.colCursos.Tabla);
            cbCurso.DisplayMember = "NombreCurso";
            LimpiarCampos();

        }

        private void Bbuscar_Click(object sender, EventArgs e)
        {

            if (mtBusqueda.Text == "")
            {
                MessageBox.Show("Debe introducir un dni para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Alumno> colAlumnos = Program.colPers.RecuperarAlumnos();
                int dni = Convert.ToInt32(mtBusqueda.Text);
                bool aEncontrado = false;
                foreach (Alumno alumno in colAlumnos)
                {
                    if (alumno.Dni == dni)
                    {
                        lInfoPersonaSeleccionada.Text = $"Alumno -- {alumno.Nombre} {alumno.Apellido} \nN° Libreta: {alumno.NroLibreta}";
                        bInscribir.Enabled = true; // solo activa el boton inscribir cuando encuentra a un alumno
                        aEncontrado = true;
                        break;
                    }
                }
                if (!aEncontrado)// si no lo encuentra muestra el error
                {
                    MessageBox.Show("El Dni ingresado no existe en los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void bInscribir_Click(object sender, EventArgs e)
        {
            foreach (Alumno alum in Program.colPers.RecuperarAlumnos())
            {
                int dni = Convert.ToInt32(mtBusqueda.Text);
                if (dni == alum.Dni)
                {
                    Curso c = (Curso)cbCurso.SelectedItem;
                    c.AgregatAlumnos(alum);
                    MessageBox.Show("Alumno Anotado Correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LimpiarCampos();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
