public class InicioDeSesion
{
	private readonly UsuarioRepository usuarioRepository;

	public InicioDeSesion(string connectionString)
	{
		usuarioRepository = new UsuarioRepository(connectionString);
	}

	public bool IniciarSesion(string username, string password)
	{
		if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
		{
			throw new ArgumentException("Usuario o contraseña no pueden estar vacíos");
		}

		return usuarioRepository.ValidarCredenciales(username, password);
	}

	public bool RegistrarUsuario(string username, string password)
	{
		if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
		{
			throw new ArgumentException("Usuario o contraseña no pueden estar vacíos");
		}

		bool registroExitoso = usuarioRepository.RegistrarUsuario(username, password);

		if (!registroExitoso)
		{
			throw new Exception("El nombre de usuario ya está en uso");
		}

		return true;
	}
}