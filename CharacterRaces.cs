namespace character;

/*
    Character race consists of-
    Name (string)
    Type (string)
    Base Attributes (list of key, value pairs) ==> collection - never empty
    Special Abilities 
    StartingTaint (int)
    Skills (list of key, value pairs) ==> collection - can be empty
    Languages (list of language names) ==> List - can be empty
    Backgrounds (list of backgrounds) ==> List - can be empty

    Inititialization should always create an empty object even if nothing will be added (e.g. empty list)
*/

class Race
{
    string RaceName {get; set;} = "Human";
    string RaceType {get; set;} = "Base Human";
    int StartingTaint {get; set;} = 0;
    List<string> Languages {get; set;} = new List<string>();
    List<string> Skills {get; set;} = new List<string>();
    List<string> SpecialAbilities {get; set;} = new List<string>();
    Dictionary<string,int> BaseAttributes {get; set;} = new Dictionary<string, int>
    {
        {"Strength",10},
        {"Constitution",10},
        {"Dexterity",10},
        {"Size",10},
        {"Intellect",10},
        {"Power",10}
    };
    List<string> Backgrounds {get; set;} = new List<string>();

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
}