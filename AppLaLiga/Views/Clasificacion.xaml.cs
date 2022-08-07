using AppLaLiga.Views;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Capa_Negocio;

namespace AppLaLiga.SCS
{
    /// <summary>
    /// Interaction logic for Clasificacion.xaml
    /// </summary>
    public partial class Clasificacion : UserControl
    {
        readonly CN_Equipos obj_CN_Equipos = new CN_Equipos();

        public Clasificacion()
        {
            InitializeComponent();
            CargarDatos();
        }

        //Hace la consulta a la base de datos y carga esos datos en el datagrid indicado
        void CargarDatos()
        {
            GridDatos.ItemsSource = obj_CN_Equipos.CargarRankingEquipos().DefaultView;
        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            EditClubs edits = new EditClubs();
            edits.IdClub = id;
            edits.CargarDatos();
            //Según el ID del club seleccionado se cambia la imagen con su escudo
            switch (edits.IdClub)
            {
                case 1:
                    edits.imagen.Source = new BitmapImage(new Uri("/SCS/IMG/relamadrid-logo.png", UriKind.Relative));
                    break;
                case 2:
                    edits.imagen.Source = new BitmapImage(new Uri("/SCS/IMG/barca-logo.png", UriKind.Relative));
                    break;
                case 3:
                    edits.imagen.Source = new BitmapImage(new Uri("/SCS/IMG/sevilla.png", UriKind.Relative));
                    break;
                case 4:
                    edits.imagen.Source = new BitmapImage(new Uri("/SCS/IMG/atm-logo.png", UriKind.Relative));
                    break;
                case 5:
                    edits.imagen.Source = new BitmapImage(new Uri("/SCS/IMG/betis-logo.png", UriKind.Relative));
                    break;
                case 6:
                    edits.imagen.Source = new BitmapImage(new Uri("/SCS/IMG/real-sociedad-logo.png", UriKind.Relative));
                    break;
                case 7:
                    edits.imagen.Source = new BitmapImage(new Uri("/SCS/IMG/villarreal.png", UriKind.Relative));
                    break;
                case 8:
                    edits.imagen.Source = new BitmapImage(new Uri("/SCS/IMG/Athletic-Bilbao-Logo.png", UriKind.Relative));
                    break;
                case 9:
                    edits.imagen.Source = new BitmapImage(new Uri("/SCS/IMG/osasuna-logo.png", UriKind.Relative));
                    break;
                case 10:
                    edits.imagen.Source = new BitmapImage(new Uri("/SCS/IMG/valencia.png", UriKind.Relative));
                    break;
                case 11:
                    edits.imagen.Source = new BitmapImage(new Uri("/SCS/IMG/celta-logo.png", UriKind.Relative));
                    break;
                case 12:
                    edits.imagen.Source = new BitmapImage(new Uri("/SCS/IMG/espanyol-logo.png", UriKind.Relative));
                    break;
                case 13:
                    edits.imagen.Source = new BitmapImage(new Uri("/SCS/IMG/elche-logo.png", UriKind.Relative));
                    break;
                case 14:
                    edits.imagen.Source = new BitmapImage(new Uri("/SCS/IMG/rayo-logo.png", UriKind.Relative));
                    break;
                case 15:
                    edits.imagen.Source = new BitmapImage(new Uri("/SCS/IMG/getafe-logo.png", UriKind.Relative));
                    break;
                case 16:
                    edits.imagen.Source = new BitmapImage(new Uri("/SCS/IMG/mallorca-logo.png", UriKind.Relative));
                    break;
                case 17:
                    edits.imagen.Source = new BitmapImage(new Uri("/SCS/IMG/cadiz-logo.png", UriKind.Relative));
                    break;
                case 18:
                    edits.imagen.Source = new BitmapImage(new Uri("/SCS/IMG/granada-logo.png", UriKind.Relative));
                    break;
                case 19:
                    edits.imagen.Source = new BitmapImage(new Uri("/SCS/IMG/levante-logo.png", UriKind.Relative));
                    break;
                case 20:
                    edits.imagen.Source = new BitmapImage(new Uri("/SCS/IMG/logo-alaves.png", UriKind.Relative));
                    break;

                default:
                    break;
            }
            FrameEditClubs.Content = edits;
        }
    }
}
