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

namespace AppLaLiga.Views
{
    /// <summary>
    /// Interaction logic for Calendario.xaml
    /// </summary>
    public partial class Calendario : UserControl
    {
        public Calendario()
        {
            InitializeComponent();
            
            //Lista de Jornadas (clase creada más abajo) con el nombre de las jornadas que se mostrará en el comboBox
            List<Jornadas> ListaJornadas = new List<Jornadas>();

            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 1" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 2" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 3" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 4" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 5" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 6" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 7" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 8" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 9" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 10" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 11" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 12" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 13" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 14" });

            //Se le asigna al comboBox las opciones que mostrará que son las guardadas en la lista anterior
            cbJornada.ItemsSource = ListaJornadas;

            CargarDatos();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["AppLaLiga.Properties.Settings.LaLigaConnectionString"].ConnectionString);
        void CargarDatos()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select dPartido, cEquipo1, cResultado, cEquipo2 from TPartido where nJornadaID = 1 order by dPartido", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridDatos.ItemsSource = dt.DefaultView;
            con.Close();
        }

        private void cbJornada_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            con.Open();
            //Guarda en una variable indice el número del indice en el que está seleccionado el comboBox
            int indice = cbJornada.SelectedIndex;
            string consulta = "";
            //Según el indice que esté marcado en el comboBox hará una consulta diferente para cada jornada de LaLiga
            switch (indice)
            {
                case 0:
                    consulta = "Select dPartido, cEquipo1, cResultado, cEquipo2 from TPartido where nJornadaID = 1 order by dPartido";
                    break;
                case 1:
                    consulta = "Select dPartido, cEquipo1, cResultado, cEquipo2 from TPartido where nJornadaID = 2 order by dPartido";
                    break;
                case 2:
                    consulta = "Select dPartido, cEquipo1, cResultado, cEquipo2 from TPartido where nJornadaID = 3 order by dPartido";
                    break;
                case 3:
                    consulta = "Select dPartido, cEquipo1, cResultado, cEquipo2 from TPartido where nJornadaID = 4 order by dPartido";
                    break;
                case 4:
                    consulta = "Select dPartido, cEquipo1, cResultado, cEquipo2 from TPartido where nJornadaID = 5 order by dPartido";
                    break;
                case 5:
                    consulta = "Select dPartido, cEquipo1, cResultado, cEquipo2 from TPartido where nJornadaID = 6 order by dPartido";
                    break;
                case 6:
                    consulta = "Select dPartido, cEquipo1, cResultado, cEquipo2 from TPartido where nJornadaID = 7 order by dPartido";
                    break;
                case 7:
                    consulta = "Select dPartido, cEquipo1, cResultado, cEquipo2 from TPartido where nJornadaID = 8 order by dPartido";
                    break;
                case 8:
                    consulta = "Select dPartido, cEquipo1, cResultado, cEquipo2 from TPartido where nJornadaID = 9 order by dPartido";
                    break;
                case 9:
                    consulta = "Select dPartido, cEquipo1, cResultado, cEquipo2 from TPartido where nJornadaID = 10 order by dPartido";
                    break;
                case 10:
                    consulta = "Select dPartido, cEquipo1, cResultado, cEquipo2 from TPartido where nJornadaID = 11 order by dPartido";
                    break;
                case 11:
                    consulta = "Select dPartido, cEquipo1, cResultado, cEquipo2 from TPartido where nJornadaID = 12 order by dPartido";
                    break;
                case 12:
                    consulta = "Select dPartido, cEquipo1, cResultado, cEquipo2 from TPartido where nJornadaID = 13 order by dPartido";
                    break;
                case 13:
                    consulta = "Select dPartido, cEquipo1, cResultado, cEquipo2 from TPartido where nJornadaID = 14 order by dPartido";
                    break;
                default:
                    consulta = "Select dPartido, cEquipo1, cResultado, cEquipo2 from TPartido where nJornadaID = 1 order by dPartido";
                    break;
            }
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridDatos.ItemsSource = dt.DefaultView;
            con.Close();
        }
    }

    public class Jornadas
    {
        public string numJornadas { get; set; }
    }
}
