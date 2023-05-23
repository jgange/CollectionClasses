namespace character;
﻿using System.Text.Json;

/*
    Character background consists of-
    - Profession (string)
    - Descripton (string)
    - Skills (list of strings)
    - Starting Equipment (list of strings)

    Inititialization should always create an empty object even if nothing will be added (e.g. empty list)
*/

class CharacterBackground
{
    public string? Profession {get; set;}
    public string? Description {get; set;}
    public List<string>? StartingSkills {get; set;}
    public List<string>? StartingEquipment {get; set;}

    public CharacterBackground(string profession, string description, List<string>startingskills, List<string>startingequipment)
    {
        Profession = profession;
        Description = description;
        StartingSkills = startingskills;
        StartingEquipment = startingequipment;
    }

    public void Display()
    {
        Console.WriteLine("Profession: {0}", Profession);
        Console.WriteLine("Description: {0}", Description);
        Console.WriteLine("Starting Skills");
        if (StartingSkills!=null)
        {
            foreach(var skill in StartingSkills)
            {
                Console.WriteLine("   {0}",skill);
            }
        }
        else {Console.WriteLine("No skills.");}
         Console.WriteLine("Starting Equipment");
        if (StartingEquipment!=null)
        {
            foreach(var item in StartingEquipment)
            {
                Console.WriteLine("   {0}",item);
            }
        }
        else {Console.WriteLine("No starting equipment.");}
        Console.WriteLine();
        
    }
}