using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject._4.UI
{
    public class MenuItem
    {
        public string MenuTitle { get; set; }
        public Screen Screen { get; set; }
        public MenuItem() { }
        public MenuItem(string title, Screen screen)
        {
            MenuTitle = title;
            Screen = screen;
        }
    }
}
