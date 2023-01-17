using Grupp1Webshop.Models;
using System.Reflection;

namespace Grupp1Webshop
{
    internal class Program
    {
        internal static void Main()
        {
            //Data.GetAllCities();
            //Data.GetAllCategories();
            //Data.GetAllSuppliers();
            //Data.GetAllProducts();
            //Data.GetAllUsers();

            //Menu.MainMenu();


            Menu.MainMenu();
            User.CreateUser(true);
            Supplier.CreateSupplier();
            Product.CreateProduct();
            //jesper testar

            //string hej = Input.GetStringLowerInput();
            //Console.WriteLine(hej);
            //hej = Input.GetStringFirstUpperInput();
            //Console.WriteLine(hej);




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



        //public static void ToDoUpdate()
        //{
        //    using (var database = new Context())
        //    {
        //        int chosenId = CaptureId();

        //        var updatePost = (from t in database.ToDoS
        //                          where t.Id == chosenId
        //                          select t).SingleOrDefault();
        //        if (updatePost.Fixat != null)
        //        {
        //            updatePost.Fixat = true;
        //            database.SaveChanges();
        //            Console.Clear();
        //        }
        //    }
        //}



        private static int CaptureId()
        {
            Console.Write("Ange vilken post du vill uppdatera: ");
            int summa = int.Parse(Console.ReadLine());
            return summa;
        }
    }
}