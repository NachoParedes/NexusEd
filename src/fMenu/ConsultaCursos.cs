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
            cbCurso.DataSource = (Program.colCursos.Tabla);
            cbCurso.DisplayMember = "NombreCurso";
            cbCurso.SelectedIndex = -1;
            ActualizarPantalla();
        }

        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCurso.SelectedIndex != -1)
            {
                lbAlumnos.Items.Clear();
                Curso c = (Curso)cbCurso.SelectedItem;
                lbAlumnos.Items.Add(c.GetAlumnos());
            }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
