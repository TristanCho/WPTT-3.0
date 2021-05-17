using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace capadatos
{
    public class DPersonal
    {
        private string _idTarea;
        private string _idempleado;
        private string _descripcion;
        private string _fcreacion;
        private string _prioridad;
        private string _estado;
        private string _fcierre;
        private string _IdTareaGrupo;
        private string _IdTareaDestino;
        private string _IdTareaOrigen;
        private string _IdTareaProyecto;
        private string _IdProyecto;
        private string _id_empleadoInsert;
        private string _id_empleadoReAsign;
        private string _Textobuscar;

        public string IdTarea { get => _idTarea; set => _idTarea = value; }
        public string Idempleado { get => _idempleado; set => _idempleado = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Fcreacion { get => _fcreacion; set => _fcreacion = value; }
        public string Prioridad { get => _prioridad; set => _prioridad = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Fcierre { get => _fcierre; set => _fcierre = value; }
        public string IdTareaGrupo { get => _IdTareaGrupo; set => _IdTareaGrupo = value; }
        public string IdTareaDestino { get => _IdTareaDestino; set => _IdTareaDestino = value; }
        public string IdTareaOrigen { get => _IdTareaOrigen; set => _IdTareaOrigen = value; }
        public string IdTareaProyecto { get => _IdTareaProyecto; set => _IdTareaProyecto = value; }
        public string IdProyecto { get => _IdProyecto; set => _IdProyecto = value; }
        public string Id_empleadoInsert { get => _id_empleadoInsert; set => _id_empleadoInsert = value; }
        public string Id_empleadoReAsign { get => _id_empleadoReAsign; set => _id_empleadoReAsign = value; }
        public string Textobuscar { get => _Textobuscar; set => _Textobuscar = value; }


        public DPersonal()
        {

        }
        public DPersonal(string idTarea, string idempleado, string descripcion, string fcreacion, string prioridad, string estado, string fcierre, string idTareaGrupo, string idTareaDestino, string idTareaOrigen, string idTareaProyecto, string idProyecto, string id_empleadoInsert, string id_empleadoReAsign, string textobuscar)
        {
            _idTarea = idTarea;
            _idempleado = idempleado;
            _descripcion = descripcion;
            _fcreacion = fcreacion;
            _prioridad = prioridad;
            _estado = estado;
            _fcierre = fcierre;
            _IdTareaGrupo = idTareaGrupo;
            _IdTareaDestino = idTareaDestino;
            _IdTareaOrigen = idTareaOrigen;
            _IdTareaProyecto = idTareaProyecto;
            _IdProyecto = idProyecto;
            _id_empleadoInsert = id_empleadoInsert;
            _id_empleadoReAsign = id_empleadoReAsign;
            _Textobuscar = textobuscar;
        }

        public DataTable buscarpersonales(DPersonal personal)
        {
            DataTable dtresultado = new DataTable("personales");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_personales";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Buscar tarea personal
                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 10;
                ParTextobuscar.Value = personal.Textobuscar;
                SqlCmd.Parameters.Add(ParTextobuscar);

                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);
                sqladap.Fill(dtresultado);
            }
            catch (Exception)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dtresultado;
        }
        public DataTable mostrarpersonales(DPersonal objeto)
        {
            DataTable dtresultado = new DataTable("personales");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;          
                SqlCmd.CommandText = "spmostrar_personales";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //TODO INSERTAR EL EMPLEADO PARA EL PROCEDIMIENTO

                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);
                sqladap.Fill(dtresultado);
            }
            catch (Exception)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dtresultado;
        }

        public string insertarPersonal(DPersonal personal)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_TareaPersonal";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //Definición de atributos
               
                //id_empleado
                SqlParameter ParIdEmpleado = new SqlParameter();
                ParIdEmpleado.ParameterName = "@id_empleado";
                ParIdEmpleado.SqlDbType = SqlDbType.NText;
                ParIdEmpleado.Size = 1024;
                ParIdEmpleado.Value = personal.IdTarea;
                SqlCmd.Parameters.Add(ParIdEmpleado);

                //descripcion
                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.NText;
                ParDescripcion.Value = personal.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                //fecha creacion
                SqlParameter ParFcreacion = new SqlParameter();
                ParFcreacion.ParameterName = "@fcreacion";
                ParFcreacion.SqlDbType = SqlDbType.SmallDateTime;
                ParFcreacion.Value = personal.Fcreacion;
                SqlCmd.Parameters.Add(ParFcreacion);

                //Prioridad
                SqlParameter ParPrioridad = new SqlParameter();
                ParPrioridad.ParameterName = "@prioridad";
                ParPrioridad.SqlDbType = SqlDbType.NText;
                ParPrioridad.Value = personal.Prioridad;
                SqlCmd.Parameters.Add(ParPrioridad);

                //estado
                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = personal.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                //fecha cierre
                SqlParameter ParFierre = new SqlParameter();
                ParFierre.ParameterName = "@fcierre";
                ParFierre.SqlDbType = SqlDbType.SmallDateTime;
                ParFierre.Value = personal.Fcierre;
                SqlCmd.Parameters.Add(ParFierre);

                //IdTareaGrupo
                SqlParameter ParIdTareaGrupo = new SqlParameter();
                ParIdTareaGrupo.ParameterName = "@idTareaGrupo";
                ParIdTareaGrupo.SqlDbType = SqlDbType.NVarChar;
                ParIdTareaGrupo.Value = personal.IdTareaGrupo;
                SqlCmd.Parameters.Add(ParIdTareaGrupo);


                //IdTareaDestino
                SqlParameter ParIdTareaDestino = new SqlParameter();
                ParIdTareaDestino.ParameterName = "@idTareaDestino";
                ParIdTareaDestino.SqlDbType = SqlDbType.NVarChar;
                ParIdTareaDestino.Value = personal.IdTareaDestino;
                SqlCmd.Parameters.Add(ParIdTareaDestino);


                //IdTareaOrigen
                SqlParameter ParIdTareaOrigen = new SqlParameter();
                ParIdTareaOrigen.ParameterName = "@idTareaOrigen";
                ParIdTareaOrigen.SqlDbType = SqlDbType.NVarChar;
                ParIdTareaOrigen.Value = personal.IdTareaOrigen;
                SqlCmd.Parameters.Add(ParIdTareaOrigen);

                //IdTareaProyecto
                SqlParameter ParIdTareaProyecto = new SqlParameter();
                ParIdTareaProyecto.ParameterName = "@idTareaProyecto";
                ParIdTareaProyecto.SqlDbType = SqlDbType.NVarChar;
                ParIdTareaProyecto.Value = personal.IdTareaOrigen;
                SqlCmd.Parameters.Add(ParIdTareaProyecto);


                //IdProyecto
                SqlParameter ParIdProyecto = new SqlParameter();
                ParIdProyecto.ParameterName = "@idProyecto";
                ParIdProyecto.SqlDbType = SqlDbType.NVarChar;
                ParIdProyecto.Value = personal.IdProyecto;
                SqlCmd.Parameters.Add(ParIdProyecto);

                //id_empleadoInsert
                SqlParameter ParIdEmpleadoInsert = new SqlParameter();
                ParIdEmpleadoInsert.ParameterName = "@id_empleadoInsert";
                ParIdEmpleadoInsert.SqlDbType = SqlDbType.NVarChar;
                ParIdEmpleadoInsert.Value = personal.Id_empleadoInsert;
                SqlCmd.Parameters.Add(ParIdEmpleadoInsert);


                //id_empleadoReAsign
                SqlParameter ParId_empleadoReAsign = new SqlParameter();
                ParId_empleadoReAsign.ParameterName = "@id_empleadoReAsign";
                ParId_empleadoReAsign.SqlDbType = SqlDbType.NVarChar;
                ParId_empleadoReAsign.Value = personal.Id_empleadoReAsign;
                SqlCmd.Parameters.Add(ParId_empleadoReAsign);


                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No es posible insertar tarea personal";

                return rpta;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public string editarPersonal(DPersonal personal)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_TareaPersonal";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //Definición de atributos
                //TODO prepara toda la entrada de insertar tareaPersonal


                //idTarea
                SqlParameter ParIdTarea = new SqlParameter();
                ParIdTarea.ParameterName = "@idTarea";
                ParIdTarea.SqlDbType = SqlDbType.NText;
                ParIdTarea.Size = 1024;
                ParIdTarea.Value = personal.IdTarea;
                SqlCmd.Parameters.Add(ParIdTarea);

                //id_empleado
                SqlParameter ParIdEmpleado = new SqlParameter();
                ParIdEmpleado.ParameterName = "@id_empleado";
                ParIdEmpleado.SqlDbType = SqlDbType.NText;
                ParIdEmpleado.Size = 1024;
                ParIdEmpleado.Value = personal.Idempleado;
                SqlCmd.Parameters.Add(ParIdEmpleado);


                //descripcion
                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.NText;
                ParDescripcion.Value = personal.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);


                //fecha creacion
                SqlParameter ParFcreacion = new SqlParameter();
                ParFcreacion.ParameterName = "@fcreacion";
                ParFcreacion.SqlDbType = SqlDbType.SmallDateTime;
                ParFcreacion.Value = personal.Fcreacion;
                SqlCmd.Parameters.Add(ParFcreacion);


                //Prioridad
                SqlParameter ParPrioridad = new SqlParameter();
                ParPrioridad.ParameterName = "@prioridad";
                ParPrioridad.SqlDbType = SqlDbType.NText;
                ParPrioridad.Value = personal.Prioridad;
                SqlCmd.Parameters.Add(ParPrioridad);


                //estado
                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = personal.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                //fecha cierre
                SqlParameter ParFierre = new SqlParameter();
                ParFierre.ParameterName = "@fcierre";
                ParFierre.SqlDbType = SqlDbType.SmallDateTime;
                ParFierre.Value = personal.Fcierre;
                SqlCmd.Parameters.Add(ParFierre);

                //IdTareaGrupo
                SqlParameter ParIdTareaGrupo = new SqlParameter();
                ParIdTareaGrupo.ParameterName = "@idTareaGrupo";
                ParIdTareaGrupo.SqlDbType = SqlDbType.NVarChar;
                ParIdTareaGrupo.Value = personal.IdTareaGrupo;
                SqlCmd.Parameters.Add(ParIdTareaGrupo);


                //IdTareaDestino
                SqlParameter ParIdTareaDestino = new SqlParameter();
                ParIdTareaDestino.ParameterName = "@idTareaDestino";
                ParIdTareaDestino.SqlDbType = SqlDbType.NVarChar;
                ParIdTareaDestino.Value = personal.IdTareaDestino;
                SqlCmd.Parameters.Add(ParIdTareaDestino);


                //IdTareaOrigen
                SqlParameter ParIdTareaOrigen = new SqlParameter();
                ParIdTareaOrigen.ParameterName = "@idTareaOrigen";
                ParIdTareaOrigen.SqlDbType = SqlDbType.NVarChar;
                ParIdTareaOrigen.Value = personal.IdTareaOrigen;
                SqlCmd.Parameters.Add(ParIdTareaOrigen);

                //IdTareaProyecto
                SqlParameter ParIdTareaProyecto = new SqlParameter();
                ParIdTareaProyecto.ParameterName = "@idTareaProyecto";
                ParIdTareaProyecto.SqlDbType = SqlDbType.NVarChar;
                ParIdTareaProyecto.Value = personal.IdTareaOrigen;
                SqlCmd.Parameters.Add(ParIdTareaProyecto);


                //IdProyecto
                SqlParameter ParIdProyecto = new SqlParameter();
                ParIdProyecto.ParameterName = "@idProyecto";
                ParIdProyecto.SqlDbType = SqlDbType.NVarChar;
                ParIdProyecto.Value = personal.IdProyecto;
                SqlCmd.Parameters.Add(ParIdProyecto);

                //id_empleadoInsert
                SqlParameter ParIdEmpleadoInsert = new SqlParameter();
                ParIdEmpleadoInsert.ParameterName = "@id_empleadoInsert";
                ParIdEmpleadoInsert.SqlDbType = SqlDbType.NVarChar;
                ParIdEmpleadoInsert.Value = personal.Id_empleadoInsert;
                SqlCmd.Parameters.Add(ParIdEmpleadoInsert);


                //id_empleadoReAsign
                SqlParameter ParId_empleadoReAsign = new SqlParameter();
                ParId_empleadoReAsign.ParameterName = "@id_empleadoReAsign";
                ParId_empleadoReAsign.SqlDbType = SqlDbType.NVarChar;
                ParId_empleadoReAsign.Value = personal.Id_empleadoReAsign;
                SqlCmd.Parameters.Add(ParId_empleadoReAsign);


                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No es posible editar tarea personal";

                return rpta;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public string eliminarPersonal(DPersonal personal)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_tarea";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                //idTarea
                SqlParameter ParIdTarea = new SqlParameter();
                ParIdTarea.ParameterName = "@idTarea";
                ParIdTarea.SqlDbType = SqlDbType.NVarChar;
                ParIdTarea.Value = personal.IdTarea;
                SqlCmd.Parameters.Add(ParIdTarea);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No es posible eliminar TareaPersonal";

                return rpta;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }
            return rpta;
        }

        public string[] mostrarEstadoModulo(DTarea objeto)
        {
            string[] array = new string[] { };

            DataTable dtresultado = new DataTable("Tareas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_combo_modulo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);//es el que se encarga de rellenar nuestra tabla con el procedimiento almacenado
                sqladap.Fill(dtresultado);

                array = dtresultado.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();

            }
            catch (Exception)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }

            return array;

        }


        public DDetallePersonales getDetallePersonal(string idTarea)
        {
            DataTable dtresultado = new DataTable("personal");
            SqlConnection SqlCon = new SqlConnection();
            DDetallePersonales dPersonal;
            string[] array = new string[] { };
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spVisualizarDetallePersonal";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdTarea = new SqlParameter();
                ParIdTarea.ParameterName = "@codigo_tarea";
                ParIdTarea.SqlDbType = SqlDbType.Int;
                ParIdTarea.Value = idTarea;
                SqlCmd.Parameters.Add(ParIdTarea);


                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);                
                sqladap.Fill(dtresultado);
            }
            catch (Exception)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }
            dPersonal = new DDetallePersonales(
                dtresultado.Rows.OfType<DataRow>().Select(k => k[0].ToString()).First(),
                dtresultado.Rows.OfType<DataRow>().Select(k => k[1].ToString()).First(),
                dtresultado.Rows.OfType<DataRow>().Select(k => k[2].ToString()).First(),
                dtresultado.Rows.OfType<DataRow>().Select(k => k[3].ToString()).First(),
                dtresultado.Rows.OfType<DataRow>().Select(k => k[4].ToString()).First(),
                dtresultado.Rows.OfType<DataRow>().Select(k => k[5].ToString()).First(),
                dtresultado.Rows.OfType<DataRow>().Select(k => k[6].ToString()).First(),
                dtresultado.Rows.OfType<DataRow>().Select(k => k[7].ToString()).First(),
                dtresultado.Rows.OfType<DataRow>().Select(k => k[8].ToString()).First(),
                dtresultado.Rows.OfType<DataRow>().Select(k => k[9].ToString()).First(),
                dtresultado.Rows.OfType<DataRow>().Select(k => k[10].ToString()).First(),
                dtresultado.Rows.OfType<DataRow>().Select(k => k[11].ToString()).First(),
                dtresultado.Rows.OfType<DataRow>().Select(k => k[12].ToString()).First(),
                dtresultado.Rows.OfType<DataRow>().Select(k => k[13].ToString()).First()
                );
                //dtresultado.Rows.OfType<DataRow>().Select(k => k[14].ToString()).First(),
                //dtresultado.Rows.OfType<DataRow>().Select(k => k[15].ToString()).First(),
                //dtresultado.Rows.OfType<DataRow>().Select(k => k[16].ToString()).First(),
                //dtresultado.Rows.OfType<DataRow>().Select(k => k[17].ToString()).First(),
                //dtresultado.Rows.OfType<DataRow>().Select(k => k[18].ToString()).First(),
                //dtresultado.Rows.OfType<DataRow>().Select(k => k[19].ToString()).First());
            return dPersonal;
        }

        public string[] mostrarProyectoCombobox(DTarea objeto)
        {
            string[] array = new string[] { };

            DataTable dtresultado = new DataTable("Proyectos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_combo_proyectos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);//es el que se encarga de rellenar nuestra tabla con el procedimiento almacenado
                sqladap.Fill(dtresultado);

                array = dtresultado.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            }
            catch (Exception)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return array;
        }      
        
    }
}
