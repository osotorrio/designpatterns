namespace GangOfFour.Patterns.Behavioral.Iterator.Aggregates
{
    public class Player
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Player(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
