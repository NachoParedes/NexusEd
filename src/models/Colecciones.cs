using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Models
{
    [Serializable()]
    public class ColeccionDePersonas
    {

        private List<Persona> _tabla;
        #region Constructores
        public ColeccionDePersonas()
        {
            _tabla = new List<Persona>();
        }
        #endregion

        #region Propiedaeds
        public List<Persona> Tabla { get { return _tabla; } }
        #endregion

        #region Consultas
        public bool ExistePersona(int nro)
        {
            foreach (Persona objPers in _tabla)
            {
                if (objPers.Dni == nro)
                    return true;
            }
            return false;
        }

        public int CantAlumnos()
        {
            int cant;
            cant = 0;

            foreach (Persona obj in _tabla)
            {
                if (obj.GetType() == typeof(Alumno))
                    cant += 1;
            }
            return cant;
        }
        public int CantProfesores()
        {
            int cant;
            cant = 0;
            foreach (Persona obj in _tabla)
            {
                if (obj.GetType() == typeof(Profesor))
                    cant += 1;
            }
            return cant;
        }

        public List<Alumno> RecuperarAlumnos()
        {
            List<Alumno> colAlumnos = new List<Alumno>();

            foreach (Persona obj in _tabla)
            {
                if (obj.GetType() == typeof(Alumno))
                {
                    colAlumnos.Add((Alumno)obj);
                }
            }
            return colAlumnos;
        }
        public List<Profesor> RecuperarProfesores()
        {
            List<Profesor> colProfesores = new List<Profesor>();

            foreach (Persona obj in _tabla)
            {
                if (obj.GetType() == typeof(Profesor))
                {
                    colProfesores.Add((Profesor)obj);
                }
            }
            return colProfesores;
        }
        #endregion

        #region Comandos
        public void AgregarPersona(Persona p)
        {
            //agregar validación por documento existente
            if (ExistePersona(p.Dni))
            {
                MessageBox.Show("DNI duplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _tabla.Add(p);
                MessageBox.Show("Persona agregada Correctamente", "Proceso Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    } // fin coleccion personas

    [Serializable()]
    public class ColeccionDeCursos
    {
        private List<Curso> _tablaCursos;

        #region Constructores
        public ColeccionDeCursos()
        {
            _tablaCursos = new List<Curso>();
        }
        #endregion

        #region Propiedaeds
        public List<Curso> Tabla { get { return _tablaCursos; } }
        #endregion

        #region Consultas
        public bool ExtisteCurso(int nro)
        {
            foreach (Curso objCurso in _tablaCursos)
            {
                if (objCurso.Id == nro)
                    return true;
            }
            return false;
        }

        public List<Curso> RecuperarCursosExternos()
        {
            List<Curso> colCursoExterno = new List<Curso>();

            foreach (Curso obj in _tablaCursos)
            {
                if (obj.GetType() == typeof(CursoExterno))
                {
                    colCursoExterno.Add((CursoExterno)obj);
                }
            }
            return colCursoExterno;
        }
        public List<Curso> RecuperarCursoUniversitario()
        {
            List<Curso> colCursoUniversitario = new List<Curso>();

            foreach (Curso obj in _tablaCursos)
            {
                if (obj.GetType() == typeof(CursoUniversitario))
                {
                    colCursoUniversitario.Add((CursoUniversitario)obj);
                }
            }
            return colCursoUniversitario;
        }

        #endregion

        #region Comandos
        public void AgregarCurso(Curso c)
        {
            if (ExtisteCurso(c.Id))
            {
                MessageBox.Show("ID de curso duplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _tablaCursos.Add(c);
                MessageBox.Show("Curso agregado Correctamente", "Proceso Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    } // fin coleccionCursos


    [Serializable()]
    public class ColeccionInstitutos
    {
        private List<Instituto> _tablaInstitutos;

        #region Constructores
        public ColeccionInstitutos()
        {
            _tablaInstitutos = new List<Instituto>();
        }
        #endregion

        #region Propiedaeds
        public List<Instituto> Tabla { get { return _tablaInstitutos; } }
        #endregion

        #region Consultas
        public bool ExisteInstituto(int nro)
        {
            foreach (Instituto objInstituto in _tablaInstitutos)
            {
                if (objInstituto.Id == nro)
                    return true;
            }
            return false;
        }

        #endregion

        #region Comandos
        public void AgregarInstituto(Instituto i)
        {
            if (ExisteInstituto(i.Id))
            {
                MessageBox.Show("ID de Instituto duplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _tablaInstitutos.Add(i);
                MessageBox.Show("Instituto agregado Correctamente", "Proceso Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

    }
}


