using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayer.DAL;
using ThreeLayer.DTO;
using ThreeLayer.Utils;

namespace ThreeLayer.BUSL
{
    public class UserBUS 
    {
        public bool IsLogin { get; set; }=false;
        private UserData userData;
        public UserBUS()
        {
           userData = new UserData();
        }
        public void RegistAccount(string name, string username, string password) 
        {
            if (userData.CheckUser(username))
            {
                Console.WriteLine("This account is already exist");
            }
            else
            {
                userData.AddUser(name,username, password);
                Console.WriteLine("Regist Successfully");
            }
        }
        public void Login (string username, string password) {
            if (!userData.CheckUser(username))
            {
                Console.WriteLine("This User name is not exist");
            }
            else
            {
                userData.GetUserList().ToList().ForEach((user) =>
                {
                    if(user.UserName == username)
                    {
                       if(user.Password == password)
                        {
                            Console.WriteLine("Login Successfully");
                            IsLogin = true;
                        }
                        else
                        {
                            Console.WriteLine("Password is wrong!");
                        }
                    }
                });
            }
        }

    
    }
}
