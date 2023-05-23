﻿using System.Text.Json;

namespace character
{
    public class Program
    {
        public static void Main()
        {
            //create a list of backgrounds and write them to disk
            CharacterBackground Apothecary = new CharacterBackground(
                "Apothecary",
                "A brewer of strange potions.",
                new List<string>{{"Corpus"},{"Knowledge"},{"Natural Lore"},{"Tinctures"}},
                new List<string>{{"Reagants"},{"Mortar and Pestle"},{"Droppers and scales"},{"Leather apron"},{"Leather gloves"}}
            );
            
            List<CharacterBackground> backgrounds = new List<CharacterBackground>();
            backgrounds.Add(Apothecary);

             CharacterBackground Craftsman = new CharacterBackground(
                "Craftsman",
                "Worker of crafts.",
                new List<string>{{"Tinker"},{"Skill1"},{"Skill2"}},
                new List<string>{{"Crafting Tools"},{"Crafting Supplies"},{"Harness or pack"},{"Set of working clothes"},{"Rags"}}
            );
            backgrounds.Add(Craftsman);

            List<CharacterBackground>? backgrounds1 = new List<CharacterBackground>();
            //backgrounds1 = CharacterBackground.Deserialize(@"./CharacterBackgrounds.json");
            backgrounds1 = utilities.ReadFromDisk<CharacterBackground>(@"./CharacterBackgrounds.json");

            
            if (backgrounds1!=null)
            {
                foreach(CharacterBackground background in backgrounds)
                {
                    utilities.Display(background);
                }
            }
            
            /*
            if(backgrounds!=null)
            {
                utilities.WriteToDisk(@"./CharacterBackgrounds.json", backgrounds);
            }
            */
        }
    }
}