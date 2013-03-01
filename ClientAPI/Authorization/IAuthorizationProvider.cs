namespace ClientAPI.Authorization
{
    /// <summary>
    /// Представляет класс реализующий логику авторизации 
    /// </summary>
    public interface IAuthorizationProvider
    {
        /// <summary>
        /// Авторизует пользователя
        /// </summary>
        /// <returns>Результат авторизации</returns>
        AuthorizationResult Authorise();
    }
}