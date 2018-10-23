using System;
//using Random;

namespace Auction
{
    class Auction{
        int auctionID{get;set;}
        int endTime{get;set;}
		int initiatorID{get;set}
		int reservePrice{get;set}
		int bestBidOwner{get;set}
		bool type{get;set}
		int bestBid{get;set}

        public Auction(){
			random rand = new random (6 digit random)
            auctionID=rand;
            
        }
        public Auction(int initiatorID0, int auctionID0)
		{
			initiatorID = initiatorID0;
			auctionID = auctionID0;
        }
	}//end class auction
}//and namespace auction