using System.Configuration;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace AppLaLiga.Views
{
    /// <summary>
    /// Interaction logic for EditJornadas.xaml
    /// </summary>
    public partial class EditJornadas : Page
    {
        public EditJornadas()
        {
            InitializeComponent();
        }

        public int IdPartido;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["AppLaLiga.Properties.Settings.LaLigaConnectionString"].ConnectionString);

        //Hace la consulta con el ID del partido en el que pinchemos en editar
        //Rellena los campos de textbox con estos datos de la consulta SQL
        public void CargarDatos()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT CONVERT(VARCHAR, dPartido,103) AS 'FechaPart', cEquipo1, cResultado, cEquipo2 FROM TPartido WHERE nPartidoID = " + IdPartido.ToString(), con);
            SqlDataReader rdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            rdr.Read();
            this.tbFecha.Text = rdr["FechaPart"].ToString();
            this.tbEquipo1.Text = rdr["cEquipo1"].ToString();
            this.tbEquipo2.Text = rdr["cEquipo2"].ToString();
            this.tbResultado.Text = rdr["cResultado"].ToString();
            rdr.Close();
            con.Close();
        }

        private void BtnActualizar_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            //Si algún campo de datos esta vacío saltará un mensaje indicándolo
            if (tbFecha.Text == "" || tbEquipo1.Text == "" || tbEquipo2.Text == "" || tbResultado.Text == "")
            {
                MessageBox.Show("No puedes dejar datos del partido vacíos");
            }
            //Si están todos los campos completados entonces realizará el UPDATE
            else
            {
                SqlCommand com = new SqlCommand("UPDATE TPartido SET dPartido = '" + tbFecha.Text + "', cResultado = '" + tbResultado.Text + "' WHERE nPartidoID = " + IdPartido.ToString(), con);
                com.ExecuteNonQuery();
            }
            con.Close();
            //Actualiza los datos del equipo y vuelve a la clasificación actualizada
            Content = new Calendario();
        }

        private void BtnRegresar_Click(object sender, RoutedEventArgs e)
        {
            Content = new Calendario();
        }
    }
}
