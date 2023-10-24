namespace ConsoleApp1.Models
{
	internal class Car : Vehicle
	{
		public int DoorCount;
		public string Type;


		public string GetMaximumSpeed()
		{
			return $"Vehicle {Brand}, {Model} can run max at speed {MaxSpeed}. Doors count {DoorCount}. Type is {Type}";
		}
	}
}
