using System.Data.SqlClient;
using System.Data;
using Capa_Entidad;
using System;

namespace Capa_Datos
{
    public class CD_Equipos
    {
        private readonly CD_Conexion con = new CD_Conexion();
        private readonly CE_Equipos ce = new CE_Equipos();

        //Consultar Datos Equipo
        public DataTable CargarRankingEquipos()
        {
            SqlDataAdapter da = new SqlDataAdapter("P_CargarRankingEquipos", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            con.CerrarConexion();

            return dt;
        }

        //Consultar Datos Equipos
        public CE_Equipos CD_Consulta(int equipoID)
        {
            SqlDataAdapter da = new SqlDataAdapter("P_CargarDatosEquipo", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@nEquipoID", SqlDbType.VarChar).Value = equipoID;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.CNombre = Convert.ToString(row[0]);
            ce.NPuntos = Convert.ToInt32(row[1]);
            ce.NPJ = Convert.ToInt32(row[2]);
            ce.NPG = Convert.ToInt32(row[3]);
            ce.NPE = Convert.ToInt32(row[4]);
            ce.NPP = Convert.ToInt32(row[5]);
          
            return ce;
        }

        //Actualizar Datos Equipo
        public void CD_ActualizarDatos(CE_Equipos Equipos)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "P_ActualizarDatosEquipo",
                CommandType = CommandType.StoredProcedure
            };
            com.Parameters.AddWithValue("@nEquipoID", Equipos.NEquipoID);
            com.Parameters.AddWithValue("@cNombre", Equipos.CNombre);
            com.Parameters.AddWithValue("@nPuntos", Equipos.NPuntos);
            com.Parameters.AddWithValue("@nPJ", Equipos.NPJ);
            com.Parameters.AddWithValue("@nPG", Equipos.NPG);
            com.Parameters.AddWithValue("@nPE", Equipos.NPE);
            com.Parameters.AddWithValue("@nPP", Equipos.NPP);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
    }
}
