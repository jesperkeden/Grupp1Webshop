using Grupp1Webshop.Models;

namespace Grupp1Webshop
{
    internal class Program
    {
        static void Main()
        {
            
        Menu.MainMenu();
        }


        public static void ToDoUpdate()
        {
            using (var database = new Context())
            {
                int chosenId = CaptureId();

                var updatePost = (from t in database.ToDoS
                                  where t.Id == chosenId
                                  select t).SingleOrDefault();
                if (updatePost.Fixat != null)
                {
                    updatePost.Fixat = true;
                    database.SaveChanges();
                    Console.Clear();
                }
            }
        }



        private static int CaptureId()
        {
            Console.Write("Ange vilken post du vill uppdatera: ");
            int summa = int.Parse(Console.ReadLine());
            return summa;
        }
    }
}