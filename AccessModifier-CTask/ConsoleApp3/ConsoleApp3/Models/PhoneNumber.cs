namespace ConsoleApp1.Models
{
	internal class PhoneNumber
	{
		private string _number;
		public string Number
		{
			get
			{
				return _number;
			}
			set
			{
				value = value.Trim();
				if (!String.IsNullOrWhiteSpace(value) && value.StartsWith("+994") && value.Length == 13)
				{
					_number = value;
                    Console.WriteLine(_number);
                }
				else
				{
					Console.WriteLine("Nomre sehvdir!!!");
				}
			}
		}
	}
}