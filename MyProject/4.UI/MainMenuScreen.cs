using MyProject.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject._4.UI
{
    public class MainMenuScreen:MenuScreen
    {
        public MainMenuScreen() : base($"Hello {MainUi.p.Name} ")
        {
            AddItem("Player Details", new PlayerDetailScreen());
            AddItem("Play Games",new GameMenuScreen());
        }

        
    }
}
