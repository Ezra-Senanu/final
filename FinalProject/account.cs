using System;

class Account{
		private string [] user_info = File.ReadAllLines("account.txt");
		private string [] options = new string[]{"1. Account Details","2. Deposit funds","3. Withdraw funds","4. Change password","5. Exit"};
		private int opt_view = 0;
		private int limit = 1200;


		public void UserAcount(){
			Console.WriteLine("Login");
			Console.Write("Username:");
			string user_name = Console.ReadLine();
			Console.Write("Password:");
			string password = Console.ReadLine();
			Console.WriteLine("\n\n");

			if(user_name == user_info[0] && password == user_info[3]){
				menu();
			}else{
				Console.WriteLine("Could not login\nWrong credentials!\n{0}\n{1}\n",user_info[0],user_info[3]);
                menu();
			}
		}

		private int AccountFunds(){
			int funds = Convert.ToInt32(user_info[5]);

			Console.Write("Account Details\nThis account has $:{0}\n\n",funds);
			menu(); //return to main menu
			return funds;
		}
		private void Deposit(){
			//deposit funds to your accounnt
			Console.WriteLine("\nCurrent funds in account:\n$ {0}\n",user_info[5]);
			Console.Write("Deposit amount:$ ");
			string funds = Console.ReadLine();
			if(Convert.ToInt32(funds) > 0 ){
				try{
					if(File.Exists("account.txt")){
						int new_funds = Convert.ToInt32(user_info[5]) + Convert.ToInt32(funds);
						try{
							user_info[5] = Convert.ToString(new_funds);
							File.WriteAllLines("account.txt",user_info);
						}catch(Exception error){
							Console.WriteLine(error.Message);
						}
					}
				}catch(Exception error){
					Console.WriteLine("\n{0}\n",error.Message);
				}
			}else{
				Console.WriteLine("\nEnter amount > 0");
			}
			Console.WriteLine("Your funds have deposited successfully!");
			Console.WriteLine("New balance:\n$ {0}\n",user_info[5]);
			menu();
		}

		private void Withdraw(){
			Console.WriteLine("");
			Console.WriteLine("Current funds:$ {0}\nLimit:$ {1}",user_info[5],limit);
			Console.WriteLine("");
			int current_funds = Convert.ToInt32(user_info[5]);

			Console.Write("Withdraw:$ ");
			int withdraw = Convert.ToInt32(Console.ReadLine());

			if(withdraw < limit && Convert.ToInt32(user_info[5]) - withdraw > 0){
				int new_funds = current_funds - withdraw;
				user_info[5] = Convert.ToString(new_funds);
				try{
					File.WriteAllLines("account.txt",user_info);
				}catch(Exception error){
					Console.WriteLine(error.Message);
				}
			}else{
				Console.Write("\n");
				Console.WriteLine("Your request is above the limit\nRequest:$ {0}\nCurrent balance:$ {1}\nLimit:$ {2}",withdraw,user_info[5],limit);
				Console.Write("\n\n");
				withdraw = 0; //reseting request
				Withdraw();
			}
			Console.WriteLine("Funds successfully withdrawn!\nNew Account ballance:$ {0}\n\n",user_info[5]);
			menu();
		}

		private void ChangePassword(){
			Console.Write("Change your password here\nKeep your password safe\n\n");
			string current_password = user_info[3];
			Console.Write("Confirm old password: ");
			string confirm = Console.ReadLine();
			if(confirm == current_password){
				Console.Write("\nEnter new password: ");
				string password = Console.ReadLine();
				if(password != current_password){
					user_info[3] = password;
				}else{
					Console.Write("\n");
					Console.Write("New password can not be the same as old password\n");
					Console.Write("\n");
					ChangePassword();
				}
			}else{
				Console.Write("\n\nPassword mismatched\n\n");
				ChangePassword();
			}
			try{
				File.WriteAllLines("account.txt",user_info);
			}catch(Exception error){
				Console.WriteLine(error.Message);
			}
			Console.WriteLine("Your password has been changed successfully!\n");
			menu();
		}
        private void Exit(){
            Console.WriteLine("Goodbye!");
        }


		public void menu(){
			for(opt_view=0;opt_view<5;opt_view++){
					Console.WriteLine("{0}",options[opt_view]);
				}
			Console.Write("");
			string option = Console.ReadLine();
			if(Convert.ToInt32(option) == 1){
				AccountFunds();
			}else{
				if(Convert.ToInt32(option) == 2){
					Deposit();
				}
			}
			if(Convert.ToInt32(option) == 3){
					Withdraw();
				}
			if(Convert.ToInt32(option) == 4){
					ChangePassword();
				}
            if(Convert.ToInt32(option) == 5){
                Exit();

            }    
		}
	}
