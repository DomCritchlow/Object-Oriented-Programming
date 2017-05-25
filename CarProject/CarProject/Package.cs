using System;

namespace CarProject
{
	[Serializable]
	public class Package
	{

		string description;
		double price;
		string type;
		public bool status;


		public string Description 
		{ 	get {return description;}
			set {description = value;}
		}

		public double Price 
		{ 	get {return price;}
			set {price = value;}
		}

		public string Type 
		{ 	get {return type;}
			set {type = value;}
		}

		public Package ()
		{
			description = "No Description Available";
			price = 0.0;
			type = "No type";
			status = false;
			
		}
	}

}

