using GangOfFour.Patterns.Creational.Singleton.Singleton;
using GangOfFour.Patterns.Creational.Singleton.Stuff;
using Shouldly;
using Xunit;

namespace GangOfFour.Patterns.Creational.Singleton.Client
{
    public class Application
    {
        private const string _expectedToken = "aHR0cHM6Ly9hcGkvYWNjZXNzL3Rva2VuYW5vdGhlckBlbWFpbC5jb21hbm90aGVycGFzc3dvcmQ=";

        public Application()
        {
            AccessTokenSingleton.RegisterHttpClient(new FakeHttpClient());
        }

        /// <summary>
        /// XUnit runs always this test first.
        /// </summary>
        [Fact]
        public void ExampleSingletonPatternOne()
        {
            var singleton = AccessTokenSingleton.GetInstanceThreadSafe("some@email.com", "somepassword");
            singleton.Token.ShouldBe(_expectedToken);
        }

        /// <summary>
        /// XUnit runs always this test second.
        /// </summary>
        [Fact]
        public void ExampleSingletonPatternTwo()
        {
            var singleton = AccessTokenSingleton.GetInstanceThreadSafe("another@email.com", "anotherpassword");
            singleton.Token.ShouldBe(_expectedToken);
        }
    }
}
