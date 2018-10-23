using system;
//using classLibrary;
	namespace User{
	   class User{
			string userName{get;set;}
			string passWord{get;set;}
			string email{get;set}
			int creditCard{get;set}
			string address{get;set}
			string zip{get;set}
			string billingAddress{get;set}
			string billingZipCode{get;set}
			int bidID{get;set;}
			int userID{get;set;)
			
			public User(){
				
				
			}
			public User(string userName0="", int bidID0=0){
				userName = userName0;
				bidID = bidID0;
			}
			public static void editAccountInfo()
			{
				//insert method/
			}//end editAccountInfo
		}//end User
	}//end namespace