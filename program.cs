using System.Text.Json;

namespace character
{
    public class Program
    {
        public static void Main()
        {
            PlayerCharacter? bob = new PlayerCharacter();
            CharacterAppearance? app = new CharacterAppearance();
            app.Hair = "brown";
            app.Eyes = "green";
            app.Height = "five feet eight inches";
            app.Weight = "176#";
            bob.Appearance = app;
            //bob.Appearance.Hair="Wavy brown";
            //bob.Appearance.Eyes="Green";
            //bob.Appearance.Height="just over six feet tall.";
            //bob.Appearance.Weight="a solid 220#.";
            //bob.Appearance.GeneralDescription="A burly man of average appearance.";
            bob.Display();
            
        }
    }
}