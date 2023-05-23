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

            if (equipmentlist!=null)
            {
                //utilities.WriteToDisk(@"./DataFiles/EquipmentList.json", equipmentlist);
                foreach (Equipment e in equipmentlist)
                {
                    utilities.Display(e);
                }
            }

        }
    }
}