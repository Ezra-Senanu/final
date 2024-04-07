using System;



class Run{
		static void Main(String [] args){
			Console.Title = "Bank";
			CreateAccount signup = new CreateAccount();
			Account user = new Account();
			Console.Write("\n\n1. Login\n2. Sign Up\n");
			int option = Convert.ToInt32(Console.ReadLine());
			if(option == 1){
				user.UserAcount();
			}else{
				signup.SetAccount();
			}
			Console.ReadKey();
		}
	}