using MyProject._2.Models;
using MyProject.App;
using MyProject.Models;
using MyProject._1;

namespace MyProject._4.UI
{
    public class RegisterScreen : Screen
		{
			string userName;
	    string passWord;

	 	public RegisterScreen():base("Register")
	 {
	
	 }
	public override void Show()
 {
 //flow
 //
 base.Show();
 SetUserName();
 SetPassword();
 CreatePlayer();
 }
 private void SetUserName()
 {
 	 Console.WriteLine("Please Enter Desired User Name");
	 userName=Console.ReadLine();
	 while(!ValidateUserName())
	{
 	Console.WriteLine("Please Enter Desired User Name");
	 userName=Console.ReadLine();
	}
 }
 private void SetPassword()
 {
  Console.WriteLine("Please Enter Desired Password");
	 this.passWord=Console.ReadLine();
	 while(!ValidatePassWord())
	{
 	Console.WriteLine("Please Enter Desired Password");
	 passWord=Console.ReadLine();
	}
 }
 private bool ValidateUserName()
 {
 return true;
 }
 private bool ValidatePassWord()
 {
 return true;
 }

private void CreatePlayer()
{
	Console.WriteLine("Enter Name");
  string name=Console.ReadLine();
			try
			{
				MainUi.p = new Player(name, userName, passWord);
				MyProject._1.Data.Users.Update(MainUi.p);
			}
			catch (Exception e)
			{
				Console.WriteLine("Something went Wrong...");
			}
}
 
}
}