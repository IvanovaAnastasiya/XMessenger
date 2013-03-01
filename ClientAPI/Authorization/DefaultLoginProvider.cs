namespace ClientAPI.Authorization
{
    /// <summary>
    /// Представляет методы для авторизации по умолчанию
    /// </summary>
    public sealed class DefaultLoginProvider:IAuthorizationProvider
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