namespace character
{
    public class PlayerCharacter{

        public CharacterAppearance? Appearance {get; set;}
        public CharacterDetails? Details {get; set;}
        public List<Equipment>? EquipmentList {get; set;}
        public List<Spells>? SpellList {get; set;}
        public List<Traits>? Traits {get; set;}
        public List<CharacterBackground>? Backgrounds {get; set;}
        public Race? CharacterRace {get; set;}
        public Dictionary<string, int>? Attributes {get; set;}

        //constructor functionality - if no race is selected, should be create an empty race that defaults to human and assign the base attributes.
        public PlayerCharacter()
        {
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


        }

    }
}