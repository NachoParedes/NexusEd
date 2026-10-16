using proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fMenu
{

    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        private void GuardarColecciones()
        {
            string directory = Application.StartupPath;

            // guardar personas
            string fileNamePersonas = directory + "\\colPers.bin";
            Stream SaveFileStreamPersonas = File.OpenWrite(fileNamePersonas);
            BinaryFormatter serializerPersonas = new BinaryFormatter();
            serializerPersonas.Serialize(SaveFileStreamPersonas, Program.colPers);
            SaveFileStreamPersonas.Close(); MessageBox.Show("Personas guardadas en: " + fileNamePersonas);

            //Guardar institutos
            string fileNameInstituto = directory + "\\colIns.bin";
            Stream SaveFileStreamInstituto = File.OpenWrite(fileNameInstituto);
            BinaryFormatter serializerInstituto = new BinaryFormatter();
            serializerInstituto.Serialize(SaveFileStreamInstituto, Program.colIns);
            SaveFileStreamInstituto.Close();
            MessageBox.Show("Institutos guardados en: " + fileNameInstituto);

            //Guardar Cursos
            string fileNameCursos = directory + "\\colCursos.bin";
            Stream SaveFileStreamCursos = File.OpenWrite(fileNameCursos);
            BinaryFormatter serializerCursos = new BinaryFormatter();
            serializerCursos.Serialize(SaveFileStreamCursos, Program.colCursos);
            SaveFileStreamCursos.Close();
            MessageBox.Show("Cursos guardados en: " + fileNameCursos);

        }

        private void CargarColecciones()
        {
            string directory = Application.StartupPath;

            string fileNameCurso = directory + "\\colCursos.bin";
            string fileNamePersona = directory + "\\colPers.bin";
            string fileNameInstituto = directory + "\\colIns.bin";

            if (File.Exists(fileNamePersona))
            {
                Stream openFileStreamPersona = File.OpenRead(fileNamePersona);
                try
                {
                    BinaryFormatter deserializer = new BinaryFormatter();
                    Program.colPers = (ColeccionDePersonas)deserializer.Deserialize(openFileStreamPersona);
                }
                catch { MessageBox.Show("Error al cargar las colecciones de personas"); }
                finally { openFileStreamPersona.Close(); }
            }
            if (File.Exists(fileNameCurso))
            {
                Stream openFileStreamCurso = File.OpenRead(fileNameCurso);
                try
                {
                    BinaryFormatter deserializer = new BinaryFormatter();
                    Program.colCursos = (ColeccionDeCursos)deserializer.Deserialize(openFileStreamCurso);
                }
                catch { MessageBox.Show("Error al cargar las colecciones de cursos"); }
                finally { openFileStreamCurso.Close(); }
            }
            if (File.Exists(fileNameInstituto))
            {
                Stream openFileStreamIns = File.OpenRead(fileNameInstituto);
                try
                {
                    BinaryFormatter deserializer = new BinaryFormatter();
                    Program.colIns = (ColeccionInstitutos)deserializer.Deserialize(openFileStreamIns);
                }
                catch { MessageBox.Show("Error al cargar las colecciones de institutos"); }
                finally { openFileStreamIns.Close(); }
            }
        }

        private void fMenu_Load(object sender, EventArgs e)
        {
            CargarColecciones();
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
            GuardarColecciones();
            Application.Exit();

        }

    }
}
