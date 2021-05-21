using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BDPARQUEO.clases
{
    public class clsProDal
    {
        public static int agregar(clspropietario pclspropietario)
        {
            int retorno = 0;
            using (SqlConnection conn = clsBDcomun.obtener_conexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("insert into Tb_Propietario(matricula,propietario,fecha_ingreso,DPI,telefono,colorAuto)values('{0}','{1}','{2}',{3},{4},'{5}')",
                    pclspropietario.matricula, pclspropietario.propietario, pclspropietario.fecha_ingreso, pclspropietario.DPI, pclspropietario.telefono, pclspropietario.color), conn);

                retorno = comando.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}