using Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace database
{
    public class RepositorioCurso
    {
        private Conexion _conexion = new Conexion();

        public void AgregarCursoUniversitario(CursoUniversitario curso)
        {
            using (MySqlConnection conn = _conexion.ObtenerConexion())
            {
                // Se inserta primero en la tabla base (Cursos) y luego en la tabla hija (CursosUniversitarios)
                string query = @"
                    INSERT INTO Cursos (Nombre) 
                    VALUES (@nombre);
                    
                    INSERT INTO CursosUniversitarios (IdCurso, Aula, Horario, IdProfesor) 
                    VALUES (LAST_INSERT_ID(), @aula, @horario, @idProfesor);";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Parámetro de la clase base Curso
                    cmd.Parameters.AddWithValue("@nombre", curso.NombreCurso);

                    // Parámetros específicos de CursoUniversitario
                    cmd.Parameters.AddWithValue("@aula", curso.Aula);
                    cmd.Parameters.AddWithValue("@horario", curso.Horario);


                    cmd.Parameters.AddWithValue("@idProfesor", curso.Profesor);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al guardar el curso universitario: " + ex.Message);
                    }
                }
            }
        }



        public void AgregarCursoExterno(CursoExterno curso)
        {
            using (MySqlConnection conn = _conexion.ObtenerConexion())
            {
                string query = @"
            INSERT INTO Cursos (Nombre) 
            VALUES (@nombre);
            
            INSERT INTO CursosExternos (IdCurso, IdInstituto) 
            VALUES (LAST_INSERT_ID(), @idInstituto);";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Parámetro de la clase base
                    cmd.Parameters.AddWithValue("@nombre", curso.NombreCurso);


                    cmd.Parameters.AddWithValue("@idInstituto", curso.Inst);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al guardar el curso externo: " + ex.Message);
                    }
                }
            }
        }











    }
}
