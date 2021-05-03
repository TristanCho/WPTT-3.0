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
    public class DTarea
    {
        private int _id;
        private string _titulo;
        private string _descripcion;
        private string _estado;
        private string _textobuscar;
        private string _proyecto;
        private string _observaciones;
        private DateTime _fecha;
        private string _tecnico;
        private string _codigo_proyecto;

        public int Id { get => _id; set => _id = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Observaciones { get => _observaciones; set => _observaciones = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }
        public string Proyecto { get => _proyecto; set => _proyecto = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public string Tecnico { get => _tecnico; set => _tecnico = value; }
        public string Codigo_proyecto { get => _codigo_proyecto; set => _codigo_proyecto = value; }

        public DTarea()
        {

        }

        public DTarea(int id, string titulo, string descripcion, string proyecto, string prioridad, string estado, string textobuscar,string codigo_proyecto)
        {
            Id = id;
            Titulo = titulo;
            Descripcion = descripcion;
            Proyecto = proyecto;
            Estado = estado;
            Textobuscar = textobuscar;
            Codigo_proyecto = codigo_proyecto;
        }

        public DataTable mostrartarea(DTarea objeto)
        {
            DataTable dtresultado = new DataTable("tareas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_tareas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);//es el que se encarga de rellenar nuestra tabla con el procedimiento almacenado
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

        public DataTable mostrarDetalleTiempos(String codigo_tarea)//DTarea tarea)
        {
            DataTable dtresultado = new DataTable("Tiempos_tarea");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_tiemposTareas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCodProyect = new SqlParameter();
                ParCodProyect.ParameterName = "@codigo_proyecto";
                ParCodProyect.SqlDbType = SqlDbType.VarChar;
                ParCodProyect.Value = codigo_tarea;//tarea.Codigo_proyecto;
                SqlCmd.Parameters.Add(ParCodProyect);


                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);//es el que se encarga de rellenar nuestra tabla con el procedimiento almacenado
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

        public string eliminarTarea(DTarea tarea)
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

                //Definición de atributos

                //id
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = tarea.Id;
                SqlCmd.Parameters.Add(ParId);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No es posible eliminar el Proyecto";

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

        public string insertartarea(DTarea tarea)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_tarea";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Definición de atributos



                //titulo
                SqlParameter ParTitulo = new SqlParameter();
                ParTitulo.ParameterName = "@titulo";
                ParTitulo.SqlDbType = SqlDbType.NVarChar;
                ParTitulo.Size = 1024;
                ParTitulo.Value = tarea.Titulo;
                SqlCmd.Parameters.Add(ParTitulo);


                //observaciones
                SqlParameter ParObservaciones = new SqlParameter();
                ParObservaciones.ParameterName = "@observaciones";
                ParObservaciones.SqlDbType = SqlDbType.NText;
                //ParObservaciones.Size = 1024;
                ParObservaciones.Value = tarea.Observaciones;
                SqlCmd.Parameters.Add(ParObservaciones);

                //descripcion
                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.NText;
                //ParObservaciones.Size = 1024;
                ParDescripcion.Value = tarea.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);


                //estado
                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                //ParFecha.SqlDbType = SqlDbType.SmallDateTime;
                ParEstado.SqlDbType = SqlDbType.NText;
                //ParFecha.Size = 1024;
                ParEstado.Value = tarea.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                //tecnico
                SqlParameter ParTecnico = new SqlParameter();
                ParTecnico.ParameterName = "@tecnico";
                ParTecnico.SqlDbType = SqlDbType.NText;
                //ParObservaciones.Size = 1024;
                ParTecnico.Value = tarea.Tecnico;
                SqlCmd.Parameters.Add(ParTecnico);

                //proyecto
                SqlParameter ParProyecto = new SqlParameter();
                ParProyecto.ParameterName = "@proyecto";
                ParProyecto.SqlDbType = SqlDbType.NText;
                //ParObservaciones.Size = 1024;
                ParProyecto.Value = tarea.Proyecto;
                SqlCmd.Parameters.Add(ParProyecto);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No es posible insertar el Proyecto";

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

        public string[] mostrarEstadoCombobox(DTarea objeto)
        {
            string[] array = new string[] { };

            DataTable dtresultado = new DataTable("tareas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_combo_estados";
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

        public string[] mostrarProyectoCombobox(DTarea objeto)
        {
            string[] array = new string[] { };

            DataTable dtresultado = new DataTable("tareas");
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

 

        public string editarTarea(DTarea tarea)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_tarea";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Definición de atributos

                //id
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = tarea.Id;
                SqlCmd.Parameters.Add(ParId);


                //titulo
                SqlParameter ParTitulo = new SqlParameter();
                ParTitulo.ParameterName = "@titulo";
                ParTitulo.SqlDbType = SqlDbType.NVarChar;
                ParTitulo.Size = 1024;
                ParTitulo.Value = tarea.Titulo;
                SqlCmd.Parameters.Add(ParTitulo);

                //descripcion
                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.NVarChar;
                //ParFecha.Size = 1024;
                ParDescripcion.Value = tarea.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                //observaciones
                SqlParameter ParObservaciones = new SqlParameter();
                ParObservaciones.ParameterName = "@observaciones";
                ParObservaciones.SqlDbType = SqlDbType.NText;
                //ParObservaciones.Size = 1024;
                ParObservaciones.Value = tarea.Observaciones;
                SqlCmd.Parameters.Add(ParObservaciones);


                //fecha
                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha_creacion";
                ParFecha.SqlDbType = SqlDbType.SmallDateTime;
                //ParFecha.Size = 1024;
                ParFecha.Value = tarea.Fecha;
                SqlCmd.Parameters.Add(ParFecha);


                //estado
                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.NText;
                //ParFecha.Size = 1024;
                ParEstado.Value = tarea.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                //tecnico
                SqlParameter ParTecnico = new SqlParameter();
                ParTecnico.ParameterName = "@tecnico";
                ParTecnico.SqlDbType = SqlDbType.NText;
                //ParObservaciones.Size = 1024;
                ParTecnico.Value = tarea.Tecnico;
                SqlCmd.Parameters.Add(ParTecnico);

                //proyecto
                SqlParameter ParProyecto = new SqlParameter();
                ParProyecto.ParameterName = "@proyecto";
                ParProyecto.SqlDbType = SqlDbType.NText;
                //ParObservaciones.Size = 1024;
                ParProyecto.Value = tarea.Proyecto;
                SqlCmd.Parameters.Add(ParProyecto);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No es posible actualizar el Proyecto";

                return rpta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");

                MessageBox.Show(ex.Message, ex.StackTrace);
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }
            return rpta;
        }

        public DataTable buscartareaDescripcion(DTarea tarea)
        {
            DataTable dtresultado = new DataTable("tareas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_tareas_descripcion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Buscar proyecto por descripcion
                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 10;
                ParTextobuscar.Value = tarea.Textobuscar;
                SqlCmd.Parameters.Add(ParTextobuscar);

                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);
                sqladap.Fill(dtresultado);//es el que se encarga de rellenar nuestra tabla con el procedimiento almacenado


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

        public DataTable buscartareaEstados(DTarea tarea)
        {
            DataTable dtresultado = new DataTable("tareas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_tareas_estado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Buscar proyecto por estados
                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 10;
                ParTextobuscar.Value = tarea.Textobuscar;
                SqlCmd.Parameters.Add(ParTextobuscar);

                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);
                sqladap.Fill(dtresultado);//es el que se encarga de rellenar nuestra tabla con el procedimiento almacenado


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

        public DataTable buscartareaFechaCreacion(DTarea tarea)
        {
            DataTable dtresultado = new DataTable("tareas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_tareasXfechacreacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Buscar proyecto por fecha
                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 10;
                ParTextobuscar.Value = tarea.Textobuscar;
                SqlCmd.Parameters.Add(ParTextobuscar);

                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);
                sqladap.Fill(dtresultado);//es el que se encarga de rellenar nuestra tabla con el procedimiento almacenado


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

        public DataTable buscartareaObservaciones(DTarea tarea)
        {
            DataTable dtresultado = new DataTable("tareas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_tareasXobservaciones";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Buscar proyecto por observaciones
                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 10;
                ParTextobuscar.Value = tarea.Textobuscar;
                SqlCmd.Parameters.Add(ParTextobuscar);

                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);
                sqladap.Fill(dtresultado);//es el que se encarga de rellenar nuestra tabla con el procedimiento almacenado


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

        public DataTable buscartareaProyecto(DTarea tarea)
        {
            DataTable dtresultado = new DataTable("tareas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_tareas_proyecto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Buscar proyecto por proyecto
                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 10;
                ParTextobuscar.Value = tarea.Textobuscar;
                SqlCmd.Parameters.Add(ParTextobuscar);

                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);
                sqladap.Fill(dtresultado);//es el que se encarga de rellenar nuestra tabla con el procedimiento almacenado


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

        public DataTable buscartareaPrioridad(DTarea tarea)
        {
            DataTable dtresultado = new DataTable("tareas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_tareas_prioridad";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Buscar proyecto por tecnico
                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 10;
                ParTextobuscar.Value = tarea.Textobuscar;
                SqlCmd.Parameters.Add(ParTextobuscar);

                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);
                sqladap.Fill(dtresultado);//es el que se encarga de rellenar nuestra tabla con el procedimiento almacenado


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

        public DataTable buscartareaTitulo(DTarea tarea)
        {
            DataTable dtresultado = new DataTable("tareas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_tareas_titulo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Buscar proyecto por titulo
                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 10;
                ParTextobuscar.Value = tarea.Textobuscar;
                SqlCmd.Parameters.Add(ParTextobuscar);

                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);
                sqladap.Fill(dtresultado);//es el que se encarga de rellenar nuestra tabla con el procedimiento almacenado


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
        public DataTable buscartareaAplicacion(DTarea tarea)
        {
            DataTable dtresultado = new DataTable("tareas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_tareas_aplicacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Buscar proyecto por titulo
                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 10;
                ParTextobuscar.Value = tarea.Textobuscar;
                SqlCmd.Parameters.Add(ParTextobuscar);

                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);
                sqladap.Fill(dtresultado);//es el que se encarga de rellenar nuestra tabla con el procedimiento almacenado


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
    }
}
