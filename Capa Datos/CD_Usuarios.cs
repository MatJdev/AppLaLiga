using System.Data.SqlClient;
using System.Data;
using Capa_Entidad;
using System;

namespace Capa_Datos
{
    public class CD_Usuarios
    {
        private readonly CD_Conexion con = new CD_Conexion();
        private readonly CE_Usuarios ce = new CE_Usuarios();

        //Insertar Usuario
        public void CD_Insertar(CE_Usuarios Usuarios)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "P_CrearUsuario",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@cNIFID", Usuarios.CNIFID);
            com.Parameters.AddWithValue("@cNombre", Usuarios.CNombre);
            com.Parameters.AddWithValue("@cPass", Usuarios.CPass);
            com.Parameters.AddWithValue("@cEmail", Usuarios.CEmail);
            //Ejecutamos comando
            com.ExecuteNonQuery();
            //Limpiamos parámetros
            com.Parameters.Clear();
            //Cerramos conexión
            con.CerrarConexion();
        }

        //Insertar Usuario Admin
        public void CD_InsertarAdmin(CE_Usuarios Usuarios)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "P_CrearUsuarioAdmin",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@cNIFID", Usuarios.CNIFID);
            com.Parameters.AddWithValue("@cNombre", Usuarios.CNombre);
            com.Parameters.AddWithValue("@cPass", Usuarios.CPass);
            com.Parameters.AddWithValue("@cEmail", Usuarios.CEmail);
            com.Parameters.AddWithValue("@lAdmin", Usuarios.LAdmin);
            com.Parameters.AddWithValue("@nAdmin", Usuarios.NAdmin);
            //Ejecutamos comando
            com.ExecuteNonQuery();
            //Limpiamos parámetros
            com.Parameters.Clear();
            //Cerramos conexión
            con.CerrarConexion();
        }

        //Consultar Datos Usuario
        public CE_Usuarios CD_Consulta(string Nombre, string Pass)
        {
            SqlDataAdapter da = new SqlDataAdapter("P_CargarInfoUsuarios", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@cNombre", SqlDbType.VarChar).Value = Nombre;
            da.SelectCommand.Parameters.Add("@cPass", SqlDbType.VarChar).Value = Pass;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.CNombre = Convert.ToString(row[0]);
            ce.CPass = Convert.ToString(row[1]);
            ce.CEmail = Convert.ToString(row[2]);
            ce.CNIFID = Convert.ToString(row[3]);                      
            return ce;
        }

        //Consultar si el nombre y correo estan registrados
        public CE_Usuarios CD_ConsultaEmailRegistrado(string Nombre, string Email)
        {
            SqlDataAdapter da = new SqlDataAdapter("P_ColsultaUsuario", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@cNombre", SqlDbType.VarChar).Value = Nombre;
            da.SelectCommand.Parameters.Add("@cEmail", SqlDbType.VarChar).Value = Email;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.CNombre = Convert.ToString(row[1]);
            ce.CEmail = Convert.ToString(row[2]);

            return ce;
        }

        //Consulta Login
        public CE_Usuarios CD_ConsultaLogin(string Nombre, string Pass)
        {
            SqlDataAdapter da = new SqlDataAdapter("P_Login", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@cNombre", SqlDbType.VarChar).Value = Nombre;
            da.SelectCommand.Parameters.Add("@cPass", SqlDbType.VarChar).Value = Pass;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.CNIFID = Convert.ToString(row[1]);
            ce.CNombre = Convert.ToString(row[2]);
            ce.CPass = Convert.ToString(row[3]);
            ce.LAdmin = Convert.ToInt32(row[4]);
            ce.NAdmin = Convert.ToInt32(row[5]);
            ce.CEmail = Convert.ToString(row[6]);

            return ce;
        }

        //Cargar Todos Usuarios
        public DataTable CargarTodosUsuarios()
        {
            SqlDataAdapter da = new SqlDataAdapter("P_CargarTodosUsuarios", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            con.CerrarConexion();

            return dt;
        }

        //Actualizar Datos Usuario
        public void CD_ActualizarDatos(CE_Usuarios Usuarios)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "P_ActualizarUsuarios",
                CommandType = CommandType.StoredProcedure
            };
            com.Parameters.AddWithValue("@cNIFID", Usuarios.CNIFID);
            com.Parameters.AddWithValue("@cNombre", Usuarios.CNombre);
            com.Parameters.AddWithValue("@cPass", Usuarios.CPass);
            com.Parameters.AddWithValue("@cEmail", Usuarios.CEmail);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
    }
}
