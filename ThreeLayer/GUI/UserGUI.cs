using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ThreeLayer.BUSL;

namespace ThreeLayer.GUI
{
    public class UserGUI
    {
        UserBUS UserBusinessLayer;
        public UserGUI(){
              UserBusinessLayer = new UserBUS(); 
        }
        public void Menu()
        {
            while (true)
            {
                if (UserBusinessLayer.IsLogin)
                {
                    IsAuthenticationMenu();
                }
                else
                {
                    GuestMenu();
                }
                
            }
       }
    public void IsAuthenticationMenu()
     {
            Console.WriteLine(
                                    @"
                    ------Menu--------
                - Logout: Press 1.
                - View Student: Press 2.
                ");
            int x = int.Parse( Console.ReadLine() );
     }
     public void GuestMenu()
     {
      Console.WriteLine(
              @"
                    ------Menu--------
                - Regist Account : Press 1
                - Login Account : Press 2 
                - Exit: press any key
                ");
      int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    {
                        Console.WriteLine("Your name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Your username: ");
                        string userName = Console.ReadLine();
                        Console.WriteLine("Password: ");
                        string password = Console.ReadLine();
                        try
                        {
                            UserBusinessLayer.RegistAccount(name, userName, password);
                        }
                        catch (Exception error)
                        {
                            Console.WriteLine(error);
                        }
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Your username: ");
                        string userName = Console.ReadLine();
                        Console.WriteLine("Password: ");
                        string password = Console.ReadLine();
                        try
                        {
                            UserBusinessLayer.Login(userName, password);
                        }
                        catch (Exception error)
                        {
                            Console.WriteLine(error);
                        }
                    }
                    break;
                default: return;
            }
        }
    }
}
