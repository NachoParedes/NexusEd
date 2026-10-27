using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Models.Database
{
	public class RepositorioPersona
	{
		private Conexion _conexion = new Conexion();

		public void AgregarAlumno(Alumno alumno)
		{
			using (MySqlConnection conn = _conexion.ObtenerConexion())
			{
				// Se ejecutan ambos INSERT secuencialmente. 
				// LAST_INSERT_ID() atrapa el IdPersona recién generado.
				string query = @"
                    INSERT INTO Personas (Dni, Nombre, Apellido, FechaNacimiento, Email) 
                    VALUES (@dni, @nombre, @apellido, @fecha, @email);
                    
                    INSERT INTO Alumnos (IdPersona, NroLibreta, FechaInscripcion, Carrera) 
                    VALUES (LAST_INSERT_ID(), @nroLibreta, @inscripcion, @carrera);";

				using (MySqlCommand cmd = new MySqlCommand(query, conn))
				{
					// Parámetros de la tabla Personas
					cmd.Parameters.AddWithValue("@dni", alumno.Dni);
					cmd.Parameters.AddWithValue("@nombre", alumno.Nombre);
					cmd.Parameters.AddWithValue("@apellido", alumno.Apellido);
					cmd.Parameters.AddWithValue("@fecha", alumno.FechaNacimiento);
					cmd.Parameters.AddWithValue("@email", alumno.Email);

					// Parámetros de la tabla Alumnos
					cmd.Parameters.AddWithValue("@nroLibreta", alumno.NroLibreta);
					cmd.Parameters.AddWithValue("@inscripcion", alumno.Inscripcion);
					cmd.Parameters.AddWithValue("@carrera", alumno.Carrera);

					try
					{
						conn.Open();
						cmd.ExecuteNonQuery();
					}
					catch (MySqlException ex)
					{
						// El código 1062 es el error nativo de MySQL para registros duplicados (UNIQUE)
						if (ex.Number == 1062)
						{
							throw new Exception("Error: El DNI o el Número de Libreta ya se encuentran registrados en el sistema.");
						}

						throw new Exception("Error al conectar con la base de datos: " + ex.Message);
					}
				}
			}
		}

		public List<Alumno> ObtenerAlumnos()
		{
			List<Alumno> listaAlumnos = new List<Alumno>();

			using (MySqlConnection conn = _conexion.ObtenerConexion())
			{
				string query = @"
                    SELECT p.Dni, p.Nombre, p.Apellido, p.FechaNacimiento, p.Email, 
                           a.NroLibreta, a.FechaInscripcion, a.Carrera
                    FROM Personas p
                    INNER JOIN Alumnos a ON p.IdPersona = a.IdPersona;";

				using (MySqlCommand cmd = new MySqlCommand(query, conn))
				{
					try
					{
						conn.Open();
						using (MySqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								Alumno al = new Alumno
								{
									Dni = Convert.ToInt32(reader["Dni"]),
									Nombre = reader["Nombre"].ToString(),
									Apellido = reader["Apellido"].ToString(),
									FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
									Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "",
									NroLibreta = Convert.ToInt32(reader["NroLibreta"]),
									Inscripcion = Convert.ToDateTime(reader["FechaInscripcion"]),
									Carrera = reader["Carrera"].ToString()
								};

								listaAlumnos.Add(al);
							}
						}
					}
					catch (Exception ex)
					{
						throw new Exception("Error al recuperar los alumnos: " + ex.Message);
					}
				}
			}
			return listaAlumnos;
		}




		public void AgregarProfesor(Profesor profesor)
		{
			using (MySqlConnection conn = _conexion.ObtenerConexion())
			{
				string query = @"
            INSERT INTO Personas (Dni, Nombre, Apellido, FechaNacimiento, Email) 
            VALUES (@dni, @nombre, @apellido, @fecha, @email);
            
            INSERT INTO Profesores (IdPersona, Legajo, Titulo) 
            VALUES (LAST_INSERT_ID(), @legajo, @titulo);";

				using (MySqlCommand cmd = new MySqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@dni", profesor.Dni);
					cmd.Parameters.AddWithValue("@nombre", profesor.Nombre);
					cmd.Parameters.AddWithValue("@apellido", profesor.Apellido);
					cmd.Parameters.AddWithValue("@fecha", profesor.FechaNacimiento);
					cmd.Parameters.AddWithValue("@email", profesor.Email);

					cmd.Parameters.AddWithValue("@legajo", profesor.Legajo);
					cmd.Parameters.AddWithValue("@titulo", profesor.Titulo);

					try
					{
						conn.Open();
						cmd.ExecuteNonQuery();
					}
					catch (MySqlException ex)
					{
						if (ex.Number == 1062)
							throw new Exception("Error: El DNI o Legajo ya existen en el sistema.");
						throw new Exception("Error en la base de datos: " + ex.Message);
					}
				}
			}
		}

		public List<Profesor> ObtenerProfesores()
		{
			List<Profesor> listaProfesores = new List<Profesor>();

			using (MySqlConnection conn = _conexion.ObtenerConexion())
			{
				string query = @"
            SELECT p.Dni, p.Nombre, p.Apellido, p.FechaNacimiento, p.Email, 
                   pr.Legajo, pr.Titulo
            FROM Personas p
            INNER JOIN Profesores pr ON p.IdPersona = pr.IdPersona;";

				using (MySqlCommand cmd = new MySqlCommand(query, conn))
				{
					try
					{
						conn.Open();
						using (MySqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								Profesor prof = new Profesor
								{
									Dni = Convert.ToInt32(reader["Dni"]),
									Nombre = reader["Nombre"].ToString(),
									Apellido = reader["Apellido"].ToString(),
									FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
									Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "",
									Legajo = Convert.ToInt32(reader["Legajo"]),
									Titulo = reader["Titulo"].ToString()
								};

								listaProfesores.Add(prof);
							}
						}
					}
					catch (Exception ex)
					{
						throw new Exception("Error al recuperar los profesores: " + ex.Message);
					}
				}
			}
			return listaProfesores;
		}
















	}

}






