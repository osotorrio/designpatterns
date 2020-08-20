using GangOfFour.Patterns.Behavioral.Iterator.Aggregates;
using System;
using Xunit;

namespace GangOfFour.Patterns.Behavioral.Iterator
{
    public class ApplicationCode
    {
        [Fact]
        public void ExampleIteratorPattern()
        {
            var attackingPlayers = new ArrayPlayers();
            attackingPlayers[0] = new Player("Mikhail", "Tal");
            attackingPlayers[1] = new Player("Garry", "Kasparov");

            var positionalPlayers = new LinkedPlayers();
            positionalPlayers[0] = new Player("Jose Raul", "Capablanca");
            positionalPlayers[1] = new Player("Magnus", "Carlsen");

            IterateCollection(attackingPlayers);
            IterateCollection(positionalPlayers);
        }

        private void IterateCollection(AbstractAggregate collection)
        {
            var iterator = collection.GetIterator();

            while (iterator.IsThereMore())
            {
                var player = iterator.Next();

                Console.WriteLine($"Welcome to {player.Surname}, {player.Name}");
            }
        }
    }
}
