namespace character
{
    public class Trait
    {
        public string? TraitName {get; set;}
        public string? TraitType {get; set;}
        public string? TraitDescription {get; set;}

        public Trait(string name, string type, string description)
        {
            TraitName = name;
            TraitType = type;
            TraitDescription = description;
        }

        public Trait() {}
    }
}