namespace character
{
    public class PlayerCharacter{

        public Appearance? Appearance {get; set;} = new Appearance();
        public CharacterDetails? Details {get; set;}
        public List<Equipment>? EquipmentList {get; set;}
        public List<Spell>? SpellList {get; set;}
        public List<Trait>? Traits {get; set;}
        public List<CharacterBackground>? Backgrounds {get; set;}
        public Race? CharacterRace {get; set;}
        public Dictionary<string, int>? Attributes {get; set;}

        //constructor functionality - if no race is selected, should be create an empty race that defaults to human and assign the base attributes.
        public PlayerCharacter()
        {
            CopyBaseAttributes();
        }

        public PlayerCharacter(Appearance app, CharacterDetails details, List<Equipment> gear, List<Spell> spelllist, List<Trait> traits, List<CharacterBackground> professions, Race race, Dictionary<string, int> attributes)
        {
            Appearance = app;
            Details = details;
            EquipmentList = gear;
            SpellList = spelllist;
            Traits = traits;
            Backgrounds = professions;
            CharacterRace = race;
            Attributes = attributes;

            CopyBaseAttributes();
        }

        private void CopyBaseAttributes()
        {
            if (CharacterRace!=null)
            {
                Attributes = CharacterRace.BaseAttributes;
            }
            else
            {
                CharacterRace = new Race();
            }
        }

        public void Display()
        {
            if (Details!=null) { utilities.Display(Details); }
            if (Appearance!=null) { utilities.Display(Appearance); }
            if (CharacterRace!=null) { utilities.Display(CharacterRace);}
            if (Traits!=null) {
                foreach(Trait t in Traits)
                {
                    utilities.Display(t);
                }
            }

        }

    }
}