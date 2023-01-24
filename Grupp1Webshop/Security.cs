using Grupp1Webshop.Models;

namespace Grupp1Webshop
{
    internal class Security
    {
        internal static void UserLogin()
        {
            User user = Login();
            if (user == null)
                return;

            Menu.UserMainMenu(user);
        }

        internal static bool CheckAdminPrivileges(User user)
        {
            return user.Admin;
        }

        private static User Login()
        {
            GUI.WriteString("Input Firstname");
            string firstName = Input.GetStringWithMaxLength(0);
            GUI.WriteString("Input Last name");
            string lastName = Input.GetStringWithMaxLength(0);
            GUI.WriteString("Input Password");
            string password = Input.GetStringWithMaxLength(0);

            string output = "Name and password has no match!\n\n";
            User user = new User();
            try
            {
                user = Querys.QGetSelectedUserFromPassword(firstName, lastName, password);
            }
            catch (Exception ex)
            {
                output += ex.Message;
            }
            if (user == null || user.Id == 0) 
            {
                Console.WriteLine(output);
                Console.ReadLine();
            }
            Console.Clear();
            return user;
        }
    }
}