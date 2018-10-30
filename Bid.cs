using System;


namespace Bid
{
    class Bid{
        int BidID{get;set;}
        int userID{get;set;}
		int auctionID{get;set}
		int itemID{get;set}
		datetime timeStamp{get;set}

        public Bid()
		{
			
		}
        public Bid(int bidID0, int userID, int auctionID, int itemID, date timeStamp)
		{
            
        }
		public static void storeBid()
		{
			//method
		}//end storeBid
	}//end class Bid
}//end namespace