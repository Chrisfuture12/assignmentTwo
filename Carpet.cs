using System;

namespace assignmentTwo
{
	class Carpet 
	{
		static void Main()
		{
			double room;
			double berber = 27.95;
			double pile = 15.95;
			string value1;
			Console.WriteLine("Provide a radius of the circle-shaped room in inches: ");
			value1 = Console.ReadLine();
			room = double.Parse(value1);
			double carpetOne = room*berber;
			double carpetTwo = room*pile;
			Console.ReadKey();

			 if (carpetOne > carpetTwo) 
			{  
				Console.WriteLine("berber carpet: $" + carpetOne + " is more expensive than pile carpet: $" + carpetTwo + ".");
			} else {
				Console.WriteLine("pile carpet: $" + carpetTwo + " is more expensive than berber carpet: $" + carpetOne + ".");
			} 
			Console.WriteLine();
			Console.WriteLine("This calculator is brought to you by Chris Morris, Eunice, And Hafsa.");
			
	

		}
	}
}

