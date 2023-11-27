using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayer.DTO;

namespace ThreeLayer.DAL
{   
    public class UserData
    {
        private List<User> UserList = new List<User>() {
        new User("John Doe", "john.doe", "password123"),
        new User("Jane Smith", "jane.smith", "password456"),
        new User("Jane Smith", "kyhung191", "123123"),
    };
        public UserData()
        {
           
        }
        public List<User> GetUserList()
        {
            return UserList;
        }
        public void AddUser(string name, string username,string password)
        {
            User user = new User(name, username, password);
            UserList.Add(user);
        }
        public bool CheckUser(string username)
        {
            foreach(User user in UserList)
            {   
                if (user.UserName == username)
                {
                    return true;
                }
            }
            return false;
        }
      
    }
}
