namespace ClientAPI.Authorization
{
    public enum AuthorizationResult
    {
        InvalidLoginOrEmail,
        InvalidPassword,
        ConnectionFailed,
        Success,
    }
}