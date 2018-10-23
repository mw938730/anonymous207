using system;
//using classlibrary
	namespace Item 
	{
		
	   class Item{
			int itemID{get;set;}
			string name{get;set;}
			char image{get;set}
			string longDesc{get;set}
			string shortDesc{get;set}
			string serialNum{get;set}
			string modelNum{get;set}

			public Item(){
				random rand = new random //(6 digit random)
				//itemID=rand;
				
			}
			public Item(int itemID0, string name0){
				name = name0;
				itemID = itemID0;
			}
			public void modelNum()
			{
				//insert method/
			}
		}//end Item
	}//end namespace Item