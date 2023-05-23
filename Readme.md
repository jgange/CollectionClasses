Collections classes

 var appearance = new CharacterAppearance
            {
                HairColor = "Brown",
                EyeColor = "Brown",
                Height = "5 foot 10 inches",
                Weight = "176#",
                Description = "A fine looking fellow."
            };

string fileName = @"./CharacterRaces.json";

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

            Race.WriteToDisk(fileName, races);
            List<Race>? racelist = new List<Race>();
            racelist = Race.Deserialize(fileName);

            if (racelist!=null)
            {
                foreach(var CharacterRace in racelist)
                {
                    CharacterRace.Display();
                }
            }


public void Display()
    {
        Console.WriteLine("Profession: {0}", Profession);
        Console.WriteLine("Description: {0}", Description);
        Console.WriteLine("Starting Skills");
        if (StartingSkills!=null)
        {
            foreach(var skill in StartingSkills)
            {
                Console.WriteLine("   {0}",skill);
            }
        }
        else {Console.WriteLine("No skills.");}
         Console.WriteLine("Starting Equipment");
        if (StartingEquipment!=null)
        {
            foreach(var item in StartingEquipment)
            {
                Console.WriteLine("   {0}",item);
            }
        }
        else {Console.WriteLine("No starting equipment.");}
        Console.WriteLine();
        
    }