using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Car
	{
		public string Brand;
		public string Model;
		public string Color;
		public int SeatNumber;

        public Car(string brand, string model, string color, int seatnumber )
        {
            Brand = brand;
			Model = model;
			Color = color;
			SeatNumber = seatnumber;
        }
    }
}
