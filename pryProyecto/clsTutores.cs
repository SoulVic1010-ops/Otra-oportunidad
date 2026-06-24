using System;
using System.Data;
using MySqlConnector;

namespace pryProyecto
{
	internal class clsTutores
	{
		private MySqlDataAdapter consulta;
		private DataTable tabla;
		private string nombretutor;

		public string Nombretutor { get => nombretutor; set => nombretutor = value; }

		public DataTable cargarDataGrid()
		{
			tabla = new DataTable();

			try
			{
				clsConexion conexionBD = new clsConexion();

				using (var conexion = conexionBD.AbrirConexion())
				{
					string sql = "SELECT * FROM tblTutores;";

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
	}
}