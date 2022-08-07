using System;
using System.Windows;
using System.Windows.Input;
using MaterialDesignThemes.Wpf;
using System.Configuration;
using AppLaLiga.Views;
using System.Data.SqlClient;

namespace AppLaLiga
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //string miConexion = ConfigurationManager.ConnectionStrings["AppLaLiga.Properties.Settings.LaLigaConnectionString"].ConnectionString;
        }

        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();

        private void toggleTheme(object sender, RoutedEventArgs e)
        {
            //Obtención del tema que va a utilizar
            ITheme theme = paletteHelper.GetTheme();

            //Activa y desactiva el modo oscuro
            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
            }

            //Para aplicar los cambios uso la función SetTheme
            paletteHelper.SetTheme(theme);
        }

        private void exitApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {

        }

        private void doLogin(object sender, RoutedEventArgs e)
        {
            logins();
        }

        private string miConexion = ConfigurationManager.ConnectionStrings["AppLaLiga.Properties.Settings.LaLigaConnectionString"].ConnectionString;
        //Atributos para pasar información del usuario de una ventana a otra
        public int admin;
        public string nom;
        public string pass;

        public void logins()
        {
            try
            {
                using(SqlConnection conexion = new SqlConnection(miConexion))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT cNombre, cPass, nAdmin FROM TUsuario WHERE cNombre = '" + txtUsername.Text + "' AND cPass = '" + txtPassword.Password.ToString() + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            //Guarda en la variable admin el valor de la columna nAdmin de la consulta realizada para saber si el usuario
                            //que inicia sesión es un Administrador o no
                            admin = (int)dr["nAdmin"];
                            nom = txtUsername.Text;
                            pass = txtPassword.Password.ToString();
                            Window1 w1 = new Window1();
                            //Le asigna a la variable admin de la segunda pantalla el valor guardado anteriormente de la consulta SQL
                            w1.isAdmin = admin;
                            w1.nom = nom;
                            w1.pass = pass;
                            //Ocultar boton de gestion de usuarios si el usuario no es Admin
                            if (admin == 0)
                            {
                                w1.LvUsers.Visibility = Visibility.Hidden;
                            }
                            w1.DataContext = new Clubs();
                            w1.Show();
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Nombre de Usuario o Contraseña incorrectos");
                        }
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void crearCuenta(object sender, RoutedEventArgs e)
        {
            CrearUsuario usuarioNuevo = new CrearUsuario();
            usuarioNuevo.Show();
            this.Close();
        }
    }
}
