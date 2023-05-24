using System.Text.Json;

namespace character
{
    public class Program
    {
        public static void Main()
        {
            List<Equipment> equipmentlist = new List<Equipment>();
            Equipment SaddleAndTack = new Equipment("Saddle and tack","This includes items such as saddles, stirrups, bridles, halters, reins, bits, and harnesses.","50sp");
            Equipment SewingKit = new Equipment("Sewing kit","Needles, thread, buttons, etc.","10sp");
            equipmentlist.Add(SaddleAndTack);
            equipmentlist.Add(SewingKit);


            List<Spell> spelllist = new List<Spell>();
            Spell WispOfDirection = new Spell(
                "Wisp of Direction",
                "This spell requests the help of a local spirit to find a place. The spirit can understand simple requests like 'take me to the nearest town' or 'help me find my way to the edge of the forest'.",
                15,
                "10 miles",
                "Spirit",
                "Spirit, Location, Communing",
                "1 cycle (either dusk to dawn or dawn to dusk)"
            );
            
            Spell BindingOfStone = new Spell(
                "Binding of Stone",
                "Target's feet sink into the ground and are unable to move until the spell expires. The caster can target anyone within 30'.",
                15,
                "Within 30' of the caster",
                "Earth",
                "Earth, Binding, Change",
                "1 hour"
            );

            spelllist.Add(WispOfDirection);
            spelllist.Add(BindingOfStone);

            if (spelllist!=null)
            {
                //utilities.WriteToDisk(@"./DataFiles/EquipmentList.json", equipmentlist);
                foreach (Spell s in spelllist)
                {
                    utilities.Display(s);
                }
            }

            if (spelllist!=null) { utilities.WriteToDisk(@"./DataFiles/SpellList.json", spelllist); }

        }
    }
}