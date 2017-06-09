using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class UserData
    {
        static private List<User> users = new List<User>();
        //TODO 2: instantiate a few new users in code here and add them to your users list
        //then write methods to add users to your list, return all users and return a user by UserId
        public static List<User> GetAll()
        {
            return users;
        }

        public static void Add(User newUser)
        {
            users.Add(newUser);
        }

        public static User GetById(int id)
        {
            return users.Single(x => x.UserId == id);
        }
    }
}
