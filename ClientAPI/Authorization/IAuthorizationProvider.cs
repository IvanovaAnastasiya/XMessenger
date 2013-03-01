namespace ClientAPI.Authorization
{
    public interface IAuthorizationProvider
    {
        AuthorizationResult Authorise();
    }
}