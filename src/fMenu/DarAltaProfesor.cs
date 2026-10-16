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
    public partial class DarAltaProfesor : Form
    {
        public DarAltaProfesor()
        {
            InitializeComponent();
        }
        private void LimpiarCampos()
        {
            tNombre.Clear();
            tApellido.Clear();
            tEmail.Clear();
            tTituloUniver.Clear();
            mtDocumento.Clear();
            mtLegajo.Clear();
            mtFechaNacimiento.Clear();
        }

        private void DarAltaProfesor_Load(object sender, EventArgs e)
        {

        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            Persona objPersona;

            string nombre = tNombre.Text;
            string apellido = tApellido.Text;
            string email = tEmail.Text;
            string titulo = tTituloUniver.Text;
            int doc = Convert.ToInt32(mtDocumento.Text);
            int legajo = Convert.ToInt32(mtLegajo.Text);
            DateTime fechaNac = Convert.ToDateTime(mtFechaNacimiento.Text);


            objPersona = new Profesor(nombre, apellido, doc, fechaNac, email, legajo, titulo);
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
