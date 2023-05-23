using System.Text.Json;

namespace character
{
    public class Program
    {
        public static void Main()
        {
            List<Race>? races = new List<Race>();
            races = utilities.ReadFromDisk<Race>(@"./CharacterRaces.json");
            if (races!=null)
            {
                foreach(Race r in races)
                {
                    utilities.Display(r);
                }
            }
            if (races!=null) { utilities.WriteToDisk(@"./CharacterRaces1.json", races); }
        }
    }
}