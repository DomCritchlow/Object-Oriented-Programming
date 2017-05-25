using System;

namespace CarProject
{
	public class Sedan:Car
	{

		double basePrice;
		double price;
		string model;

		public double BasePrice 
		{ 	get {return basePrice;}
			set {basePrice = value;}
		}

		public double Price 
		{ 	get {return price;}
			set {price = value;}
		}

		public string Model 
		{ 	get {return model;}
			set {model = value;}
		}

		public Sedan ()
		{
			
		}
	}
}

