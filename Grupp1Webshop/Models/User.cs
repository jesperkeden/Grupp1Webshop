using Grupp1Webshop.Data;
using Grupp1Webshop.Gammalt;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Grupp1Webshop.Models
{
    internal class User
    {
        public User()
        {
            Order = new HashSet<Order>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool Admin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string StreetAdress { get; set; }
        public int ZipCode { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public virtual ICollection<Order> Order { get; set; }


        internal static void CreateUser(bool isAdmin)
        {
            EditUser(new User(), isAdmin);
        }

        internal static int GetUserChoice(List<User> model)
        {
            if (model.Count < 1)
            {
                Console.WriteLine("There is no Users");
                Console.ReadKey();
                return -1;
            }
            return Menu.EditMenu(Helpers.ConvertClassListToStringList(model));
        }

        internal static void UpdateUser(bool isAdmin)
        {
            List<User> users = Helpers.GetUsersFromDb();
            int index = GetUserChoice(users);
            if (index != -1)
            {
                EditUser(users[index], isAdmin);
            }
        }

        internal static void RemoveUser()
        {
            List<User> users = Helpers.GetUsersFromDb();
            int index = GetUserChoice(users);
            if (index != -1)
            {
                Helpers.DeleteModel(users[index]);
            }
        }

        internal static void EditUser(User model, bool isAdmin)
        {
            //Get List of prop names and prop values
            PropertyInfo[] properties = model.GetType().GetProperties();
            List<string> firstColumn = Helpers.AddMenuChoicesForProp(Helpers.GetPropertyNames(properties));
            List<string> secondCollumn = Helpers.AddMenuChoicesForValues(Helpers.GetPropertyValues(model, properties));

            //Position of list in GUI
            int firstColumnPositionX = 3;
            int secondColumnPositionX = (Helpers.GetLengthOfStringInList(firstColumn) + firstColumnPositionX);
            int positionY = 2;

            int index = 0;

            //Edit prop values
            while (true)
            {
                index = Menu.EditMenu(firstColumn, secondCollumn, firstColumnPositionX, secondColumnPositionX, positionY, index);

                if (index == 0) SaveUser(secondCollumn, model);
                else if (index == secondCollumn.Count) break;

                GUI.OverWriteWithSpaces(secondCollumn[index].Length, secondColumnPositionX, (positionY + index));
                secondCollumn[index] = GetValueInput(properties[index], secondColumnPositionX, isAdmin);
            }
        }

        private static void SaveUser(List<string> secondColumn, User user)
        {
            string saveOutput = "";
            if (Helpers.ColumnValueEmpty(secondColumn))
                saveOutput = "Could not save values, some values are empty";
            else
            {
                using (var db = new Context())
                {
                    var dbUsers = db.Users;
                    User dbUser = dbUsers.ToList().SingleOrDefault(a => a.Id == user.Id);
                    if (dbUser == null)
                    {
                        dbUsers.Add(user);
                    }
                    else user = dbUser;

                    user.Admin = Convert.ToBoolean(secondColumn[1]);
                    user.FirstName = secondColumn[2];
                    user.LastName = secondColumn[3];
                    user.Password = secondColumn[4];
                    user.Email = secondColumn[5];
                    user.Age = Convert.ToInt32(secondColumn[6]);
                    user.PhoneNumber = secondColumn[7];
                    user.StreetAdress = secondColumn[8];
                    user.ZipCode = Convert.ToInt32(secondColumn[9]);
                    string cityFromColumn = secondColumn[10];

                    var dbCities = db.Cities;
                    City dbCity = dbCities.ToList().SingleOrDefault(a => a.Name == cityFromColumn);
                    if (dbCity == null)
                    {
                        dbCity = new City()
                        {
                            Name = cityFromColumn
                        };

                        dbCities.Add(dbCity);
                    }
                    user.City = dbCity;

                    try
                    {
                        db.SaveChanges();
                        saveOutput = "Save success";
                    }
                    catch (Exception ex)
                    {
                        saveOutput = "Could not save values to database" + ex;
                    }
                }
            }
            Console.WriteLine("\n\n" + saveOutput);
            Console.ReadLine();
        }

        internal static string GetValueInput(PropertyInfo edit, int positionX, bool isAdmin)
        {
            string value = "";
            switch (edit.Name)
            {
                case nameof(Password):
                    value = Input.GetStringWithMaxLengthForDescription("");
                    break;
                case nameof(Admin):
                    if (!isAdmin) return "False";
                    value = Input.GetBoolAsString(positionX);
                    break;
                case nameof(StreetAdress):
                case nameof(Email):
                    value = Input.GetStringFirstLeterInEachWordUpperInput(positionX);
                    break;
                case nameof(FirstName):
                case nameof(LastName):
                case nameof(City):
                    value = Input.GetStringFirstUpperInput(positionX);
                    break;
                case nameof(Age):
                    value = Input.GetIntAsStringInput(18, 120, positionX);
                    break;
                case nameof(ZipCode):
                    value = Input.GetIntAsStringInput(10000, 99999, positionX);
                    break;
                case nameof(PhoneNumber):
                    value = Input.GetPhonenumberInput(positionX);
                    break;
            }
            return value;
        }
    }
}
