using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeLayer.DTO
{

    public class User
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public User() { }
        public User(string name, string userName, string password)
        {
            Name = name;
            UserName = userName;
            Password = password;
        }
    }
}
