using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;


namespace database
{
    public class Conexion
    {
        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(Credenciales.Cadena);
        }
    }
}

