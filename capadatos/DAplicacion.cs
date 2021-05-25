using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capadatos
{
    public class DAplicacion
    {
        private string id;
        private string titulo;
        private string descripcion;

        public DAplicacion()
        {
        }

        public DAplicacion(string id, string titulo, string descripcion)
        {
            this.id = id;
            this.titulo = titulo;
            this.descripcion = descripcion;
        }

        public DAplicacion(string titulo, string descripcion)
        {
            this.titulo = titulo;
            this.descripcion = descripcion;
        }

        public DataTable mostrarAplicaciones(DAplicacion objeto)
        {
            DataTable dtresultado = new DataTable("Aplicaciones");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_aplicaciones";
                SqlCmd.CommandType = CommandType.StoredProcedure;

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

        public string insertarAplicacion(DAplicacion objeto)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_aplicacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                /*
                SqlParameter ParId= new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.SmallInt;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);*/

                SqlParameter ParTitulo = new SqlParameter();
                ParTitulo.ParameterName = "@titulo";
                ParTitulo.SqlDbType = SqlDbType.NVarChar;
                ParTitulo.Value = objeto.titulo;
                SqlCmd.Parameters.Add(ParTitulo);


                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.NVarChar;
                ParDescripcion.Value = objeto.descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No es posible insertar la aplicacion";


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
    }
}
