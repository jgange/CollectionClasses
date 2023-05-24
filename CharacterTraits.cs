namespace character
{
    class Traits
    {
        public string? TraitName {get; set;}
        public string? TraitType {get; set;}
        public string? TraitDescription {get; set;}

        public Traits(string name, string type, string description)
        {
            TraitName = name;
            TraitType = type;
            TraitDescription = description;
        }
    }
}