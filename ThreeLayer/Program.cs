using ThreeLayer.DAL;
using ThreeLayer.DTO;
using ThreeLayer.GUI;

namespace ThreeLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserGUI userForm= new UserGUI();    
            UserData userList = new UserData();
            userForm.Menu();
        }
    }
}