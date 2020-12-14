using GangOfFour.Patterns.Creational.Singleton.Singleton;
using GangOfFour.Patterns.Creational.Singleton.Stuff;
using Shouldly;
using Xunit;

namespace GangOfFour.Patterns.Creational.Singleton.Client
{
    public class Application
    {
        [Fact]
        public void ExampleSingletonPattern()
        {
            var fakeHttpClient = new FakeHttpClient();

            var singletonA = AccessTokenSingleton.GetInstanceNonThreadSafe();
            singletonA.HttpClient = fakeHttpClient;
            singletonA.Login("some@email.com", "somepassword");

            var singletonB = AccessTokenSingleton.GetInstanceNonThreadSafe();
            singletonB.HttpClient = fakeHttpClient;
            singletonB.Login("some@email.com", "somepassword");

            singletonA.ShouldBeSameAs(singletonB);
            singletonA.Token.ShouldBeSameAs(singletonB.Token);
        }
    }
}
