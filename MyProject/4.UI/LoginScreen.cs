using MyProject._1.Data;
using MyProject.App;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyProject._4.UI
{
    internal class LoginScreen : Screen
    {
        public LoginScreen() : base("Login")
        {

        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Enter UserName");
            string user = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            MainUi.p = Login(user, password);
            while(MainUi.p==null)
            {
                Console.WriteLine("Invalid Login");
                Console.WriteLine("Enter UserName");
                user = Console.ReadLine();
                Console.WriteLine("Enter password");
                password = Console.ReadLine();
            }
            Console.WriteLine("Login Successfull");
            Screen next = new Screen("Welcome");
            next.Show();

        }

        private Player Login(string? user, string? password)
        {

            return Users.Login(user, password);
        }
    }
}
