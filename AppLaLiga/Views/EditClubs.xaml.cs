using AppLaLiga.SCS;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using Capa_Negocio;
using Capa_Entidad;

namespace AppLaLiga.Views
{
    /// <summary>
    /// Interaction logic for EditClubs.xaml
    /// </summary>
    public partial class EditClubs : Page
    {
        readonly CN_Equipos obj_CN_Equipos = new CN_Equipos();
        readonly CE_Equipos obj_CE_Equipos = new CE_Equipos();

        public EditClubs()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, RoutedEventArgs e)
        {
            Content = new Clasificacion();
        }

        //Para guardar el ID del equipo que vamos a editar
        //Se le asigna el valor en la ventana de Clasificación al darle al botón de editar
        public int IdClub;

        //Hace la consulta con el ID del club en el que pinchemos en editar
        //Rellena los campos de textbox con estos datos de la consulta SQL
        public void CargarDatos()
        {
            var e = obj_CN_Equipos.Consulta(IdClub);
            tbNombre.Text = e.CNombre.ToString();
            tbPuntos.Text = e.NPuntos.ToString();
            tbPj.Text = e.NPJ.ToString();
            tbPg.Text = e.NPG.ToString();
            tbPe.Text = e.NPE.ToString();
            tbPp.Text = e.NPP.ToString();
        }

        private void BtnActualizar_Click(object sender, RoutedEventArgs e)
        {
            //con.Open();
            //Si algún campo de datos esta vacío saltará un mensaje indicándolo
            if (tbNombre.Text == "" || tbPuntos.Text == "" || tbPj.Text == "" || tbPg.Text == "" || tbPe.Text == "" || tbPp.Text == "")
            {
                MessageBox.Show("No puedes dejar datos del equipo vacíos");
            }
            //Si están todos los campos completados entonces realizará el UPDATE
            else
            {
                obj_CE_Equipos.CNombre = tbNombre.Text;
                obj_CE_Equipos.NPuntos = int.Parse(tbPuntos.Text);
                obj_CE_Equipos.NPJ = int.Parse(tbPj.Text);
                obj_CE_Equipos.NPG = int.Parse(tbPg.Text);
                obj_CE_Equipos.NPE = int.Parse(tbPe.Text);
                obj_CE_Equipos.NPP = int.Parse(tbPp.Text);
                obj_CE_Equipos.NEquipoID = IdClub;

                obj_CN_Equipos.ActualizarDatos(obj_CE_Equipos);
            }           
            //con.Close();
            //Actualiza los datos del equipo y vuelve a la clasificación actualizada
            Content = new Clasificacion();
        }
    }
}
