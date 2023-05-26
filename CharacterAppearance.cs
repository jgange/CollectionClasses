namespace character;
    public class CharacterAppearance
    {
        public string? Hair {get; set;}
        public string? Eyes {get; set;}
        public string? Height {get; set;}
        public string? Weight {get; set;}
        public string? GeneralDescription {get; set;}

    public CharacterAppearance(string hair, string eyes, string height, string weight, string description)
    {
        Hair = hair;
        Eyes = eyes;
        Height = height;
        Weight = weight;
        GeneralDescription = description;
    }

    public CharacterAppearance() {}
}