using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Capa_Datos
{
    public class CD_Conexion
    {
        //Conexion SQL con referencia a mi servidor y base de datos
        private readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["AppLaLiga.Properties.Settings.LaLigaConnectionString"].ConnectionString);

        //Metodo para abrir la conexion
        public SqlConnection AbrirConexion()
        {
            //Valida si el estado de la conexion es cerrado y entonces la abrira
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }
        //Metodo para cerrar la conexion
        public SqlConnection CerrarConexion()
        {
            //Valida si el estado de la conexion es abierto y entonces la cerrara
            if (con.State == ConnectionState.Open)
                con.Close();
            return con;
        }
    }
}
