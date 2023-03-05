namespace ApiTokenDemo;

public interface IJwtTokenManager
{
	string Authenticate(string username, string password);
}
