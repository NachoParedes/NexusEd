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
    public partial class DarAltaAlumno : Form
    {

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
        public DarAltaAlumno()
        {
            InitializeComponent();
        }

        private void DarAltaAlumno_Load(object sender, EventArgs e)
        {

        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            Persona objPersona;

            string nombre = tNombreAlumno.Text;
            string apellido = tApellidoAlumno.Text;
            string email = tEmailAlumno.Text;
            int doc = Convert.ToInt32(mtDocumentoAlumno.Text);
            DateTime fechaNac = Convert.ToDateTime(mtFechaNacimientoAlumno.Text);

            int nroLibreta = Convert.ToInt32(mtNroLibretaAlumno.Text);
            string carrera = tCarreraAlumno.Text;
            DateTime fechaInscripcion = Convert.ToDateTime(mtFechaInscripcionAlumno.Text);

            objPersona = new Alumno(nombre, apellido, doc, fechaNac, email, nroLibreta, fechaInscripcion, carrera);

            
            Program.colPers.AgregarPersona(objPersona);
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
