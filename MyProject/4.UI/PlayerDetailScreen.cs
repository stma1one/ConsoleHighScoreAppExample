using MyProject._2.Models;
using MyProject.App;

namespace MyProject._4.UI
{
    public class PlayerDetailScreen : Screen
    {
        public PlayerDetailScreen() : base($"{MainUi.p.Name} details")
        {
        }

        public override void Show()
        {
            base.Show();
            HighScore h;
            Console.WriteLine($"Total Score:{MainUi.p.Points,4}");
            Console.WriteLine("HighScores:");
            if (MainUi.p.Scores.Count > 0)
            {
                h = MainUi.p.Scores[0];

                Console.Write($"\t{nameof(h.Game),6}");
                Console.Write($"\t{nameof(h.Score),10}\n");
                Console.WriteLine($"\t{"------".PadLeft(5)}{" ------".PadLeft(14)}");
                foreach (var p in MainUi.p.Scores)
                {
                    Console.Write($"\t{p.Game.PadLeft(10)}");
                    Console.Write($"\t{p.Score.ToString().PadLeft(4)}\n");
                }
            }
            else
                Console.WriteLine("No Games Played Yet...");

            Console.ReadKey();


                    
        }
    }
}