namespace character;

public class Spells
{
    public string? SpellName {get; set;}
    public string? SpellDescription {get; set;}
    public int? QuintessenceCost {get; set;}
    public string? Range {get; set;}
    public string? Affinity {get; set;}
    public string? Workings {get; set;}
    public string? Duration {get; set;}

    public Spells(string name, string description, int q, string range, string affinity, string workings, string duration)
    {
        SpellName = name;
        SpellDescription = description;
        QuintessenceCost = q;
        Range = range;
        Affinity = affinity;
        Workings = workings;
        Duration = duration;
    }

}