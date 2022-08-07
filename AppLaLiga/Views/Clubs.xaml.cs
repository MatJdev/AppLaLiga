using System;
using System.Collections.Generic;
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
    /// Interaction logic for Clubs.xaml
    /// </summary>
    public partial class Clubs : UserControl
    {
        public Clubs()
        {
            InitializeComponent();
        }

        private void BtnAthletic_Click(object sender, RoutedEventArgs e)
        {
            //Crea nuevo UserControl de EquipoInfo
            EquipoInfo athletic = new EquipoInfo();
            //Indicamos el ID de este club, para usarlo en la consulta SQL
            athletic.idClub = 8;
            //LLamamos los 2 metodos de carga de datos
            athletic.CargarDatos();
            athletic.CargarJugadores();
            FrameClubs.Content = athletic;
            //Cambia valores de color del background, imagen del escudo y tamaño
            athletic.backgroundClub.Background = Brushes.IndianRed;
            athletic.backgroundData.Background = Brushes.IndianRed;
            athletic.backgroundText.Background = Brushes.IndianRed;
            athletic.Escudo.Source = new BitmapImage(new Uri("/SCS/IMG/Athletic-Bilbao-Logo.png", UriKind.Relative));
            athletic.Escudo.Height = 300;
            athletic.Escudo.Width = 300;
        }

        private void BtnAtm_Click(object sender, RoutedEventArgs e)
        {
            EquipoInfo atm = new EquipoInfo();
            atm.idClub = 4;
            atm.CargarDatos();
            atm.CargarJugadores();
            FrameClubs.Content = atm;
            atm.backgroundClub.Background = Brushes.DarkRed;
            atm.backgroundData.Background = Brushes.DarkRed;
            atm.backgroundText.Background = Brushes.DarkRed;
            atm.Escudo.Source = new BitmapImage(new Uri("/SCS/IMG/atm-logo.png", UriKind.Relative));
            atm.EstadioFoto.Source = new BitmapImage(new Uri("/SCS/IMG/atm-est.png", UriKind.Relative));
            atm.Escudo.Height = 170;
            atm.Escudo.Width = 170;
        }

        private void BtnCadiz_Click(object sender, RoutedEventArgs e)
        {
            EquipoInfo cadiz = new EquipoInfo();
            cadiz.idClub = 17;
            cadiz.CargarDatos();
            cadiz.CargarJugadores();
            FrameClubs.Content = cadiz;
            cadiz.backgroundClub.Background = Brushes.Yellow;
            cadiz.backgroundData.Background = Brushes.Yellow;
            cadiz.backgroundText.Background = Brushes.Yellow;
            cadiz.Escudo.Source = new BitmapImage(new Uri("/SCS/IMG/cadiz-logo.png", UriKind.Relative));
            cadiz.EstadioFoto.Source = new BitmapImage(new Uri("/SCS/IMG/cadiz-est.png", UriKind.Relative));
            cadiz.Escudo.Height = 250;
            cadiz.Escudo.Width = 250;
            cadiz.Escudo.Margin = new Thickness(1);
        }

        private void BtnOsasuna_Click(object sender, RoutedEventArgs e)
        {
            EquipoInfo info = new EquipoInfo();
            info.idClub = 9;
            info.CargarDatos();
            info.CargarJugadores();
            FrameClubs.Content = info;
            info.backgroundClub.Background = Brushes.DarkSlateBlue;
            info.backgroundData.Background = Brushes.DarkSlateBlue;
            info.backgroundText.Background = Brushes.DarkSlateBlue;
            info.Escudo.Source = new BitmapImage(new Uri("/SCS/IMG/osasuna-logo.png", UriKind.Relative));
            info.EstadioFoto.Source = new BitmapImage(new Uri("/SCS/IMG/osasuna-est.png", UriKind.Relative));
            info.Escudo.Height = 200;
            info.Escudo.Width = 200;
            info.Escudo.Margin = new Thickness(20);
        }

        private void BtnAlaves_Click(object sender, RoutedEventArgs e)
        {
            EquipoInfo info = new EquipoInfo();
            info.idClub = 20;
            info.CargarDatos();
            info.CargarJugadores();
            FrameClubs.Content = info;
            info.backgroundClub.Background = Brushes.DeepSkyBlue;
            info.backgroundData.Background = Brushes.DeepSkyBlue;
            info.backgroundText.Background = Brushes.DeepSkyBlue;
            info.Escudo.Source = new BitmapImage(new Uri("/SCS/IMG/logo-alaves.png", UriKind.Relative));
            info.EstadioFoto.Source = new BitmapImage(new Uri("/SCS/IMG/alaves-est.png", UriKind.Relative));
            info.Escudo.Height = 200;
            info.Escudo.Width = 200;
            info.Escudo.Margin = new Thickness(20);
        }

        private void BtnElche_Click(object sender, RoutedEventArgs e)
        {
            EquipoInfo info = new EquipoInfo();
            info.idClub = 13;
            info.CargarDatos();
            info.CargarJugadores();
            FrameClubs.Content = info;
            info.backgroundClub.Background = Brushes.LightGreen;
            info.backgroundData.Background = Brushes.LightGreen;
            info.backgroundText.Background = Brushes.LightGreen;
            info.Escudo.Source = new BitmapImage(new Uri("/SCS/IMG/elche-logo.png", UriKind.Relative));
            info.EstadioFoto.Source = new BitmapImage(new Uri("/SCS/IMG/elche-est.png", UriKind.Relative));
            info.Escudo.Height = 200;
            info.Escudo.Width = 200;
            info.Escudo.Margin = new Thickness(20);
        }

        private void BtnBarcelona_Click(object sender, RoutedEventArgs e)
        {
            EquipoInfo info = new EquipoInfo();
            info.idClub = 2;
            info.CargarDatos();
            info.CargarJugadores();
            FrameClubs.Content = info;
            info.backgroundClub.Background = Brushes.PaleVioletRed;
            info.backgroundData.Background = Brushes.PaleVioletRed;
            info.backgroundText.Background = Brushes.PaleVioletRed;
            info.Escudo.Source = new BitmapImage(new Uri("/SCS/IMG/barca-logo.png", UriKind.Relative));
            info.EstadioFoto.Source = new BitmapImage(new Uri("/SCS/IMG/barca-est.png", UriKind.Relative));
            info.Escudo.Height = 330;
            info.Escudo.Width = 330;
            info.Escudo.Margin = new Thickness(20);
        }

        private void BtnGetafe_Click(object sender, RoutedEventArgs e)
        {
            EquipoInfo info = new EquipoInfo();
            info.idClub = 15;
            info.CargarDatos();
            info.CargarJugadores();
            FrameClubs.Content = info;
            info.backgroundClub.Background = Brushes.CadetBlue;
            info.backgroundData.Background = Brushes.CadetBlue;
            info.backgroundText.Background = Brushes.CadetBlue;
            info.Escudo.Source = new BitmapImage(new Uri("/SCS/IMG/getafe-logo.png", UriKind.Relative));
            info.EstadioFoto.Source = new BitmapImage(new Uri("/SCS/IMG/geta-est.png", UriKind.Relative));
            info.Escudo.Height = 250;
            info.Escudo.Width = 250;
            info.Escudo.Margin = new Thickness(1);
        }

        private void BtnGranada_Click(object sender, RoutedEventArgs e)
        {
            EquipoInfo info = new EquipoInfo();
            info.idClub = 18;
            info.CargarDatos();
            info.CargarJugadores();
            FrameClubs.Content = info;
            info.backgroundClub.Background = Brushes.WhiteSmoke;
            info.backgroundData.Background = Brushes.WhiteSmoke;
            info.backgroundText.Background = Brushes.WhiteSmoke;
            info.Escudo.Source = new BitmapImage(new Uri("/SCS/IMG/granada-logo.png", UriKind.Relative));
            info.EstadioFoto.Source = new BitmapImage(new Uri("/SCS/IMG/granada-est.png", UriKind.Relative));
            info.Escudo.Height = 230;
            info.Escudo.Width = 230;
            info.Escudo.Margin = new Thickness(1);
        }

        private void BtnLevante_Click(object sender, RoutedEventArgs e)
        {
            EquipoInfo info = new EquipoInfo();
            info.idClub = 19;
            info.CargarDatos();
            info.CargarJugadores();
            FrameClubs.Content = info;
            info.backgroundClub.Background = Brushes.DarkViolet;
            info.backgroundData.Background = Brushes.DarkViolet;
            info.backgroundText.Background = Brushes.DarkViolet;
            info.Escudo.Source = new BitmapImage(new Uri("/SCS/IMG/levante-logo.png", UriKind.Relative));
            info.EstadioFoto.Source = new BitmapImage(new Uri("/SCS/IMG/levante-est.png", UriKind.Relative));
            info.Escudo.Height = 230;
            info.Escudo.Width = 230;
            info.Escudo.Margin = new Thickness(1);
        }

        private void BtnRayo_Click(object sender, RoutedEventArgs e)
        {
            EquipoInfo info = new EquipoInfo();
            info.idClub = 14;
            info.CargarDatos();
            info.CargarJugadores();
            FrameClubs.Content = info;
            info.backgroundClub.Background = Brushes.WhiteSmoke;
            info.backgroundData.Background = Brushes.WhiteSmoke;
            info.backgroundText.Background = Brushes.WhiteSmoke;
            info.Escudo.Source = new BitmapImage(new Uri("/SCS/IMG/rayo-logo.png", UriKind.Relative));
            info.EstadioFoto.Source = new BitmapImage(new Uri("/SCS/IMG/rayo-est.png", UriKind.Relative));
            info.Escudo.Height = 230;
            info.Escudo.Width = 230;
            info.Escudo.Margin = new Thickness(1);
        }

        private void BtnCelta_Click(object sender, RoutedEventArgs e)
        {
            EquipoInfo info = new EquipoInfo();
            info.idClub = 11;
            info.CargarDatos();
            info.CargarJugadores();
            FrameClubs.Content = info;
            info.backgroundClub.Background = Brushes.AliceBlue;
            info.backgroundData.Background = Brushes.AliceBlue;
            info.backgroundText.Background = Brushes.AliceBlue;
            info.Escudo.Source = new BitmapImage(new Uri("/SCS/IMG/celta-logo.png", UriKind.Relative));
            info.EstadioFoto.Source = new BitmapImage(new Uri("/SCS/IMG/celta-est.png", UriKind.Relative));
            info.Escudo.Height = 230;
            info.Escudo.Width = 230;
            info.Escudo.Margin = new Thickness(1);
        }

        private void BtnEspanyol_Click(object sender, RoutedEventArgs e)
        {
            EquipoInfo info = new EquipoInfo();
            info.idClub = 12;
            info.CargarDatos();
            info.CargarJugadores();
            FrameClubs.Content = info;
            info.backgroundClub.Background = Brushes.CornflowerBlue;
            info.backgroundData.Background = Brushes.CornflowerBlue;
            info.backgroundText.Background = Brushes.CornflowerBlue;
            info.Escudo.Source = new BitmapImage(new Uri("/SCS/IMG/espanyol-logo.png", UriKind.Relative));
            info.EstadioFoto.Source = new BitmapImage(new Uri("/SCS/IMG/espanyol-est.png", UriKind.Relative));
            info.Escudo.Height = 230;
            info.Escudo.Width = 230;
            info.Escudo.Margin = new Thickness(1);
        }

        private void BtnMallorca_Click(object sender, RoutedEventArgs e)
        {
            EquipoInfo info = new EquipoInfo();
            info.idClub = 16;
            info.CargarDatos();
            info.CargarJugadores();
            FrameClubs.Content = info;
            info.backgroundClub.Background = Brushes.Red;
            info.backgroundData.Background = Brushes.Red;
            info.backgroundText.Background = Brushes.Red;
            info.Escudo.Source = new BitmapImage(new Uri("/SCS/IMG/mallorca-logo.png", UriKind.Relative));
            info.EstadioFoto.Source = new BitmapImage(new Uri("/SCS/IMG/mallorca-est.png", UriKind.Relative));
            info.Escudo.Height = 230;
            info.Escudo.Width = 230;
            info.Escudo.Margin = new Thickness(1);
        }

        private void BtnBetis_Click(object sender, RoutedEventArgs e)
        {
            EquipoInfo info = new EquipoInfo();
            info.idClub = 5;
            info.CargarDatos();
            info.CargarJugadores();
            FrameClubs.Content = info;
            info.backgroundClub.Background = Brushes.Green;
            info.backgroundData.Background = Brushes.Green;
            info.backgroundText.Background = Brushes.Green;
            info.Escudo.Source = new BitmapImage(new Uri("/SCS/IMG/betis-logo.png", UriKind.Relative));
            info.EstadioFoto.Source = new BitmapImage(new Uri("/SCS/IMG/betis-est.png", UriKind.Relative));
            info.Escudo.Height = 230;
            info.Escudo.Width = 230;
            info.Escudo.Margin = new Thickness(1);
        }

        private void BtnRealMadrid_Click(object sender, RoutedEventArgs e)
        {
            EquipoInfo info = new EquipoInfo();
            info.idClub = 1;
            info.CargarDatos();
            info.CargarJugadores();
            FrameClubs.Content = info;
            info.backgroundClub.Background = Brushes.DodgerBlue;
            info.backgroundData.Background = Brushes.DodgerBlue;
            info.backgroundText.Background = Brushes.DodgerBlue;
            info.Escudo.Source = new BitmapImage(new Uri("/SCS/IMG/relamadrid-logo.png", UriKind.Relative));
            info.EstadioFoto.Source = new BitmapImage(new Uri("/SCS/IMG/realmadrid-est.png", UriKind.Relative));
            info.Escudo.Height = 200;
            info.Escudo.Width = 200;
            info.Escudo.Margin = new Thickness(20);
        }

        private void BtnRealSociedad_Click(object sender, RoutedEventArgs e)
        {
            EquipoInfo info = new EquipoInfo();
            info.idClub = 6;
            info.CargarDatos();
            info.CargarJugadores();
            FrameClubs.Content = info;
            info.backgroundClub.Background = Brushes.DodgerBlue;
            info.backgroundData.Background = Brushes.DodgerBlue;
            info.backgroundText.Background = Brushes.DodgerBlue;
            info.Escudo.Source = new BitmapImage(new Uri("/SCS/IMG/real-sociedad-logo.png", UriKind.Relative));
            info.EstadioFoto.Source = new BitmapImage(new Uri("/SCS/IMG/rsociedad-est.png", UriKind.Relative));
            info.Escudo.Height = 230;
            info.Escudo.Width = 230;
            info.Escudo.Margin = new Thickness(1);
        }

        private void BtnSevilla_Click(object sender, RoutedEventArgs e)
        {
            EquipoInfo info = new EquipoInfo();
            info.idClub = 3;
            info.CargarDatos();
            info.CargarJugadores();
            FrameClubs.Content = info;
            info.backgroundClub.Background = Brushes.IndianRed;
            info.backgroundData.Background = Brushes.IndianRed;
            info.backgroundText.Background = Brushes.IndianRed;
            info.Escudo.Source = new BitmapImage(new Uri("/SCS/IMG/sevilla.png", UriKind.Relative));
            info.EstadioFoto.Source = new BitmapImage(new Uri("/SCS/IMG/sevilla-est.png", UriKind.Relative));
            info.Escudo.Height = 230;
            info.Escudo.Width = 230;
            info.Escudo.Margin = new Thickness(1);
        }

        private void BtnValencia_Click(object sender, RoutedEventArgs e)
        {
            EquipoInfo info = new EquipoInfo();
            info.idClub = 10;
            info.CargarDatos();
            info.CargarJugadores();
            FrameClubs.Content = info;
            info.backgroundClub.Background = Brushes.Orange;
            info.backgroundData.Background = Brushes.Orange;
            info.backgroundText.Background = Brushes.Orange;
            info.Escudo.Source = new BitmapImage(new Uri("/SCS/IMG/valencia.png", UriKind.Relative));
            info.EstadioFoto.Source = new BitmapImage(new Uri("/SCS/IMG/valencia-est.png", UriKind.Relative));
            info.Escudo.Height = 230;
            info.Escudo.Width = 230;
            info.Escudo.Margin = new Thickness(1);
        }

        private void BtnVillareal_Click(object sender, RoutedEventArgs e)
        {
            EquipoInfo info = new EquipoInfo();
            info.idClub = 7;
            info.CargarDatos();
            info.CargarJugadores();
            FrameClubs.Content = info;
            info.backgroundClub.Background = Brushes.Yellow;
            info.backgroundData.Background = Brushes.Yellow;
            info.backgroundText.Background = Brushes.Yellow;
            info.Escudo.Source = new BitmapImage(new Uri("/SCS/IMG/villarreal.png", UriKind.Relative));
            info.EstadioFoto.Source = new BitmapImage(new Uri("/SCS/IMG/villareal-est.png", UriKind.Relative));
            info.Escudo.Height = 230;
            info.Escudo.Width = 230;
            info.Escudo.Margin = new Thickness(1);
        }
    }
}
