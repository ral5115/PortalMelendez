using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace MelendezFront3.Data
{
    public class clsDatos
    {

        public SqlConnection sqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ToString());

        public SqlCommand sqlComando = new SqlCommand();

        public SqlDataAdapter sqlAdaptador = new SqlDataAdapter();

        public DataSet ds = new DataSet();

        public DataTable dt = new DataTable();
    }
}