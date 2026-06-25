using System;
using System.Data;
using MySqlConnector;

namespace pryProyecto
{
	internal class clsTutores
	{
		private MySqlDataAdapter consulta;
		private DataTable tabla;
		private MySqlCommand comando;
		private string nombretutor;
		private int id_Tutores;
		private string parentesco;
		private string direccion;
		private string telefono;
		private string correo;


        public string Nombretutor { get => nombretutor; set => nombretutor = value; }
		public int Id_Tutores { get => id_Tutores; set => id_Tutores = value; }
		public string Parentesco { get => parentesco; set => parentesco = value; }
		public string Direccion { get => direccion; set => direccion = value; }
		public string Telefono { get => telefono; set => telefono = value; }
		public string Correo { get => correo; set => correo = value; }

		public DataTable cargarDataGrid()
		{
			tabla = new DataTable();

			try
			{
				clsConexion conexionBD = new clsConexion();

				using (var conexion = conexionBD.AbrirConexion())
				{
                    string sql = "SELECT idTutor AS Clave, nombreTutor AS Nombre, parentesco AS Parentesco, direccion AS Dirección, telefono AS Teléfono, correo AS Correo FROM tblTutores;";

                    using (consulta = new MySqlDataAdapter(sql, conexion))
					{
						consulta.Fill(tabla);
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error en la conexión: " + ex.Message);
			}

			return tabla;
		}

		public DataTable Consultar()
		{
			tabla = new DataTable();

			try
			{
				clsConexion conexionBD = new clsConexion();

				using (var conexion = conexionBD.AbrirConexion())
				{
					string sql = "SELECT idTutor AS Clave, nombreTutor AS Nombre, parentesco AS Parentesco, direccion AS Dirección, telefono AS Teléfono, correo AS Correo FROM tblTutores WHERE nombreTutor LIKE @nombretutor;";
  


					using (var consultar = new MySqlCommand(sql, conexion))
					{
						consultar.Parameters.AddWithValue("@nombretutor", "%" + nombretutor + "%");

						using (consulta = new MySqlDataAdapter(consultar))
						{
							consulta.Fill(tabla);
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error en la conexión: " + ex.Message);
			}

			return tabla;
		}

		public string GuardarActualizar(int TipoOperacion)
		{
			string msg = "";
			try
			{
				clsConexion conexionBD = new clsConexion();
				using (var conexion = conexionBD.AbrirConexion())
				{
					switch (TipoOperacion)
					{
						case 0: // Insertar
							{
								string sqlN = "INSERT INTO tbltutores (nombreTutor, parentesco, direccion, telefono, correo) VALUES (@nombreTutor, @parentesco, @direccion, @telefono, @correo);";

								using (comando = new MySqlCommand(sqlN, conexion))
								{
									comando.Parameters.AddWithValue("@nombreTutor", nombretutor);
									comando.Parameters.AddWithValue("@parentesco", parentesco);
									comando.Parameters.AddWithValue("@direccion", direccion);
									comando.Parameters.AddWithValue("@telefono", telefono);
									comando.Parameters.AddWithValue("@correo", correo);

									int filasAfectadas = comando.ExecuteNonQuery();

									if (filasAfectadas > 0)
										msg = "El registro se guardó correctamente.";
									else
										msg = "Error, no se guardaron los datos.";
								}
							}
							break;

						case 1: // Actualizar
							{
								string sqlA = "UPDATE tbltutores SET nombreTutor=@nombreTutor, parentesco=@parentesco, direccion=@direccion, telefono=@telefono, correo=@correo WHERE idTutor=@idTutor;";

								using (comando = new MySqlCommand(sqlA, conexion))
								{
									comando.Parameters.AddWithValue("@idTutor", id_Tutores);
									comando.Parameters.AddWithValue("@nombreTutor", nombretutor);
									comando.Parameters.AddWithValue("@parentesco", parentesco);
									comando.Parameters.AddWithValue("@direccion", direccion);
									comando.Parameters.AddWithValue("@telefono", telefono);
									comando.Parameters.AddWithValue("@correo", correo);


									int filasAfectadas = comando.ExecuteNonQuery();

									if (filasAfectadas > 0)
										msg = "El registro se actualizó correctamente.";
									else
										msg = "Error, no se actualizaron los datos.";
								}
							}
							break;
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error: " + ex.Message);
			}

			return msg;
		}
		public string Eliminar()
		{
			string msg = "";
			try
			{
				clsConexion conexionBD = new clsConexion();
				using (var conexion = conexionBD.AbrirConexion())
				{
					string sql = "DELETE FROM tbltutores c WHERE c.idTutor = @idTutor;";
					using (comando = new MySqlCommand(sql, conexion))
					{
						comando.Parameters.AddWithValue("@idTutor", id_Tutores);
						int filasAfectadas = comando.ExecuteNonQuery();
						if (filasAfectadas > 0)
						{
							msg = "Datos eliminados correctamnete";
						}
						else
						{
							msg = "Los datos no se pudieron eliminar";
						}
					}//Libera la eliminacion

				}//Libera las conexion

			}
			catch (Exception ex)
			{
				throw new Exception("Error" + ex.Message);
			}
			return msg;
		}
	}
}