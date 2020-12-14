using System;
using System.Text;

namespace GangOfFour.Patterns.Creational.Singleton.Stuff
{
    public interface IHttpClient
    {
        string GetAsString(Uri url, dynamic body);
    }

    public class FakeHttpClient : IHttpClient
    {
        public string GetAsString(Uri url, dynamic body)
        {
            var random = new Random();
            var prefix = random.Next(1000, 10000);
            return Convert.ToBase64String(Encoding.UTF8.GetBytes($"{prefix}{url}{body.email}{body.password}"));
        }
    }
}
