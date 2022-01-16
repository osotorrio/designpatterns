using System.Collections.Generic;
using GangOfFour.Patterns.Behavioral.Iterator.Aggregates;
using Shouldly;
using Xunit;

namespace GangOfFour.Patterns.Behavioral.Iterator
{
    public class ApplicationCode
    {
        private readonly List<string> _players = new();

        [Fact]
        public void ExampleIteratorPattern()
        {
            var attackingPlayers = new ArrayPlayers();
            attackingPlayers[0] = new Player("Tal", "Mikhail");
            attackingPlayers[1] = new Player("Garry", "Kasparov");

            var positionalPlayers = new LinkedPlayers();
            positionalPlayers[0] = new Player("Jose Raul", "Capablanca");
            positionalPlayers[1] = new Player("Magnus", "Carlsen");

            ClientCode(attackingPlayers);
            ClientCode(positionalPlayers);

            _players[0].ShouldBe("Mikhail, Tal");
            _players[1].ShouldBe("Kasparov, Garry");
            _players[2].ShouldBe("Capablanca, Jose Raul");
            _players[3].ShouldBe("Carlsen, Magnus");
        }

        /// <summary>
        /// The client code knows how to loop any collection despite of having different data structure under the hood.
        /// In this case under the hood we have ArrayList and LinkedList.
        /// </summary>
        /// <param name="collection">An abstract aggregate implementation</param>
        private void ClientCode(AbstractAggregate collection)
        {
            var iterator = collection.GetIterator();

            while (iterator.IsThereMore())
            {
                var player = iterator.Next();
                _players.Add($"{player.Surname}, {player.Name}");
            }
        }
    }
}
