using System.Windows;
using System.Windows.Controls;
using Capa_Negocio;
using Capa_Entidad;

namespace AppLaLiga.Views
{
    /// <summary>
    /// Interaction logic for GestionUsuario.xaml
    /// </summary>
    public partial class GestionUsuario : UserControl
    {
        readonly CN_Usuarios obj_CN_Usuarios = new CN_Usuarios();
        readonly CE_Usuarios obj_CE_Usuarios = new CE_Usuarios();

        public GestionUsuario()
        {
            InitializeComponent();
            CargarDatos();
        }

        //Hace la consulta SQL para mostrar todos los usuarios registrados en nuestra base de datos
        //Y lo muestra en el datagrid
        void CargarDatos()
        {
            GridDatos.ItemsSource = obj_CN_Usuarios.CargarTodosUsuarios().DefaultView;
        }


        private void Btn_Registrar(object sender, RoutedEventArgs e)
        {
            //Si algún campo de datos esta vacío saltará un mensaje indicándolo
            if (nombreU.Text == "" || passU.Text == "" || emailU.Text == "" || dniU.Text == "" || adminU.Text == "")
            {
                MessageBox.Show("No puedes dejar datos de registro vacíos");
            }
            //Si están todos los campos completados entonces realizará el INSERT
            else
            {
                obj_CE_Usuarios.CNIFID = dniU.Text;
                obj_CE_Usuarios.CNombre = nombreU.Text;
                obj_CE_Usuarios.CPass = passU.Text;
                obj_CE_Usuarios.CEmail = emailU.Text;
                obj_CE_Usuarios.LAdmin = int.Parse(adminU.Text);
                obj_CE_Usuarios.NAdmin = int.Parse(adminU.Text);

                obj_CN_Usuarios.InsertarAdmin(obj_CE_Usuarios);

                MessageBox.Show("Nuevo Usuario Registrado!");
            }
            CargarDatos();
        }
    }
}
