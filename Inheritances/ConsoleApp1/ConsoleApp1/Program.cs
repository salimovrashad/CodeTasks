using ConsoleApp1.Models;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Car mers = new Car();
			mers.Brand = "bmw";
			mers.Model = "x5";
			mers.Color = "black";
			mers.ProducedYear = 2023;
			mers.MaxSpeed = 400;
			mers.DoorCount = 40;
			mers.Type = "car";

			Plane srt = new Plane();
			srt.Brand = "srt";
			srt.Model = "ausdyf";
			srt.Color = "black";
			srt.ProducedYear = 2012;
			srt.MaxSpeed = 7899;
			srt.seatCount = 80;
			srt.HasBusinessClass = true;

			Console.WriteLine(mers.GetMaximumSpeed());
			Console.WriteLine(srt.GetMaximumSpeed());
		}
	}
}