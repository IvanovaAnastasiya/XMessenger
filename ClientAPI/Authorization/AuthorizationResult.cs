namespace ClientAPI.Authorization
{
    /// <summary>
    /// Результат авторизации
    /// </summary>
    public enum AuthorizationResult
    {
        InvalidLoginOrEmail, //неправильный логин или почта
        InvalidPassword,     //неправиьный пароль
        ConnectionFailed,    //проблема подключения
        Success,             //успешная авторизация
    }
}