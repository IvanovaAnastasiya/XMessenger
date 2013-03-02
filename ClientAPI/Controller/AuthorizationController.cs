using System;
using System.Text.RegularExpressions;
using ClientAPI.Authorization;
using ClientAPI.View;

namespace ClientAPI.Controller
{
    public sealed class AuthorizationController
    {
        private readonly ILoginView view;
        private IAuthorizationProvider provider;//Текущий провайдер для авторизации  

        public AuthorizationController(ILoginView view)
        {
            this.view = view;
        }

        /// <summary>
        /// Авторизует пользователя
        /// </summary>
        /// <returns>Результат авторизации</returns>
        public AuthorizationResult Authorize()
        {
            if (!IsEmailValid(view.GetEmail()) || view.GetLogin().Equals(string.Empty))
            {
                return AuthorizationResult.InvalidLoginOrEmail;
            }
            if (view.GetPassword().Equals(string.Empty))
            {
                return AuthorizationResult.InvalidPassword;
            }
            if (provider != null)
            {
                return provider.Authorise();
            }
            provider = new DefaultLoginProvider();
            return provider.Authorise();
        }

        public void SetProvider(Provider loginProvider)
        {
            switch (loginProvider)
            {
                case Provider.Default:
                    provider = new DefaultLoginProvider();
                    break;
                case Provider.Facebook:
                    provider = new FacebookLoginProvider();
                    break;
                case Provider.Twitter:
                    provider = new TwitterLoginProvider();
                    break;
                case Provider.VKontakte:
                    provider = new VkLoginProvider();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Invalid login provider");
            }
        }

        /// <summary>
        /// Проверяет правильность введеной почты
        /// </summary>
        /// <param name="email">Электронная почта</param>
        /// <returns>true если почтовый ящик действителен</returns>
        public bool IsEmailValid(string email)
        {
            const string emailValidationPattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            return Regex.IsMatch(email, emailValidationPattern);
        }
    }
}