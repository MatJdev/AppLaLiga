using System.Configuration;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using Capa_Entidad;
using Capa_Negocio;

namespace AppLaLiga.Views
{
    /// <summary>
    /// Interaction logic for MiCuenta.xaml
    /// </summary>
    public partial class MiCuenta : UserControl
    {
        readonly CN_Usuarios obj_CN_Usuarios = new CN_Usuarios();
        readonly CE_Usuarios obj_CE_Usuarios = new CE_Usuarios();

        public MiCuenta()
        {
            InitializeComponent();
            
        }

        public string nom;
        public string pass;

        //Hace la consulta SQL con los datos del usuario que ha iniciado sesión
        //Y los muestra en los textBox para poder editarlos
        public void CargarDatos()
        {
            var u = obj_CN_Usuarios.Consulta(nom, pass);
            tbNombre.Text = u.CNombre.ToString();
            tbPass.Text = u.CPass.ToString();
            tbEmail.Text = u.CEmail.ToString();
            tbDni.Text = u.CNIFID.ToString();
        }
        private void BtnActualizar_Click(object sender, RoutedEventArgs e)
        {
            //con.Open();
            //Si algún campo de datos esta vacío saltará un mensaje indicándolo
            if (tbNombre.Text == "" || tbPass.Text == "" || tbEmail.Text == "" || tbDni.Text == "")
            {
                MessageBox.Show("No puedes dejar datos de usuario vacíos");
            }
            //Si están todos los campos completados entonces realizará el UPDATE
            else
            {
                obj_CE_Usuarios.CNombre = tbNombre.Text;
                obj_CE_Usuarios.CPass = tbPass.Text;
                obj_CE_Usuarios.CEmail = tbEmail.Text;
                obj_CE_Usuarios.CNIFID = tbDni.Text;

                obj_CN_Usuarios.ActualizarDatos(obj_CE_Usuarios);
            }
            //con.Close();
            //Actualiza los datos del equipo y vuelve a la clasificación actualizada
            MessageBox.Show("Datos Actualizados!");
        }

    }
}
