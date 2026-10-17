using System;

namespace Models
{
    public class Persona
    {
        #region atributos de instancia 
        private string _nombre;
        private string _apellido;
        private int _dni;
        private DateTime _fechaNacimiento;
        private string _email;
        #endregion

        #region Constructores
        public Persona() { }

        public Persona(string nombre, string apellido, int dni, DateTime fechaNacimiento, string email)
        {
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _fechaNacimiento = fechaNacimiento;
            _email = email;
        }
        #endregion

        #region propiedades
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        public DateTime FechaNacimiento 
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        #endregion

        #region Consultas
        public override string ToString()
        {
            return $"Nombre: {this.Nombre} {this.Apellido},  Fecha de Nacimiento: {this.FechaNacimiento.ToShortDateString()}, Correo Electronico: {this.Email} ";
        }

        public bool Equals(Persona per)
        {
            return (this.Nombre == per.Nombre &&
                    this.Apellido == per.Apellido &&
                    this.FechaNacimiento == per.FechaNacimiento &&
                    this.Email == per.Email);
        }

        public Persona Clone()
        {
            return new Persona(this.Nombre, this.Apellido, this.Dni, this.FechaNacimiento, this.Email);
        }
        #endregion

        #region Comandos
        public void Copy(Persona per)
        {
            _nombre = per.Nombre;
            _apellido = per.Apellido;
            _email = per.Email;
            _fechaNacimiento = per.FechaNacimiento;
        }
        #endregion
    }// fin Persona

    public class Alumno : Persona
    {
        #region atributos de instancia
        private int _nroLibreta;
        private DateTime _inscripcion;
        private string _carrera;
        #endregion

        #region Constructores
        public Alumno() : base() { }

        public Alumno(int nroLibreta) : base()
        {
            _nroLibreta = nroLibreta;
            _inscripcion = DateTime.Now;
            _carrera = "";
        }

        public Alumno(string nombre, string apellido, int dni, DateTime fechaNacimiento, string email, int nroLibreta, DateTime inscripcion, string carrera)
                      : base(nombre, apellido, dni, fechaNacimiento, email)
        {
            _nroLibreta = nroLibreta;
            _inscripcion = inscripcion;
            _carrera = carrera;
        }
        #endregion

        #region Propiedades
        public int NroLibreta
        {
            get { return _nroLibreta; }
            set { _nroLibreta = value; }
        }
        public DateTime Inscripcion
        {
            get { return _inscripcion; }
            set { _inscripcion = value; }
        }
        public string Carrera
        {
            get { return _carrera; }
            set { _carrera = value; }
        }
        #endregion

        #region Consultas
        public override string ToString()
        {
            return $"{base.ToString()}, N° Libreta: {this.NroLibreta}, Fecha de Inscripcion: {this.Inscripcion.ToShortDateString()}, Carrera: {this.Carrera}";
        }
        public bool Equals(Alumno al)
        {
            return (base.Equals(this) == base.Equals(al) &&
                    this.NroLibreta == al.NroLibreta &&
                    this.Inscripcion == al.Inscripcion &&
                    this.Carrera == al.Carrera);
        }

        public Alumno Clone()
        {
            Alumno alumnoClone = (Alumno)base.Clone();
            alumnoClone.NroLibreta = this.NroLibreta;
            alumnoClone.Inscripcion = this.Inscripcion;
            alumnoClone.Carrera = this.Carrera;
            return alumnoClone;
        }
        #endregion

        #region Comandos
        public void Copy(Alumno al)
        {
            base.Copy(al);
            this.NroLibreta = al.NroLibreta;
            this.Inscripcion = al.Inscripcion;
            this.Carrera = al.Carrera;
        }
        #endregion
    }// fin Alumno

    public class Profesor : Persona
    {
        #region Atributos de Instancia
        private int _legajo;
        private string _tituloUniversitario;
        #endregion

        #region Constructores
        public Profesor() : base() { }

        public Profesor(int legajo) : base()
        {
            _legajo = legajo;
            _tituloUniversitario = "";
        }

        public Profesor(string nombre, string apellido, int dni, DateTime fechaNacimiento, string email, int legajo, string titulo)
                       : base(nombre, apellido, dni, fechaNacimiento, email)
        {
            _legajo = legajo;
            _tituloUniversitario = titulo;
        }
        #endregion

        #region Propiedades
        public int Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }
        public string Titulo
        {
            get { return _tituloUniversitario; }
            set { _tituloUniversitario = value; }
        }
        public string Datos
        {
            get { return $"{this.Nombre} {this.Apellido}, Legajo: {this.Legajo}"; }
        }
        #endregion

        #region Consultas
        public override string ToString()
        {
            return $"{base.ToString()}, Legajo: {this.Legajo}, Titulo Universitario: {this.Titulo}";
        }
        public bool Equals(Profesor prof)
        {
            return (base.Equals(this) == base.Equals(prof) &&
                    this.Legajo == prof.Legajo &&
                    this.Titulo == prof.Titulo);
        }

        public Profesor Clone()
        {
            Profesor prof = (Profesor)base.Clone();
            prof.Legajo = this.Legajo;
            prof.Titulo = this.Titulo;
            return prof;
        }
        #endregion

        #region Comandos
        public void Copy(Profesor prof)
        {
            base.Copy(prof);
            this.Legajo = prof.Legajo;
            this.Titulo = prof.Titulo;
        }
        #endregion
    } // fin profesor
}