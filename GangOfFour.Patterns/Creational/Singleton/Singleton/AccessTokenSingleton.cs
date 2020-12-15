using GangOfFour.Patterns.Creational.Singleton.Stuff;
using System;

namespace GangOfFour.Patterns.Creational.Singleton.Singleton
{
    public class AccessTokenSingleton
    {
        private static AccessTokenSingleton _instance;

        private static IHttpClient _client;

        private static readonly object _lock = new object();

        public string Token { get; private set; }

        private AccessTokenSingleton(string email, string password)
        {
            Token = _client.Post(new Uri("https://api/access/token"), new
            {
                email,
                password
            });
        }

        public static void RegisterHttpClient(IHttpClient client)
        {
            _client = client;
        }

        public static AccessTokenSingleton GetInstanceNonThreadSafe(string email, string password)
        {
            if (_instance == null)
            {
                _instance = new AccessTokenSingleton(email, password);
            }

            return _instance;
        }

        public static AccessTokenSingleton GetInstanceThreadSafe(string email, string password)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new AccessTokenSingleton(email, password);
                    }
                }
            }

            return _instance;
        }
    }
}
