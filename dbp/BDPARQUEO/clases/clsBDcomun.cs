using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BDPARQUEO.clases
{
    public class clsBDcomun
    {
        
        public static SqlConnection obtener_conexion()
            {
                SqlConnection conn = new SqlConnection("data source=UMG-VM\\SQLEXPRESS; initial catalog=DBPARQUEO;integrated security=true");
                conn.Open();
                return conn;
            }

        


    }

}
