namespace _45_ListOfObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            Player player1 = new Player("Chad");
            Player player2 = new Player("Steve");
            Player player3 = new Player("Karen");

            players.Add(new Player("John"));
            players.Add(player2);
            players.Add(player3);

            foreach (Player player in players)
            {
                //Console.WriteLine(player.username);
                Console.WriteLine(player);
            }

            Console.ReadKey();
        }
    }

    class Player
    {
        public String username;

        public Player (String username)
        {
            this.username = username;
        }

        public override string ToString()
        {
            return username;
        }
    }
}
