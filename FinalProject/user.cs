using System;
public class CreateAccount{
		private string [] user=new string [6];
		private string user_file = "account.txt";

		public void SetAccount(){
			//Create user Account
			Console.WriteLine("Welcome\nHere you will create your Bank account\nPlease fill out the form\n\n");
			string [] field = new string [6]{"first name:","Last name:","Date of Birth:","password:","account type:","Initial deposit must have a minimum of $500\n$:"};

			int controller = 0;
			int max_try = 3; 
			for(controller=0;controller<6;controller++){
				Console.Write("{0}",field[controller]);
				user[controller] = Console.ReadLine();
			}
			if(Convert.ToInt32(user[5]) < 500){
				Console.WriteLine("Sorry Enter deposit with the minimum of $500");
				user[5] = "0.00";
				while(Convert.ToInt32(user[5]) < 500 && max_try > 0){
					Console.Write("{0}",field[5]);
					user[5] = Console.ReadLine(); 
					max_try--;
				}
			}
			
			if(Convert.ToInt32(user[5]) < 500 && max_try <= 0){
					Console.WriteLine("Sorry your account could not be created\n try again later!");
					Console.ReadKey();
				}else{
					if(Convert.ToInt32(user[5]) >= 500){
						Console.WriteLine("Congratulations!!\nYour account has been created successfully");
					}
				}
			//Creating user account file
			if(File.Exists(user_file)){
				try{
					File.WriteAllLines(user_file,user);
				}catch(Exception error){
					Console.WriteLine(error.Message);
				}
			}else{
				try{
					File.WriteAllLines(user_file,user);
				}catch(Exception error){
					Console.WriteLine(error.Message);
				}
			}
		}
	}
