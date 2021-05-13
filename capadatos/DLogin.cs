using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capadatos
{
    public class DLogin
    {
        private string hostname;
        private string usuario;

        public string Hostname { get => hostname; set => hostname = value; }
        public string Usuario { get => usuario; set => usuario = value; }

        public DLogin(string usuario, string hostname)
        {
            this.Hostname = hostname;
            this.Usuario = usuario;
        }

        public bool login()
        {
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //con.Open();
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand query = new SqlCommand("select count(*) as existe from Empleados where usuario=@usuario and maquina=@maquina", SqlCon);
                query.Parameters.AddWithValue("@usuario", usuario);
                query.Parameters.AddWithValue("@maquina", hostname);
                //para el comando

                String existe = "";

                using (SqlDataReader oReader = query.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        existe = oReader["existe"].ToString();
                        Console.WriteLine(existe+" existe");
                    }
                }
                if (existe.Equals("1"))
                {
                    Console.WriteLine("es igual a 1, devuelve true");

                    return true;

                }

            }
            catch (Exception)
            {
                Console.WriteLine("excepcion");
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }
            return false;
        }


        public DLogin()
        {
        }
    }
}
