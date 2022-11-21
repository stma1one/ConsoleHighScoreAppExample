using MyProject._4.UI;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.App
{
    public class MainUi
    {
        public static Player p;

        private Screen main;

        public MainUi(Screen p)
        {
            this.main = p;
        }

        public void ApplicationStart()
        {
            this.main.Show();
        }
    }
}
