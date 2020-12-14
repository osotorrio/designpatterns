using GangOfFour.Patterns.Creational.Singleton.Singleton;
using GangOfFour.Patterns.Creational.Singleton.Stuff;
using Shouldly;
using Xunit;

namespace GangOfFour.Patterns.Creational.Singleton.Client
{
    public class Application
    {
        private const string _expectedToken = "aHR0cHM6Ly9hcGkvYWNjZXNzL3Rva2Vuc29tZUBlbWFpbC5jb21zb21lcGFzc3dvcmQ=";

        /// <summary>
        /// XUnit runs always this test first.
        /// </summary>
        [Fact]
        public void ExampleSingletonPatternOne()
        {
            AccessTokenSingleton.RegisterHttpClient(new FakeHttpClient());
            var singleton = AccessTokenSingleton.GetInstanceThreadSafe("some@email.com", "somepassword");
            singleton.Token.ShouldBe(_expectedToken);
        }

        /// <summary>
        /// XUnit runs always this test second.
        /// </summary>
        [Fact]
        public void ExampleSingletonPatternTwo()
        {
            AccessTokenSingleton.RegisterHttpClient(new FakeHttpClient());
            var singleton = AccessTokenSingleton.GetInstanceThreadSafe("another@email.com", "anotherpassword");
            singleton.Token.ShouldBe(_expectedToken);
        }
    }
}
