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
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Show();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{"\tEnter UserName"}");
            Console.SetCursorPosition(Console.CursorLeft - 13, Console.CursorTop + 1);
            Console.ResetColor();
            string user = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{"\tEnter password"}");
            Console.SetCursorPosition(Console.CursorLeft - 13, Console.CursorTop + 1);
            Console.ResetColor();
            string password = Console.ReadLine();
            MainUi.p = Login(user, password);
            while(MainUi.p==null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{"\tInvalid Login Try Again"}");
                Thread.Sleep(2000);
                Show();

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tLogin Successfull");
            Thread.Sleep(2000);
            Screen next = new MainMenuScreen();
            Console.ResetColor();
            next.Show();
            base.Show();
            Console.WriteLine("Press Any Key To SignOut...",10);
            Console.ReadKey();

        }

        private Player Login(string? user, string? password)
        {

            return Users.Login(user, password);
        }
    }
}
