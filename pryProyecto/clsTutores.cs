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
		private string Parentesco;
		private string Direccion;
		private string Telefono;
		private string Correo;

		public string Nombretutor { get => nombretutor; set => nombretutor = value; }
        public int Id_Tutores { get => id_Tutores; set => id_Tutores = value; }
        public string Parentesco1 { get => Parentesco; set => Parentesco = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public string Correo1 { get => Correo; set => Correo = value; }

        private string descripcion;
        private int idTutor;

		private string nombretutor;
        //usamos un adaptador
        private MySqlDataAdapter consulta;
        //usamos un command para insertar o actualizar
        private MySqlCommand comando;
        //Usamos una tabla temporal
        private DataTable tabla;

        public string Nombretutor { get => nombretutor; set => nombretutor = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdTutor { get => idTutor; set => idTutor = value; }
>>>>>>> No che

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
<<<<<<< HEAD
=======

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
                                string sqlN = "INSERT INTO tbltutores (nombreTutor) VALUES (@nombreTutor);";

                                using (comando = new MySqlCommand(sqlN, conexion))
                                {
                                    comando.Parameters.AddWithValue("@nombreTutor", nombretutor);

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
                                string sqlA = "UPDATE tbltutores SET nombreTutor=@nombreTutor WHERE idTutor=@idTutor;";

                                using (comando = new MySqlCommand(sqlA, conexion))
                                {
                                    comando.Parameters.AddWithValue("@idTutor", id_Tutores);
                                    comando.Parameters.AddWithValue("@nombreTutor", nombretutor);

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
=======
                        case 0://insertar new
                            {
                                string sqlN = "INSERT INTO tblcarreras (nombreCarrera,descrpcion) VALUES ('@nombreCarrera','@descripcion');";
                                using (comando = new MySqlCommand(sqlN, conexion))
                                {
                                    comando.Parameters.AddWithValue("idTutor", idTutor);
                                    comando.Parameters.AddWithValue("nombreTutor", nombretutor);
                                    comando.Parameters.AddWithValue("descrpcion", descripcion);

                                    int filasAfectadas = comando.ExecuteNonQuery();
                                    if (filasAfectadas > 0)
                                    {
                                        msg = "el registro se guardo correctamente";

                                    }
                                    else
                                    {
                                        msg = "Error, no se guardaron los dartos...";
                                    }


                                }
                            }//libera la operacion de la actualizacion
                            break;
                        case 1:
                            {
                                string sqlA = "UPDATE tblcarreras C SET C.nombreCarrera=@nombreCarrera,C.descrpcion=@descrpcion WHERE C.idCarrera=@idCarrera;";
                                using (comando = new MySqlCommand(sqlA, conexion))
                                {
                                    comando.Parameters.AddWithValue("nombreTutor", nombretutor);
                                    comando.Parameters.AddWithValue("descrpcion", descripcion);

                                    int filasAfectadas = comando.ExecuteNonQuery();
                                    if (filasAfectadas > 0)
                                    {
                                        msg = "el registro se guardo correctamente";

                                    }
                                    else
                                    {
                                        msg = "Error, no se guardaron los dartos...";
                                    }


                                }
                            }//Actualizar old
                            break;

                    }

                }//Libera la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("error" + ex.Message);
            }

            return msg;

        }
    }
}