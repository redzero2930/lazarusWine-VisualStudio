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

		return usuarioRepository.IniciarSesion(username, password);
	}
}