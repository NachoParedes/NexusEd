using System;

namespace Models
{
    public class Instituto
    {
        #region Atributos de clase
        private int _id;
        private string _nombre;
        private string _direccion;
        private int _telefono;
        private string _contacto;
        #endregion

        #region Constructores
        public Instituto() { }

        public Instituto(int id, string nombre, string direccion, int telefono, string contacto)
        {
            _id = id;
            _nombre = nombre;
            _direccion = direccion;
            _telefono = telefono;
            _contacto = contacto;
        }
        #endregion

        #region Propiedaes
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public int Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string Contacto
        {
            get { return _contacto; }
            set { _contacto = value; }
        }
        #endregion

        #region Consultas
        public override string ToString()
        {
            return $"Id: {Id}, Nombre: {Nombre}, Dirección: {Direccion}, Teléfono: {Telefono}, Contacto: {Contacto}";
        }

        public bool Equals(Instituto ins)
        {
            return (Id == ins.Id &&
                   Nombre == ins.Nombre &&
                   Direccion == ins.Direccion &&
                   Telefono == ins.Telefono &&
                   Contacto == ins.Contacto);
        }

        public Instituto Clone()
        {
            return new Instituto(this.Id, this.Nombre, this.Direccion, this.Telefono, this.Contacto);
        }
        #endregion

        #region Comandos
        public void Copy(Instituto instituto)
        {
            _id = instituto.Id;
            _nombre = instituto.Nombre;
            _direccion = instituto.Direccion;
            _telefono = instituto.Telefono;
            _contacto = instituto.Contacto;
        }
        #endregion
    }
}