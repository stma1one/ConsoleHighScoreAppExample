using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject._4.UI
{
    public class GameMenuScreen:MenuScreen
    {
        
        public GameMenuScreen() : base("Choose Game")
        {
            this.AddItem("Pong", new GameScreen(new Pong()));
            this.AddItem("Pack-Man", new GameScreen(new PacManGame()));
            this.AddItem("Fluffy Bird", new GameScreen(new FluffyBirdGame()));
        }

   
    }
}
