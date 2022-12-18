using MyProject._2.Models;
using MyProject.App;

namespace MyProject._4.UI
{
    public class RegisterScreen : Screen
		{
			string userName;
	    string passWord;

	 	public RegisterScreen():base("Register")
	 {
	
	 }
	public override Show()
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
	 this.password=Console.ReadLine();
	 while(!ValidatePassWord())
	{
 	Console.WriteLine("Please Enter Desired Password");
	 password=Console.ReadLine();
	}
 }
 private bool ValidateUserName()
 {
 return true;
 }
 private bool ValidatePassword()
 {
 return true;
 }

private void CreatePlayer()
{
	Console.WriteLine("Enter Name");
  string name=Console.ReadLine();
	MainUi.P=new Player(name,userName,password);
 Data.Update(MainUi.P);
}
 
}
}