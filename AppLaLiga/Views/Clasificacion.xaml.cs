using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppLaLiga.SCS
{
    /// <summary>
    /// Interaction logic for Clasificacion.xaml
    /// </summary>
    public partial class Clasificacion : UserControl
    {
        public Clasificacion()
        {
            InitializeComponent();
            CargarDatos();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["AppLaLiga.Properties.Settings.LaLigaConnectionString"].ConnectionString);
        void CargarDatos()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select ROW_NUMBER() OVER(ORDER BY nPuntos DESC) AS rowNum, cNombre, nPuntos, nPJ, nPG, nPE, nPP from TEquipo order by TEquipo.nPuntos DESC", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridDatos.ItemsSource = dt.DefaultView;
            con.Close();
        }
    }
}
