using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace ProyectoBancoRediseñado2
{
    class DBHelper
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=Maxi;Initial Catalog=Banco;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlTransaction t = null;

        private void Open()
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            
        }

        public void Close()
        {            
            cnn.Close();
        }

        public DataTable ConsultarBD(string SP)
        {
            DataTable tabla = new DataTable();
            Open();
            cmd.CommandText = SP;
            tabla.Load(cmd.ExecuteReader());
            Close();
            return tabla;
        }

        public int SPActualizar(string sp, List<Parametros> lParametros)
        {
            int filasAfectadas;
            Open();
            cmd.CommandText = sp;
            cmd.Parameters.Clear();
            foreach (Parametros p in lParametros)
            {
                cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            filasAfectadas = cmd.ExecuteNonQuery();
            
            Close();
            return filasAfectadas;
        }

        public DataTable SPConsultaParametros(string SP, string Nombre, object Valor)
        {
            DataTable tabla = new DataTable();
            Open();
            cmd.CommandText = SP;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue(Nombre, Valor);
            tabla.Load(cmd.ExecuteReader());
            Close();
            return tabla;
        }

        public int Trasacciones(string sp, List<Parametros> lParametros)
        {
            int filasAfectadas = 0;
            Open();
            t = cnn.BeginTransaction();
            cmd.Transaction = t;
            cmd.CommandText = sp;            
            foreach (Parametros p in lParametros)
            {
                cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            filasAfectadas = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            t.Commit();
            Close();            
            return filasAfectadas;            
        }

        public int BajaLogica(int Cbu,string estado)
        {
            int filasAfectadas = 0;
            SqlTransaction t = null;
            cmd.Parameters.Clear();

            try
            {
                Open();
                t = cnn.BeginTransaction();
                cmd.Transaction = t;
                cmd.CommandText = "BajaLogica";
                cmd.Parameters.AddWithValue("@cbu", Cbu);
                cmd.Parameters.AddWithValue("@estado", estado);
                filasAfectadas = cmd.ExecuteNonQuery();
                t.Commit();
                Close();
                return filasAfectadas;
            }
            catch
            {
                t.Rollback();
            }
            
            return filasAfectadas;

        }

        public DataTable Reporte(string estado)
        {
            Open();
            DataTable tabla = new DataTable();
            cmd.CommandText = "SP_Reporte";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@estado", estado);           
            tabla.Load(cmd.ExecuteReader());
            Close();
            return tabla;            
        }

    }
}
