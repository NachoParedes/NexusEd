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
    public partial class DarAltaInstituto : Form
    {
        public DarAltaInstituto()
        {
            InitializeComponent();
        }

        public void LimpiarCampos()
        {
            mtIdInstituto.Clear();
            tNombreInstituto.Clear();
            tDireccionInstituto.Clear();
            mtTelefonoInstituto.Clear();
            tContactoInstituto.Clear();
        }

        private void DarAltaInstituto_Load(object sender, EventArgs e)
        {

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

        private void bAceptar_Click(object sender, EventArgs e)
        {
            Instituto instituto;

            int id = Convert.ToInt32(mtIdInstituto.Text);
            string nombre = tNombreInstituto.Text;
            string direccion = tDireccionInstituto.Text;
            int telefono = Convert.ToInt32(mtTelefonoInstituto.Text);
            string contacto = tContactoInstituto.Text;

            instituto = new Instituto(id,nombre,direccion,telefono,contacto);

            Program.colIns.AgregarInstituto(instituto);
            LimpiarCampos();
           
        }
    }
}
