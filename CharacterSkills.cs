namespace character;
    public class Skill
    {
        public string? SkillName {get; set;}
        public string? SkillType {get; set;}
        public string? SkillDescription {get; set;}

    public Skill(string name, string type, string description)
    {
        SkillName = name;
        SkillType = type;
        SkillDescription = description;
    }

    public Skill() {}
}