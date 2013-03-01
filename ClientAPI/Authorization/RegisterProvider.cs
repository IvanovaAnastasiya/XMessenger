namespace ClientAPI.Authorization
{
    /// <summary>
    /// Представляет методы для регистрации пользователя
    /// </summary>
    public sealed class RegisterProvider:IAuthorizationProvider
    {
        public AuthorizationResult Authorise()
        {
            //1.Send auth request to server
            //2.On server: if login is free then create and authorise new user
            //2.Convert result to AuthorizationResult
            //3.Return result
            return AuthorizationResult.Success;
        }
    }
}