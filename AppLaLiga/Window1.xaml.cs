using AppLaLiga.SCS;
using AppLaLiga.Views;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AppLaLiga
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        //Cambia la opacidad del fondo cuando abrimos o cerramos la barra lateral
        private void TBShow(object sender, RoutedEventArgs e)
        {
            GridContent.Opacity = 0.5;
        }

        private void TBHide(object sender, RoutedEventArgs e)
        {
            GridContent.Opacity = 1;
        }

        //Variable para guardar el valor de si es Administrador o no el usuario que inicia sesión
        public int isAdmin;

        private void BtnClasificacion_Click(object sender, RoutedEventArgs e)
        {
            Clasificacion clasi = new Clasificacion();
            //Si el valor guardado en la variable isAdmin es 0 significa que el usuario no es Administrador, entonces quitamos los botones de editar de la app
            if (isAdmin == 0)
            {
                clasi.Admin.Visibility = Visibility.Hidden;
            }             
            DataContext = clasi;
        }

        private void BtnCalendario_Click(object sender, RoutedEventArgs e)
        {
            Calendario calendario = new Calendario();
            //Si el valor guardado en la variable isAdmin es 0 significa que el usuario no es Administrador, entonces quitamos los botones de editar de la app
            if (isAdmin == 0)
            {
                calendario.Admin.Visibility = Visibility.Hidden;
            }
            DataContext = calendario;
        }

        private void BtnClubs_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Clubs();
        }

        private void BtnCerrar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void BtnUsers_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new GestionUsuario();
        }

        public string nom;
        public string pass;

        private void BtnMiCuenta_Click(object sender, RoutedEventArgs e)
        {
            MiCuenta cuenta = new MiCuenta();
            cuenta.nom = nom;
            cuenta.pass = pass;
            cuenta.CargarDatos();
            DataContext = cuenta;
        }

        private void PreviewMouseLeftButtonDownBG(object sender, MouseButtonEventArgs e)
        {
            BtnShowHide.IsChecked = false;
        }

        private void BtnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        //Metodo para cambiar tamaño de la ventana
        //Podremos hacer doble click en la barra superior o moverla hacia arriba
        //Para maximizar y minimizar la app
        private void Mover(Border header)
        {
            var restaurar = false;

            header.MouseLeftButtonDown += (s, e) =>
            {
                if (e.ClickCount == 2)
                {
                    if ((ResizeMode == ResizeMode.CanResize) || (ResizeMode == ResizeMode.CanResizeWithGrip))
                    {
                        CambiarEstado();
                    }
                }
                else
                {
                    if (WindowState == WindowState.Maximized)
                    {
                        restaurar = true;
                    }
                    DragMove();
                }
            };

            header.MouseLeftButtonUp += (s, e) =>
            {
                restaurar = false;
            };

            header.MouseMove += (s, e) =>
            {
                if (restaurar)
                {
                    try
                    {
                        restaurar = false;
                        var mouseX = e.GetPosition(this).X;
                        var width = RestoreBounds.Width;
                        var x = mouseX - width / 2;

                        if (x<0)
                        {
                            x = 0;
                        }
                        else if (x+width > SystemParameters.PrimaryScreenWidth)
                        {
                            x = SystemParameters.PrimaryScreenWidth - width;
                        }

                        WindowState = WindowState.Normal;
                        Left = x;
                        Top = 0;
                        DragMove();
                    }
                    catch (System.Exception)
                    {

                        throw;
                    }
                }
            };
        }

        private void CambiarEstado()
        {
            switch (WindowState)
            {
                case WindowState.Normal:
                    {
                        WindowState = WindowState.Maximized;
                        break;
                    }                   
                case WindowState.Maximized:
                    {
                        WindowState = WindowState.Normal;
                        break;
                    }
            }
        }

        private void RestaurarVentana(object sender, RoutedEventArgs e)
        {
            Mover(sender as Border);
        }
    }
}
