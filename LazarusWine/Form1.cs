using MySql.Data.MySqlClient;
using System.DirectoryServices;
using System.Drawing.Text;
using System.Web;

namespace LazarusWine
{
	public partial class Login : Form
	{
		private const string connectionString = "Server=localhost;Database=login_demo;Uid=root;Pwd=greenday99";

		public Login()
		{
			InitializeComponent();
		}

		private void buttonIniciarSesion_Click(object sender, EventArgs e)
		{
			try
			{
				InicioDeSesion inicioDeSesion = new InicioDeSesion(connectionString);

				string username = textBoxUsuario.Text;
				string password = textBoxContraseña.Text;

				bool loginExitoso = inicioDeSesion.IniciarSesion(username, password);

				if (loginExitoso)
				{
					MessageBox.Show("Has iniciado sesión exitosamente :)");
				}
				else
				{
					MessageBox.Show("Nombre o contraseña incorrectos");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al iniciar sesión: " + ex.Message);
			}
		}
	}
}
