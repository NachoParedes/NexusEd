using System;
using System.Collections.Generic;

namespace Models
{
    public class Curso
    {
        #region Atributos de instancia
        private int _id;
        private string _nombreCurso;
        private List<Alumno> _alumnos;
        #endregion

        #region constructores
        public Curso() { }

        public Curso(int id)
        {
            _id = id;
        }

        public Curso(int id, string nombre)
        {
            _id = id;
            _nombreCurso = nombre;
            _alumnos = new List<Alumno>();
        }
        #endregion

        #region propiedades
        public int CantAlumnos
        {
            get { return _alumnos.Count; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string NombreCurso
        {
            get { return _nombreCurso; }
            set { _nombreCurso = value; }
        }
        // Agregado para poder interactuar con la lista desde afuera cuando se cargue desde la BD
        public List<Alumno> Alumnos
        {
            get { return _alumnos; }
            set { _alumnos = value; }
        }
        #endregion

        #region Consultas
        public override string ToString()
        {
            return $"Nombre: {this.NombreCurso}, Id: {this.Id} - Cantidad de Alumnos: {this.CantAlumnos} ";
        }

        public Curso Clone()
        {
            return new Curso(this.Id, this.NombreCurso);
        }

        public bool Equals(Curso cur)
        {
            return (cur.NombreCurso == this.NombreCurso && cur.Id == this.Id);
        }

        public string GetAlumnos()
        {
            string alumnosStr = "";
            if (_alumnos.Count == 0)
            {
                alumnosStr = "No hay Alumnos anotados en este curso.";
            }
            else
            {
                foreach (Alumno al in _alumnos)
                {
                    alumnosStr += $"{al.Nombre} {al.Apellido}, N° libreta: {al.NroLibreta} \n";
                }
            }
            return alumnosStr;
        }
        #endregion

        #region Comandos
        public void Copy(Curso cur)
        {
            this.Id = cur.Id;
            this.NombreCurso = cur.NombreCurso;
        }

        public void AgregarAlumnos(Alumno al)
        {
            if (_alumnos.Contains(al))
            {
                throw new Exception("El alumno que desea agregar ya existe en el curso.");
            }
            else
            {
                _alumnos.Add(al);
            }
        }

        public void EliminarAlumnos(Alumno al)
        {
            if (_alumnos.Contains(al))
            {
                _alumnos.Remove(al);
            }
            else
            {
                throw new Exception("El alumno que desea eliminar no existe en el curso.");
            }
        }
        #endregion
    } //fin curso

    public class CursoUniversitario : Curso
    {
        #region  Atributos de Clase
        private string _aula;
        private string _horario;
        private Profesor _profesor;
        #endregion

        #region Constructores
        public CursoUniversitario() { }

        public CursoUniversitario(string aula, string horario, Profesor profesor)
        {
            _aula = aula;
            _horario = horario;
            _profesor = profesor;
        }

        public CursoUniversitario(int id, string nombre, string aula, string horario, Profesor profesor)
                                    : base(id, nombre)
        {
            _aula = aula;
            _horario = horario;
            _profesor = profesor;
        }
        #endregion

        #region Propiedades
        public Profesor Profesor
        {
            get { return _profesor; }
            set { _profesor = value; }
        }
        public string Aula
        {
            get { return _aula; }
            set { _aula = value; }
        }
        public string Horario
        {
            get { return _horario; }
            set { _horario = value; }
        }
        #endregion

        #region Consultas
        public override string ToString()
        {
            return $"{base.ToString()}\n Profesor: {Profesor.Nombre} {Profesor.Apellido}, Aula {this.Aula}, Horario: {this.Horario}";
        }

        public CursoUniversitario Clone()
        {
            CursoUniversitario cur = (CursoUniversitario)base.Clone();
            cur.Aula = this.Aula;
            cur.Horario = this.Horario;
            cur.Profesor = this.Profesor;
            return cur;
        }

        public bool Equals(CursoUniversitario cur)
        {
            return (base.Equals(this) == base.Equals(cur) &&
                cur.Profesor == this.Profesor &&
                cur.Aula == this.Aula &&
                cur.Horario == this.Horario);
        }
        #endregion

        #region Comandos
        public void Copy(CursoUniversitario cur)
        {
            base.Copy(cur);
            this.Aula = cur.Aula;
            this.Horario = cur.Horario;
            this.Profesor = cur.Profesor;
        }
        #endregion
    }// fin CursoUniversitario

    public class CursoExterno : Curso
    {
        #region Atributos de clase
        private Instituto _instituto;
        #endregion

        #region Constructores
        public CursoExterno() { }

        public CursoExterno(Instituto instituto)
        {
            _instituto = instituto;
        }

        public CursoExterno(int id, string nombre, Instituto instituto)
                            : base(id, nombre)
        {
            _instituto = instituto;
        }
        #endregion

        #region Propiedades
        public Instituto Inst
        {
            get { return _instituto; }
            set { _instituto = value; }
        }
        #endregion

        #region Consultas
        public override string ToString()
        {
            return $"{base.ToString()}\n Instituto a cargo {this._instituto.Nombre}";
        }

        public CursoExterno Clone()
        {
            CursoExterno cur = (CursoExterno)base.Clone();
            cur.Inst = this.Inst;
            return cur;
        }

        public bool Equals(CursoExterno cur)
        {
            return (base.Equals(this) == base.Equals(cur) &&
                cur.Inst == this.Inst);
        }
        #endregion

        #region Comandos
        public void Copy(CursoExterno cur)
        {
            base.Copy(cur);
            this.Inst = cur.Inst;
        }
        #endregion
    } // fin CursoExterno
}