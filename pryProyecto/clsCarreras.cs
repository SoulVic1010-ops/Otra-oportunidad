using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace pryProyecto
{
    internal class clsCarreras
    {
        private string nombreCarrera;
        private string descripcion;
        private int idCarrera;//este atributo es para refrencia en update y delete
        //usamos un adaptador
        private MySqlDataAdapter consulta;
        //usamos un command para insertar o actualizar
        private MySqlCommand comando;
        //Usamos una tabla temporal
        private DataTable tabla;
        
        //propiedad para el atributo nombreCarrera
        public string NombreCarrera { get => nombreCarrera; set => nombreCarrera = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdCarrera { get => idCarrera; set => idCarrera = value; }

        //Método para cargar datos en el DataGrid
        public DataTable cargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "select idCarrera As Clave, nombreCarrera AS Carrera, descripcion AS Descripción from tblCarreras;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//liberar la consulta
                }//liberar la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("error en la conexion"+ex.Message);
            }
            return tabla;
        }

        //Metodo para consultar por coincidencias 
        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "select idCarrera As Clave, nombreCarrera AS Carrera, descripcion AS Descripción from tblCarreras where nombreCarrera like @carrera;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@carrera", "%"+nombreCarrera+"%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }//liberar el adaptador
                    }//liberar la consulta
                }//libera la conexion
            }catch (Exception ex)
            {
                throw new Exception("Error en la conexion" + ex.Message);
            }
            return tabla;
        }

        //Metodo para actualizar
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
                        case 0://insertar new
                            {
                                string sqlN = "INSERT INTO tblcarreras (nombreCarrera,descrpcion) VALUES ('@nombreCarrera','@descripcion');";
                                using (comando = new MySqlCommand(sqlN, conexion))
                                {
                                    comando.Parameters.AddWithValue("idCarrera", idCarrera);
                                    comando.Parameters.AddWithValue("nombreCarrera", nombreCarrera);
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
                                string sqlA = "UPDATE tblcarreras C SET C.nombreCarrera=@nombreCarrera,C.descrpcion=@descrocion WHERE C.idCarrera=@idCarrera;";
                                using (comando = new MySqlCommand(sqlA, conexion))
                                {
                                    comando.Parameters.AddWithValue("nombreCarrera", nombreCarrera);
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
                throw new Exception("error"+ex.Message);
            }

            return msg;
            
        }
    }
}
