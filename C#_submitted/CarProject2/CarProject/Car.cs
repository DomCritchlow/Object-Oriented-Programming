using System;

namespace CarProject
{[Serializable]
	abstract public class Car
	{
		public Car ()
		{

		}

		int carID;
		string color;
		string make;
		string petname;

		public Package pkg = new Package();


		public int CarID
		{ 	get {return carID;}
			set {carID = value;}
		}
		public string Color
		{ 	get {return color;}
			set {color = value;}
		}


		public string Make
		{ 	get {return make;}
			set {make = value;}
		}

		public string Petname
		{ 	get {return petname;}
			set {petname = value;}
		}

	}
}

