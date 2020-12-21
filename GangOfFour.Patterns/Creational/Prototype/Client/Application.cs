using GangOfFour.Patterns.Creational.Prototype.Stuff;
using Xunit;

namespace GangOfFour.Patterns.Creational.Prototype.Client
{
    public class Application
    {
        [Fact]
        public void ExamplePrototypePattern()
        {
            var root = new Folder("C:");
            var chess = new Folder("Chess")
            {
                Parent = root
            };
            root.Childs.Add(chess);
            var path = chess.Path;
        }
    }
}
