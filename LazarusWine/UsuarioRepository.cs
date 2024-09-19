using MySql.Data.MySqlClient;
using BCrypt.Net;
using System.Drawing.Text;

public class UsuarioRepository
{
	private string connectionString;

	public UsuarioRepository(string connectionString) 
	{
		this.connectionString = connectionString;
	}

	public bool IniciarSesion(string username, string password)
	{
		const string checkQuery = "SELECT password FROM users WHERE username = @username";

		using (MySqlConnection connection = new MySqlConnection(connectionString))
		{
			connection.Open();

			using (MySqlCommand command = new MySqlCommand(checkQuery, connection))
			{
				command.Parameters.AddWithValue("@username", username);
				string hashedPassword = (string)command.ExecuteScalar();

				if (hashedPassword != null)
				{
					return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
				}
				else return false;
			}
		}
	}
	
}
