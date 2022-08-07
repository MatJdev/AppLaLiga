using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using Capa_Entidad;
using Capa_Negocio;

namespace AppLaLiga.Views
{
    /// <summary>
    /// Interaction logic for EquipoInfo.xaml
    /// </summary>
    public partial class EquipoInfo : UserControl
    {
        readonly CN_Jugadores obj_CN_Jugadores = new CN_Jugadores();
        readonly CE_Jugadores obj_CE_Jugadores = new CE_Jugadores();

        public EquipoInfo()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["AppLaLiga.Properties.Settings.LaLigaConnectionString"].ConnectionString);
        public int idClub = 0;
        //Hace la consulta con el ID del club en el que pinchemos en editar
        //Rellena los campos de textbox con estos datos de la consulta SQL
        public void CargarDatos()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT TEquipo.cNombre, TEquipo.nAnyoFundacion, TEquipo.cEntrenador, TEquipo.cCiudad, TEstadio.cNombre as 'Estadio', TEstadio.nAforo, TEstadio.cDireccion from TEquipo INNER JOIN TEstadio ON TEquipo.nEquipoID = TEstadio.nEquipoID WHERE TEquipo.nEquipoID = " + idClub.ToString(), con);
            SqlDataReader rdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            rdr.Read();
            this.NombreClub.Text = rdr["cNombre"].ToString();
            this.año.Text = rdr["nAnyoFundacion"].ToString();
            this.Entrenador.Text = rdr["cEntrenador"].ToString();
            this.Ciudad.Text = rdr["cCiudad"].ToString();
            this.Estadio.Text = rdr["Estadio"].ToString();
            this.Aforo.Text = rdr["nAforo"].ToString();
            this.Direccion.Text = rdr["cDireccion"].ToString();
            rdr.Close();
            con.Close();
        }

        //Hace la consulta SQL a la tabla de jugadores con el ID del club
        //Y muestra los datos en el datagrid
        public void CargarJugadores()
        {
            GridDatos.ItemsSource = obj_CN_Jugadores.CargarJugadores(idClub).DefaultView;
        }

        private void BtnRegresar_Click(object sender, RoutedEventArgs e)
        {
            Content = new Clubs();
        }
    }
}
