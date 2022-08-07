using System.Data.SqlClient;
using System.Data;
using Capa_Entidad;
using System;

namespace Capa_Datos
{
    public class CD_Jugadores
    {
        private readonly CD_Conexion con = new CD_Conexion();
        private readonly CE_Jugadores ce = new CE_Jugadores();

        //Consultar Datos Jugadores
        public DataTable CargarJugadores(int equipoID)
        {
            SqlDataAdapter da = new SqlDataAdapter("P_CargarDatosJugadores", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@nEquipoID", SqlDbType.VarChar).Value = equipoID;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            con.CerrarConexion();

            return dt;
        }
    }
}
