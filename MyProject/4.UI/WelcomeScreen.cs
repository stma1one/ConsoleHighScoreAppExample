using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject._4.UI
{
    public class WelcomeScreen:Screen
    {
      

        public WelcomeScreen():base("Welcome")
        {
           
        }

        public override void Show()
        {
            Console.Clear();
            Console.Write($"{ title,65}");
            Screen next = new LoginScreen();
            next.Show();
        }
    }
}
