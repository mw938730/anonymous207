using system;
//using classLibrary;
	namespace Controller{
	   class Controller{
			int userID{get;set;}
			int auctionID{get;set;}
			int bidID{get;set}
			
			public Controller(){
				
				
			}
			public Controller(int userID0=0, int auctionID0=0, int bidID0=0)
			{
				userID = userID0;
				auctionID = auctionID0;
				bidID = bidID0;
			}
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
			public static void placeBid()
			{
				//insert method/
			}//end placeBid
			public static void collectPayment()
			{
				//insert method/
			}//end collectPayment

		}//end Controller
	}//end namespace