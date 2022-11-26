using MyProject._1.Data;
using MyProject.App;
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
           base.Show();
            Console.Write(@"         _______  _        _______  _______  _______  _______ 
|\     /|(  ____ \( \      (  ____ \(  ___  )(       )(  ____ \
| )   ( || (    \/| (      | (    \/| (   ) || () () || (    \/
| | _ | || (__    | |      | |      | |   | || || || || (__    
| |( )| ||  __)   | |      | |      | |   | || |(_)| ||  __)   
| || || || (      | |      | |      | |   | || |   | || (      
| () () || (____/\| (____/\| (____/\| (___) || )   ( || (____/\
(_______)(_______/(_______/(_______/(_______)|/     \|(_______/
                                                               ",65);


            Console.ReadKey();
            Screen next = new LoginScreen();
            next.Show();
            Console.Clear();
            Console.WriteLine(@"        _______  _______  _______  ______     ______            _______ 
       (  ____ \(  ___  )(  ___  )(  __  \   (  ___ \ |\     /|(  ____ \
       | (    \/| (   ) || (   ) || (  \  )  | (   ) )( \   / )| (    \/
       | |      | |   | || |   | || |   ) |  | (__/ /  \ (_) / | (__    
       | | ____ | |   | || |   | || |   | |  |  __ (    \   /  |  __)   
       | | \_  )| |   | || |   | || |   ) |  | (  \ \    ) (   | (      
       | (___) || (___) || (___) || (__/  )  | )___) )   | |   | (____/\
       (_______)(_______)(_______)(______/   |/ \___/    \_/   (_______/
                                                                        ");
            Users.Save(MainUi.p);
            Console.ReadKey();

        }
    }
}
