using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RecetasSLN.dominio;

namespace RecetasSLN.datos
{
    class HelperDAO
    {
        private static HelperDAO Helper;

        private string Conexion;

        private HelperDAO()
        {
            Conexion = Properties.Resources.Conexion;
        }

        public static HelperDAO ObtenerHelper()
        {
            if (Helper == null)
                Helper = new HelperDAO();
            return Helper;
        }

        public DataTable ConsultarDB(string SP)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            cnn.ConnectionString = Conexion;            
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = SP;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
             
        public int SPconParametroSalida(string SP, string Parametro)
        {           
             SqlParameter pOut = new SqlParameter();
            try
            {
                SqlConnection cnn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();

                cnn.ConnectionString = Conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SP;              
                pOut.ParameterName = Parametro;
                pOut.Value = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();
                cnn.Close();
                int idReceta = (int)pOut.Value;
                return idReceta;
            }
            catch (Exception)
            {
                pOut.Value = 1;
                return (int)pOut.Value;
            }

}
          

        public bool CargarMaestroDetalle(Recetas oReceta)
        {
            SqlConnection cnn = new SqlConnection();
            SqlTransaction t = null;
            try
            {
                SqlCommand cmd1 = new SqlCommand();
                cnn.ConnectionString = Conexion;
                cnn.Open();
                cmd1.Connection = cnn;
                t = cnn.BeginTransaction();
                cmd1.Transaction = t;
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "SP_INSERTAR_RECETA";
                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@nombre", oReceta.Nombre);
                cmd1.Parameters.AddWithValue("id_chef", oReceta.Chef);
                cmd1.Parameters.AddWithValue("@id_tipo_receta", oReceta.TipoReceta);


                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@id_receta";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd1.Parameters.Add(pOut);
                cmd1.ExecuteNonQuery();

                int idReceta = (int)pOut.Value;     

                SqlCommand cmd2;
                int count = 1;

                for (int i = 0; i < oReceta.Detalles.Count; i++)
                {
                    cmd2 = new SqlCommand("SP_INSERTAR_DETALLES", cnn, t);
                    cmd2.CommandType = CommandType.StoredProcedure;

                    cmd2.Parameters.AddWithValue("@detalle_nro", count);
                    cmd2.Parameters.AddWithValue("@id_receta", idReceta);
                    cmd2.Parameters.AddWithValue("@id_ingrediente", oReceta.Detalles[i].Ingredientes.IngredienteID);
                    cmd2.Parameters.AddWithValue("@cantidad", oReceta.Detalles[i].Cantidad);

                    cmd2.ExecuteNonQuery();
                    count++;
                }           
                t.Commit();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
                cnn.Close();
                return false;
            }


        }

    }
}
