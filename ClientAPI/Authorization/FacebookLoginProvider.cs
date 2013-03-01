namespace ClientAPI.Authorization
{
    /// <summary>
    /// Представляет методы для авторизации через Facebook
    /// </summary>
    public sealed class FacebookLoginProvider:IAuthorizationProvider
    {
        public AuthorizationResult Authorise()
        {
            //1.Send auth request to server
            //2.Convert result to AuthorizationResult
            //3.Return result
            return AuthorizationResult.Success;
        }
    }
}