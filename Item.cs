using system;
//using classlibrary
	namespace Item 
	{
		
	   class Item{
			int itemID{get;set;}
			string name{get;set;}
			char image{get;set}//placeholder for image variable
			string longDesc{get;set}
			string shortDesc{get;set}
			string serialNum{get;set}
			string modelNum{get;set}
			double reservePrice{get;set;}
			DateTime startTime{get;set;}
			DateTime endTime{get;set;}			
			double highestBid{get;set}
			int sellerID{get;set;}
			

			public Item(){
	
				//this instance may not be used. 
				
			}
			public Item(int itemID0, string name0){
				name = name0;
				itemID = itemID0;
			}

		}//end Item
	}//end namespace Item