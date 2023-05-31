using System.Text.Json;

namespace character
{
    public class Program
    {
        public static void Main()
        {           
            
            PlayerCharacter? bob = new PlayerCharacter(
                new Appearance("brown","brown","six feet","176#","good looking fellow"),
                new CharacterDetails("Bob","The Mighty","From mighty folk."),
                new List<Equipment>{
                    new Equipment{ EquipmentName = "Rope", EquipmentDescription="A 50 foot long coil of rope", EquipmentValue="5 cp" },
                    new Equipment{ EquipmentName = "Lantern", EquipmentDescription = "A hooded lantern.", EquipmentValue = "5 sp"}
                    },
                new List<Spell>{
                    new Spell{SpellName = "Fireball",SpellDescription="A whirling globe of fire",QuintessenceCost=10,Range="50 yards",Affinity="Fire",Workings="Fire",Duration="Instant"},
                    new Spell{SpellName = "Cloak of Mist",SpellDescription="Mist gathers around the caster to conceal them.",QuintessenceCost=10,Range="5 yards",Affinity="Water,Air",Workings="Air",Duration="1 hour"}
                    },
                new List<Trait>{
                    new Trait{TraitName="Affinity",TraitDescription="An affinity for a prime element.",TraitType="Positive"},
                    new Trait{TraitName="Surly", TraitDescription="Unpleasant to be around.", TraitType="Negative"}
                    },
                new List<CharacterBackground>{
                    new CharacterBackground{
                        Profession="Apothecary",
                        Description="A creator of potions",
                        StartingSkills=new List<string>{"Lore","Nature"},
                        StartingEquipment=new List<string>{"Mortar and Pestle","Leather Apron"}
                    }
                },
                new Race("Elf","Near Human",0, new List<string>{"Elvish"}, new List<string>{"Ranged Weapons","Tree Care"}, new List<string>{"Pathfinding","Woodcraft"},
                    new Dictionary<string, int>
                    {
                        {"Strength",10},
                        {"Constitution",10},
                        {"Dexterity",12},
                        {"Size",10},
                        {"Intellect",12},
                        {"Power",12}
                    },
                    new List<string>{"Forest Warden"}),
                    new Dictionary<string, int>
                    {
                        {"Strength",10},
                        {"Constitution",10},
                        {"Dexterity",12},
                        {"Size",10},
                        {"Intellect",12},
                        {"Power",12}
                    },
                new List<Skill>{new Skill{SkillName="Athletics",SkillType="Standard",SkillDescription="Any major physical activity."}}    
            );

            bob.Display();
            utilities.WriteToDisk(@"./Bob.json", bob);
            
        }
    }
}