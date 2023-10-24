namespace ConsoleApp1.Models
{
	internal class Plane : Vehicle
	{
		public int seatCount;
		public bool HasBusinessClass;

		public string GetMaximumSpeed()
		{
			return $"Vehicle {Brand}, {Model} can run max at speed {MaxSpeed}. Seat count {seatCount}.And Business Class? {HasBusinessClass}";
		}
	}
}
