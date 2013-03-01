namespace ClientAPI.Authorization
{
    public class DefaultLoginProvider:IAuthorizationProvider
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