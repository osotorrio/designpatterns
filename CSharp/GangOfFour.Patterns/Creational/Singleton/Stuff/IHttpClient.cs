using System;
using System.Text;

namespace GangOfFour.Patterns.Creational.Singleton.Stuff
{
    public interface IHttpClient
    {
        string Post(Uri url, dynamic body);
    }

    public class FakeHttpClient : IHttpClient
    {
        public string Post(Uri url, dynamic body)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes($"{url.AbsoluteUri}{body.email}{body.password}"));
        }
    }
}
