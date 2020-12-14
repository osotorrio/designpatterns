using GangOfFour.Patterns.Creational.Singleton.Stuff;
using System;

namespace GangOfFour.Patterns.Creational.Singleton.Singleton
{
    public class AccessTokenSingleton
    {
        private static AccessTokenSingleton _instance;

        private static readonly object _lock = new object();

        private AccessTokenSingleton() { }

        public IHttpClient HttpClient { get; set; }

        public string Token { get; private set; }

        public void Login(string userEmail, string userPassword)
        {
            if (string.IsNullOrEmpty(Token))
            {
                Token = HttpClient.GetAsString(new Uri("https://api/access/token"), new
                {
                    email = userEmail,
                    password = userPassword
                });
            }
        }

        public static AccessTokenSingleton GetInstanceNonThreadSafe()
        {
            if (_instance == null)
            {
                _instance = new AccessTokenSingleton();
            }

            return _instance;
        }

        public static AccessTokenSingleton GetInstanceThreadSafe()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new AccessTokenSingleton();
                    }
                }
            }

            return _instance;
        }
    }
}
