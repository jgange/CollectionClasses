using System.Text.Json;

namespace character
{
    public class Program
    {
        public static void Main()
        {
            var appearance = new CharacterAppearance
            {
                HairColor = "Brown",
                EyeColor = "Brown",
                Height = "5 foot 10 inches",
                Weight = "176#",
                Description = "A fine looking fellow."
            };

            string fileName = @"./CharacterRacesOut.json";
            //string? json;

            Race HumanRace = new Race("Human","Base Human",0,new List<string>(),new List<string>(),new List<string>(),
                new Dictionary<string, int>
                {
                    {"Strength",10},
                    {"Constitution",10},
                    {"Dexterity",10},
                    {"Size",10},
                    {"Intellect",10},
                    {"Power",10}
                },new List<string>()
            );

            List<Race> races = new List<Race>();

            races.Add(HumanRace);

            Race ElvenRace = new Race("Elf","Near Human",0,
            new List<string>{"Elvish"},
            new List<string>{"Ranged Weapons","Tree Care"},
            new List<string>{"Pathfinding","Woodcraft"},
            new Dictionary<string, int>
            {
                {"Strength",10},
                {"Constitution",10},
                {"Dexterity",12},
                {"Size",10},
                {"Intellect",12},
                {"Power",12}
            },
            new List<string>{"Forest Warden"}
            );

            races.Add(ElvenRace);

            Race.WriteListToDisk(fileName, races);
            List<Race>? racelist = new List<Race>();
            racelist = Race.Deserialize(fileName);

            foreach(var CharacterRace in racelist)
            {
                CharacterRace.Display();
            }

    }

    static string? GetJsonFromDisk(string fileName)
    {
        StreamReader r = new StreamReader(fileName);
        string? json = r.ReadToEnd();
        Console.WriteLine(json);
        return json;
        }
    }
}