using MyProject._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class Player
    {
        //members
        private string name;

        public string Name { get { return name; } set { if (value[0] < 'a' || value[0] > 'z')
                    throw new Exception
                        ("Name must start with lower case letter");
                else name = value;
            } }
        public int Points { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public List<HighScore> Scores{get;set;}

        public Player(string name,string username,string password)
        {
            Name = name;
            
            this.Scores = new List<HighScore>();
            Points = 0;
            this.UserName = username;
            this.Password = password;

        }

        public void AddScore(string game, int score)
        {
            this.Points += score;
            AddHighScore(game, score);
        }
        public void AddHighScore(string game, int score)
        {
            var highscore = Scores.FirstOrDefault(x => x.Game == game);
            if(highscore == null)
            {
                Scores.Add(highscore);
            }
            else if(score>highscore.Score)
                    highscore.Score = score;
        }
    }
}
