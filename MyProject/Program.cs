using MyProject.App;
using MyProject._4;
using MyProject._4.UI;

namespace MyProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainUi app = new MainUi(new WelcomeScreen() );
            app.ApplicationStart();

        }
    }
}