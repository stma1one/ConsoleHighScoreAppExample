using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MyProject._1.Data
{
    public  class Users
    {
        private static List<Player> players=new List<Player>() { new Player("tal", "Talsi", "1234") };

     

        public static Player Login(string user, string password)
        {
            return players.FirstOrDefault(x => x.UserName == user && x.Password == password);
        }
    }
}
