﻿using System;
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
        private int _idtarea;
        private string _descripcion;        
        private string _idempleado;
        private string _estado;
        private string _tareaproyecto;
        private string _proyecto;

    
        public int Idtarea { get => _idtarea; set => _idtarea = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Idempleado { get => _idempleado; set => _idempleado = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Tareaproyecto { get => _tareaproyecto; set => _tareaproyecto = value; }
        public string Proyecto { get => _proyecto; set => _proyecto = value; }

        public DPersonal()
        {

        }
        public DPersonal(int idtarea, string descripcion, string idempleado, string estado, string tareaproyecto, string proyecto)
        {
            _idtarea = idtarea;
            _descripcion = descripcion;
            _idempleado = idempleado;
            _estado = estado;
            _tareaproyecto = tareaproyecto;
            _proyecto = proyecto;
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


                /*
                //id
                SqlParameter ParIdTarea = new SqlParameter();
                ParIdTarea.ParameterName = "@idTarea";
                ParIdTarea.SqlDbType = SqlDbType.Int;
                ParIdTarea.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdTarea);


                //descripcion               
                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.NText;
                //ParObservaciones.Size = 1024;
                ParDescripcion.Value = objeto.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);
            

                //nombre
                SqlParameter ParEmpleado = new SqlParameter();
                ParEmpleado.ParameterName = "@Nombre";
                ParEmpleado.SqlDbType = SqlDbType.NVarChar;
                ParEmpleado.Size = 1024;
                ParEmpleado.Value = objeto.Idempleado;                
                SqlCmd.Parameters.Add(ParEmpleado);


                //DesEstado
                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@DesEstado";
                ParEstado.SqlDbType = SqlDbType.NVarChar;
                ParEstado.Size = 1024;
                ParEstado.Value = objeto.Estado;
                SqlCmd.Parameters.Add(ParEstado);


                //TareaProyecto
                SqlParameter ParTareaProyecto = new SqlParameter();
                ParTareaProyecto.ParameterName = "@TareaProyecto";
                ParTareaProyecto.SqlDbType = SqlDbType.NText;
                ParTareaProyecto.Size = 1024;
                ParTareaProyecto.Value = objeto.Tareaproyecto;
                SqlCmd.Parameters.Add(ParTareaProyecto);

                //Proyecto
                SqlParameter ParProyecto = new SqlParameter();
                ParProyecto.ParameterName = "@Proyecto";
                ParProyecto.SqlDbType = SqlDbType.NText;
                ParProyecto.Size = 1024;
                ParProyecto.Value = objeto.Proyecto;
                SqlCmd.Parameters.Add(ParProyecto);
                */

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

        public string[] mostrarPrioridad(DTarea objeto)
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
                SqlCmd.CommandText = "spmostrar_combo_prioridad";
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

        public string[] mostrarTenicos(DTarea objeto)
        {
            string[] array = new string[] { };

            DataTable dtresultado = new DataTable("Empleados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_combo_tecnicos";
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

        public string[] mostrarAplicaciones(DTarea objeto)
        {
            string[] array = new string[] { };

            DataTable dtresultado = new DataTable("Aplicaciones");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_combo_aplicaciones";
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

        public DetalleTareas getDetalleTareas(string codigo_tarea)
        {
            DataTable dtresultado = new DataTable("Tareas");
            SqlConnection SqlCon = new SqlConnection();
            DetalleTareas dTarea;
            string[] array = new string[] { };
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spVisualizarDetalleTareas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCodTarea = new SqlParameter();
                ParCodTarea.ParameterName = "@codigo_tarea";
                ParCodTarea.SqlDbType = SqlDbType.VarChar;
                ParCodTarea.Value = codigo_tarea;//tarea.Codigo_proyecto;
                SqlCmd.Parameters.Add(ParCodTarea);


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
            dTarea = new DetalleTareas(dtresultado.Rows.OfType<DataRow>().Select(k => k[0].ToString()).First(),
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
                dtresultado.Rows.OfType<DataRow>().Select(k => k[13].ToString()).First(),
                dtresultado.Rows.OfType<DataRow>().Select(k => k[14].ToString()).First(),
                dtresultado.Rows.OfType<DataRow>().Select(k => k[15].ToString()).First(),
                dtresultado.Rows.OfType<DataRow>().Select(k => k[16].ToString()).First(),
                dtresultado.Rows.OfType<DataRow>().Select(k => k[17].ToString()).First(),
                dtresultado.Rows.OfType<DataRow>().Select(k => k[18].ToString()).First(),
                dtresultado.Rows.OfType<DataRow>().Select(k => k[19].ToString()).First());
            return dTarea;
        }

        public string eliminarTarea(int id)
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


                //id
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = id;
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
                ParTitulo.SqlDbType = SqlDbType.NText;
                ParTitulo.Size = 1024;
                ParTitulo.Value = tarea.Titulo;
                SqlCmd.Parameters.Add(ParTitulo);

                //tiempo estmiado
                SqlParameter ParTiempoEstimado = new SqlParameter();
                ParTiempoEstimado.ParameterName = "@tiempo_estimado";
                ParTiempoEstimado.SqlDbType = SqlDbType.Int;
                ParTiempoEstimado.Value = tarea.TiempoEstimado;
                SqlCmd.Parameters.Add(ParTiempoEstimado);

                //proyecto
                SqlParameter ParProyecto = new SqlParameter();
                ParProyecto.ParameterName = "@proyecto";
                ParProyecto.SqlDbType = SqlDbType.NText;
                ParProyecto.Value = tarea.Proyecto;
                SqlCmd.Parameters.Add(ParProyecto);

                //proyecto
                SqlParameter ParPrioridad = new SqlParameter();
                ParPrioridad.ParameterName = "@prioridad";
                ParPrioridad.SqlDbType = SqlDbType.NText;
                ParPrioridad.Value = tarea.Prioridad;
                SqlCmd.Parameters.Add(ParPrioridad);

                //Estado
                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.NText;
                ParEstado.Value = tarea.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                //Aplicacion
                SqlParameter ParAplicacion = new SqlParameter();
                ParAplicacion.ParameterName = "@aplicacion";
                ParAplicacion.SqlDbType = SqlDbType.NText;
                ParAplicacion.Value = tarea.Aplicacion;
                SqlCmd.Parameters.Add(ParAplicacion);

                //Version Deteccion
                SqlParameter ParVDeteccion = new SqlParameter();
                ParVDeteccion.ParameterName = "@vdeteccion";
                ParVDeteccion.SqlDbType = SqlDbType.NText;
                ParVDeteccion.Value = tarea.Vdeteccion;
                SqlCmd.Parameters.Add(ParVDeteccion);

                //Modulo
                SqlParameter ParModulo = new SqlParameter();
                ParModulo.ParameterName = "@modulo";
                ParModulo.SqlDbType = SqlDbType.NText;
                ParModulo.Value = tarea.Modulo;
                SqlCmd.Parameters.Add(ParModulo);

                //Referencias
                SqlParameter ParReferencias = new SqlParameter();
                ParReferencias.ParameterName = "@referencias";
                ParReferencias.SqlDbType = SqlDbType.NText;
                ParReferencias.Value = tarea.Referencias;
                SqlCmd.Parameters.Add(ParReferencias);

                //Version solucion
                SqlParameter ParVSolucion = new SqlParameter();
                ParVSolucion.ParameterName = "@vsolucion";
                ParVSolucion.SqlDbType = SqlDbType.NText;
                ParVSolucion.Value = tarea.Vsolucion;
                SqlCmd.Parameters.Add(ParVSolucion);

                //Historia
                SqlParameter ParHistoria = new SqlParameter();
                ParHistoria.ParameterName = "@historia";
                ParHistoria.SqlDbType = SqlDbType.NText;
                ParHistoria.Value = tarea.Historia;
                SqlCmd.Parameters.Add(ParHistoria);

                //descripcion
                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.NText;
                ParDescripcion.Value = tarea.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                //Solucion
                SqlParameter ParSolucion = new SqlParameter();
                ParSolucion.ParameterName = "@solucion";
                ParSolucion.SqlDbType = SqlDbType.NText;
                ParSolucion.Value = tarea.Solucion;
                SqlCmd.Parameters.Add(ParSolucion);

                //Tecnico deteccion
                SqlParameter ParTDeteccion = new SqlParameter();
                ParTDeteccion.ParameterName = "@tdeteccion";
                ParTDeteccion.SqlDbType = SqlDbType.NText;
                ParTDeteccion.Value = tarea.Tdeteccion;
                SqlCmd.Parameters.Add(ParTDeteccion);

                //Tecnico solucion
                SqlParameter ParTSolucion = new SqlParameter();
                ParTSolucion.ParameterName = "@tsolucion";
                ParTSolucion.SqlDbType = SqlDbType.NText;
                ParTSolucion.Value = tarea.Tsolucion;
                SqlCmd.Parameters.Add(ParTSolucion);

                //Tecnico verificacion
                SqlParameter ParTVerificacion = new SqlParameter();
                ParTVerificacion.ParameterName = "@tverificacion";
                ParTVerificacion.SqlDbType = SqlDbType.NText;
                ParTVerificacion.Value = tarea.Tverificacion;
                SqlCmd.Parameters.Add(ParTVerificacion);

                //fecha deteccion
                SqlParameter ParFechaDeteccion = new SqlParameter();
                ParFechaDeteccion.ParameterName = "@fechadeteccion";
                ParFechaDeteccion.SqlDbType = SqlDbType.SmallDateTime;
                ParFechaDeteccion.Value = tarea.Fechadeteccion;
                SqlCmd.Parameters.Add(ParFechaDeteccion);

                //fecha solucion
                SqlParameter ParFechaSolucion = new SqlParameter();
                ParFechaSolucion.ParameterName = "@fechasolucion";
                ParFechaSolucion.SqlDbType = SqlDbType.SmallDateTime;
                ParFechaSolucion.Value = tarea.Fechasolucion;
                SqlCmd.Parameters.Add(ParFechaSolucion);

                //fecha verificacion
                SqlParameter ParFechaVerificacion = new SqlParameter();
                ParFechaVerificacion.ParameterName = "@fechaverififcacion";
                ParFechaVerificacion.SqlDbType = SqlDbType.SmallDateTime;
                ParFechaVerificacion.Value = tarea.Fechaverificacion;
                SqlCmd.Parameters.Add(ParFechaVerificacion);


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

            DataTable dtresultado = new DataTable("TEstadosTareasPersonales");
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
