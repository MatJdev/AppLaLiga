using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

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
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 15" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 16" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 17" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 18" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 19" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 20" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 21" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 22" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 23" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 24" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 25" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 26" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 27" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 28" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 29" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 30" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 31" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 32" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 33" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 34" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 35" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 36" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 37" });
            ListaJornadas.Add(new Jornadas { numJornadas = "Jornada 38" });

            //Se le asigna al comboBox las opciones que mostrará que son las guardadas en la lista anterior
            cbJornada.ItemsSource = ListaJornadas;
            CargarDatos();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["AppLaLiga.Properties.Settings.LaLigaConnectionString"].ConnectionString);
        //Hace la consulta a la base de datos y carga esos datos en el datagrid indicado
        void CargarDatos()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 1 order by dPartido", con);
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
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 1 order by dPartido";
                    break;
                case 1:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 2 order by dPartido";
                    break;
                case 2:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 3 order by dPartido";
                    break;
                case 3:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 4 order by dPartido";
                    break;
                case 4:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 5 order by dPartido";
                    break;
                case 5:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 6 order by dPartido";
                    break;
                case 6:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 7 order by dPartido";
                    break;
                case 7:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 8 order by dPartido";
                    break;
                case 8:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 9 order by dPartido";
                    break;
                case 9:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 10 order by dPartido";
                    break;
                case 10:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 11 order by dPartido";
                    break;
                case 11:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 12 order by dPartido";
                    break;
                case 12:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 13 order by dPartido";
                    break;
                case 13:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 14 order by dPartido";
                    break;
                case 14:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 15 order by dPartido";
                    break;
                case 15:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 16 order by dPartido";
                    break;
                case 16:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 17 order by dPartido";
                    break;
                case 17:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 18 order by dPartido";
                    break;
                case 18:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 19 order by dPartido";
                    break;
                case 19:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 20 order by dPartido";
                    break;
                case 20:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 21 order by dPartido";
                    break;
                case 21:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 22 order by dPartido";
                    break;
                case 22:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 23 order by dPartido";
                    break;
                case 23:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 24 order by dPartido";
                    break;
                case 24:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 25 order by dPartido";
                    break;
                case 25:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 26 order by dPartido";
                    break;
                case 26:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 27 order by dPartido";
                    break;
                case 27:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 28 order by dPartido";
                    break;
                case 28:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 29 order by dPartido";
                    break;
                case 29:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 30 order by dPartido";
                    break;
                case 30:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 31 order by dPartido";
                    break;
                case 31:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 32 order by dPartido";
                    break;
                case 32:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 33 order by dPartido";
                    break;
                case 33:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 34 order by dPartido";
                    break;
                case 34:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 35 order by dPartido";
                    break;
                case 35:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 36 order by dPartido";
                    break;
                case 36:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 37 order by dPartido";
                    break;
                case 37:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 38 order by dPartido";
                    break;
                default:
                    consulta = "Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where nJornadaID = 1 order by dPartido";
                    break;
            }
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridDatos.ItemsSource = dt.DefaultView;
            con.Close();
        }

        //Este botón es el que nos permite editar los datos de cada partido
        //Según el partido en el que pinchemos guarda su ID
        //Y cargará los datos de ese partido para poder editarlos
        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            EditJornadas edits = new EditJornadas();
            edits.IdPartido = id;
            edits.CargarDatos();
            FrameEditJornadas.Content = edits;
        }

        private void BtnBuscar(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2, nPartidoID from TPartido where cEquipo1 LIKE '%" + tbBuscar.Text +"%' OR cEquipo2 LIKE '%" + tbBuscar.Text +"%' order by dPartido", con);
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
