namespace character;
    public class CharacterDetails
    {
        public string? CharacterName {get; set;}
        public string? CharacterTitle {get; set;}
        public string? CharacterOrigin {get; set;}

    public CharacterDetails(string name, string title, string background)
    {
        CharacterName = name;
        CharacterTitle = title;
        CharacterOrigin = background;
    }
}