using Grupp1Webshop.Models;
using System.Reflection;

namespace Grupp1Webshop
{
    internal class Program
    {
        static void Main()
        {
            User.CreateUser();


            //List<string> user = new List<string>();
            //user.Add("Förnamn");
            //user.Add("Efternamn");
            //user.Add("Ålder");
            //user.Add("Förnamn");
            //user.Add("Efternamn");
            //user.Add("Ålder");
            //user.Add("Förnamn");
            //user.Add("Efternamn");
            //user.Add("Ålder");
            //user.Add("Förnamn");
            //user.Add("Efternamn");
            //user.Add("Ålder");

            //List<string> userEdit = new List<string>();
            //userEdit.Add("Robin");
            //userEdit.Add("Forsling");
            //userEdit.Add("30");
            //userEdit.Add("Robin");
            //userEdit.Add("Forsling");
            //userEdit.Add("30");
            //userEdit.Add("Robin");
            //userEdit.Add("Forsling");
            //userEdit.Add("30");
            //userEdit.Add("Robin");
            //userEdit.Add("Forsling");
            //userEdit.Add("30");
            //Menu.EditMenu(user, userEdit);
            //Menu.MainMenu();
        }

        internal static List<string> GetPropList(User getPropFrom)
        {
            //List<string> propNameList = getPropFrom.GetType().GetProperties().Select(p => p.Name).ToList();

            PropertyInfo[] newUserProp = getPropFrom.GetType().GetProperties();
            List<string> propNameList = new List<string>();

            for (int i = 1; i < (newUserProp.Length); i++)
            {
                propNameList.Add(newUserProp[i].Name);
            }
            return propNameList;
        }
    }
}