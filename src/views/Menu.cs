using System;
using System.Windows.Forms;

namespace Views
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void fMenu_Load(object sender, EventArgs e)
        {
            // Más adelante acá podemos verificar que haya conexión a MySQL al abrir el programa
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DarAltaCurso formAltaCurso = new DarAltaCurso();
            formAltaCurso.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DarAltaAlumno darAltaAlumno = new DarAltaAlumno();
            darAltaAlumno.ShowDialog();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DarAltaProfesor darAltaProfesor = new DarAltaProfesor();
            darAltaProfesor.ShowDialog();
        }

        private void institutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DarAltaInstituto darAltaIns = new DarAltaInstituto();
            darAltaIns.ShowDialog();
        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inscripcion inscrip = new Inscripcion();
            inscrip.ShowDialog();
        }

        private void generalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaGeneral consulta = new ConsultaGeneral();
            consulta.ShowDialog();
        }

        private void cursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaCursos consulta = new ConsultaCursos();
            consulta.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}