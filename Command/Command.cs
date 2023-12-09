namespace Models
{
    public class Command
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draw { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsConceded { get; set; }

        public Command()
        {
        }

        public Command(string name, string city, int wins, int losses, int draw, int goalsScored, int goalsConceded)
        {
            Name = name;
            City = city;
            Wins = wins;
            Losses = losses;
            Draw = draw;
            GoalsScored = goalsScored;
            GoalsConceded = goalsConceded;
        }
        public override string ToString()
        {
            return $"{Id} {Name} {City} {Wins} {Losses} {Draw} {GoalsScored} {GoalsConceded}";
        }
    }
}
