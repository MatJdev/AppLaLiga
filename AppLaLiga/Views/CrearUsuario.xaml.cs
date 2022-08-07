using System.Configuration;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using Capa_Entidad;
using Capa_Negocio;
using System.Net.Mail;
using System.Net;

namespace AppLaLiga.Views
{
    /// <summary>
    /// Interaction logic for CrearUsuario.xaml
    /// </summary>
    public partial class CrearUsuario : Window
    {
        readonly CN_Usuarios obj_CN_Usuarios = new CN_Usuarios();
        readonly CE_Usuarios obj_CE_Usuarios = new CE_Usuarios();

        public CrearUsuario()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["AppLaLiga.Properties.Settings.LaLigaConnectionString"].ConnectionString);

        private void Btn_Cancelar(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void Btn_Exit(object sender, ContextMenuEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void Btn_Registrar(object sender, RoutedEventArgs e)
        {
            con.Open();
            //Si algún campo de datos esta vacío saltará un mensaje indicándolo
            if (nombreU.Text == "" || passU.Text == "" || emailU.Text == "" || dniU.Text == "")
            {
                MessageBox.Show("No puedes dejar datos de registro vacíos");
            }
            //Si están todos los campos completados entonces comprobará si el nombre de usuario
            //O el correo están ya registrados en la base de datos
            //Si no están ya en la base de datos realizará el INSERT
            else
            {
                using (SqlCommand cmd = new SqlCommand("SELECT cNombre, cEmail FROM TUsuario WHERE cNombre = '" + nombreU.Text + "' OR cEmail = '" + emailU.Text + "'", con))
                {
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        MessageBox.Show("Este Nombre de Usuario o Correo ya están registrados en nuestra base de datos.");

                    }
                    else
                    {
                        obj_CE_Usuarios.CNIFID = dniU.Text;
                        obj_CE_Usuarios.CNombre = nombreU.Text;
                        obj_CE_Usuarios.CPass = passU.Text;
                        obj_CE_Usuarios.CEmail = emailU.Text;

                        obj_CN_Usuarios.Insertar(obj_CE_Usuarios);

                        MessageBox.Show("Te has registrado con éxito! Ya puedes iniciar sesión.");
                        //Guarda el nuevo usuario y vuelve a la pantalla de login
                        MainWindow mw = new MainWindow();
                        mw.Show();
                        this.Close();

                        # region mail
                        try
                        {
                            using (MailMessage mailMessage = new MailMessage())
                            {
                                //destinatario
                                mailMessage.To.Add(emailU.Text);

                                //asunto
                                mailMessage.Subject = "Bienvenido a LaLiga";

                                //body
                                mailMessage.Body = "Te has registrado con éxito en nuestra app de LaLiga";
                                mailMessage.IsBodyHtml = false;

                                //remitente
                                mailMessage.From = new MailAddress("email@gmail.com", "LaLiga");

                                using (SmtpClient cliente = new SmtpClient())
                                {
                                    //contrasenas
                                    cliente.UseDefaultCredentials = false;
                                    cliente.Credentials = new NetworkCredential("email@gmail.com", "password");
                                    cliente.Port = 587;
                                    cliente.EnableSsl = true;

                                    //host
                                    cliente.Host = "smtp.gmail.com";
                                    cliente.Send(mailMessage);
                                }
                            }
                        }
                        catch (System.Exception)
                        {

                            throw;
                        }
                        
                        #endregion
                    }
                }
                
            }
            con.Close();
            
            
        }
    }
}
