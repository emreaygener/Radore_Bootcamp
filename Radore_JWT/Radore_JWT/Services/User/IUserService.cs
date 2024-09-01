namespace Radore_JWT.Services.User
{
    public interface IUserService
    {
        (string username, string token)? Authenticate(string username, string password);
    }
}
