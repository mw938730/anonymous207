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
    public long getCreditCard(){
        return creditCard;
    }
    public void setBillingAddress(string address){
        billAddress = address ;
    }
    public int getBillingAddress(){
        return billAddress;
    }
    public void setBillingZip(string zip){
        billZip = zip ;
    }
    public zip getBillingZip(){
        return billZip;
    }
		public static void placeBid()
		{
			//insert method/
		}//end placeBid
	}//end class buyer	
		
	public class Seller:User
	{
		//insert any additional attributes for seller class here!
		public Seller(string userName, string passWord, string email, int zip, int bidID
					, int userID):base(userName,  passWord,  email,  zip,  bidID
					,  userID){

    }//end Seller
		public static void createBidLog()
		{
			//insert method/
		}//end createBidLog
		public static void endAuction()
		{
			//insert method/
		}//end endAuction
		public static void distributePayment()
		{
			//insert method/
		}//end distributePayment
		public static void startAuction()
		{
			//insert method/
		}//end startAuction
    }//end class seller
		 public static void createAccount()
	 {
		//return user; maybe? 
	 }//end createAccount
	 public static void login()
	 {
		
	 } //end login
	 public static void logout();
	 {
		 
	 } //login
	

	}//end class user			
		
		
		
		
		
	}//end namespace