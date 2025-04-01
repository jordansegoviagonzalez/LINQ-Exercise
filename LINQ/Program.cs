namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gameNames = new List<string>()
            {
                "Helldivers",
                "Fallout: New Vegas",
                "Half life",
                "Legend of Zelda",
                "Doom",
                "Halo Reach",
                "Mario"
            };
            
            gameNames.OrderBy(gameName => gameName.Length).ToList().ForEach(gameName => Console.WriteLine(gameName));
            
        }
    }
}
