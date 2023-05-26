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

//create a list of backgrounds and write them to disk
            CharacterBackground Apothecary = new CharacterBackground(
                "Apothecary",
                "A brewer of strange potions.",
                new List<string>{{"Corpus"},{"Knowledge"},{"Natural Lore"},{"Tinctures"}},
                new List<string>{{"Reagants"},{"Mortar and Pestle"},{"Droppers and scales"},{"Leather apron"},{"Leather gloves"}}
            );
            
            List<CharacterBackground> backgrounds = new List<CharacterBackground>();
            backgrounds.Add(Apothecary);

             CharacterBackground Craftsman = new CharacterBackground(
                "Craftsman",
                "Worker of crafts.",
                new List<string>{{"Tinker"},{"Skill1"},{"Skill2"}},
                new List<string>{{"Crafting Tools"},{"Crafting Supplies"},{"Harness or pack"},{"Set of working clothes"},{"Rags"}}
            );
            backgrounds.Add(Craftsman);

            List<CharacterBackground>? backgrounds1 = new List<CharacterBackground>();
            //backgrounds1 = CharacterBackground.Deserialize(@"./CharacterBackgrounds.json");
            backgrounds1 = utilities.ReadFromDisk<CharacterBackground>(@"./CharacterBackgrounds.json");
            
            if (backgrounds1!=null)
            {
                foreach(CharacterBackground background in backgrounds)
                {
                    utilities.Display(background);
                }
            }
            
            /*
            if(backgrounds!=null)
            {
                utilities.WriteToDisk(@"./CharacterBackgrounds.json", backgrounds);
            }
            */
public void Display()
    {
        Console.WriteLine("Race: {0}", this.RaceName);
        Console.WriteLine("Type: {0}", this.RaceType);
        Console.WriteLine("Inherited Taint: {0}", this.StartingTaint);
        
        Console.WriteLine("Base Attributes");
        foreach (var attribute in this.BaseAttributes)
        {
            Console.WriteLine("   {0}: {1}",attribute.Key, attribute.Value);
        }
        
        ListDisplayHelper("Skills", this.Skills);
        ListDisplayHelper("Languages", this.Languages);
        ListDisplayHelper("Special Abilities", this.SpecialAbilities);

    }
    private void ListDisplayHelper(string Title, List<string> displayList)
    {
     Console.WriteLine(Title);
        if (displayList.Count==0)
        {
            Console.WriteLine("   No extra {0}", Title);
        }
        else
        {
            foreach (var item in displayList)
            {
                Console.WriteLine("   {0}",item);
            }
        }
    }

    static public List<Race>? Deserialize(string path)
    {
        StreamReader r = new StreamReader(path);
        string? json = r.ReadToEnd();
        return JsonSerializer.Deserialize<List<Race>>(json);
    }

    static public void WriteToDisk(string fileName, Race race)
    {
        var systemJsonReadable = JsonSerializer.Serialize(race, new JsonSerializerOptions
        {
            WriteIndented = true
        });
        //Console.WriteLine(systemJsonReadable);
        //Console.WriteLine();
        File.WriteAllText(fileName, systemJsonReadable);
    }

    static public void WriteToDisk(string fileName, List<Race> races)
    {
        var systemJsonReadable = JsonSerializer.Serialize(races, new JsonSerializerOptions
        {
            WriteIndented = true
        });
        //Console.WriteLine(systemJsonReadable);
        //Console.WriteLine();
        File.WriteAllText(fileName, systemJsonReadable);
    }

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

List<Equipment> equipmentlist = new List<Equipment>();
            Equipment SaddleAndTack = new Equipment("Saddle and tack","This includes items such as saddles, stirrups, bridles, halters, reins, bits, and harnesses.","50sp");
            Equipment SewingKit = new Equipment("Sewing kit","Needles, thread, buttons, etc.","10sp");
            equipmentlist.Add(SaddleAndTack);
            equipmentlist.Add(SewingKit);


            List<Spells> spelllist = new List<Spells>();
            Spells WispOfDirection = new Spells(
                "Wisp of Direction",
                "This spell requests the help of a local spirit to find a place. The spirit can understand simple requests like 'take me to the nearest town' or 'help me find my way to the edge of the forest'.",
                15,
                "10 miles",
                "Spirit",
                "Spirit, Location, Communing",
                "1 cycle (either dusk to dawn or dawn to dusk)"
            );
            
            Spells BindingOfStone = new Spells(
                "Binding of Stone",
                "Target's feet sink into the ground and are unable to move until the spell expires. The caster can target anyone within 30'.",
                15,
                "Within 30' of the caster",
                "Earth",
                "Earth, Binding, Change",
                "1 hour"
            );

            spelllist.Add(WispOfDirection);
            spelllist.Add(BindingOfStone);

            if (spelllist!=null)
            {
                //utilities.WriteToDisk(@"./DataFiles/EquipmentList.json", equipmentlist);
                foreach (Spells s in spelllist)
                {
                    utilities.Display(s);
                }
            }

            if (spelllist!=null) { utilities.WriteToDisk(@"./DataFiles/SpellList.json", spelllist); }

            List<Traits> traits = new List<Traits>();
            Traits affinity = new Traits("Affinity","Positive","The character has a mystical connection to one of the Prime Symbols.");
            Traits alert = new Traits("Alert","Positive","The character is hard to surprise. In combat you often strike first.");

            traits.Add(affinity);
            traits.Add(alert);

            if (traits!=null)
            {
                foreach (Traits t in traits)
                {
                    utilities.Display(t);
                }

                //utilities.WriteToDisk(@"./DataFiles/TraitList.json", traits);
            }
