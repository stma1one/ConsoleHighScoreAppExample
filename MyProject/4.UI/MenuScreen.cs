using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject._4.UI
{
    public class MenuScreen:Screen
    {
        Dictionary<string, Screen> menu;

        public MenuScreen(string title) : base(title)
        {
        }

        public virtual void Show()
        {
            Console.Clear();
            Console.WriteLine($"{ title,65}");
           
        }
    }
}
