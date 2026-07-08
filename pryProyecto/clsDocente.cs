using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace pryProyecto
{
	internal class clsDocente
	{
		private int claveDocente;
		private string nombreDocente;
		private string puesto;
		private string telefono;
		private string correo;
		private int idUsuario;
		//Estos atributos agregamos para registrar el usuario
		private string nombreUsuario;
		private string password;
		private string perfil;

		//Adaptador y tabla virtuales de la clase
		private MySqlDataAdapter consulta;
		private DataTable tabla;
		private MySqlCommand comando;

		public int ClaveDocente { get => claveDocente; set => claveDocente = value; }
		public string NombreDocente { get => nombreDocente; set => nombreDocente = value; }
		public string Puesto { get => puesto; set => puesto = value; }
		public string Telefono { get => telefono; set => telefono = value; }
		public string Correo { get => correo; set => correo = value; }
		public int IdUsuario { get => idUsuario; set => idUsuario = value; }
		public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
		public string Password { get => password; set => password = value; }
		public string Perfil { get => perfil; set => perfil = value; }
		//Propiedades
		public DataTable cargarDataGrid()
		{
			tabla = new DataTable();

			try
			{
				clsConexion conexionBD = new clsConexion();
				using (var conexion = conexionBD.AbrirConexion())
				{
					//Unimos las 4 tablas mediante INNER JOIN para mostrar descripciones claras en el Grid
					string sql = "SELECT D.claveDocente AS Clave, " +
								 "D.nombreDocente AS Nombre, " +
								 "D.puesto AS Puesto, " +
								 "D.telefono AS Telefono, " +
								 "D.correo AS Correo, " +
								 "U.vchnombreUsuario AS Usuario, " +
								 "U.vchpassword, " +
								 "U.vchperfil, " +
								 "D.idUsuario " +
								 "FROM tbldocentes D " +
								 "INNER JOIN tblusuarios U ON D.idUsuario = U.intidUsuario;";
					using (var consultar = new MySqlCommand(sql, conexion))
					{
						
						using (consulta = new MySqlDataAdapter(sql, conexion))
						{
							consulta.Fill(tabla);
						}//liberar la consulta
					}//Liberar la consulta
				}//liberar la conexion externa automaticamente
			}
			catch (Exception ex)
			{
				throw new Exception("Error en la conexión al cargar catálogo de Docentes: " + ex.Message);
			}
			return tabla;
		}

		//Metodo para el combo de tutores
		public void LimpiarPanel(Panel panelDestino)
		{
			foreach (Control control in panelDestino.Controls)
			{
				if (control is TextBox)
				{
					((TextBox)control).Clear();
				}

				else if (control is ComboBox)
				{
					((ComboBox)control).SelectedIndex = 0;
				}
			}
		}

		public DataTable Consultar()
		{
			tabla = new DataTable();
			try
			{
				clsConexion conexionBD = new clsConexion();
				using (var conexion = conexionBD.AbrirConexion())
				{
					string sql = "SELECT D.claveDocente AS Clave, " +
								 "D.nombreDocente AS Nombre, " +
								 "D.puesto AS Puesto, " +
								 "D.telefono AS Telefono, " +
								 "D.correo AS Correo, " +
								 "U.vchnombreUsuario AS Usuario, " +
								 "U.vchpassword, " +
								 "U.vchperfil, " +
								 "D.idUsuario " +
								 "FROM tbldocentes D " +
								 "INNER JOIN tblusuarios U ON D.idUsuario = U.intidUsuario " +
								 "WHERE D.claveDocente LIKE @claveDocente";
					using (var consultar = new MySqlCommand(sql, conexion))
					{
						consultar.Parameters.AddWithValue("@claveDocente", "%" + claveDocente + "%");
						using (consulta = new MySqlDataAdapter(consultar))
						{
							consulta.Fill(tabla);
						}//liberar el adaptador
					}//liberar la consulta
				}//libera la conexion
			}
			catch (Exception ex)
			{
				throw new Exception("Error en la conexion" + ex.Message);
			}
			return tabla;
		}
		public string GuardarActualizar(int tipoOperacion)
		{
			string msg = "";
			clsConexion conexionBD = new clsConexion();

			try
			{
				using (var conexion = conexionBD.AbrirConexion())
				{
					using (var transaccion = conexion.BeginTransaction())
					{
						try
						{
							switch (tipoOperacion)
							{
								case 0: // NUEVO
									string sqlInsUser = "INSERT INTO tblUsuarios(vchnombreUsuario, vchpassword, vchperfil, vchestado) " +
														"VALUES(@nomUser, MD5(@pass), @perfil, 'Activo'); SELECT LAST_INSERT_ID();";

									int nuevoIdUsuario = 0;

									using (comando = new MySqlCommand(sqlInsUser, conexion, transaccion))
									{
										comando.Parameters.AddWithValue("@nomUser", nombreUsuario);
										comando.Parameters.AddWithValue("@pass", password);
										comando.Parameters.AddWithValue("@perfil", perfil);

										nuevoIdUsuario = Convert.ToInt32(comando.ExecuteScalar());
									}


									string sqlInsDocente = "INSERT INTO tblDocentes(claveDocente, idUsuario, nombreDocente, puesto, telefono, correo) " +
														   "VALUES(@claveDocente, @idUsuario, @nombreDocente, @puesto, @telefono, @correo);";
									using (comando = new MySqlCommand(sqlInsDocente, conexion, transaccion))
									{
										comando.Parameters.AddWithValue("@claveDocente", claveDocente);
										comando.Parameters.AddWithValue("@idUsuario", nuevoIdUsuario);
										comando.Parameters.AddWithValue("@nombreDocente", nombreDocente);
										comando.Parameters.AddWithValue("@puesto", puesto);
										comando.Parameters.AddWithValue("@telefono", telefono);
										comando.Parameters.AddWithValue("@correo", correo);
										

										comando.ExecuteNonQuery();
									}

									msg = "El docente y sus credenciales fueron registrados correctamente.";
									break;

								case 1: // ACTUALIZAR

									string sqlUpdUser = "UPDATE tblUsuarios SET vchnombreUsuario = @nomUser, vchperfil = @perfil " +
														"WHERE intidUsuario = @idUsuario;";

									using (comando = new MySqlCommand(sqlUpdUser, conexion, transaccion))
									{
										comando.Parameters.AddWithValue("@idUsuario", idUsuario);
										comando.Parameters.AddWithValue("@nomUser", nombreUsuario);
										comando.Parameters.AddWithValue("@perfil", perfil);

										comando.ExecuteNonQuery();
									}

									string sqlUpdDocente = "UPDATE tblDocentes SET nombreDocente = @nombreDocente, " +
														   "puesto = @puesto, telefono = @telefono, correo = @correo " +
														   "WHERE claveDocente = @claveDocente;";

									using (comando = new MySqlCommand(sqlUpdDocente, conexion, transaccion))
									{
										comando.Parameters.AddWithValue("@claveDocente", claveDocente);
										comando.Parameters.AddWithValue("@nombreDocente", nombreDocente);
										comando.Parameters.AddWithValue("@puesto", puesto);
										comando.Parameters.AddWithValue("@telefono", telefono);
										comando.Parameters.AddWithValue("@correo", correo);

										comando.ExecuteNonQuery();
									}

									msg = "Los datos del docente se actualizaron correctamente.";
									break;
							}

							transaccion.Commit();
						}
						catch (Exception ex)
						{
							transaccion.Rollback();
							throw new Exception("Error en la operación. Se cancelaron los cambios: " + ex.Message);
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error de conexión: " + ex.Message);
			}

			return msg;
		}//Finaliza el metodo de guardar nuevo o alguna modificación

		public string Eliminar()
		{
			string msg = "";
			clsConexion conexionBD = new clsConexion();

			try
			{
				using (var conexion = conexionBD.AbrirConexion())
				{
					using (var transaccion = conexion.BeginTransaction())
					{
						try
						{
							// Eliminamos al Docente
							string sqlDelDocente = "DELETE FROM tbldocentes WHERE claveDocente = @claveDocente;";
							using (comando = new MySqlCommand(sqlDelDocente, conexion, transaccion))
							{
								comando.Parameters.AddWithValue("@claveDocente", claveDocente);
								comando.ExecuteNonQuery();
							}

							// Eliminamos el Usuario
							string sqlDelUsuario = "DELETE FROM tblusuarios WHERE intidUsuario = @idUsuario;";
							using (comando = new MySqlCommand(sqlDelUsuario, conexion, transaccion))
							{
								comando.Parameters.AddWithValue("@idUsuario", idUsuario);
								comando.ExecuteNonQuery();
							}

							transaccion.Commit();
							msg = "El docente y sus credenciales de usuario han sido eliminados del sistema.";
						}
						catch (Exception ex)
						{
							transaccion.Rollback();
							throw new Exception("No se pudo completar la eliminación. Cambios revertidos: " + ex.Message);
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error de conexión al eliminar: " + ex.Message);
			}

			return msg;
		}
	}
}
