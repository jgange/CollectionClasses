namespace character;

class CharacterAppearance
{
    public string? HairColor {get; set;}
    public string? EyeColor {get; set;}
    public string? Height {get; set;}
    public string? Weight {get; set;}
    public string? Description {get; set;}

    public CharacterAppearance(){}

    public CharacterAppearance(string hair, string eyes, string height, string weight, string description)
    {
        HairColor = hair;
        EyeColor = eyes;
        Height = height;
        Weight = weight;
        Description = description;
    }

    public void Display()
    {
        Console.WriteLine("Hair: {0}  Eyes: {1}  Height: {2} Weight: {3} ", HairColor,EyeColor,Height,Weight);
        Console.WriteLine(Description);
    }

}