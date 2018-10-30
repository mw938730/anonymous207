using system;
//using classLibrary;
	namespace User{
	   class User{
			string userName{get;set;}
			string passWord{get;set;}
			string email{get;set}
			string address{get;set}
			string zip{get;set}
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
	public class Buyer:User
	{
		int creditCard
		string billingAddress
		string billingZipCode
		public Buyer(string userName, string address, string passWord, string email, int zip, int bidID
					, int userID,int credCard ,  string billAddress, string billZip ):base(userName,  address,  passWord,  email,  zip,  bidID
					,  userID){
        setCreditCard(credCard);
        setBillingAddress(billAddress);
		setBillingZip(billZip);
    }//end Buyer
	public void setCreditCard(int card){
        creditCard = card ;
    }
    public float getCreditCard(){
        return creditCard;
    }
    public void setBillingAddress(string address){
        billAddress = address ;
    }
    public float getBillingAddress(){
        return billAddress;
    }
    public void setBillingZip(string zip){
        billZip = zip ;
    }
    public float getBillingZip(){
        return billZip;
    }
}//MIGHT NOT NEED THIS BRACKET
	}//end class buyer	
		
	public class Seller:User
	{
		//insert any additional attributes for seller class here!
		public Buyer(string userName, string passWord, string email, int zip, int bidID
					, int userID):base(userName,  passWord,  email,  zip,  bidID
					,  userID){

    }//end Seller

    }
}//MIGHT NOT NEED THIS BRACKET
	}//end class buyer			
		
		
		
		
		
	}//end namespace