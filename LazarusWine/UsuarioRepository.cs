using MySql.Data.MySqlClient;
using BCrypt.Net; 

public class UsuarioRepository
{
	private readonly string connectionString;

	public UsuarioRepository(string connectionString)
	{
		this.connectionString = connectionString;
	}

	public bool IniciarSesion(string username, string password)
	{
		const string query = "SELECT password FROM users WHERE username = @username";

		using (MySqlConnection connection = new MySqlConnection(connectionString))
		{
			connection.Open();
			using (MySqlCommand command = new MySqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@username", username);
				string storedPasswordHash = (string)command.ExecuteScalar();
				return storedPasswordHash != null && BCrypt.Net.BCrypt.Verify(password, storedPasswordHash);
			}
		}
	}

	public bool RegistrarUsuario(string username, string password)
	{
		const string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username";

		using (MySqlConnection connection = new MySqlConnection(connectionString))
		{
			connection.Open();

			using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
			{
				checkCommand.Parameters.AddWithValue("@username", username);
				int userCount = Convert.ToInt32(checkCommand.ExecuteScalar());

				if (userCount > 0)
				{
					return false; 
				}
			}

			string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

			const string insertQuery = "INSERT INTO users (username, password) VALUES (@username, @password)";
			using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
			{
				insertCommand.Parameters.AddWithValue("@username", username);
				insertCommand.Parameters.AddWithValue("@password", passwordHash);

				insertCommand.ExecuteNonQuery();
				return true;
			}
		}
	}
}
